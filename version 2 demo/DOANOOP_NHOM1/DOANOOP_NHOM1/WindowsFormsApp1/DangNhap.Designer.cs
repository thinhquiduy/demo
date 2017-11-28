namespace WindowsFormsApp1
{
    partial class DangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbdangnhap = new System.Windows.Forms.TextBox();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.cbhienpass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbdangnhap);
            this.panel2.Controls.Add(this.lbdangnhap);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(132, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 64);
            this.panel2.TabIndex = 1;
            // 
            // tbdangnhap
            // 
            this.tbdangnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbdangnhap.Location = new System.Drawing.Point(199, 15);
            this.tbdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.tbdangnhap.Name = "tbdangnhap";
            this.tbdangnhap.Size = new System.Drawing.Size(392, 22);
            this.tbdangnhap.TabIndex = 1;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.Location = new System.Drawing.Point(4, 11);
            this.lbdangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(180, 26);
            this.lbdangnhap.TabIndex = 0;
            this.lbdangnhap.Text = "Tên Đăng Nhập:";
            this.lbdangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbmatkhau);
            this.panel3.Controls.Add(this.lbmatkhau);
            this.panel3.Location = new System.Drawing.Point(132, 173);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 64);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(199, 14);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(392, 22);
            this.tbmatkhau.TabIndex = 1;
            this.tbmatkhau.UseSystemPasswordChar = true;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(4, 11);
            this.lbmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(126, 26);
            this.lbmatkhau.TabIndex = 0;
            this.lbmatkhau.Text = "Mật Khẩu:";
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(453, 256);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(100, 28);
            this.btlogin.TabIndex = 2;
            this.btlogin.Text = "Đăng Nhập";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(615, 256);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 28);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Thoát";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbhienpass
            // 
            this.cbhienpass.AutoSize = true;
            this.cbhienpass.Location = new System.Drawing.Point(104, 256);
            this.cbhienpass.Name = "cbhienpass";
            this.cbhienpass.Size = new System.Drawing.Size(128, 21);
            this.cbhienpass.TabIndex = 4;
            this.cbhienpass.Text = "Show password";
            this.cbhienpass.UseVisualStyleBackColor = true;
            this.cbhienpass.CheckedChanged += new System.EventHandler(this.cbhienpass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbhienpass);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.btlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 321);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::WindowsFormsApp1.Properties.Resources.if_Login_73221;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.if_Keys_128435;
            this.pictureBox2.Location = new System.Drawing.Point(20, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 84);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.if_Login_73221;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.if_Login_73221;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 84);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbdangnhap;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.CheckBox cbhienpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

