namespace WinFormsAppWithApi
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            paged = new ComboBox();
            AddBtn = new Button();
            RefreshBtn = new Button();
            body = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(paged);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(RefreshBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 95);
            panel1.TabIndex = 0;
            // 
            // paged
            // 
            paged.FormattingEnabled = true;
            paged.Location = new Point(574, 34);
            paged.Name = "paged";
            paged.Size = new Size(169, 29);
            paged.TabIndex = 2;
            paged.TextChanged += paged_TextChanged;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Location = new Point(334, 23);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(134, 49);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Anchor = AnchorStyles.None;
            RefreshBtn.Location = new Point(95, 23);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(134, 49);
            RefreshBtn.TabIndex = 0;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // body
            // 
            body.AutoScroll = true;
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 0);
            body.Name = "body";
            body.Size = new Size(800, 355);
            body.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(body);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddBtn;
        private Button RefreshBtn;
        private FlowLayoutPanel body;
        private ComboBox paged;
    }
}