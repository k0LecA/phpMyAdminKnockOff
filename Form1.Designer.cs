namespace phpMyAdminKnockOff
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.grDB = new System.Windows.Forms.GroupBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtDbName = new System.Windows.Forms.TextBox();
			this.Enter = new System.Windows.Forms.Label();
			this.grTable = new System.Windows.Forms.GroupBox();
			this.pnl = new System.Windows.Forms.Panel();
			this.lblSize = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numFieldCount = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnShowTables = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.comboBoxTables = new System.Windows.Forms.ComboBox();
			this.grDB.SuspendLayout();
			this.grTable.SuspendLayout();
			this.pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFieldCount)).BeginInit();
			this.SuspendLayout();
			// 
			// grDB
			// 
			this.grDB.Controls.Add(this.btnCreate);
			this.grDB.Controls.Add(this.txtDbName);
			this.grDB.Controls.Add(this.Enter);
			this.grDB.Location = new System.Drawing.Point(18, 19);
			this.grDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grDB.Name = "grDB";
			this.grDB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grDB.Size = new System.Drawing.Size(841, 118);
			this.grDB.TabIndex = 0;
			this.grDB.TabStop = false;
			this.grDB.Text = "Database";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(734, 43);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 30);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtDbName
			// 
			this.txtDbName.Location = new System.Drawing.Point(121, 45);
			this.txtDbName.Name = "txtDbName";
			this.txtDbName.Size = new System.Drawing.Size(552, 26);
			this.txtDbName.TabIndex = 1;
			// 
			// Enter
			// 
			this.Enter.AutoSize = true;
			this.Enter.Location = new System.Drawing.Point(16, 45);
			this.Enter.Name = "Enter";
			this.Enter.Size = new System.Drawing.Size(80, 20);
			this.Enter.TabIndex = 0;
			this.Enter.Text = "DB name:";
			// 
			// grTable
			// 
			this.grTable.Controls.Add(this.pnl);
			this.grTable.Enabled = false;
			this.grTable.Location = new System.Drawing.Point(18, 147);
			this.grTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grTable.Name = "grTable";
			this.grTable.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grTable.Size = new System.Drawing.Size(841, 345);
			this.grTable.TabIndex = 1;
			this.grTable.TabStop = false;
			this.grTable.Text = "Table";
			// 
			// pnl
			// 
			this.pnl.AutoScroll = true;
			this.pnl.Controls.Add(this.label3);
			this.pnl.Controls.Add(this.btnShowTables);
			this.pnl.Controls.Add(this.lblSize);
			this.pnl.Controls.Add(this.lblType);
			this.pnl.Controls.Add(this.lblName);
			this.pnl.Controls.Add(this.label2);
			this.pnl.Controls.Add(this.numFieldCount);
			this.pnl.Controls.Add(this.button1);
			this.pnl.Controls.Add(this.txtTableName);
			this.pnl.Controls.Add(this.label1);
			this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl.Location = new System.Drawing.Point(4, 24);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(833, 316);
			this.pnl.TabIndex = 11;
			// 
			// lblSize
			// 
			this.lblSize.AutoSize = true;
			this.lblSize.Location = new System.Drawing.Point(372, 88);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(44, 20);
			this.lblSize.TabIndex = 18;
			this.lblSize.Text = "Size:";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(224, 88);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(47, 20);
			this.lblType.TabIndex = 17;
			this.lblType.Text = "Type:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(16, 88);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(55, 20);
			this.lblName.TabIndex = 16;
			this.lblName.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(352, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Field count:";
			// 
			// numFieldCount
			// 
			this.numFieldCount.Location = new System.Drawing.Point(471, 22);
			this.numFieldCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numFieldCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numFieldCount.Name = "numFieldCount";
			this.numFieldCount.Size = new System.Drawing.Size(73, 26);
			this.numFieldCount.TabIndex = 14;
			this.numFieldCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(569, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 30);
			this.button1.TabIndex = 13;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(144, 22);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(202, 26);
			this.txtTableName.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Table name:";
			// 
			// btnShowTables
			// 
			this.btnShowTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnShowTables.Location = new System.Drawing.Point(707, 22);
			this.btnShowTables.Name = "btnShowTables";
			this.btnShowTables.Size = new System.Drawing.Size(108, 39);
			this.btnShowTables.TabIndex = 19;
			this.btnShowTables.Text = "Show Tables and BIGINT";
			this.btnShowTables.UseVisualStyleBackColor = true;
			this.btnShowTables.Click += new System.EventHandler(this.btnShowTables_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(500, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 20;
			this.label3.Text = "isFK:";
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(1024, 57);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(101, 33);
			this.btnInsert.TabIndex = 2;
			this.btnInsert.Text = "InsertRandom";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// comboBoxTables
			// 
			this.comboBoxTables.FormattingEnabled = true;
			this.comboBoxTables.Location = new System.Drawing.Point(886, 59);
			this.comboBoxTables.Name = "comboBoxTables";
			this.comboBoxTables.Size = new System.Drawing.Size(121, 28);
			this.comboBoxTables.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1175, 519);
			this.Controls.Add(this.comboBoxTables);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.grTable);
			this.Controls.Add(this.grDB);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.grDB.ResumeLayout(false);
			this.grDB.PerformLayout();
			this.grTable.ResumeLayout(false);
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFieldCount)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDB;
        private System.Windows.Forms.GroupBox grTable;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFieldCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnShowTables;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.ComboBox comboBoxTables;
	}
}

