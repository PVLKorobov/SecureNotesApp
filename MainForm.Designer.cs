namespace SecureNotesApp
{
    partial class MainForm
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
            add_note_button = new Button();
            info_button = new Button();
            open_folder_button = new Button();
            settings_button = new Button();
            notes_buttons_list = new FlowLayoutPanel();
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
            notes_list_panel.Controls.Add(add_note_button);
            notes_list_panel.Controls.Add(info_button);
            notes_list_panel.Controls.Add(open_folder_button);
            notes_list_panel.Controls.Add(settings_button);
            notes_list_panel.Controls.Add(notes_buttons_list);
            notes_list_panel.Location = new Point(10, 10);
            notes_list_panel.Name = "notes_list_panel";
            notes_list_panel.Size = new Size(762, 499);
            notes_list_panel.TabIndex = 0;
            // 
            // add_note_button
            // 
            add_note_button.Cursor = Cursors.Hand;
            add_note_button.Location = new Point(355, 417);
            add_note_button.Name = "add_note_button";
            add_note_button.Size = new Size(50, 50);
            add_note_button.TabIndex = 4;
            add_note_button.UseVisualStyleBackColor = true;
            add_note_button.Click += create_note_button_click;
            // 
            // info_button
            // 
            info_button.Cursor = Cursors.Hand;
            info_button.Location = new Point(3, 464);
            info_button.Name = "info_button";
            info_button.Size = new Size(30, 30);
            info_button.TabIndex = 3;
            info_button.UseVisualStyleBackColor = true;
            info_button.Click += about_button_click;
            // 
            // open_folder_button
            // 
            open_folder_button.Cursor = Cursors.Hand;
            open_folder_button.Location = new Point(50, 15);
            open_folder_button.Name = "open_folder_button";
            open_folder_button.Size = new Size(30, 30);
            open_folder_button.TabIndex = 2;
            open_folder_button.UseVisualStyleBackColor = true;
            open_folder_button.Click += open_folder_button_Click;
            // 
            // settings_button
            // 
            settings_button.Cursor = Cursors.Hand;
            settings_button.Location = new Point(15, 15);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(30, 30);
            settings_button.TabIndex = 1;
            settings_button.UseVisualStyleBackColor = true;
            settings_button.Click += settings_button_click;
            // 
            // notes_buttons_list
            // 
            notes_buttons_list.AutoScroll = true;
            notes_buttons_list.Location = new Point(50, 60);
            notes_buttons_list.Name = "notes_buttons_list";
            notes_buttons_list.Size = new Size(660, 340);
            notes_buttons_list.TabIndex = 0;
            // 
            // current_note_panel
            // 
            current_note_panel.Controls.Add(current_note_text);
            current_note_panel.Controls.Add(current_note_title);
            current_note_panel.Controls.Add(close_current_note_button);
            current_note_panel.Location = new Point(10, 10);
            current_note_panel.Name = "current_note_panel";
            current_note_panel.Size = new Size(762, 499);
            current_note_panel.TabIndex = 2;
            // 
            // current_note_text
            // 
            current_note_text.Cursor = Cursors.IBeam;
            current_note_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_note_text.Location = new Point(50, 59);
            current_note_text.Name = "current_note_text";
            current_note_text.Size = new Size(708, 435);
            current_note_text.TabIndex = 2;
            current_note_text.Text = "";
            // 
            // current_note_title
            // 
            current_note_title.Cursor = Cursors.IBeam;
            current_note_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_note_title.Location = new Point(128, 24);
            current_note_title.Name = "current_note_title";
            current_note_title.Size = new Size(630, 29);
            current_note_title.TabIndex = 1;
            current_note_title.Text = "<note title>";
            current_note_title.TextChanged += current_note_title_TextChanged;
            // 
            // close_current_note_button
            // 
            close_current_note_button.Cursor = Cursors.Hand;
            close_current_note_button.Location = new Point(3, 3);
            close_current_note_button.Name = "close_current_note_button";
            close_current_note_button.Size = new Size(50, 30);
            close_current_note_button.TabIndex = 0;
            close_current_note_button.Text = "<-----";
            close_current_note_button.UseVisualStyleBackColor = true;
            close_current_note_button.Click += close_note_button_click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 517);
            Controls.Add(notes_list_panel);
            Controls.Add(current_note_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Notes";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            notes_list_panel.ResumeLayout(false);
            current_note_panel.ResumeLayout(false);
            current_note_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel notes_list_panel;
        private Panel current_note_panel;
        private Button close_current_note_button;
        private TextBox current_note_title;
        private RichTextBox current_note_text;
        private FlowLayoutPanel notes_buttons_list;
        private Button settings_button;
        private Button open_folder_button;
        private Button info_button;
        private Button add_note_button;
    }
}
