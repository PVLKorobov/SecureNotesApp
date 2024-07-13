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
        public void open_note(string fileName, string password, out bool correct_password)
        {
            correct_password = false;
            byte[] encrypted_contents = Program.read_file(fileName);
            byte[] decrypted_contents = AES.Decryption(password, encrypted_contents, out correct_password);

            if (correct_password)
            {
                // ������ ������� ������ � rich text box ����� memory stream
                MemoryStream RTBInputStream = new MemoryStream();
                RTBInputStream.Write(decrypted_contents);
                RTBInputStream.Position = 0;

                current_note_text.LoadFile(RTBInputStream, RichTextBoxStreamType.RichText);
                //
                current_note_title.Text = fileName;
                cached_title = fileName;
                cached_password = password;

                notes_list_panel.Visible = false;
                current_note_panel.Visible = true;
            }
        }

        // ���������� ������ ������ �������
        private void save_note()
        {
            string fileName = current_note_title.Text;
            // ���������� ������ rich text box � ������ ������ ����� memory stream
            MemoryStream RTBOutputStream = new MemoryStream();
            current_note_text.SaveFile(RTBOutputStream, RichTextBoxStreamType.RichText);
            RTBOutputStream.Position = 0;
            byte[] decryptedContents = RTBOutputStream.ToArray();
            //
            byte[] encryptedContents = AES.Encryption(cached_password, decryptedContents);
            Program.update_file_contents(fileName, encryptedContents);
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
            OpenNoteForm enter_password_dialog = new OpenNoteForm(this, fileName);
            enter_password_dialog.ShowDialog();
        }


        // ������ �������������� �������

        // ������� �� ������ "�����"
        private void close_note_button_click(object sender, EventArgs e)
        {
            save_note();

            notes_list_panel.Visible = true;
            current_note_panel.Visible = false;

            cached_title = "";
            cached_password = "";
            current_note_title.Text = "";
            current_note_text.Text = "";
        }

        // ��������� ��������� �������
        private void current_note_title_TextChanged(object sender, EventArgs e)
        {
            string newFileName = current_note_title.Text;
            Program.update_file_name(cached_title, newFileName);
            cached_title = newFileName;
        }


        // �����

        // ������ �������� �����
        private void MainForm_Load(object sender, EventArgs e)
        {
            update_notes_list();
            current_note_panel.Visible = false;
        }
        
        // �������� �����
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
