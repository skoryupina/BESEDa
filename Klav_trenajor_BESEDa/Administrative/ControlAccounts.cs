using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Authorization;
using BESEDa.Training;
using System.Data.SQLite;
using BESEDa.Administrative;
namespace BESEDa
{
    public partial class ControlAccounts : Form
    {
        User _currentUser;  //кого отображаем на панели
        User _chosenUser;
        TrainerForm main;
        public ControlAccounts()
        {
            InitializeComponent();
            //_currentUser = user;
            fillDataGreed();
            listOfUsers.MultiSelect = false;
            fillPieChartExercises();
            fillPieChartMistakes();
        }
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
        public User ChosenUser
        {
            get { return _chosenUser; }
            set { _chosenUser = value; }
        }


        public void forExercisesChart(int[] mas)
        {
            //разбиваем число ячеек по группам
            // 1-15 упр 
            // 16-30 упр
            // 30-60 упр
            // 60-150 упр
            int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 3)
                    group1++;
                else
                {
                    if (mas[i] < 5)
                        group2++;
                    else
                    {
                        if (mas[i] < 10)
                            group3++;
                        else
                            group4++;
                    }
                }
            }

            //заполняем чарт
            Dictionary<string, int> tags = new Dictionary<string, int>() { 
            { "1-2 упр.", group1 },
            { "3-5 упр.", group2 },
            { "5-10 упр.", group3 },
            { "10-150 упр.", group4 },
            };

            distrExercisesOfUsers.Series[0].Points.Clear();
            distrExercisesOfUsers.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (string tagname in tags.Keys)
            {
                distrExercisesOfUsers.Series[0].Points.AddXY(tagname, tags[tagname]);
                distrExercisesOfUsers.Series[0].IsValueShownAsLabel = true;
                distrExercisesOfUsers.Series[0].LabelBackColor = Color.White;
            }
        }

        public void forMistakesChart(int[] mas)
        {
            int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 10)
                    group1++;
                else
                {
                    if (mas[i] < 20)
                        group2++;
                    else
                    {
                        if (mas[i] < 30)
                            group3++;
                        else
                            group4++;
                    }
                }
            }

            //заполняем чарт
            Dictionary<string, int> tags = new Dictionary<string, int>() { 
            { "1-10 ошиб.", group1 },
            { "11-20 ошиб.", group2 },
            { "21-30 ошиб.", group3 },
            { "31-150 ошиб.", group4 },
            };

            distrMistakesOfUsers.Series[0].Points.Clear();
            distrMistakesOfUsers.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (string tagname in tags.Keys)
            {
                distrMistakesOfUsers.Series[0].Points.AddXY(tagname, tags[tagname]);
                distrMistakesOfUsers.Series[0].IsValueShownAsLabel = true;
                distrMistakesOfUsers.Series[0].LabelBackColor = Color.White;
            }
        }


        /// <summary>
        /// Строит круговую диаграмму,
        /// распределяя сколько пользователей прошли
        /// сколько упражнений
        /// 1-15 упр 
        /// 16-30 упр
        /// 30-60 упр
        /// 60-150 упр
        /// </summary>
        public void fillPieChartExercises()
        {
            //запрос должен суммировать число упражнений пройденных каждым пользователем и
            //группировать по пользователю
            //потом беру полученные чиселки и получаю из них свои стат данные
            //смотрю сколько упражнений прошел каждый пользователь
            //а суммирую пользователей,
            //на диаграмме будут пользователи
            WorkWithDB workDB = new WorkWithDB();
            int code = workDB.openConnection();

            if (code == 1)
            {
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("SELECT u.login, COUNT(st.number) FROM " +
                    "User u JOIN Training tr ON u.login=tr.login " +
                    "JOIN StatisticsOfExercises AS st ON  tr.id_training=st.id_training " +
                    "GROUP BY u.login;"), scon);

                DataTable dt = null;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                if (dt == null)
                {
                    MessageBox.Show("БД пуста или запрос не вернул данных");
                }
                else
                {
                    int amount = dt.Rows.Count;
                    int[] mas = new int[amount];

                    //Получаем распределение числа пройденных упражнений по пользователям
                    //каждая ячейка относится к одному пользователю
                    for (int i = 0; i < amount; i++)
                    {
                        mas[i] = Convert.ToInt32(dt.Rows[i][1].ToString());
                    }

                    //сортируем массив
                    Array.Sort(mas);
                    forExercisesChart(mas);
                }
                workDB.closeConnection();
            }
        }


        /// <summary>
        /// Строит круговую диаграмму,
        /// распределяя ошибки среди пользователей
        /// сколько ошибок
        /// 1-5 ошиб. 
        /// 5-10 ошиб.
        /// 11-60 ошиб.
        /// 61-100 ошиб.
        /// </summary>
        public void fillPieChartMistakes()
        {
            WorkWithDB workDB = new WorkWithDB();
            int code = workDB.openConnection();

            if (code == 1)
            {
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("SELECT u.login, SUM(st.amountOfMistakes) FROM " +
                    "User u JOIN Training tr ON u.login=tr.login " +
                    "JOIN StatisticsOfExercises AS st ON  tr.id_training=st.id_training " +
                    "GROUP BY u.login;"), scon);

                DataTable dt = null;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                if (dt == null)
                {
                    MessageBox.Show("БД пуста или запрос не вернул данных");
                }
                else
                {
                    int amount = dt.Rows.Count;
                    int[] mas = new int[amount];

                    //Получаем распределение числа пройденных упражнений по пользователям
                    //каждая ячейка относится к одному пользователю
                    for (int i = 0; i < amount; i++)
                    {
                        mas[i] = Convert.ToInt32(dt.Rows[i][1].ToString());
                    }

                    //сортируем массив
                    Array.Sort(mas);
                    forMistakesChart(mas);
                }
                workDB.closeConnection();
            }
        }



        public void fillDataGreed()
        {
            WorkWithDB workDB = new WorkWithDB();
            int code = workDB.openConnection();

            if (code == 1)
            {
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("SELECT u.login,u.lastDataTraining,u.lastLevelNumber,ROUND(AVG(st.speed),2),ROUND(AVG(st.amountOfMistakes),2) FROM User AS u JOIN Training AS t " +
                    "ON u.login=t.login " +
                    "JOIN StatisticsOfExercises AS st ON  t.id_training=st.id_training " +
                    "GROUP BY u.login ORDER BY u.lastLevelNumber DESC;"), scon);

                DataTable dt = null;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                if (dt == null)
                {
                    MessageBox.Show("БД пуста или запрос не вернул данных");
                }
                else
                {
                    listOfUsers.DataSource = dt;
                    listOfUsers.Columns[0].HeaderText = "Логин";
                    listOfUsers.Columns[1].HeaderText = "Дата последней тренировки";
                    listOfUsers.Columns[2].HeaderText = "Номер уровня";
                    listOfUsers.Columns[3].HeaderText = "Ср. v, симв./мин";
                    listOfUsers.Columns[4].HeaderText = "Ср. кол-во ошибок";
                }
            }
            else
            {
                MessageBox.Show("Ошибка при соединении с БД");
            }
            workDB.closeConnection();
        }

        private void открытьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfUsers.SelectedRows.Count != 0)
            {
                _chosenUser = new User(listOfUsers[0, listOfUsers.CurrentRow.Index].Value.ToString(), "", false);
                openStat();
            }
            else
                MessageBox.Show("Не выбран пользователь для открытия статистики", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void openStat()
        {
            StatisticOfUser statOfUser = new StatisticOfUser();
            statOfUser.Owner = this;
            statOfUser.ShowDialog();

            _currentUser = main.CurrentUser;
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
        }
        private void ControlAccounts_Load(object sender, EventArgs e)
        {
            main = this.Owner as TrainerForm;
            _currentUser = main.CurrentUser;
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfUsers.SelectedRows.Count != 0)
            {
                WorkWithDB workDB = new WorkWithDB();
                int code = workDB.openConnection();
                int index = listOfUsers.CurrentRow.Index;
                string login = listOfUsers[0, index].Value.ToString();
                if (code == 1)
                {
                    try
                    {
                        SQLiteConnection scon = workDB.SqLiteConnection;
                        SQLiteCommand command = new SQLiteCommand(string.Format
                            ("DELETE FROM User WHERE login='{0}';", login), scon);

                        /*SQLiteCommand command = new SQLiteCommand(
                            string.Format("DELETE u.*, t.*, st.* FROM User as u LEFT JOIN Training as t ON u.login=t.login " +
                            "LEFT JOIN StatisticsOfExercises as st on t.id_training=st.id_training " +
                            "WHERE u.login='{0}';", ), scon);
                        */
                        command.ExecuteNonQuery();

                        command = new SQLiteCommand(string.Format
                            ("SELECT id_training FROM 'Training' WHERE login='{0}';", login), scon);
                        string ids = "";
                        DataTable dt = null;
                        SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dt = ds.Tables[0];
                        if (dt == null)
                        {
                            MessageBox.Show("БД пуста или запрос не вернул данных");
                        }
                        else
                        {
                            int rows = dt.Rows.Count;
                            for (int i = 0; i < rows; i++)
                                ids += dt.Rows[i][0].ToString() + ",";
                        }
                        ids = ids.Substring(0, ids.Length - 1);
                        command = new SQLiteCommand(string.Format
                            ("DELETE FROM Training WHERE login='{0}';", login), scon);
                        command.ExecuteNonQuery();
                        command = new SQLiteCommand(string.Format("DELETE FROM 'StatisticsOfExercises' WHERE id_training IN ({0});", ids), scon);
                        command.ExecuteNonQuery();

                    }
                    catch
                    { }
                    finally
                    {
                        workDB.closeConnection();
                    }
                    listOfUsers.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Не выбран пользователь для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listOfUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            if (rowInd >= 0)
            {
                _chosenUser = new User(listOfUsers.Rows[rowInd].Cells[0].Value.ToString(), "", false);
                openStat();
            }
        }


    }
}
