using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.IO;

namespace phpMyAdminKnockOff
{

	public partial class Form1 : Form
	{
		//TODO
		//-1. Sekti kiek ir kokių lentelių sukūrė žmogus (Saugoti lentelės, ir visų bigint laukų pavadinimus) 
		// 2. Pridėti foreign key pasirinkimą, checkBox - isFK, jei pažymėtas, atsiranda combobox kuriame rodomi "lentelės_pavadinimas(bigint_lauko_pavadinimas)"
		// 3. Papildykite kodą, kad būtų sukuriami atitinkami foreign keys.
		// 4. Pridėkite papildomą funkcionalumą - random duomenų generavimas: žmogus įveda kiek įrašų turi būti lentelėje, jūs sugeneruojate INSERT užklausą pagal laukelių duomenų tipus (skaičius galima generuoti su Random(), žodžiams ir sakiniams galima naudoti random žodžių failus arba list’us).



		enum SqlDataType
		{
			SERIAL,
			TINYINT,
			INT,
			BIGINT,
			CHAR,
			VARCHAR,
			TINYTEXT,
			SMALLTEXT,
			TEXT,
			DATETIME,
			DATE,
			TIMESTAMP
		}

		MySqlConnection connection;
		MySqlConnectionStringBuilder builder;

		List<TextBox> txtList;
		List<ComboBox> cmbList;
		List<NumericUpDown> numList;
		List<CheckBox> chkList;
		List<string> tables;
		List<string> bigINTs;
		List<string> nameList;

		public Form1()
		{
			InitializeComponent();

			connection = new MySqlConnection();
			builder = new MySqlConnectionStringBuilder()
			{
				Server = "localhost",
				Port = 3306,
				UserID = "root",
				Password = ""
			};


			connection.ConnectionString = builder.ToString();

			txtList = new List<TextBox>();
			cmbList = new List<ComboBox>();
			numList = new List<NumericUpDown>();
			chkList = new List<CheckBox>();
			tables = new List<string>();
			bigINTs = new List<string>();
			nameList = new List<string>();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtDbName.Text))
			{
				MessageBox.Show("Invalid DB name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtDbName.Focus();

				return;
			}

			MySqlCommand cmd = new MySqlCommand();
			string query = $"CREATE DATABASE IF NOT EXISTS {txtDbName.Text}; USE {txtDbName.Text}";

			cmd.CommandText = query;

			try
			{
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
				}

				cmd.Connection = connection;
				cmd.ExecuteNonQuery();

				grTable.Enabled = true;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTableName.Text))
			{
				MessageBox.Show("Invalid table name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtTableName.Focus();

				return;
			}

			CreateObjects();
		}

		private void CreateObjects()
		{
			ClearPanel();
			for (int i = 0; i < numFieldCount.Value; i++)
			{
				TextBox txt = new TextBox();
				txt.Width = 120;
				txt.Height = 80;
				txt.Location = new Point(lblName.Location.X, lblName.Location.Y + lblName.Height + (i * txt.Height) + (i * 10));

				txtList.Add(txt);
				pnl.Controls.Add(txt);

				ComboBox cmb = new ComboBox();
				cmb.Width = 120;
				cmb.Height = 80;
				cmb.Location = new Point(lblType.Location.X, lblType.Location.Y + lblType.Height + (i * (cmb.Height + 10)));
				cmb.DropDownStyle = ComboBoxStyle.DropDownList;
				cmb.DataSource = Enum.GetValues(typeof(SqlDataType));
				cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
				cmb.Name = i.ToString();

				cmbList.Add(cmb);
				pnl.Controls.Add(cmb);

				NumericUpDown num = new NumericUpDown();
				num.Minimum = 1;
				num.Width = 120;
				num.Height = 80;
				num.Location = new Point(lblSize.Location.X, lblSize.Location.Y + lblSize.Height + (i * (num.Height + 10)));

				numList.Add(num);
				pnl.Controls.Add(num);

				CheckBox chk = new CheckBox();
				chk.Width = 20;
				chk.Height = 20;
				chk.Location = new Point(label3.Location.X+10, label3.Location.Y + label3.Height + (i * (chk.Height + 10))+3);
				chkList.Add(chk);
				pnl.Controls.Add(chk);

			}

			Button btn = new Button();
			btn.AutoSize = true;
			btn.Text = "Create Table";
			btn.Click += Btn_Click;
			btn.Name = "btnCreateTable";

			int index = numList.Count - 1;

			btn.Location = new Point(numList[index].Location.X, numList[index].Location.Y + numList[index].Height + 10);
			pnl.Controls.Add(btn);
		}

		private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cmb = sender as ComboBox;
			var index = Convert.ToInt32(cmb.Name);

			numList[index].Enabled = true;

			switch (cmb.Text)
			{
				case "TINYINT":
					numList[index].Maximum = 3;
					break;
				case "SMALLINT":
					numList[index].Maximum = 8;
					break;
				case "INT":
					numList[index].Maximum = 10;
					break;
				case "BIGINT":
					numList[index].Maximum = 20;
					break;
				case "VARCHAR":
					numList[index].Maximum = 255;
					break;
				case "TEXT":
					numList[index].Maximum = 65535;
					break;
				case "MEDIUMTEXT":
					numList[index].Maximum = 16777215;
					break;
				case "TINYTEXT":
					numList[index].Maximum = 255;
					break;
				default:
					numList[index].Enabled = false;
					break;
			}
		}

		private void ClearPanel()
		{
			for (int i = 0; i < txtList.Count; i++)
			{
				pnl.Controls.Remove(txtList[i]);
				pnl.Controls.Remove(cmbList[i]);
				pnl.Controls.Remove(numList[i]);
			}

			txtList.Clear();
			cmbList.Clear();
			numList.Clear();
			pnl.Controls.RemoveByKey("btnCreateTable");
		}

		private void Btn_Click(object sender, EventArgs e)
		{
			if (CheckNames())
			{
				MessageBox.Show("All fields must be named", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (CheckSerial())
			{
				MessageBox.Show("There can onlybe one (Primary key)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			StringBuilder builder = new StringBuilder();
			builder.Append($"CREATE TABLE IF NOT EXISTS {txtTableName.Text} (");

			for (int i = 0; i < txtList.Count; i++)
			{
				if (cmbList[i].Text == "BIGINT")
				{
					bigINTs.Add(txtList[i].Text);
					MessageBox.Show("Test");
					tables.Add(txtTableName.Text);
				}
				builder.Append($"{txtList[i].Text} {cmbList[i].Text}{CheckValue(i)},");
			}

			builder.Remove(builder.Length - 1, 1);
			builder.Append(");");

			MySqlCommand cmd = new MySqlCommand();

			try
			{
				if (connection.State == ConnectionState.Closed)
					connection.Open();

				cmd.Connection = connection;
				cmd.CommandText = builder.ToString();
				cmd.ExecuteNonQuery();

				MessageBox.Show("Table Created");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private bool CheckSerial()
		{
			if (cmbList.FindAll(x => x.Text == "SERIAL").Count > 1)
				return true;
			return false;
		}

		private bool CheckNames()
		{
			foreach (var txt in txtList)
			{
				if (string.IsNullOrWhiteSpace(txt.Text))
					return true;
			}

			return false;
		}

		string CheckValue(int index)
		{
			StringBuilder builder = new StringBuilder();

			switch (cmbList[index].Text)
			{
				case "TINYINT":
				case "SMALLINT":
				case "INT":
				case "BIGINT":
				case "TINYTEXT":
				case "MEDIUMTEXT":
				case "TEXT":
					if (numList[index].Value != 0)
						builder.Append($"({numList[index].Value})");
					else
						builder.Append("");//use default size
					break;
				case "VARCHAR":
					builder.Append($"({numList[index].Value})");
					break;
				default:
					builder.Append("");
					break;
			}
			return builder.ToString();
		}

		private void btnShowTables_Click(object sender, EventArgs e)
		{
			string tableList = "Tables:\n";
			for (int i = 0; i < tables.Count; i++)
			{
				comboBoxTables.Items.Add(tables[i]) ;
				tableList += tables[i];
				tableList += "\n";
			}

			tableList+= "\n\nBIGINT fields:\n";
			for (int i = 0; i < bigINTs.Count; i++)
			{
				tableList += bigINTs[i];
				tableList += "\n";
			}
			MessageBox.Show(tableList);
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			GetNamesFromFile();
			Random rnd = new Random();
			StringBuilder builder = new StringBuilder();
			builder.Append($"INSERT {comboBoxTables.Text} VALUES");
			builder.Append($"(NULL,{nameList[rnd.Next(nameList.Count)]},{rnd.Next(30)})"); //example
			builder.Append(";");


			MySqlCommand cmd = new MySqlCommand();
			try
			{
				if (connection.State == ConnectionState.Closed)
					connection.Open();

				cmd.Connection = connection;
				cmd.CommandText = builder.ToString();
				cmd.ExecuteNonQuery();

				MessageBox.Show("Inserted!");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GetNamesFromFile()
		{
			StreamReader sr = new StreamReader("C:/Users/User/Desktop/names.txt");
			while (!sr.EndOfStream)
			{
				nameList.Add(sr.ReadLine());
			}
		}
	}
}
