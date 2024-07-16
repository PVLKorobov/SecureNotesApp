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
    public partial class ConfirmDeleteForm : Form
    {
        public ConfirmDeleteForm(MainForm caller_form, string fileName)
        {
            main_form = caller_form;
            cached_file_name = fileName;
            InitializeComponent();
            message_label.Text = $"Удалить {fileName}?";
        }


        private void exit()
        {
            Close();
            Dispose();
        }


        // Нажатие на кнопку "нет"
        private void no_button_click(object sender, EventArgs e)
        {
            exit();
        }
        
        // Нажатие на кнопку "да"
        private void yes_button_click(object sender, EventArgs e)
        {
            if (main_form.is_editor)
            {
                main_form.switch_to_main();
            }
            FileWork.delete_note_file(cached_file_name);
            main_form.update_notes_list();
            exit();
        }

        // Нажатие на enter
        private void escape_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                exit();
            }
        }


        private MainForm main_form = null;
        private string cached_file_name;
    }
}
