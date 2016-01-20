using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;

namespace BESEDa.Authorization
{
    public partial class StatisticOfUser : Form
    {
        public User _currentUser;  //кого отображаем на панели в датагриде
        User _adminUser;
        WorkWithDB workDB;
        TrainedForm main;
        ControlAccounts mainAdmin;
        int chosenLevel=0;
        public StatisticOfUser()
        {
            InitializeComponent();
            workDB = new WorkWithDB();
            listOfTrainings.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listOfTrainings.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listOfExercises.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listOfExercises.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            chart1.Legends.Add("График ошибок и скоростей");
            chart1.Legends[0].Title = "График ошибок и скоростей";
            chart1.Series.Add("Скорость");
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelBackColor = Color.Wheat;
            chart1.Series[0].IsXValueIndexed = true;

            chart1.Series.Add("Ошибки");
            chart1.Series[1].ChartType = SeriesChartType.Spline;
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[1].LabelBackColor = Color.Wheat;
            chart1.Series[1].IsXValueIndexed = true;

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            //chart1.ChartAreas[0].AxisX.Interval = 12;
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM HH:mm";
            chart1.Series[0].Points.AddXY(DateTime.Now.ToOADate(), 0);
        }

        public void fillDataGreed()
        {
            int code = workDB.openConnection();
 
            if (code == 1)
            {
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("SELECT t.id_training,t.dataTimeOfTraining,t.numberOfLevel FROM User AS u JOIN Training AS t " +
                    "ON u.login=t.login " +
                    "WHERE u.login='{0}';",_currentUser.Login), scon);

                DataTable dt = doRequest(scon, command);
                if (dt == null)
                {
                    MessageBox.Show("БД пуста или запрос не вернул данных");
                }
                else
                {
                    listOfTrainings.DataSource = dt;
                    listOfTrainings.Columns[0].HeaderText = "ID";
                    listOfTrainings.Columns[0].Width = 20;
                    listOfTrainings.Columns[0].Visible = false;
                   
                    listOfTrainings.Columns[1].HeaderText = "Дата&Время";
                    listOfTrainings.Columns[2].HeaderText = "Уровень";
                    listOfTrainings.Columns[2].Width = 60;

                    int id = Convert.ToInt32(listOfTrainings.Rows[0].Cells[0].Value.ToString());
                    fillExercises(id);
                }
            }
            else
            {
                MessageBox.Show("Ошибка при соединении с БД");
            }  
        }

        private void fillExercises(int id)
        {
            SQLiteConnection scon = workDB.SqLiteConnection;
            SQLiteCommand command = new SQLiteCommand(
                  string.Format("SELECT ex.number,ex.usedSymbols,ex.AmountOfMistakes,st.amountOfMistakes, st.speed " +
                  "FROM Training AS t JOIN Level AS l ON t.numberOfLevel=l.number " +
                  "JOIN Exercise AS ex ON l.number=ex.numberOfLevel " +
                  "JOIN StatisticsOfExercises AS st ON st.number=ex.number " +
                  "WHERE t.login='{0}' AND t.id_training={1} AND st.id_training={1} ORDER BY ex.number;", _currentUser.Login,id), scon);

            DataTable dt = doRequest(scon, command);
            if (dt == null)
            {
                MessageBox.Show("БД пуста или запрос не вернул данных");
            }
            else
            {
                listOfExercises.DataSource = dt;
                listOfExercises.Columns[0].HeaderText = "№";
                listOfExercises.Columns[0].Width = 20;
                listOfExercises.Columns[1].HeaderText = "Исп.символы";
                listOfExercises.Columns[2].HeaderText = "Количество доп.ошибок";
                listOfExercises.Columns[3].HeaderText = "Количество допущ.ошибок";
                listOfExercises.Columns[4].HeaderText = "Скорость, симв./мин";
            }
        }

        private DataTable doRequest(SQLiteConnection scon, SQLiteCommand command)
        {
            DataTable dt = null;
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        private void StatisticOfUser_Load(object sender, EventArgs e)
        {
             main = this.Owner as TrainedForm;
            if (main != null)
            {
                _currentUser = main.CurrentUser;
                выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
                
            }
            else
            {
                mainAdmin = this.Owner as ControlAccounts;
                _adminUser = mainAdmin.CurrentUser;
                _currentUser = mainAdmin.ChosenUser;
                выToolStripMenuItem.Text = "Вы: " + _adminUser.Login;

            }
            this.Text += " " + _currentUser.Login;
            fillDataGreed();
            if (listOfTrainings.SelectedRows.Count != 0)
            {
                chosenLevel = Convert.ToInt32(listOfTrainings.Rows[0].Cells[2].Value.ToString());
                paintPlot(0);
            }

            
        }

        private void listOfTrainings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            if (rowInd >= 0)
            {
                int id = Convert.ToInt32(listOfTrainings.Rows[rowInd].Cells[0].Value.ToString());
                chosenLevel = Convert.ToInt32(listOfTrainings.Rows[rowInd].Cells[2].Value.ToString());
                fillExercises(id);
                paintPlot(0);
            }
        }

        private void StatisticOfUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            workDB.closeConnection();
        }
        private void paintPlot(int rowInd)
        {
            if (rowInd >= 0)
            {
                int number = Convert.ToInt32(listOfExercises.Rows[rowInd].Cells[0].Value.ToString());
                SQLiteConnection scon = workDB.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                      string.Format("SELECT st.speed, st.amountOfMistakes, st.dataTimeTr " +
                      "FROM Training AS t JOIN StatisticsOfExercises AS st ON st.id_training=t.id_training " +
                      "WHERE t.login='{0}' AND t.numberOfLevel={1} AND st.number={2};", _currentUser.Login, chosenLevel, number), scon);

                DataTable dt = doRequest(scon, command);
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                if (dt == null)
                {

                }
                else
                {
                    int amount = dt.Rows.Count;
                    int[] masSpeed = new int[amount];
                    int[] masMist = new int[amount];
                    DateTime[] masDate = new DateTime[amount];

                    //Сохраняем полученные значения ошибок и даты
                    for (int i = 0; i < amount; i++)
                    {
                        masSpeed[i] = (int)(Convert.ToDouble(dt.Rows[i][0].ToString()));
                        masMist[i] = (int)(Convert.ToDouble(dt.Rows[i][1].ToString()));
                        masDate[i] = DateTime.Parse(dt.Rows[i][2].ToString());
                        chart1.Series[1].Points.AddXY(masDate[i], masMist[i]);
                        chart1.Series[0].Points.AddXY(masDate[i], masSpeed[i]);
                    }
                }
            }
        }
        private void listOfExercises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            if (rowInd >= 0)
            {
                paintPlot(rowInd);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
