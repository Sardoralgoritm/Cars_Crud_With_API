namespace WinFormsAppWithApi
{
    partial class Edit
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
            Esave = new Button();
            Ecancel = new Button();
            imageurl = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label3 = new Label();
            price = new TextBox();
            label2 = new Label();
            brand = new TextBox();
            label1 = new Label();
            Edelete = new Button();
            SuspendLayout();
            // 
            // Esave
            // 
            Esave.Location = new Point(174, 308);
            Esave.Name = "Esave";
            Esave.Size = new Size(118, 46);
            Esave.TabIndex = 29;
            Esave.Text = "Save";
            Esave.UseVisualStyleBackColor = true;
            Esave.Click += Esave_Click;
            // 
            // Ecancel
            // 
            Ecancel.Location = new Point(28, 308);
            Ecancel.Name = "Ecancel";
            Ecancel.Size = new Size(118, 46);
            Ecancel.TabIndex = 28;
            Ecancel.Text = "Cancel";
            Ecancel.UseVisualStyleBackColor = true;
            Ecancel.Click += Ecancel_Click;
            // 
            // imageurl
            // 
            imageurl.Location = new Point(271, 215);
            imageurl.Name = "imageurl";
            imageurl.Size = new Size(153, 29);
            imageurl.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(271, 187);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 26;
            label4.Text = "ImageUrl";
            // 
            // name
            // 
            name.Location = new Point(40, 215);
            name.Name = "name";
            name.Size = new Size(153, 29);
            name.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(40, 187);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 24;
            label3.Text = "Name";
            // 
            // price
            // 
            price.Location = new Point(271, 97);
            price.Name = "price";
            price.Size = new Size(153, 29);
            price.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(271, 69);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 22;
            label2.Text = "Price";
            // 
            // brand
            // 
            brand.Location = new Point(40, 97);
            brand.Name = "brand";
            brand.Size = new Size(153, 29);
            brand.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(40, 69);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 20;
            label1.Text = "Brand";
            // 
            // Edelete
            // 
            Edelete.Location = new Point(320, 308);
            Edelete.Name = "Edelete";
            Edelete.Size = new Size(118, 46);
            Edelete.TabIndex = 30;
            Edelete.Text = "Delete";
            Edelete.UseVisualStyleBackColor = true;
            Edelete.Click += Edelete_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 412);
            Controls.Add(Edelete);
            Controls.Add(Esave);
            Controls.Add(Ecancel);
            Controls.Add(imageurl);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(brand);
            Controls.Add(label1);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Esave;
        private Button Ecancel;
        private TextBox imageurl;
        private Label label4;
        private TextBox name;
        private Label label3;
        private TextBox price;
        private Label label2;
        private TextBox brand;
        private Label label1;
        private Button Edelete;
    }
}