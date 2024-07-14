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
            open_folder_button = new Button();
            settings_button = new Button();
            add_note_button = new Button();
            info_button = new Button();
            notes_buttons_list = new FlowLayoutPanel();
            current_note_panel = new Panel();
            text_alignments_panel = new Panel();
            alignment_left_button = new Button();
            alignment_right_button = new Button();
            alignment_center_button = new Button();
            text_sizes_panel = new Panel();
            title_size_button = new Button();
            subtitle_size_button = new Button();
            tools_panel = new Panel();
            save_button = new Button();
            text_sizes_button = new Button();
            bold_button = new Button();
            text_alignments_button = new Button();
            italic_button = new Button();
            strikeout_button = new Button();
            underline_button = new Button();
            current_note_text = new RichTextBox();
            current_note_title = new TextBox();
            close_current_note_button = new Button();
            menuStrip1 = new MenuStrip();
            notes_list_panel.SuspendLayout();
            current_note_panel.SuspendLayout();
            text_alignments_panel.SuspendLayout();
            text_sizes_panel.SuspendLayout();
            tools_panel.SuspendLayout();
            SuspendLayout();
            // 
            // notes_list_panel
            // 
            notes_list_panel.Controls.Add(open_folder_button);
            notes_list_panel.Controls.Add(settings_button);
            notes_list_panel.Controls.Add(add_note_button);
            notes_list_panel.Controls.Add(info_button);
            notes_list_panel.Controls.Add(notes_buttons_list);
            notes_list_panel.Location = new Point(10, 10);
            notes_list_panel.Name = "notes_list_panel";
            notes_list_panel.Size = new Size(762, 499);
            notes_list_panel.TabIndex = 0;
            // 
            // open_folder_button
            // 
            open_folder_button.BackgroundImage = Properties.Resources.folder_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            open_folder_button.BackgroundImageLayout = ImageLayout.Zoom;
            open_folder_button.Cursor = Cursors.Hand;
            open_folder_button.FlatStyle = FlatStyle.Flat;
            open_folder_button.ForeColor = SystemColors.Control;
            open_folder_button.Location = new Point(90, 12);
            open_folder_button.Margin = new Padding(0);
            open_folder_button.Name = "open_folder_button";
            open_folder_button.Size = new Size(40, 40);
            open_folder_button.TabIndex = 4;
            open_folder_button.UseVisualStyleBackColor = true;
            open_folder_button.Click += open_folder_button_Click;
            // 
            // settings_button
            // 
            settings_button.BackgroundImage = Properties.Resources.settings_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            settings_button.BackgroundImageLayout = ImageLayout.Zoom;
            settings_button.Cursor = Cursors.Hand;
            settings_button.FlatStyle = FlatStyle.Flat;
            settings_button.ForeColor = SystemColors.Control;
            settings_button.Location = new Point(50, 12);
            settings_button.Margin = new Padding(0);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(40, 40);
            settings_button.TabIndex = 3;
            settings_button.UseVisualStyleBackColor = true;
            settings_button.Click += settings_button_click;
            // 
            // add_note_button
            // 
            add_note_button.BackColor = SystemColors.Control;
            add_note_button.BackgroundImage = Properties.Resources.add_circle_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            add_note_button.BackgroundImageLayout = ImageLayout.Zoom;
            add_note_button.Cursor = Cursors.Hand;
            add_note_button.FlatStyle = FlatStyle.Flat;
            add_note_button.ForeColor = SystemColors.Control;
            add_note_button.Location = new Point(355, 417);
            add_note_button.Margin = new Padding(0);
            add_note_button.Name = "add_note_button";
            add_note_button.Size = new Size(50, 50);
            add_note_button.TabIndex = 0;
            add_note_button.UseVisualStyleBackColor = false;
            add_note_button.Click += create_note_button_click;
            // 
            // info_button
            // 
            info_button.BackgroundImage = Properties.Resources.info_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            info_button.BackgroundImageLayout = ImageLayout.Zoom;
            info_button.Cursor = Cursors.Hand;
            info_button.FlatStyle = FlatStyle.Flat;
            info_button.ForeColor = SystemColors.Control;
            info_button.Location = new Point(50, 427);
            info_button.Margin = new Padding(0);
            info_button.Name = "info_button";
            info_button.Size = new Size(30, 30);
            info_button.TabIndex = 5;
            info_button.UseVisualStyleBackColor = true;
            info_button.Click += about_button_click;
            // 
            // notes_buttons_list
            // 
            notes_buttons_list.AutoScroll = true;
            notes_buttons_list.Location = new Point(50, 60);
            notes_buttons_list.Name = "notes_buttons_list";
            notes_buttons_list.Size = new Size(738, 340);
            notes_buttons_list.TabIndex = 0;
            // 
            // current_note_panel
            // 
            current_note_panel.Controls.Add(text_alignments_panel);
            current_note_panel.Controls.Add(text_sizes_panel);
            current_note_panel.Controls.Add(tools_panel);
            current_note_panel.Controls.Add(current_note_text);
            current_note_panel.Controls.Add(current_note_title);
            current_note_panel.Controls.Add(close_current_note_button);
            current_note_panel.Controls.Add(menuStrip1);
            current_note_panel.Location = new Point(10, 10);
            current_note_panel.Name = "current_note_panel";
            current_note_panel.Size = new Size(762, 499);
            current_note_panel.TabIndex = 2;
            // 
            // text_alignments_panel
            // 
            text_alignments_panel.Controls.Add(alignment_left_button);
            text_alignments_panel.Controls.Add(alignment_right_button);
            text_alignments_panel.Controls.Add(alignment_center_button);
            text_alignments_panel.Location = new Point(50, 243);
            text_alignments_panel.Name = "text_alignments_panel";
            text_alignments_panel.Size = new Size(108, 37);
            text_alignments_panel.TabIndex = 14;
            text_alignments_panel.Visible = false;
            // 
            // alignment_left_button
            // 
            alignment_left_button.Cursor = Cursors.Hand;
            alignment_left_button.Location = new Point(3, 3);
            alignment_left_button.Name = "alignment_left_button";
            alignment_left_button.Size = new Size(30, 30);
            alignment_left_button.TabIndex = 9;
            alignment_left_button.UseVisualStyleBackColor = true;
            alignment_left_button.Click += align_left_button_click;
            // 
            // alignment_right_button
            // 
            alignment_right_button.Cursor = Cursors.Hand;
            alignment_right_button.Location = new Point(75, 3);
            alignment_right_button.Name = "alignment_right_button";
            alignment_right_button.Size = new Size(30, 30);
            alignment_right_button.TabIndex = 11;
            alignment_right_button.UseVisualStyleBackColor = true;
            alignment_right_button.Click += align_right_button_click;
            // 
            // alignment_center_button
            // 
            alignment_center_button.Cursor = Cursors.Hand;
            alignment_center_button.Location = new Point(39, 3);
            alignment_center_button.Name = "alignment_center_button";
            alignment_center_button.Size = new Size(30, 30);
            alignment_center_button.TabIndex = 10;
            alignment_center_button.UseVisualStyleBackColor = true;
            alignment_center_button.Click += align_center_button_click;
            // 
            // text_sizes_panel
            // 
            text_sizes_panel.Controls.Add(title_size_button);
            text_sizes_panel.Controls.Add(subtitle_size_button);
            text_sizes_panel.Location = new Point(50, 279);
            text_sizes_panel.Name = "text_sizes_panel";
            text_sizes_panel.Size = new Size(72, 37);
            text_sizes_panel.TabIndex = 12;
            text_sizes_panel.Visible = false;
            // 
            // title_size_button
            // 
            title_size_button.Cursor = Cursors.Hand;
            title_size_button.Location = new Point(39, 3);
            title_size_button.Name = "title_size_button";
            title_size_button.Size = new Size(30, 30);
            title_size_button.TabIndex = 14;
            title_size_button.UseVisualStyleBackColor = true;
            title_size_button.Click += set_size_title_button_click;
            // 
            // subtitle_size_button
            // 
            subtitle_size_button.Cursor = Cursors.Hand;
            subtitle_size_button.Location = new Point(3, 3);
            subtitle_size_button.Name = "subtitle_size_button";
            subtitle_size_button.Size = new Size(30, 30);
            subtitle_size_button.TabIndex = 13;
            subtitle_size_button.UseVisualStyleBackColor = true;
            subtitle_size_button.Click += set_size_subtitle_button_click;
            // 
            // tools_panel
            // 
            tools_panel.Controls.Add(save_button);
            tools_panel.Controls.Add(text_sizes_button);
            tools_panel.Controls.Add(bold_button);
            tools_panel.Controls.Add(text_alignments_button);
            tools_panel.Controls.Add(italic_button);
            tools_panel.Controls.Add(strikeout_button);
            tools_panel.Controls.Add(underline_button);
            tools_panel.Location = new Point(7, 60);
            tools_panel.Name = "tools_panel";
            tools_panel.Size = new Size(37, 254);
            tools_panel.TabIndex = 11;
            // 
            // save_button
            // 
            save_button.Cursor = Cursors.Hand;
            save_button.Location = new Point(3, 3);
            save_button.Name = "save_button";
            save_button.Size = new Size(30, 30);
            save_button.TabIndex = 3;
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_click;
            // 
            // text_sizes_button
            // 
            text_sizes_button.Cursor = Cursors.Hand;
            text_sizes_button.Location = new Point(3, 219);
            text_sizes_button.Name = "text_sizes_button";
            text_sizes_button.Size = new Size(30, 30);
            text_sizes_button.TabIndex = 12;
            text_sizes_button.UseVisualStyleBackColor = true;
            text_sizes_button.Click += sizes_list_button_click;
            // 
            // bold_button
            // 
            bold_button.Cursor = Cursors.Hand;
            bold_button.Location = new Point(3, 39);
            bold_button.Name = "bold_button";
            bold_button.Size = new Size(30, 30);
            bold_button.TabIndex = 4;
            bold_button.UseVisualStyleBackColor = true;
            bold_button.Click += bold_button_click;
            // 
            // text_alignments_button
            // 
            text_alignments_button.Cursor = Cursors.Hand;
            text_alignments_button.Location = new Point(3, 183);
            text_alignments_button.Name = "text_alignments_button";
            text_alignments_button.Size = new Size(30, 30);
            text_alignments_button.TabIndex = 8;
            text_alignments_button.UseVisualStyleBackColor = true;
            text_alignments_button.Click += alignments_list_button_click;
            // 
            // italic_button
            // 
            italic_button.Cursor = Cursors.Hand;
            italic_button.Location = new Point(3, 75);
            italic_button.Name = "italic_button";
            italic_button.Size = new Size(30, 30);
            italic_button.TabIndex = 5;
            italic_button.UseVisualStyleBackColor = true;
            italic_button.Click += italic_button_click;
            // 
            // strikeout_button
            // 
            strikeout_button.Cursor = Cursors.Hand;
            strikeout_button.Location = new Point(3, 147);
            strikeout_button.Name = "strikeout_button";
            strikeout_button.Size = new Size(30, 30);
            strikeout_button.TabIndex = 7;
            strikeout_button.UseVisualStyleBackColor = true;
            strikeout_button.Click += strikeout_button_click;
            // 
            // underline_button
            // 
            underline_button.Cursor = Cursors.Hand;
            underline_button.Location = new Point(3, 111);
            underline_button.Name = "underline_button";
            underline_button.Size = new Size(30, 30);
            underline_button.TabIndex = 6;
            underline_button.UseVisualStyleBackColor = true;
            underline_button.Click += underline_button_click;
            // 
            // current_note_text
            // 
            current_note_text.Cursor = Cursors.IBeam;
            current_note_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_note_text.Location = new Point(50, 59);
            current_note_text.Name = "current_note_text";
            current_note_text.Size = new Size(708, 435);
            current_note_text.TabIndex = 0;
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
            close_current_note_button.BackgroundImage = Properties.Resources.arrow_back_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            close_current_note_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_current_note_button.Cursor = Cursors.Hand;
            close_current_note_button.FlatStyle = FlatStyle.Flat;
            close_current_note_button.ForeColor = SystemColors.Control;
            close_current_note_button.Location = new Point(0, 0);
            close_current_note_button.Margin = new Padding(0);
            close_current_note_button.Name = "close_current_note_button";
            close_current_note_button.Size = new Size(42, 42);
            close_current_note_button.TabIndex = 2;
            close_current_note_button.UseVisualStyleBackColor = true;
            close_current_note_button.Click += close_note_button_click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Location = new Point(205, 168);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 517);
            Controls.Add(notes_list_panel);
            Controls.Add(current_note_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Notes";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            notes_list_panel.ResumeLayout(false);
            current_note_panel.ResumeLayout(false);
            current_note_panel.PerformLayout();
            text_alignments_panel.ResumeLayout(false);
            text_sizes_panel.ResumeLayout(false);
            tools_panel.ResumeLayout(false);
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
        private Button strikeout_button;
        private Button underline_button;
        private Button italic_button;
        private Button bold_button;
        private Button save_button;
        private Button text_sizes_button;
        private Button text_alignments_button;
        private MenuStrip menuStrip1;
        private Panel tools_panel;
        private Panel text_sizes_panel;
        private Button title_size_button;
        private Button subtitle_size_button;
        private Panel text_alignments_panel;
        private Button alignment_center_button;
        private Button alignment_left_button;
        private Button alignment_right_button;
    }
}
