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
    public partial class OpenNoteForm : Form
    {
        public OpenNoteForm()
        {
            InitializeComponent();
        }

        public OpenNoteForm(Form caller_form, string noteTitle)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();

            note_title_label.Text = noteTitle;
        }


        // нажатие на кнопку "открыть"
        private void confirm_password_button_click(object sender, EventArgs e)
        {
            if (note_password_textbox.Text != "")
            {
                string fileName = note_title_label.Text;
                string password = note_password_textbox.Text;
                bool correct_password = false;
                main_form.open_note(fileName, password, out correct_password);

                if (correct_password)
                {
                    Close();
                    Dispose();
                }
            }
        }


        private MainForm main_form = null;
    }
}
