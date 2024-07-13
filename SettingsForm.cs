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
    public partial class SettingsForm : Form
    {
        public SettingsForm(Form caller_form)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();
        }


        private MainForm main_form = null;
    }
}
