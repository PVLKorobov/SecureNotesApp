namespace SecureNotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            is_editor = false;
            cached_password = "";
            cached_title = "";
        }

        // Заполнение списка заметок
        public void update_notes_list()
        {
            notes_buttons_list.Controls.Clear();

            List<string> notesFilenames = Program.get_notes_filenames();
            foreach (string filename in notesFilenames)
            {
                Panel note_panel = new Panel();
                Button note_open_button = new Button();
                Button note_delete_button = new Button();

                note_open_button.Text = filename;
                note_open_button.Dock = DockStyle.Fill;
                note_open_button.Click += open_note_button_click;
                note_open_button.Cursor = Cursors.Hand;
                note_open_button.TabIndex = 1;
/*                note_open_button.FlatStyle = FlatStyle.Flat;
                note_open_button.BackColor = SystemColors.ControlLight;
                note_open_button.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
                note_open_button.FlatAppearance.BorderSize = 0;
*/

                note_delete_button.DataContext = filename;
                note_delete_button.Height = 30;
                note_delete_button.Width = 30;
                note_delete_button.Left = 5;
                note_delete_button.Top = 5;
                note_delete_button.Click += delete_note_button_click;
                note_delete_button.Cursor = Cursors.Hand;
                note_delete_button.TabIndex = 2;


                //note_delete_button.BackColor = SystemColors.Control;
                note_delete_button.BackgroundImage = Properties.Resources.close_16dp_000000_FILL0_wght400_GRAD0_opsz20;
                note_delete_button.BackgroundImageLayout = ImageLayout.Zoom;

                note_delete_button.FlatStyle = FlatStyle.Flat;
                note_delete_button.FlatAppearance.BorderSize = 0;
                
               // note_delete_button.FlatAppearance.BorderColor = SystemColors.ControlDark;
                note_delete_button.BackColor = SystemColors.ControlLight;

                note_delete_button.Margin = new Padding(0);
                
                


                note_panel.Controls.Add(note_delete_button);
                note_panel.Controls.Add(note_open_button);
                note_panel.Height = 100;
                note_panel.Width = 654;

                notes_buttons_list.Controls.Add(note_panel);
            }
        }

        // Функция открытия заметки
        public void open_note(string fileName, string password, out bool isCorrectPassword)
        {
            isCorrectPassword = false;
            byte[] encrypted_contents = Program.read_file(fileName);
            byte[] decrypted_contents = AES.Decryption(password, encrypted_contents, out isCorrectPassword);

            if (isCorrectPassword)
            {
                // Запись массива байтов в rich text box через memory stream
                MemoryStream RTBInputStream = new MemoryStream();
                RTBInputStream.Write(decrypted_contents);
                RTBInputStream.Position = 0;

                current_note_text.LoadFile(RTBInputStream, RichTextBoxStreamType.RichText);
                RTBInputStream.Close();
                //
                current_note_title.Text = fileName;
                cached_title = fileName;
                cached_password = password;

                switch_to_editor();
            }
        }

        // Сохранение нового текста заметки
        private void save_note()
        {
            string fileName = current_note_title.Text;
            // считывание текста rich text box в массив байтов через memory stream
            MemoryStream RTBOutputStream = new MemoryStream();
            current_note_text.SaveFile(RTBOutputStream, RichTextBoxStreamType.RichText);
            RTBOutputStream.Position = 0;
            byte[] decryptedContents = RTBOutputStream.ToArray();
            RTBOutputStream.Close();
            //
            byte[] encryptedContents = AES.Encryption(cached_password, decryptedContents);
            Program.update_file_contents(fileName, encryptedContents);
        }

        // Переход в главное меню
        public void switch_to_main()
        {
            notes_list_panel.Visible = true;
            current_note_panel.Visible = false;
            is_editor = false;

            cached_title = "";
            cached_password = "";
            current_note_title.Text = "";
            current_note_text.Text = "";
        }

        // Переход в редактор заметки
        public void switch_to_editor()
        {
            notes_list_panel.Visible = false;
            current_note_panel.Visible = true;
            is_editor = true;

            hide_panel(text_alignments_panel);
            hide_panel(text_sizes_panel);
            // DataContext показывает статус соответствующего списка
            text_alignments_button.DataContext = false;
            text_sizes_button.DataContext = false;
        }


        // Нажатие на кнопку создания новой заметки
        private void create_note_button_click(Object sender, EventArgs e)
        {
            CreateNoteForm create_new_note_dialog = new CreateNoteForm(this);
            create_new_note_dialog.ShowDialog();
        }

        // Нажатие на кнопку настроек
        private void settings_button_click(Object sender, EventArgs e)
        {
            SettingsForm settigs_dialog = new SettingsForm(this);
            settigs_dialog.ShowDialog();
        }

        private void about_button_click(Object sender, EventArgs e)
        {
            AboutForm settigs_dialog = new AboutForm();
            settigs_dialog.ShowDialog();
        }

        // Нажатие на кнопку директории
        private void open_folder_button_Click(object sender, EventArgs e)
        {
            Program.open_notes_location();
        }


        // Нажатие на заметку из списка
        private void open_note_button_click(object sender, EventArgs e)
        {
            string fileName = (sender as Button).Text;
            OpenNoteForm enter_password_dialog = new OpenNoteForm(this, fileName);
            enter_password_dialog.ShowDialog();
        }

        // Нажатие на кнопку удаления в списке
        private void delete_note_button_click(Object sender, EventArgs e)
        {
            string fileName = (sender as Button).DataContext as string;
            ConfirmDeleteForm confirmation_dialog = new ConfirmDeleteForm(this, fileName);
            confirmation_dialog.ShowDialog();
        }


        //
        // Панель редактирования заметки
        //


        // Функция отключения панели
        private void hide_panel(Panel target)
        {
            target.Visible = false;
        }

        // Функция включения панели
        private void show_panel(Panel target)
        {
            target.Visible = true;
        }


        // Нажатие на кнопку "назад"
        private void close_note_button_click(object sender, EventArgs e)
        {
            save_note();
            switch_to_main();
        }

        // Нажатие на кнопку удаления в редакторе
        private void editor_delete_note_button_click(Object sender, EventArgs e)
        {
            string fileName = current_note_title.Text;
            ConfirmDeleteForm confirmation_dialog = new ConfirmDeleteForm(this, fileName);
            confirmation_dialog.ShowDialog();
        }

        // Нажатие на кнопку сохранения
        private void save_button_click(object sender, EventArgs e)
        {
            save_note();
        }

        // Нажатие на кнопку "жирный текст"
        private void bold_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            bool isBold = current_note_text.SelectionFont.Bold;
            if (isBold)
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Bold);


        }

        // Нажатие на кнопку "курсив"
        private void italic_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            bool isItalic = current_note_text.SelectionFont.Italic;
            if (isItalic)
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Italic);
        }

        // Нажатие на кнопку "подчёркивание"
        private void underline_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            bool isUnderline = current_note_text.SelectionFont.Underline;
            if (isUnderline)
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Underline);
        }

        // Нажатие на кнопку "зачёркивание"
        private void strikeout_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            bool isStrikeout = current_note_text.SelectionFont.Strikeout;
            if (isStrikeout)
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Regular);
            else
                current_note_text.SelectionFont = new Font(font_name, font_size, FontStyle.Strikeout);
        }


        // Нажатие на кнопку списка кнопок выравнивания
        private void alignments_list_button_click(object sender, EventArgs e)
        {
            bool listShown = (bool)text_alignments_button.DataContext;
            if (listShown)
            {
                hide_panel(text_alignments_panel);
                text_alignments_button.DataContext = false;
            }
            else
            {
                show_panel(text_alignments_panel);
                text_alignments_button.DataContext = true;
            }
        }


        // Нажатие на кнопку "текст слева"
        private void align_left_button_click(object sender, EventArgs e)
        {
            current_note_text.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Нажатие на кнопку "текст по центру"
        private void align_center_button_click(object sender, EventArgs e)
        {
            current_note_text.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Нажатие на кнопку "текст справа"
        private void align_right_button_click(object sender, EventArgs e)
        {
            current_note_text.SelectionAlignment = HorizontalAlignment.Right;
        }


        // Нажатие на кнопку списка кнопок размера текста
        private void sizes_list_button_click(object sender, EventArgs e)
        {
            bool listShown = (bool)text_sizes_button.DataContext;
            if (listShown)
            {
                hide_panel(text_sizes_panel);
                text_sizes_button.DataContext = false;
            }
            else
            {
                show_panel(text_sizes_panel);
                text_sizes_button.DataContext = true;
            }
        }

        // Нажатие на кнопку "размер текста - заголовок"
        private void set_size_title_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            if (font_size == 20)
                current_note_text.SelectionFont = new Font(font_name, 14);
            else
                current_note_text.SelectionFont = new Font(font_name, 20);
        }

        // Нажатие на кнопку "размер текста - подзаголовок"
        private void set_size_subtitle_button_click(object sender, EventArgs e)
        {
            string font_name = current_note_text.SelectionFont.Name;
            float font_size = current_note_text.SelectionFont.Size;
            if (font_size == 16)
                current_note_text.SelectionFont = new Font(font_name, 14);
            else
                current_note_text.SelectionFont = new Font(font_name, 16);
        }

        // Изменение заголовка заметки
        private void current_note_title_TextChanged(object sender, EventArgs e)
        {
            string newFileName = current_note_title.Text;
            Program.update_file_name(cached_title, newFileName);
            update_notes_list();
            cached_title = newFileName;
        }


        // Форма

        // Первая загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            update_notes_list();
            current_note_panel.Visible = false;
        }
        
        // Закрытие формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (current_note_panel.Visible)
            {
                save_note();
            }
        }


        public bool is_editor;
        private string cached_title, cached_password;
    }
}
