namespace PravinBakes
{
    partial class AddProducts
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
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_CategoryName = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_ProductImage = new System.Windows.Forms.Label();
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_ProductImage = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_AddProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Image = global::PravinBakes.Properties.Resources.exit;
            this.picBox_Exit.Location = new System.Drawing.Point(1206, 1);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(51, 50);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 7;
            this.picBox_Exit.TabStop = false;
            this.picBox_Exit.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryName.Location = new System.Drawing.Point(789, 224);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(290, 35);
            this.txt_CategoryName.TabIndex = 11;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(789, 149);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(290, 35);
            this.txt_ProductName.TabIndex = 10;
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CategoryName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoryName.Location = new System.Drawing.Point(561, 224);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(205, 28);
            this.lbl_CategoryName.TabIndex = 9;
            this.lbl_CategoryName.Text = "Category Name";
            this.lbl_CategoryName.Click += new System.EventHandler(this.lbl_CategoryName_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(561, 149);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(187, 28);
            this.lbl_ProductName.TabIndex = 8;
            this.lbl_ProductName.Text = "Product Name";
            this.lbl_ProductName.Click += new System.EventHandler(this.lbl_ProductName_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(789, 375);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(290, 35);
            this.txt_Quantity.TabIndex = 15;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cost.Location = new System.Drawing.Point(789, 300);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(290, 35);
            this.txt_Cost.TabIndex = 14;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(561, 375);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(120, 28);
            this.lbl_Quantity.TabIndex = 13;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cost.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost.Location = new System.Drawing.Point(561, 300);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(67, 28);
            this.lbl_Cost.TabIndex = 12;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_ProductImage
            // 
            this.lbl_ProductImage.AutoSize = true;
            this.lbl_ProductImage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductImage.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductImage.Location = new System.Drawing.Point(561, 516);
            this.lbl_ProductImage.Name = "lbl_ProductImage";
            this.lbl_ProductImage.Size = new System.Drawing.Size(195, 28);
            this.lbl_ProductImage.TabIndex = 17;
            this.lbl_ProductImage.Text = "Product Image";
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.AutoSize = true;
            this.lbl_ExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExpiryDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(561, 441);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(159, 28);
            this.lbl_ExpiryDate.TabIndex = 16;
            this.lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(789, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txt_ProductImage
            // 
            this.txt_ProductImage.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductImage.Location = new System.Drawing.Point(789, 516);
            this.txt_ProductImage.Name = "txt_ProductImage";
            this.txt_ProductImage.Size = new System.Drawing.Size(290, 35);
            this.txt_ProductImage.TabIndex = 19;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Submit.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(583, 623);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(140, 56);
            this.btn_Submit.TabIndex = 20;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(755, 623);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(140, 56);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Browse.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(922, 623);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(140, 56);
            this.btn_Browse.TabIndex = 22;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1125, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_AddProducts
            // 
            this.lbl_AddProducts.AutoSize = true;
            this.lbl_AddProducts.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddProducts.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddProducts.ForeColor = System.Drawing.Color.Black;
            this.lbl_AddProducts.Location = new System.Drawing.Point(605, 39);
            this.lbl_AddProducts.Name = "lbl_AddProducts";
            this.lbl_AddProducts.Size = new System.Drawing.Size(448, 46);
            this.lbl_AddProducts.TabIndex = 24;
            this.lbl_AddProducts.Text = "Add Products";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PravinBakes.Properties.Resources.cute;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 760);
            this.Controls.Add(this.lbl_AddProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_ProductImage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_ProductImage);
            this.Controls.Add(this.lbl_ExpiryDate);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_CategoryName);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.picBox_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Exit;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_ProductImage;
        private System.Windows.Forms.Label lbl_ExpiryDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_ProductImage;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_AddProducts;
    }
}