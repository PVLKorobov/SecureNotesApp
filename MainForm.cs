namespace SecureNotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ���������� ������ �������
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

        // ������� �������� �������
        public void open_note(string fileName, string notePassword = "") // ��������� ����������� �������� ������
        {
            notes_list_panel.Visible = false;
            current_note_panel.Visible = true;
            current_note_text.Text = Program.read_file(fileName);
            current_note_title.Text = fileName;
        }


        // ������� �� ������ �������� ����� �������
        private void create_note_button_click(Object sender, EventArgs e)
        {
            CreateNoteForm create_new_note_dialog = new CreateNoteForm(this);
            create_new_note_dialog.ShowDialog();
        }

        // ������� �� ������ ��������
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

        // ������� �� ������ ����������
        private void open_folder_button_Click(object sender, EventArgs e)
        {
            Program.open_notes_location();
        }


        // ������� �� ������� �� ������
        private void open_note_button_click(object sender, EventArgs e)
        {
            string fileName = (sender as Button).Text;
            open_note(fileName); // ����� ������� �������� �������
        }

        
        // ������ �������������� �������

        // ������� �� ������ "�����"
        private void close_note_button_click(object sender, EventArgs e)
        {
            notes_list_panel.Visible = true;
            current_note_panel.Visible = false;
            current_note_text.Text = "";
        }

        // ������ �������� �����
        private void Form1_Load(object sender, EventArgs e)
        {
            update_notes_list();
            current_note_panel.Visible = false;
        }
    }
}
