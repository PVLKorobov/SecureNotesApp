namespace SecureNotesApp
{
    partial class ConfirmDeleteForm
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
            message_label = new Label();
            no_button = new Button();
            yes_button = new Button();
            SuspendLayout();
            // 
            // message_label
            // 
            message_label.Font = new Font("Segoe UI", 14F);
            message_label.Location = new Point(12, 23);
            message_label.Name = "message_label";
            message_label.Size = new Size(260, 25);
            message_label.TabIndex = 0;
            message_label.Text = "<message text>";
            message_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // no_button
            // 
            no_button.Font = new Font("Segoe UI", 12F);
            no_button.Location = new Point(32, 113);
            no_button.Name = "no_button";
            no_button.Size = new Size(60, 30);
            no_button.TabIndex = 1;
            no_button.Text = "Нет";
            no_button.UseVisualStyleBackColor = true;
            no_button.Click += no_button_click;
            no_button.KeyPress += escape_keyPress;
            // 
            // yes_button
            // 
            yes_button.Font = new Font("Segoe UI", 12F);
            yes_button.Location = new Point(192, 113);
            yes_button.Name = "yes_button";
            yes_button.Size = new Size(60, 30);
            yes_button.TabIndex = 2;
            yes_button.Text = "Да";
            yes_button.UseVisualStyleBackColor = true;
            yes_button.Click += yes_button_click;
            yes_button.KeyPress += escape_keyPress;
            // 
            // ConfirmDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(yes_button);
            Controls.Add(no_button);
            Controls.Add(message_label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmDeleteForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Label message_label;
        private Button no_button;
        private Button yes_button;
    }
}