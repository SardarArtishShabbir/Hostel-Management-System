namespace Hostel_MS.Forms
{
	partial class Search_Student
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Student));
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dg_Student = new System.Windows.Forms.DataGridView();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
			this.hostelDbDataSet = new Hostel_MS.HostelDbDataSet();
			this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_StudentTableAdapter = new Hostel_MS.HostelDbDataSetTableAdapters.tbl_StudentTableAdapter();
			this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.instituteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guardianNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guardianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmb_Choice = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Cnic = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_Student)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 613);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1095, 58);
			this.panel4.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1095, 150);
			this.panel1.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(307, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(455, 69);
			this.label2.TabIndex = 14;
			this.label2.Text = "Search Student";
			// 
			// dg_Student
			// 
			this.dg_Student.AutoGenerateColumns = false;
			this.dg_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNICDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.instituteDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.dateOfRegDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.guardianNumberDataGridViewTextBoxColumn,
            this.guardianNameDataGridViewTextBoxColumn});
			this.dg_Student.DataSource = this.tblStudentBindingSource;
			this.dg_Student.Location = new System.Drawing.Point(40, 231);
			this.dg_Student.Name = "dg_Student";
			this.dg_Student.RowHeadersWidth = 51;
			this.dg_Student.RowTemplate.Height = 24;
			this.dg_Student.Size = new System.Drawing.Size(1005, 350);
			this.dg_Student.TabIndex = 9;
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(698, 194);
			this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(203, 22);
			this.txt_Name.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Search With :";
			// 
			// btn_Search
			// 
			this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
			this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Search.Location = new System.Drawing.Point(936, 178);
			this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(109, 38);
			this.btn_Search.TabIndex = 13;
			this.btn_Search.Text = "Search";
			this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// hostelDbDataSet
			// 
			this.hostelDbDataSet.DataSetName = "HostelDbDataSet";
			this.hostelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblStudentBindingSource
			// 
			this.tblStudentBindingSource.DataMember = "tbl_Student";
			this.tblStudentBindingSource.DataSource = this.hostelDbDataSet;
			// 
			// tbl_StudentTableAdapter
			// 
			this.tbl_StudentTableAdapter.ClearBeforeFill = true;
			// 
			// cNICDataGridViewTextBoxColumn
			// 
			this.cNICDataGridViewTextBoxColumn.DataPropertyName = "CNIC";
			this.cNICDataGridViewTextBoxColumn.HeaderText = "CNIC";
			this.cNICDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cNICDataGridViewTextBoxColumn.Name = "cNICDataGridViewTextBoxColumn";
			this.cNICDataGridViewTextBoxColumn.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 125;
			// 
			// fatherNameDataGridViewTextBoxColumn
			// 
			this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
			this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
			this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
			this.fatherNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.Width = 125;
			// 
			// mobileDataGridViewTextBoxColumn
			// 
			this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
			this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
			this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
			this.mobileDataGridViewTextBoxColumn.Width = 125;
			// 
			// instituteDataGridViewTextBoxColumn
			// 
			this.instituteDataGridViewTextBoxColumn.DataPropertyName = "Institute";
			this.instituteDataGridViewTextBoxColumn.HeaderText = "Institute";
			this.instituteDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.instituteDataGridViewTextBoxColumn.Name = "instituteDataGridViewTextBoxColumn";
			this.instituteDataGridViewTextBoxColumn.Width = 125;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.Width = 125;
			// 
			// dateOfRegDataGridViewTextBoxColumn
			// 
			this.dateOfRegDataGridViewTextBoxColumn.DataPropertyName = "DateOfReg";
			this.dateOfRegDataGridViewTextBoxColumn.HeaderText = "DateOfReg";
			this.dateOfRegDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dateOfRegDataGridViewTextBoxColumn.Name = "dateOfRegDataGridViewTextBoxColumn";
			this.dateOfRegDataGridViewTextBoxColumn.Width = 125;
			// 
			// doBDataGridViewTextBoxColumn
			// 
			this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
			this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
			this.doBDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
			this.doBDataGridViewTextBoxColumn.Width = 125;
			// 
			// bloodGroupDataGridViewTextBoxColumn
			// 
			this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
			this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
			this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
			this.bloodGroupDataGridViewTextBoxColumn.Width = 125;
			// 
			// guardianNumberDataGridViewTextBoxColumn
			// 
			this.guardianNumberDataGridViewTextBoxColumn.DataPropertyName = "GuardianNumber";
			this.guardianNumberDataGridViewTextBoxColumn.HeaderText = "GuardianNumber";
			this.guardianNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.guardianNumberDataGridViewTextBoxColumn.Name = "guardianNumberDataGridViewTextBoxColumn";
			this.guardianNumberDataGridViewTextBoxColumn.Width = 125;
			// 
			// guardianNameDataGridViewTextBoxColumn
			// 
			this.guardianNameDataGridViewTextBoxColumn.DataPropertyName = "GuardianName";
			this.guardianNameDataGridViewTextBoxColumn.HeaderText = "GuardianName";
			this.guardianNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.guardianNameDataGridViewTextBoxColumn.Name = "guardianNameDataGridViewTextBoxColumn";
			this.guardianNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// cmb_Choice
			// 
			this.cmb_Choice.FormattingEnabled = true;
			this.cmb_Choice.Items.AddRange(new object[] {
            "CNIC",
            "Name"});
			this.cmb_Choice.Location = new System.Drawing.Point(154, 196);
			this.cmb_Choice.Name = "cmb_Choice";
			this.cmb_Choice.Size = new System.Drawing.Size(121, 24);
			this.cmb_Choice.TabIndex = 14;
			this.cmb_Choice.SelectedIndexChanged += new System.EventHandler(this.cmb_Choice_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(618, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Name :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(306, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "CNIC : ";
			// 
			// txt_Cnic
			// 
			this.txt_Cnic.Location = new System.Drawing.Point(386, 196);
			this.txt_Cnic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Cnic.Name = "txt_Cnic";
			this.txt_Cnic.Size = new System.Drawing.Size(203, 22);
			this.txt_Cnic.TabIndex = 16;
			// 
			// Search_Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 671);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Cnic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmb_Choice);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dg_Student);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "Search_Student";
			this.Text = "Search_Student";
			this.Load += new System.EventHandler(this.Search_Student_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_Student)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dg_Student;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Search;
		private HostelDbDataSet hostelDbDataSet;
		private System.Windows.Forms.BindingSource tblStudentBindingSource;
		private HostelDbDataSetTableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn instituteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRegDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guardianNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guardianNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox cmb_Choice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Cnic;
	}
}