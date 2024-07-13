namespace SecureNotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

                note_delete_button.DataContext = filename;
                note_delete_button.Height = 30;
                note_delete_button.Width = 30;
                note_delete_button.Left = 5;
                note_delete_button.Top = 5;
                note_delete_button.Click += delete_note_button_click;
                note_delete_button.Cursor = Cursors.Hand;
                note_delete_button.TabIndex = 2;

                note_panel.Controls.Add(note_delete_button);
                note_panel.Controls.Add(note_open_button);
                note_panel.Height = 100;
                note_panel.Width = 654;

                notes_buttons_list.Controls.Add(note_panel);
            }
        }

        // Функция открытия заметки
        public void open_note(string fileName, string password, out bool correct_password)
        {
            correct_password = false;
            byte[] encrypted_contents = Program.read_file(fileName);
            byte[] decrypted_contents = AES.Decryption(password, encrypted_contents, out correct_password);

            if (correct_password)
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
            ConfirmDeleteForm confirmation_dialog = new ConfirmDeleteForm(this, fileName, false);
            confirmation_dialog.ShowDialog();
        }


        // Панель редактирования заметки

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
            ConfirmDeleteForm confirmation_dialog = new ConfirmDeleteForm(this, fileName, true);
            confirmation_dialog.ShowDialog();
        }

        // Изменение заголовка заметки
        private void current_note_title_TextChanged(object sender, EventArgs e)
        {
            string newFileName = current_note_title.Text;
            Program.update_file_name(cached_title, newFileName);
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


        private string cached_title, cached_password;
    }
}
