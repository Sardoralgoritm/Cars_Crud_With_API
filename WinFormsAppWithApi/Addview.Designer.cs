namespace WinFormsAppWithApi
{
    partial class Addview
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
            Save = new Button();
            button1 = new Button();
            imageurl = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label3 = new Label();
            price = new TextBox();
            label2 = new Label();
            brand = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(258, 294);
            Save.Name = "Save";
            Save.Size = new Size(118, 46);
            Save.TabIndex = 19;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(92, 294);
            button1.Name = "button1";
            button1.Size = new Size(118, 46);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageurl
            // 
            imageurl.Location = new Point(272, 212);
            imageurl.Name = "imageurl";
            imageurl.Size = new Size(153, 29);
            imageurl.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(272, 184);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 16;
            label4.Text = "ImageUrl";
            // 
            // name
            // 
            name.Location = new Point(41, 212);
            name.Name = "name";
            name.Size = new Size(153, 29);
            name.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(41, 184);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 14;
            label3.Text = "Name";
            // 
            // price
            // 
            price.Location = new Point(272, 94);
            price.Name = "price";
            price.Size = new Size(153, 29);
            price.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(272, 66);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 12;
            label2.Text = "Price";
            // 
            // brand
            // 
            brand.Location = new Point(41, 94);
            brand.Name = "brand";
            brand.Size = new Size(153, 29);
            brand.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(41, 66);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 10;
            label1.Text = "Brand";
            // 
            // Addview
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 418);
            Controls.Add(Save);
            Controls.Add(button1);
            Controls.Add(imageurl);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(brand);
            Controls.Add(label1);
            Name = "Addview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private Button button1;
        private TextBox imageurl;
        private Label label4;
        private TextBox name;
        private Label label3;
        private TextBox price;
        private Label label2;
        private TextBox brand;
        private Label label1;
    }
}