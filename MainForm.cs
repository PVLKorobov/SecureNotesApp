namespace SecureNotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // заполнение списка заметок
        public void update_notes_list()
        {
            notes_buttons_list.Controls.Clear();

            List<string> notesFilenames = Program.get_notes_filenames();
            foreach (string filename in notesFilenames)
            {
                Button note_button = new Button();
                note_button.Text = filename;
                note_button.Width = notes_buttons_list.Width - 25;
                note_button.Height = 100;
                note_button.Click += open_note_button_click;
                note_button.Cursor = Cursors.Hand;

                notes_buttons_list.Controls.Add(note_button);
            }
        }

        // функция открытия заметки
        public void open_note(string fileName)
        {
            current_note_text.Text = Program.read_file(fileName);
            current_note_title.Text = fileName;
            cached_title = fileName;

            notes_list_panel.Visible = false;
            current_note_panel.Visible = true;
        }

        // Сохранение нового текста заметки
        private void save_note()
        {
            string fileName = current_note_title.Text;
            string contents = current_note_text.Text;
            Program.update_file_contents(fileName, contents);
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
            open_note(fileName); // вызов функции открытия заметки
        }


        // Панель редактирования заметки

        // Нажатие на кнопку "назад"
        private void close_note_button_click(object sender, EventArgs e)
        {
            save_note();

            notes_list_panel.Visible = true;
            current_note_panel.Visible = false;

            cached_title = "";
            current_note_title.Text = "";
            current_note_text.Text = "";
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


        private string cached_title;
    }
}
