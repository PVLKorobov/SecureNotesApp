namespace SecureNotesApp
{
    partial class Form1
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
            notes_list_panel = new Panel();
            test_note_open_button = new Button();
            test_note_name = new Label();
            current_note_panel = new Panel();
            current_note_text = new RichTextBox();
            current_note_title = new TextBox();
            close_current_note_button = new Button();
            notes_list_panel.SuspendLayout();
            current_note_panel.SuspendLayout();
            SuspendLayout();
            // 
            // notes_list_panel
            // 
            notes_list_panel.Controls.Add(test_note_open_button);
            notes_list_panel.Controls.Add(test_note_name);
            notes_list_panel.Location = new Point(12, 12);
            notes_list_panel.Name = "notes_list_panel";
            notes_list_panel.Size = new Size(776, 426);
            notes_list_panel.TabIndex = 0;
            // 
            // test_note_open_button
            // 
            test_note_open_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            test_note_open_button.Cursor = Cursors.Hand;
            test_note_open_button.Location = new Point(330, 59);
            test_note_open_button.Name = "test_note_open_button";
            test_note_open_button.Size = new Size(53, 49);
            test_note_open_button.TabIndex = 1;
            test_note_open_button.UseVisualStyleBackColor = true;
            test_note_open_button.Click += open_note_click;
            // 
            // test_note_name
            // 
            test_note_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            test_note_name.AutoSize = true;
            test_note_name.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            test_note_name.Location = new Point(101, 55);
            test_note_name.Name = "test_note_name";
            test_note_name.Size = new Size(220, 50);
            test_note_name.TabIndex = 0;
            test_note_name.Text = "<note title>";
            // 
            // current_note_panel
            // 
            current_note_panel.Controls.Add(current_note_text);
            current_note_panel.Controls.Add(current_note_title);
            current_note_panel.Controls.Add(close_current_note_button);
            current_note_panel.Location = new Point(12, 12);
            current_note_panel.Name = "current_note_panel";
            current_note_panel.Size = new Size(776, 426);
            current_note_panel.TabIndex = 2;
            // 
            // current_note_text
            // 
            current_note_text.Cursor = Cursors.IBeam;
            current_note_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_note_text.Location = new Point(74, 59);
            current_note_text.Name = "current_note_text";
            current_note_text.Size = new Size(630, 343);
            current_note_text.TabIndex = 2;
            current_note_text.Text = "";
            // 
            // current_note_title
            // 
            current_note_title.Cursor = Cursors.IBeam;
            current_note_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_note_title.Location = new Point(344, 24);
            current_note_title.Name = "current_note_title";
            current_note_title.Size = new Size(91, 29);
            current_note_title.TabIndex = 1;
            current_note_title.Text = "<note title>";
            // 
            // close_current_note_button
            // 
            close_current_note_button.Cursor = Cursors.Hand;
            close_current_note_button.Location = new Point(3, 3);
            close_current_note_button.Name = "close_current_note_button";
            close_current_note_button.Size = new Size(75, 23);
            close_current_note_button.TabIndex = 0;
            close_current_note_button.Text = "<-----";
            close_current_note_button.UseVisualStyleBackColor = true;
            close_current_note_button.Click += close_note_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notes_list_panel);
            Controls.Add(current_note_panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            notes_list_panel.ResumeLayout(false);
            notes_list_panel.PerformLayout();
            current_note_panel.ResumeLayout(false);
            current_note_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel notes_list_panel;
        private Label test_note_name;
        private Button test_note_open_button;
        private Panel current_note_panel;
        private Button close_current_note_button;
        private TextBox current_note_title;
        private RichTextBox current_note_text;
    }
}
