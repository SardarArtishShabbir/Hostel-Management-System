namespace Hostel_MS.Forms
{
    partial class AssignRoom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignRoom));
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_StudentName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_RoomNo = new System.Windows.Forms.ComboBox();
			this.cmb_CNIC = new System.Windows.Forms.ComboBox();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.txt_AvailSeat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.hostelDbDataSet1 = new Hostel_MS.HostelDbDataSet1();
			this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_StudentTableAdapter = new Hostel_MS.HostelDbDataSet1TableAdapters.tbl_StudentTableAdapter();
			this.roomNumberDataSet = new Hostel_MS.RoomNumberDataSet();
			this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_RoomTableAdapter = new Hostel_MS.RoomNumberDataSetTableAdapters.tbl_RoomTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomNumberDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Student CNIC : ";
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel4.Location = new System.Drawing.Point(0, 572);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(507, 58);
			this.panel4.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(507, 150);
			this.panel1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(50, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(441, 83);
			this.label2.TabIndex = 14;
			this.label2.Text = "Assign Room";
			// 
			// txt_StudentName
			// 
			this.txt_StudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txt_StudentName.Location = new System.Drawing.Point(192, 253);
			this.txt_StudentName.Name = "txt_StudentName";
			this.txt_StudentName.ReadOnly = true;
			this.txt_StudentName.Size = new System.Drawing.Size(203, 22);
			this.txt_StudentName.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Student Name :";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(60, 317);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Room No: ";
			// 
			// cmb_RoomNo
			// 
			this.cmb_RoomNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmb_RoomNo.DataSource = this.tblRoomBindingSource;
			this.cmb_RoomNo.DisplayMember = "RoomNumber";
			this.cmb_RoomNo.FormattingEnabled = true;
			this.cmb_RoomNo.Location = new System.Drawing.Point(192, 313);
			this.cmb_RoomNo.Name = "cmb_RoomNo";
			this.cmb_RoomNo.Size = new System.Drawing.Size(203, 24);
			this.cmb_RoomNo.TabIndex = 13;
			this.cmb_RoomNo.SelectedIndexChanged += new System.EventHandler(this.cmb_RoomNo_SelectedIndexChanged);
			// 
			// cmb_CNIC
			// 
			this.cmb_CNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmb_CNIC.DataSource = this.tblStudentBindingSource;
			this.cmb_CNIC.DisplayMember = "CNIC";
			this.cmb_CNIC.FormattingEnabled = true;
			this.cmb_CNIC.Location = new System.Drawing.Point(192, 191);
			this.cmb_CNIC.Name = "cmb_CNIC";
			this.cmb_CNIC.Size = new System.Drawing.Size(203, 24);
			this.cmb_CNIC.TabIndex = 14;
			this.cmb_CNIC.SelectedIndexChanged += new System.EventHandler(this.cmb_CNIC_SelectedIndexChanged);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
			this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Clear.Location = new System.Drawing.Point(246, 463);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(110, 38);
			this.btn_Clear.TabIndex = 16;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Clear.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
			this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Save.Location = new System.Drawing.Point(88, 463);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(110, 38);
			this.btn_Save.TabIndex = 15;
			this.btn_Save.Text = "Save";
			this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// txt_AvailSeat
			// 
			this.txt_AvailSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txt_AvailSeat.Location = new System.Drawing.Point(192, 385);
			this.txt_AvailSeat.Name = "txt_AvailSeat";
			this.txt_AvailSeat.ReadOnly = true;
			this.txt_AvailSeat.Size = new System.Drawing.Size(203, 22);
			this.txt_AvailSeat.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(60, 387);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Available Seats :";
			// 
			// hostelDbDataSet1
			// 
			this.hostelDbDataSet1.DataSetName = "HostelDbDataSet1";
			this.hostelDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblStudentBindingSource
			// 
			this.tblStudentBindingSource.DataMember = "tbl_Student";
			this.tblStudentBindingSource.DataSource = this.hostelDbDataSet1;
			// 
			// tbl_StudentTableAdapter
			// 
			this.tbl_StudentTableAdapter.ClearBeforeFill = true;
			// 
			// roomNumberDataSet
			// 
			this.roomNumberDataSet.DataSetName = "RoomNumberDataSet";
			this.roomNumberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblRoomBindingSource
			// 
			this.tblRoomBindingSource.DataMember = "tbl_Room";
			this.tblRoomBindingSource.DataSource = this.roomNumberDataSet;
			// 
			// tbl_RoomTableAdapter
			// 
			this.tbl_RoomTableAdapter.ClearBeforeFill = true;
			// 
			// AssignRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 630);
			this.Controls.Add(this.txt_AvailSeat);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.cmb_CNIC);
			this.Controls.Add(this.cmb_RoomNo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_StudentName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "AssignRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AssignRoom";
			this.Load += new System.EventHandler(this.AssignRoom_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomNumberDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_RoomNo;
        private System.Windows.Forms.ComboBox cmb_CNIC;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_AvailSeat;
        private System.Windows.Forms.Label label5;
		private HostelDbDataSet1 hostelDbDataSet1;
		private System.Windows.Forms.BindingSource tblStudentBindingSource;
		private HostelDbDataSet1TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
		private RoomNumberDataSet roomNumberDataSet;
		private System.Windows.Forms.BindingSource tblRoomBindingSource;
		private RoomNumberDataSetTableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
	}
}