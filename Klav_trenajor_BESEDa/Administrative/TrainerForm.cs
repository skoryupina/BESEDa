using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Authorization;
using System.Data.SQLite;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace BESEDa.Administrative
{
    public partial class TrainerForm : Form
    {
        User _currentUser;
        KeyboardTrainIndex main;
        Settings _currentSettings;
        private const string settingPath = "settings";
        private const string helpfile = "spravka.chm";
        private const string Topic = "administrator.htm";
        public TrainerForm()
        {
            InitializeComponent();
        }
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
        public Settings CurrentSettings
        {
            get { return _currentSettings; }
            set { _currentSettings = value;
            serialiseSettings();
            }
        }
        private void deserealiseSettings()
        {
            FileInfo fi = null;
            try
            {
                fi = new FileInfo(settingPath);
                if (fi.Length != 0)
                {
                    FileStream stream = null;
                    _currentSettings = null;
                    try
                    {
                        stream = new FileStream(settingPath, FileMode.Open);
                        BinaryFormatter bf = new BinaryFormatter();
                        _currentSettings = (Settings)bf.Deserialize(stream);
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
                else
                {
                    _currentSettings = new Settings();
                }
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Отсутствует файл с настройками.");
            }
        }
        private void serialiseSettings()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(settingPath, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _currentSettings);
            }
            catch (SerializationException se)
            {

            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
        private void controlAccountsBut_Click(object sender, EventArgs e)
        {
            ControlAccounts controlAcc = new ControlAccounts();
            controlAcc.Owner = this;
            controlAcc.ShowDialog();
        }

        private void fillTextBoxes()
        {
            WorkWithDB workDB = new WorkWithDB();
            int code = workDB.openConnection();
            if (code == 1)
            {
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("SELECT COUNT(login) FROM User;"), scon);
                amoutOfUsersBox.Text = doRequest(command);

                command = new SQLiteCommand(
                    string.Format("SELECT COUNT(id_training) FROM Training;"), scon);

                amountOfTrainBox.Text = doRequest(command);

                command = new SQLiteCommand(
                    string.Format("SELECT COUNT(number) FROM Exercise;"), scon);

                amountOfExBox.Text = doRequest(command);
                workDB.closeConnection();
            }

            else 
            {
                MessageBox.Show("Не возможно подключиться к БД");
            }
        }
        private string doRequest(SQLiteCommand command)
        {
            string result;
            DataTable dt = null;
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            if (dt == null)
            {
                // MessageBox.Show("БД пуста или запрос не вернул данных");
                result = "0";
            }
            else
            {
                result = dt.Rows[0].ItemArray[0].ToString();
            }
            return result;
        }
        private void TrainerForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as KeyboardTrainIndex;
            _currentUser = main.Admin;
            выToolStripMenuItem.Text = "Вы: " +_currentUser.Login;
            fillTextBoxes();
            deserealiseSettings();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccountForm edit = new EditAccountForm();
            edit.Owner = this;
            edit.ShowDialog();
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
            main.Admin = _currentUser;
        }

        private void workWithExBut_Click(object sender, EventArgs e)
        {
            if (_currentSettings.Count == 0)
                MessageBox.Show("Тренажер не настроен. Сначала настройте тренажер", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                WorkWithExercises workWithEx = new WorkWithExercises();
                workWithEx.Owner = this;
                workWithEx.Show();
            }
        }

        private void SettingsBut_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Owner = this;
            sf.ShowDialog();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic);
        }






    }
}
