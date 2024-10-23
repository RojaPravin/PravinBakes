namespace PravinBakes
{
    partial class LoginPage
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Black;
            this.lbl_Login.Location = new System.Drawing.Point(730, 110);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(258, 46);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN";
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Uname.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(607, 249);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(181, 35);
            this.lbl_Uname.TabIndex = 1;
            this.lbl_Uname.Text = "User Name";
            this.lbl_Uname.Click += new System.EventHandler(this.lbl_Uname_Click);
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pwd.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pwd.Location = new System.Drawing.Point(607, 405);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(156, 35);
            this.lbl_Pwd.TabIndex = 2;
            this.lbl_Pwd.Text = "Password";
            // 
            // txt_Uname
            // 
            this.txt_Uname.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Uname.Location = new System.Drawing.Point(613, 313);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(495, 40);
            this.txt_Uname.TabIndex = 3;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pwd.Location = new System.Drawing.Point(611, 477);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(497, 40);
            this.txt_Pwd.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(778, 593);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(140, 56);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Image = global::PravinBakes.Properties.Resources.exit;
            this.picBox_Exit.Location = new System.Drawing.Point(1203, 2);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(51, 50);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 6;
            this.picBox_Exit.TabStop = false;
            this.picBox_Exit.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PravinBakes.Properties.Resources.cute;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 760);
            this.Controls.Add(this.picBox_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox picBox_Exit;
    }
}

