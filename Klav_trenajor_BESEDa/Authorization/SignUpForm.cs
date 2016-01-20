using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Authorization;
namespace BESEDa
{
    public partial class SignUpForm : Form
    {
        private User _currentUser;
        public SignUpForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '•';
            confirmBox.PasswordChar = '•';
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            string confirm = confirmBox.Text;
            if (login.Equals(""))
                MessageBox.Show("Форма ввода логина не заполнена. ");
            else
            {
                if (password.Equals(""))
                    MessageBox.Show("Форма ввода пароля не заполнена.");
                else if (confirm.Equals(""))
                    MessageBox.Show("Форма ввода подтверждения пароля не заполнена.");
                else if (password.Length < 4)
                    MessageBox.Show("Слишком короткий пароль. Длина пароля должна быть не менее 4-х символов");
                else if (password.Equals(confirm))
                {
                    _currentUser = new User(login, password, false);
                    int code = _currentUser.insertUser();
                    if (code != -1)
                    {
                        KeyboardTrainIndex main = this.Owner as KeyboardTrainIndex;
                        if (main != null)
                        {
                            main.CurrentUser = _currentUser;
                        }
                        this.Close();
                    }
                    else
                        MessageBox.Show("Учетная запись с таким логином уже существует!");
                }
                else
                    MessageBox.Show("Пароли не совпадают");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
