namespace SecureNotesApp
{
    partial class SettingsForm
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
            path_label = new Label();
            path_textbox = new TextBox();
            confirm_button = new Button();
            cancel_button = new Button();
            SuspendLayout();
            // 
            // path_label
            // 
            path_label.AutoSize = true;
            path_label.Font = new Font("Segoe UI", 14F);
            path_label.Location = new Point(12, 23);
            path_label.Name = "path_label";
            path_label.Size = new Size(219, 25);
            path_label.TabIndex = 0;
            path_label.Text = "Путь хранения заметок:";
            // 
            // path_textbox
            // 
            path_textbox.Font = new Font("Segoe UI", 14F);
            path_textbox.Location = new Point(12, 51);
            path_textbox.Name = "path_textbox";
            path_textbox.Size = new Size(400, 32);
            path_textbox.TabIndex = 1;
            path_textbox.Click += textbox_inFocus;
            path_textbox.Enter += textbox_inFocus;
            // 
            // confirm_button
            // 
            confirm_button.Font = new Font("Segoe UI", 12F);
            confirm_button.Location = new Point(312, 169);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(100, 30);
            confirm_button.TabIndex = 2;
            confirm_button.Text = "Применить";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Font = new Font("Segoe UI", 12F);
            cancel_button.Location = new Point(12, 169);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(100, 30);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Отмена";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 211);
            Controls.Add(cancel_button);
            Controls.Add(confirm_button);
            Controls.Add(path_textbox);
            Controls.Add(path_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label path_label;
        private TextBox path_textbox;
        private Button confirm_button;
        private Button cancel_button;
    }
}