namespace SecureNotesApp
{
    partial class CreateNoteForm
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
            confirm_button = new Button();
            note_title_textbox = new TextBox();
            note_password_textbox = new TextBox();
            new_note_label = new Label();
            name_label = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // confirm_button
            // 
            confirm_button.Cursor = Cursors.Hand;
            confirm_button.Font = new Font("Segoe UI", 12F);
            confirm_button.Location = new Point(140, 200);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(120, 40);
            confirm_button.TabIndex = 2;
            confirm_button.Text = "Создать";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_click;
            // 
            // note_title_textbox
            // 
            note_title_textbox.Cursor = Cursors.IBeam;
            note_title_textbox.Font = new Font("Segoe UI", 12F);
            note_title_textbox.Location = new Point(117, 81);
            note_title_textbox.Name = "note_title_textbox";
            note_title_textbox.Size = new Size(255, 29);
            note_title_textbox.TabIndex = 0;
            note_title_textbox.Click += textbox_inFocus;
            note_title_textbox.Enter += textbox_inFocus;
            note_title_textbox.KeyPress += escape_enter_keyPress;
            // 
            // note_password_textbox
            // 
            note_password_textbox.Cursor = Cursors.IBeam;
            note_password_textbox.Font = new Font("Segoe UI", 12F);
            note_password_textbox.Location = new Point(117, 123);
            note_password_textbox.MaxLength = 32;
            note_password_textbox.Name = "note_password_textbox";
            note_password_textbox.PasswordChar = '*';
            note_password_textbox.Size = new Size(255, 29);
            note_password_textbox.TabIndex = 1;
            note_password_textbox.Click += textbox_inFocus;
            note_password_textbox.Enter += textbox_inFocus;
            note_password_textbox.KeyPress += escape_enter_keyPress;
            // 
            // new_note_label
            // 
            new_note_label.AutoSize = true;
            new_note_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            new_note_label.Location = new Point(83, 20);
            new_note_label.Name = "new_note_label";
            new_note_label.Size = new Size(234, 45);
            new_note_label.TabIndex = 3;
            new_note_label.Text = "Новая заметка";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_label.Location = new Point(12, 81);
            name_label.Name = "name_label";
            name_label.Size = new Size(99, 25);
            name_label.TabIndex = 4;
            name_label.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(29, 123);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            // 
            // CreateNoteForm
            // 
            AcceptButton = confirm_button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(label2);
            Controls.Add(name_label);
            Controls.Add(new_note_label);
            Controls.Add(note_password_textbox);
            Controls.Add(note_title_textbox);
            Controls.Add(confirm_button);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateNoteForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += CreateNoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirm_button;
        private TextBox note_title_textbox;
        private TextBox note_password_textbox;
        private Label new_note_label;
        private Label name_label;
        private Label label2;
    }
}