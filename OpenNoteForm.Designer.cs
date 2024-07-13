namespace SecureNotesApp
{
    partial class OpenNoteForm
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
            note_title_label = new Label();
            note_password_textbox = new TextBox();
            password_label = new Label();
            confirm_password_button = new Button();
            SuspendLayout();
            // 
            // note_title_label
            // 
            note_title_label.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            note_title_label.Location = new Point(58, 10);
            note_title_label.Name = "note_title_label";
            note_title_label.Size = new Size(268, 37);
            note_title_label.TabIndex = 0;
            note_title_label.Text = "<note_name>";
            note_title_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // note_password_textbox
            // 
            note_password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            note_password_textbox.Location = new Point(160, 70);
            note_password_textbox.Name = "note_password_textbox";
            note_password_textbox.Size = new Size(166, 29);
            note_password_textbox.TabIndex = 0;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 14F);
            password_label.Location = new Point(58, 70);
            password_label.Name = "password_label";
            password_label.Size = new Size(82, 25);
            password_label.TabIndex = 2;
            password_label.Text = "Пароль:";
            // 
            // confirm_password_button
            // 
            confirm_password_button.Font = new Font("Segoe UI", 12F);
            confirm_password_button.Location = new Point(140, 120);
            confirm_password_button.Name = "confirm_password_button";
            confirm_password_button.Size = new Size(120, 40);
            confirm_password_button.TabIndex = 1;
            confirm_password_button.Text = "Открыть";
            confirm_password_button.UseVisualStyleBackColor = true;
            confirm_password_button.Click += confirm_password_button_click;
            // 
            // OpenNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 181);
            Controls.Add(confirm_password_button);
            Controls.Add(password_label);
            Controls.Add(note_password_textbox);
            Controls.Add(note_title_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OpenNoteForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label note_title_label;
        private TextBox note_password_textbox;
        private Label password_label;
        private Button confirm_password_button;
    }
}