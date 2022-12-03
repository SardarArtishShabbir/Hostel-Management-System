namespace Hostel_MS.Forms
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.btn_Login = new System.Windows.Forms.Button();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chk_ShowPass = new System.Windows.Forms.CheckBox();
			this.btn_Clear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Login
			// 
			this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
			this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Login.Location = new System.Drawing.Point(288, 278);
			this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(97, 41);
			this.btn_Login.TabIndex = 8;
			this.btn_Login.Text = "Login";
			this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(320, 176);
			this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(158, 20);
			this.txt_username.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(239, 176);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Username : ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(20, 145);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(189, 202);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 368);
			this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(588, 47);
			this.panel4.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(404, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(184, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Hostel Management System";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "label3";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(588, 122);
			this.panel1.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(184, 29);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 66);
			this.label2.TabIndex = 14;
			this.label2.Text = "Welcome";
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(320, 228);
			this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(158, 20);
			this.txt_password.TabIndex = 13;
			this.txt_password.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(239, 228);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password :";
			// 
			// chk_ShowPass
			// 
			this.chk_ShowPass.AutoSize = true;
			this.chk_ShowPass.Location = new System.Drawing.Point(484, 230);
			this.chk_ShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chk_ShowPass.Name = "chk_ShowPass";
			this.chk_ShowPass.Size = new System.Drawing.Size(102, 17);
			this.chk_ShowPass.TabIndex = 14;
			this.chk_ShowPass.Text = "Show Password";
			this.chk_ShowPass.UseVisualStyleBackColor = true;
			this.chk_ShowPass.CheckedChanged += new System.EventHandler(this.chk_ShowPass_CheckedChanged);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
			this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Clear.Location = new System.Drawing.Point(398, 278);
			this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(89, 41);
			this.btn_Clear.TabIndex = 15;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Clear.UseVisualStyleBackColor = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 415);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.chk_ShowPass);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_ShowPass;
        private System.Windows.Forms.Button btn_Clear;
    }
}