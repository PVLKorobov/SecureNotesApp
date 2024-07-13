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
        public ConfirmDeleteForm(MainForm caller_form, string fileName, bool is_editor)
        {
            this.is_editor = is_editor;
            main_form = caller_form;
            cached_file_name = fileName;
            InitializeComponent();
            message_label.Text = $"Удалить {fileName}?";
        }


        private void no_button_click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        
        private void yes_button_click(object sender, EventArgs e)
        {
            if (is_editor)
            {
                main_form.switch_to_main();
            }
            Program.delete_note_file(cached_file_name);
            main_form.update_notes_list();
            Close();
            Dispose();
        }


        private MainForm main_form = null;
        private string cached_file_name;
        private bool is_editor;
    }
}
