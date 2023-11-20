namespace WinFormsAppWithApi
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picture = new PictureBox();
            brand = new Label();
            price = new Label();
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Location = new Point(15, 13);
            picture.Name = "picture";
            picture.Size = new Size(156, 158);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            brand.Location = new Point(200, 25);
            brand.Name = "brand";
            brand.Size = new Size(81, 25);
            brand.TabIndex = 1;
            brand.Text = "Brand : ";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            price.Location = new Point(200, 131);
            price.Name = "price";
            price.Size = new Size(81, 25);
            price.TabIndex = 2;
            price.Text = "Prise: $ ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            name.Location = new Point(200, 78);
            name.Name = "name";
            name.Size = new Size(74, 25);
            name.TabIndex = 3;
            name.Text = "Name: ";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(name);
            Controls.Add(price);
            Controls.Add(brand);
            Controls.Add(picture);
            Name = "UserControl1";
            Size = new Size(800, 183);
            DoubleClick += UserControl1_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Label brand;
        private Label price;
        private Label name;
    }
}
