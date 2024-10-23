namespace PravinBakes
{
    partial class Customer
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
            this.lbl_AddCustomers = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_MbNo = new System.Windows.Forms.TextBox();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_cusName = new System.Windows.Forms.Label();
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddCustomers
            // 
            this.lbl_AddCustomers.AutoSize = true;
            this.lbl_AddCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddCustomers.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddCustomers.ForeColor = System.Drawing.Color.Black;
            this.lbl_AddCustomers.Location = new System.Drawing.Point(624, 49);
            this.lbl_AddCustomers.Name = "lbl_AddCustomers";
            this.lbl_AddCustomers.Size = new System.Drawing.Size(501, 46);
            this.lbl_AddCustomers.TabIndex = 33;
            this.lbl_AddCustomers.Text = "Add Customers";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(815, 378);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(290, 35);
            this.txt_Address.TabIndex = 31;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(587, 378);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(111, 28);
            this.lbl_Address.TabIndex = 29;
            this.lbl_Address.Text = "Address";
            // 
            // txt_MbNo
            // 
            this.txt_MbNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MbNo.Location = new System.Drawing.Point(815, 302);
            this.txt_MbNo.Name = "txt_MbNo";
            this.txt_MbNo.Size = new System.Drawing.Size(290, 35);
            this.txt_MbNo.TabIndex = 28;
            // 
            // txt_CusName
            // 
            this.txt_CusName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusName.Location = new System.Drawing.Point(815, 227);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(290, 35);
            this.txt_CusName.TabIndex = 27;
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.Location = new System.Drawing.Point(587, 302);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(198, 28);
            this.lbl_Mobile.TabIndex = 26;
            this.lbl_Mobile.Text = "Mobile Number";
            // 
            // lbl_cusName
            // 
            this.lbl_cusName.AutoSize = true;
            this.lbl_cusName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cusName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusName.Location = new System.Drawing.Point(587, 227);
            this.lbl_cusName.Name = "lbl_cusName";
            this.lbl_cusName.Size = new System.Drawing.Size(212, 28);
            this.lbl_cusName.TabIndex = 25;
            this.lbl_cusName.Text = "Customer Name";
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Image = global::PravinBakes.Properties.Resources.exit;
            this.picBox_Exit.Location = new System.Drawing.Point(1184, 3);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(51, 50);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 34;
            this.picBox_Exit.TabStop = false;
            this.picBox_Exit.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(859, 522);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(140, 56);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Submit.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(687, 522);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(140, 56);
            this.btn_Submit.TabIndex = 35;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PravinBakes.Properties.Resources.cute1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 713);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.picBox_Exit);
            this.Controls.Add(this.lbl_AddCustomers);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_MbNo);
            this.Controls.Add(this.txt_CusName);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_cusName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddCustomers;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_MbNo;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_cusName;
        private System.Windows.Forms.PictureBox picBox_Exit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
    }
}