using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace BESEDa.Authorization
{
    [Serializable()]
    public class User
    {
       
        private string _login;
        private string _password;
        [NonSerialized]
        private DateTime _dateOfLastTraining;
        [NonSerialized]
        private int _numberOfLastLevel;
        private bool _isAdmin;
        [NonSerialized]
        private WorkWithDB _db;
        public User(string login, string password, bool isAdmin)
        {
            _login = login;
            _password = password;
            _isAdmin = isAdmin;
            _db = new WorkWithDB();
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password // не уверен на счет доступа к паролю. Для смены пароля наверняка надо проверять старый
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool IsAdmin
        {
            get { return _isAdmin;}
        }
        public DateTime DateofLastTraining 
        { get {return _dateOfLastTraining;}
            set { _dateOfLastTraining = value; }
        }
        public int NumberOfLastLevel {
            get { return _numberOfLastLevel; } 
            set{_numberOfLastLevel=value;}
        }
        /// <summary>
        /// Добавляет нового пользователя в БД по логину и паролю
        /// </summary>
        /// <returns>Код ошибки, либо кол-во добавленных строк в БД</returns>
        public int insertUser()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT into 'User'"
                        + "(login, password) VALUES ('" + _login + "','" +
                        _password + "');", scon);
                    int num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else
            { return code; }

        }
        /// <summary>
        /// Добавляет информацию о последней тренировке пройденной пользователем.
        /// </summary>
        /// <returns>Код ошибки, либо кол-во обновленных строк в БД</returns>
        public int updateUsersTraining()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                   
                    SQLiteCommand command = new SQLiteCommand(string.Format("UPDATE 'User' SET "+
                        "lastDataTraining='{0}', lastLevelNumber={1} WHERE login='{2}'",
                        DateofLastTraining.ToString("yyyy-MM-dd HH:mm:ss"), NumberOfLastLevel, _login), scon);
                    int num = command.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else
            { return code; }
        }
        /// <summary>
        /// Извлекает из БД данные о пользователе вошедшем в систему
        /// </summary>
        /// <returns>Код ошибки, либо число извлеченных строк </returns>
        public int selectSignIn()
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    DataTable dt = null;
                    SQLiteCommand command = new SQLiteCommand(string.Format("SELECT lastDataTraining,"+
                        " lastLevelNumber from 'User' where login = '{0}' AND password = '{1}';",
                        _login, _password), scon);
                    SQLiteDataReader data = command.ExecuteReader();
                    if (data.HasRows)
                    {
                        if (!data.IsDBNull(0))
                        {
                            data.Read();
                            _dateOfLastTraining = data.GetDateTime(0);
                            _numberOfLastLevel = data.GetInt32(1);
                        }
                    }
                    int num = data.StepCount;
                    data.Close();
                    return num;

                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else { return code; }
        }
        /// <summary>
        /// Редактирование учетной записи в БД
        /// </summary>
        /// <param name="newLogin">Новый логин</param>
        /// <param name="newPassword">Новый пароль</param>
        /// <returns>Код ошибки или кол-во обновленных строк в БД</returns>
        public int changeUsersData(string newLogin, string newPassword)
        {
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    SQLiteCommand command;
                    SQLiteCommand com = null;
                    if (newLogin.Equals(_login))
                    {
                        if (newPassword.Equals(_password) || (newPassword.Equals("")))
                            return -2; // Код когда замена не производится
                        else // меняем только пароль
                        {

                            command = new SQLiteCommand(string.Format("UPDATE 'User' SET" +
                                " password='{0}'  where login='{1}' AND password='{2}';",
                                newPassword, _login, _password), scon);

                        }
                    }
                    else
                    {
                        if ((newPassword.Equals(_password)) || (newPassword.Equals(""))) // меняем только логин
                        {
                            command = new SQLiteCommand(string.Format("UPDATE 'User' SET" +
                       " login='{0}' where login='{1}' AND password='{2}';",
                       newLogin, _login, _password), scon);
                            com = new SQLiteCommand(string.Format("UPDATE 'Training' SET" +
                                " login='{0}' where login='{1}';",
                                newLogin, _login), scon);
                        }
                        else // меняем и логин и пароль
                        {
                            command = new SQLiteCommand(string.Format("UPDATE 'User' SET login='{0}'," +
                        " password ='{1}' where login = '{2}' AND password = '{3}';",
                        newLogin, newPassword, _login, _password), scon);
                            com = new SQLiteCommand(string.Format("UPDATE 'Training' SET" +
                                    " login='{0}' where login='{1}';",
                                    newLogin, _login, _password), scon);
                        }
                    }

                    int num = command.ExecuteNonQuery();
                    if (com != null)
                        com.ExecuteNonQuery();
                    _db.closeConnection();
                    return num;
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        scon.Close();
                }
            }
            else { return code; }


        }
        public int existLogin(string checkLogin)
        {
            if (_db == null)
                _db = new WorkWithDB();
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    DataTable dt = null;
                    SQLiteCommand command = new SQLiteCommand(string.Format("SELECT login" +
                        " from 'User' where login = '{0}';",
                        checkLogin), scon);
                    SQLiteDataReader data = command.ExecuteReader();

                    int num = data.StepCount;
                    data.Close();
                    return num;

                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else { return code; }
        }

        public int getLastNumberOfEx()
        {
            if (_db == null)
                _db = new WorkWithDB();
            int code = _db.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = _db.SqLiteConnection;
                try
                {
                    DataTable dt = null;
                    SQLiteCommand command = new SQLiteCommand(string.Format("SELECT MAX(st.number)" +
                        " from User as u JOIN Training as tr ON tr.login=u.login JOIN StatisticsOfExercises as st ON" +
                        " st.id_training=tr.id_training where u.login = '{0}' AND tr.id_training=(SELECT MAX(id_training) FROM Training WHERE login = '{0}');",
                        _login), scon);
                    SQLiteDataReader data = command.ExecuteReader();
                    int num=0;
                    if (data.HasRows)
                    {
                        if (!data.IsDBNull(0))
                        {
                            data.Read();
                            num = data.GetInt32(0);
                        }
                    }
                    data.Close();
                    return num;

                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (scon != null)
                        _db.closeConnection();
                }
            }
            else { return code; }
        }
        

    }
}
