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
        // Конструктор
        public SettingsForm(Form caller_form)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();
        }


        // Функция вывода сообщения об ошибке
        private void display_error(TextBox target, string message)
        {
            target.DataContext = true;
            target.Text = message;
            target.ForeColor = Color.Red;
        }

        // Функция скрытия сообщения об ошибке
        private void hide_error(TextBox target)
        {
            bool displaying_error = (bool)target.DataContext;
            if (displaying_error)
            {
                target.DataContext = false;
                target.ForeColor = Color.Black;
                if (target.Name == "path_textbox")
                {
                    target.Text = Program.get_location();
                }
                else
                {
                    target.Text = "";
                }
            }
        }

        // Фукнция закрытия
        private void exit()
        {
            Close();
            Dispose();
        }


        // Нажатие на кнопку "применить"
        private void confirm_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (path_textbox.Text != Program.get_location())
                {
                    Program.set_location(path_textbox.Text);
                    main_form.update_notes_list();
                }
                exit();
            }
            catch (ArgumentException exeption)
            {
                display_error(path_textbox, exeption.Message);
            }
        }

        // Нажатие на кнопку "отмена"
        private void cancel_button_Click(object sender, EventArgs e)
        {
            exit();
        }

        // Переключение или нажатие на поле ввода
        private void textbox_inFocus(object sender, EventArgs e)
        {
            TextBox target = sender as TextBox;
            hide_error(target);
        }


        // Загрузка формы
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            path_textbox.Text = Program.get_location();
            // DataContext показывает отображается ли ошибка
            path_textbox.DataContext = false;
        }


        private MainForm main_form = null;
    }
}
