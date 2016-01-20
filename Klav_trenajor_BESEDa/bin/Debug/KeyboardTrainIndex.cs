using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using BESEDa.Authorization;
using BESEDa.Properties;
using BESEDa.Administrative;
namespace BESEDa
{
    public partial class KeyboardTrainIndex : Form
    {
        User _currentUser;
        private const string _adminPath = "admin";
        User _admin;
        public KeyboardTrainIndex()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '•';
            deserializeAdmin();

        }
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
        public User Admin
        {
            get { return _admin; }
            set { _admin = value;
            serializeAdmin();
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
        private void serializeAdmin()
        {
            FileStream stream = null;
            try
            {
                stream = File.Open(_adminPath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, _admin);
            }
            catch (FileNotFoundException fnfe)
            { }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

        }
        private void deserializeAdmin()
        {
            try
            {
                FileInfo fi = new FileInfo(_adminPath);
                if (fi.Length == 0)
                {
                    MessageBox.Show("Файл с информацией об учетной записи Администратора пуст");
                    //_admin = new User("Admin", "Admin", true);
                    //serializeAdmin();
                } 
                else
                {
                    FileStream stream = null;
                    _admin=null;
                    try
                    {
                        stream = File.Open(_adminPath, FileMode.Open);
                        BinaryFormatter bf = new BinaryFormatter();
                        _admin = (User)bf.Deserialize(stream);
                    }
                    catch (FileNotFoundException fnfe)
                    {
                        
                    }
                    finally 
                    {
                        if (stream != null)
                            stream.Close();
                    }
                
                }
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Отсутствует файл с информацией об учетной записи Администратора");
            }
        
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            authentication();
           
        }
        /// <summary>
        /// Процесс проверки данных
        /// </summary>
        public void authentication()
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            if (login.Equals(""))
                MessageBox.Show("Форма ввода логина не заполнена. ");
            else
            {
                if (password.Equals(""))
                    MessageBox.Show("Форма ввода пароля не заполнена.");
                else if (password.Length < 4)
                    MessageBox.Show("Слишком короткий пароль. Длина пароля должна быть не менее 4-х символов");
                else
                {
                    // Добавить проверку на админа
                    if (login.Equals(_admin.Login))
                    {
                        if (password.Equals(_admin.Password))
                        {
                            TrainerForm adminForm = new TrainerForm();
                            adminForm.Owner = this;
                            adminForm.ShowDialog();
                            loginBox.Text = _admin.Login;
                            passwordBox.Text = _admin.Password;
                        }
                        else
                            MessageBox.Show("Не правильно указан пароль. Проверьте правильность написания");

                    }
                    else
                    {
                        _currentUser = new User(login, password, false);
                        int code = _currentUser.selectSignIn();
                        if (code == -1)
                            MessageBox.Show("Ошибка подключения к БД. Возможно отсутствует файл");
                        else if (code == 0)
                            MessageBox.Show("Не существует учетной записи с таким логином, либо Введен неверный пароль. Проверьте правильность написания");
                        else
                        {
                            TrainedForm userForm = new TrainedForm();
                            userForm.Owner = this;
                            userForm.ShowDialog();
                            loginBox.Text = _currentUser.Login;
                            passwordBox.Text = _currentUser.Password;
                            //ControlAccounts testForm = new ControlAccounts(/*currentUser*/);
                            //testForm.ShowDialog();
                        }
                    }
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Owner = this;
            signUp.ShowDialog();
            if (_currentUser != null) 
            {
                loginBox.Text = _currentUser.Login;
                passwordBox.Text = _currentUser.Password;
            }
        }
    }
}
