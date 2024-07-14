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
        public CreateNoteForm(Form caller_form)
        {
            main_form = caller_form as MainForm;
            InitializeComponent();
        }


        // Функция вывода сообщения об ошибке
        private void display_error(TextBox target, string message)
        {
            if (target.Name == "note_password_textbox") { target.PasswordChar = '\0'; }
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
                if (target.Name == "note_password_textbox") { target.PasswordChar = '*'; }
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


        // Нажатие на кнопку "создать"
        private void confirm_button_click(object sender, EventArgs e)
        {
            // Чистка сообщений об ошибке
            hide_error(note_password_textbox);
            hide_error(note_title_textbox);

            if (note_title_textbox.Text != "" && note_password_textbox.Text != "")
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
                    main_form.update_notes_list();
                    exit();
                }
                else
                {
                    display_error(note_password_textbox, "Неверный пароль");
                }
            }
            else
            {
                if (note_title_textbox.Text == "") 
                {
                    display_error(note_title_textbox, "Поле не может быть пустым");
                }
                if (note_password_textbox.Text == "")
                {
                    display_error(note_password_textbox, "Поле не может быть пустым");
                }
            }
        }

        // Переключение или нажатие на поле ввода пароля
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
        private void CreateNoteForm_Load(object sender, EventArgs e)
        {
            // DataContext показывает отображается ли ошибка
            note_title_textbox.DataContext = false;
            note_password_textbox.DataContext = false;
        }


        private MainForm main_form = null;
    }
}
