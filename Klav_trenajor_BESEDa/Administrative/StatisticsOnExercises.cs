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
    public partial class StatisticsOnExercises : Form
    {
        SQLiteConnection scon;
        WorkWithDB workDB;
        public StatisticsOnExercises()
        {
            InitializeComponent();
            workDB = new WorkWithDB();
            int code = workDB.openConnection();
            if (code == 1)
            {
                scon = workDB.SqLiteConnection;
            }
            else
            {
                MessageBox.Show("Не возможно подключиться к БД");
            }
            fillDefault();
        }

        private void fillGridView(SQLiteCommand command)
        {
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
                listOfExercises.DataSource = dt;
                listOfExercises.Columns[0].HeaderText = "Уровень ";
                listOfExercises.Columns[1].HeaderText = "№ упражнения";
                listOfExercises.Columns[2].HeaderText = "Используемые символы";
                listOfExercises.Columns[3].HeaderText = "Пройдено";
                listOfExercises.Columns[4].HeaderText = "V сред. симв./мин";
                listOfExercises.Columns[5].HeaderText = "Сред.кол-во ошибок";
            }
                
        }
      
        private string defZones()
        {
            if (zone1CB.Checked)
            {
                if (zone2CB.Checked)
                {
                    if (zone3CB.Checked)
                    {
                        if (zone4CB.Checked) // Выбраны все
                            return "1,2,3,4";
                        else                // выбраны первые три
                            return "1,2,3";
                    }
                    else
                    {
                        if (zone4CB.Checked)
                            return "1,2,4";
                        else
                            return "1,2";
                    }
                }
                else
                {
                    if (zone3CB.Checked)
                    {
                        if (zone4CB.Checked)
                            return "1,3,4";
                        else
                            return "1,3";
                    }
                    else
                    {
                        if (zone4CB.Checked)
                            return "1,4";
                        else
                            return "1";
                    }

                }
            }
            else
            {
                if (zone2CB.Checked)
                {
                    if (zone3CB.Checked)
                    {
                        if (zone4CB.Checked)
                            return "2,3,4";
                        else
                            return "2,3";
                    }
                    else
                    {
                        if (zone4CB.Checked)
                            return "2,4";
                        else
                            return "2";
                    }
                }
                else
                {
                    if (zone3CB.Checked)
                    {
                        if (zone4CB.Checked)
                            return "3,4";
                        else
                            return "3";
                    }
                    else
                    {
                        if (zone4CB.Checked)
                            return "4";
                        else
                            return "";
                    }
                }
            }
        }
        private void listOfExercises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            if (rowInd >= 0)
            {
                string level = listOfExercises.Rows[rowInd].Cells[0].Value.ToString();
                string exer = listOfExercises.Rows[rowInd].Cells[1].Value.ToString();
                string symbList = listOfExercises.Rows[rowInd].Cells[2].Value.ToString();
                string zones = Exercise.zonesFromExercise(Convert.ToInt32(exer));

                StatisticsOn1Exercise st1ex = new StatisticsOn1Exercise(level, exer, symbList, zones);
                st1ex.ShowDialog();
            }
        }

        private void allExercisesRBut_CheckedChanged(object sender, EventArgs e)
        {
            if (allExercisesRBut.Checked)
            {
                fillDefault();
            }
        }

        private void fillDefault()
        {
            SQLiteCommand command = new SQLiteCommand(
                   string.Format("SELECT ex.numberOfLevel, ex.number, ex.usedSymbols," +
                   "COUNT(st.number),ROUND(AVG(st.speed),2)," +
                   "ROUND(AVG(st.amountOfMistakes),2) " +
                   "FROM Training tr JOIN " +
                   "StatisticsOfExercises AS st ON st.id_training=tr.id_training JOIN " +
                   "Exercise AS ex ON ex.number=st.number " +
                   "WHERE ex.numberOfLevel=tr.numberOfLevel " +
                   "GROUP BY ex.numberOfLevel,st.number  " +
                   ";"), scon);
            fillGridView(command);
        }

        private void checkedZone()
        {
            string zones = defZones();
            int numberOfExercise = Exercise.accordZoneWithExercise(zones);
            createCommandWithArea(numberOfExercise);
        }
        private void byLevelRB_CheckedChanged(object sender, EventArgs e)
        {
            if (byLevelRB.Checked)
            {
                string level = numericUpDown1.Value.ToString();
                createCommandWithLevel(level);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (byLevelRB.Checked)
            {
                //получаем значение уровня
                string level = numericUpDown1.Value.ToString();
                createCommandWithLevel(level);

            }
        }

        private void createCommandWithLevel(string level)
        {
            SQLiteCommand command = new SQLiteCommand(
                 string.Format("SELECT ex.numberOfLevel, ex.number, ex.usedSymbols," +
                 "COUNT(st.number),ROUND(AVG(st.speed),2)," +
                 "ROUND(AVG(st.amountOfMistakes),2) " +
                 "FROM Training tr JOIN " +
                 "StatisticsOfExercises AS st ON st.id_training=tr.id_training JOIN " +
                 "Exercise AS ex ON ex.number=st.number " +
                 "WHERE ex.numberOfLevel={0} AND tr.numberOfLevel={0} " +
                 "GROUP BY st.number" +
                 ";",level), scon);
            fillGridView(command);
        }
        private void createCommandWithArea(int number)
        {
            SQLiteCommand command = new SQLiteCommand(
                 string.Format("SELECT ex.numberOfLevel, ex.number, ex.usedSymbols," +
                 "COUNT(st.number),ROUND(AVG(st.speed),2)," +
                 "ROUND(AVG(st.amountOfMistakes),2) " +
                 "FROM Training tr JOIN " +
                 "StatisticsOfExercises AS st ON st.id_training=tr.id_training JOIN " +
                 "Exercise AS ex ON ex.number=st.number " +
                 "WHERE ex.number={0} and ex.numberOfLevel=tr.numberOfLevel " +
                 "GROUP BY tr.numberOfLevel" +
                 ";", number), scon);
            fillGridView(command);
        }

        private void StatisticsOnExercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                workDB.closeConnection();
            }
            catch { }
        }

        private void byKeyboardZoneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void zone1CB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void zone2CB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void zone3CB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void zone4CB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

       

    }
}
