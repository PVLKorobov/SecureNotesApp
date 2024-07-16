namespace SecureNotesApp
{
    partial class AboutForm
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
            name_label = new Label();
            desc_label = new Label();
            authors_label = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.BorderStyle = BorderStyle.FixedSingle;
            name_label.Font = new Font("Segoe UI", 24F);
            name_label.Location = new Point(118, 12);
            name_label.Name = "name_label";
            name_label.Size = new Size(211, 47);
            name_label.TabIndex = 1;
            name_label.Text = "Secure Notes";
            // 
            // desc_label
            // 
            desc_label.AutoSize = true;
            desc_label.Font = new Font("Segoe UI", 14F);
            desc_label.Location = new Point(118, 69);
            desc_label.Name = "desc_label";
            desc_label.Size = new Size(324, 25);
            desc_label.TabIndex = 2;
            desc_label.Text = "Менеджер заметок с шифрованием";
            // 
            // authors_label
            // 
            authors_label.AutoSize = true;
            authors_label.Font = new Font("Segoe UI", 12F);
            authors_label.Location = new Point(13, 115);
            authors_label.Name = "authors_label";
            authors_label.Size = new Size(316, 42);
            authors_label.TabIndex = 3;
            authors_label.Text = "Авторы:\r\nПоливанов А.А., Носкорв С.Р., Коробов П.А.";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Icon_3;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 181);
            Controls.Add(pictureBox1);
            Controls.Add(authors_label);
            Controls.Add(desc_label);
            Controls.Add(name_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label name_label;
        private Label desc_label;
        private Label authors_label;
        private PictureBox pictureBox1;
    }
}