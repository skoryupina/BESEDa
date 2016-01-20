using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BESEDa.Administrative
{
    public partial class StatisticsOn1Exercise : Form
    {
        public StatisticsOn1Exercise(string level, string exer, string symbList, string zones)
        {
            InitializeComponent();
            levelBox.Text = level;
            exerBox.Text = exer;
            symbListBox.Text = symbList;
            amountOfExBox.Text = zones;
            fillDataGreed();
            fillPieChartSpeed();
            fillPieChartMistakes();
        }

        public void forSpeedChart(int[] mas)
        {
            int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 101)
                    group1++;
                else
                {
                    if (mas[i] < 181)
                        group2++;
                    else
                    {
                        if (mas[i] < 301)
                            group3++;
                        else
                            group4++;
                    }
                }
            }

            //заполняем чарт
            Dictionary<string, int> tags = new Dictionary<string, int>() { 
            { "1-100 сим/мин", group1 },
            { "101-180 сим/мин", group2 },
            { "181-300 сим/мин", group3 },
            { "300-500 сим/мин", group4 },
            };

            distrSpeedOfUsers.Series[0].Points.Clear();
            distrSpeedOfUsers.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (string tagname in tags.Keys)
            {
                distrSpeedOfUsers.Series[0].Points.AddXY(tagname, tags[tagname]);
                distrSpeedOfUsers.Series[0].IsValueShownAsLabel = true;
                distrSpeedOfUsers.Series[0].LabelBackColor = Color.White;
            }
        }

        public void forMistakesChart(int[] mas)
        {
            int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 5)
                    group1++;
                else
                {
                    if (mas[i] < 9)
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
            { "0-4 ошиб.", group1 },
            { "5-8 ошиб.", group2 },
            { "9-30 ошиб.", group3 },
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


        public void fillPieChartSpeed()
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
                    string.Format("SELECT u.login, AVG(st.speed) FROM " +
                    "User u JOIN Training tr ON u.login=tr.login " +
                    "JOIN StatisticsOfExercises AS st ON  tr.id_training=st.id_training " +
                    "WHERE st.number={0} AND tr.numberOfLevel={1} " +
                    "GROUP BY u.login;", exerBox.Text, levelBox.Text), scon);

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
                        mas[i] = (int)(Convert.ToDouble(dt.Rows[i][1].ToString()));
                    }

                    //сортируем массив
                    Array.Sort(mas);
                    forSpeedChart(mas);
                }
                workDB.closeConnection();
            }
        }

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
                    "WHERE st.number={0} AND tr.numberOfLevel={1} " +
                    "GROUP BY u.login;", exerBox.Text, levelBox.Text), scon);

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
                    string.Format("SELECT tr.login, tr.dataTimeOfTraining, st.speed, st.amountOfMistakes " +
                    "FROM Training tr JOIN StatisticsOfExercises st ON tr.id_training=st.id_training " +
                    "WHERE tr.numberOfLevel = {0} AND st.number= {1} ;", levelBox.Text, exerBox.Text), scon);

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
                    listOfExercisesStat.DataSource = dt;
                    listOfExercisesStat.Columns[0].HeaderText = "Логин";
                    listOfExercisesStat.Columns[1].HeaderText = "Дата/время тренировки";
                    listOfExercisesStat.Columns[2].HeaderText = "v, симв./мин";
                    listOfExercisesStat.Columns[3].HeaderText = "Количество\n\r ошибок";
                }
            }
            else
            {
                MessageBox.Show("Ошибка при соединении с БД");
            }
            workDB.closeConnection();
        }



    }
}
