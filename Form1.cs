namespace SecureNotesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_note_click(object sender, EventArgs e)
        {
            notes_list_panel.Visible = false;
            current_note_panel.Visible = true;
            current_note_text.Text = Program.read_file("test1");
        }

        private void close_note_click(object sender, EventArgs e)
        {
            notes_list_panel.Visible = true;
            current_note_panel.Visible = false;
            current_note_text.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_note_panel.Visible = false;
        }
    }
}
