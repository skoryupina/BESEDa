using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Authorization;
using BESEDa.Administrative;
namespace BESEDa
{
    public partial class EditAccountForm : Form
    {
        User _currentUser;
        TrainedForm main;
        TrainerForm adminMain;
        public EditAccountForm()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '•';
            newPasswordBox.PasswordChar = '•';
            apprPasswordBox.PasswordChar = '•';
        }
        private void checkAndChange()
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            string newPassword = newPasswordBox.Text;
            string apprPassword = apprPasswordBox.Text;
            if (login.Equals(""))
                MessageBox.Show("Форма ввода логина не заполнена. ");
            else
            {
                if (password.Equals(""))
                    MessageBox.Show("Форма ввода пароля не заполнена.");
                else if (password.Length < 4)
                {
                    MessageBox.Show("Слишком короткий пароль. Длина пароля должна быть не менее 4-х символов");
                }
                else
                {
                    if (newPassword.Equals(""))
                    {
                        if (newPassword.Equals(apprPassword))
                        {
                            if (password.Equals(_currentUser.Password))
                            {
                                if (_currentUser.IsAdmin)
                                {
                                    changeAdmin(login, newPassword);
                                }
                                else
                                    commitChange(login, newPassword);
                            }
                            else
                                MessageBox.Show("Введен неверный пароль");
                        }
                        else
                            MessageBox.Show("Пароли не совпадают");
                    }
                    else
                    {
                        if (newPassword.Length < 4)
                            MessageBox.Show("Слишком короткий новый пароль.\n Длина пароля должна быть не менее 4-х символов");
                        else if (apprPassword.Equals(""))
                            MessageBox.Show("Форма ввода подтверждения пароля не заполнена.");
                        else if (newPassword.Equals(apprPassword))
                        {
                            if (password.Equals(_currentUser.Password))
                            {
                                if (_currentUser.IsAdmin)
                                { changeAdmin(login, newPassword); }
                                else
                                    commitChange(login, newPassword);
                            } else
                                MessageBox.Show("Введен неверный пароль");
                        }
                        else
                            MessageBox.Show("Пароли не совпадают");
                    }

                }
            }
        }
        private void commitChange(string login, string newPassword)
        {
            int code = _currentUser.changeUsersData(login, newPassword);
            if (code == -2)
                MessageBox.Show("Введены те же данные. Изменения не произошло");
            else if (code == -1)
                MessageBox.Show("Пользователь с таким логином уже существует");
            else if (code == 0)
            {
                MessageBox.Show("Введен неверный пароль. Проверьте правильность написания");
            }
            else
            {
                main.CurrentUser.Login = login;
                if (!newPassword.Equals(""))
                    main.CurrentUser.Password = newPassword;
                MessageBox.Show("Данные успешно изменены");
                this.Close();
            }
        }
        private void changeAdmin(string newLogin, string newPassword)
        {
            if ((newPassword.Equals(""))||(newPassword.Equals(_currentUser.Password)))
            {
               
                if (_currentUser.Login.Equals(newLogin))
                    MessageBox.Show("Введены те же данные. Изменения не произошло");
                else
                { // меняем только логин
                    int code = _currentUser.existLogin(newLogin);
                    if (code == 0)
                    {
                        adminMain.CurrentUser.Login = newLogin;
                        MessageBox.Show("Данные успешно изменены");
                        this.Close();
                    }
                    else if (code == 1)
                        MessageBox.Show("Пользователь с таким логином уже существует");
                    else
                        MessageBox.Show("Ошибка при подключении к БД");
                }

            }
            else 
            {
                if (_currentUser.Login.Equals(newLogin)) // меняем только пароль
                {
                    adminMain.CurrentUser.Password = newPassword;
                    MessageBox.Show("Данные успешно изменены");
                    this.Close();
                }
                else // меняем и логин и пароль
                {
                    int code = _currentUser.existLogin(newLogin);
                    if (code == 0)
                    {
                        adminMain.CurrentUser.Login = newLogin;
                        adminMain.CurrentUser.Password = newPassword;
                        MessageBox.Show("Данные успешно изменены");
                        this.Close();
                    }
                    else if (code == 1)
                        MessageBox.Show("Пользователь с таким логином уже существует");
                    else
                        MessageBox.Show("Ошибка при подключении к БД");
                }
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            checkAndChange();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {
           
                main = this.Owner as TrainedForm;
                if (main != null)
                {
                    _currentUser = main.CurrentUser;
                    loginBox.Text = _currentUser.Login;
                }
                else
                {
                    adminMain = this.Owner as TrainerForm;
                    if (adminMain != null)
                    {
                        _currentUser = adminMain.CurrentUser;
                        loginBox.Text = _currentUser.Login;
                    }
                }
            
        }
    }
}
