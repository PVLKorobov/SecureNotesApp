﻿using System;
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
                string password = note_password_textbox.Text;
                string empty_temp = "{\\rtf1\\ansi\\deff0}";
                byte[] decryptedContents = Encoding.ASCII.GetBytes(empty_temp);
                byte[] encryptedContents = AES.Encryption(password, decryptedContents);
                Program.create_note_file(fileName, encryptedContents);
                bool correct_password;
                main_form.open_note(fileName, password, out correct_password);

                if (correct_password)
                {
                    Close();
                    main_form.update_notes_list();
                    Dispose();
                }
            }
        }


        private MainForm main_form = null;
    }
}
