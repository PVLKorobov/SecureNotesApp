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
        public OpenNoteForm(Form caller_form, string noteTitle)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();

            note_title_label.Text = noteTitle;
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
                target.Text = "";
                target.ForeColor = Color.Black;
            }
        }

        // Фукнция закрытия
        private void exit()
        {
            Close();
            Dispose();
        }


        // Нажатие на кнопку "открыть"
        private void confirm_button_click(object sender, EventArgs e)
        {
            // Чистка сообщений об ошибке
            hide_error(note_password_textbox);

            if (note_password_textbox.Text != "")
            {
                string fileName = note_title_label.Text;
                string password = note_password_textbox.Text;
                bool correct_password = false;
                main_form.open_note(fileName, password, out correct_password);

                if (correct_password)
                {
                    exit();
                }
                else
                {
                    display_error(note_password_textbox, "Неверный пароль");
                }
            }
            else
            {
                display_error(note_password_textbox, "Поле не может быть пустым");
            }
        }

        // Переключение или нажатие на поле ввода
        private void textbox_inFocus(object sender, EventArgs e)
        {
            TextBox target = sender as TextBox;
            hide_error(target);
        }

        // Нажатие на enter или escape
        private void escape_enter_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                confirm_button_click(this, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                exit();
            }
        }


        // Загрузка формы
        private void OpenNoteForm_Load(object sender, EventArgs e)
        {
            // DataContext показывает отображается ли ошибка
            note_password_textbox.DataContext = false;
        }


        private MainForm main_form = null;
    }
}
