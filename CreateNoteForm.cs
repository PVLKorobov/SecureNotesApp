using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureNotesApp
{
    public partial class CreateNoteForm : Form
    {
        public CreateNoteForm()
        {
            InitializeComponent();
        }

        public CreateNoteForm(Form caller_form)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();
        }


        // нажатие на кнопку "создать"
        private void confirm_button_click(object sender, EventArgs e)
        {
            if (note_title_textbox.Text != "")
            {
                string fileName = note_title_textbox.Text;
                Program.create_note_file(fileName);
                this.Close();
                this.main_form.open_note(fileName);
                this.main_form.update_notes_list();
                this.Dispose();
            }
        }


        private MainForm main_form = null;
    }
}
