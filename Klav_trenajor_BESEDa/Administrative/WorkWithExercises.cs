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
    public partial class WorkWithExercises : Form
    {
        SQLiteConnection scon;
        WorkWithDB workDB;
        Exercise chosenExercise;
        TrainerForm main;
        Settings currentSettings;
        public WorkWithExercises()
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
        public Exercise ChosenExercise
        {
            get { return chosenExercise; }
            set { chosenExercise = value; }
        }
        public Settings CurrentSettings
        {
            get { return currentSettings; }
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
                dt.Columns.Add("Зоны", typeof(string)).SetOrdinal(1);
               
                int rows = dt.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dt.Rows[i][1] =  Exercise.zonesFromExercise(Convert.ToInt32(dt.Rows[i][2].ToString()));
                dt.Columns.RemoveAt(2);
                listOfExercises.DataSource = dt;
                listOfExercises.Columns[0].HeaderText = "№ уровня";
                listOfExercises.Columns[1].HeaderText = "Зоны";
                listOfExercises.Columns[2].HeaderText = "Используемые символы";
                listOfExercises.Columns[3].HeaderText = "Текст упражнения";

            }
            
            
        }


        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsOnExercises statExer = new StatisticsOnExercises();
            statExer.Show();
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
                   string.Format("SELECT numberOfLevel,number, usedSymbols, text FROM Exercise ORDER BY numberOfLevel ASC,  number ASC;"), scon);
            fillGridView(command);
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
        private void createCommandWithArea(int number)
        {
            SQLiteCommand command = new SQLiteCommand(
                 string.Format("SELECT numberOfLevel, number, usedSymbols, text FROM Exercise " +
                 "WHERE number={0} ORDER BY numberOfLevel ASC,  number ASC;", number), scon);
            fillGridView(command);
        }

        private void createCommandWithLevel(string level)
        {
            SQLiteCommand command = new SQLiteCommand(
                 string.Format("SELECT numberOfLevel, number, usedSymbols, text FROM Exercise " +
                 "WHERE numberOfLevel={0} ORDER BY numberOfLevel ASC,  number ASC;", level), scon);
            fillGridView(command);
        }

        private void WorkWithExercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                workDB.closeConnection();
            }
            catch { }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExercise addExercise = new AddExercise();
            addExercise.Owner = this;
            addExercise.ShowDialog();
            renewList();
        }
        
        
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // определить по зонам номер упражнения
            if (listOfExercises.SelectedRows.Count != 0)
            {
                int currentRow = listOfExercises.CurrentRow.Index;
                int numberOfLevel = Convert.ToInt32(listOfExercises[0, currentRow].Value);
                string zones = Convert.ToString(listOfExercises[1, currentRow].Value);
                string text = Convert.ToString(listOfExercises[3, currentRow].Value);
                string usingS = Convert.ToString(listOfExercises[2, currentRow].Value);
                chosenExercise = new Exercise(zones, numberOfLevel, text, usingS);
                EditExercise editEx = new EditExercise();
                editEx.Owner = this;
                editEx.ShowDialog();
                renewList();
            }
            else
                MessageBox.Show("Не выбрано упражнение для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void WorkWithExercises_Load(object sender, EventArgs e)
        {
            main = this.Owner as TrainerForm;
            if (main != null)
                currentSettings = main.CurrentSettings;
        }

        private void zone1CB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void checkedZone()
        {
            string zones = defZones();
            int numberOfLevel = Exercise.accordZoneWithExercise(zones);
            createCommandWithArea(numberOfLevel);
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

        private void byKeyboardZoneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentRow = listOfExercises.CurrentRow.Index;
            int numberOfLevel = Convert.ToInt32(listOfExercises[0, currentRow].Value);
            string zones = Convert.ToString(listOfExercises[1, currentRow].Value);
            int numberOfExercise = Exercise.accordZoneWithExercise(zones);
            deleteExercise(numberOfExercise, numberOfLevel);
            listOfExercises.Rows.RemoveAt(currentRow);
            
        }
        /// <summary>
        /// Удаляет упражнение из системы и связанные с ней тренировки.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberOfLevel"></param>
        private void deleteExercise(int number, int numberOfLevel)
        {
            WorkWithDB wdb = new WorkWithDB();
            wdb.openConnection();
            try
            {
                SQLiteConnection scon = wdb.SqLiteConnection;
                SQLiteCommand command = new SQLiteCommand(
                    string.Format("DELETE FROM Exercise WHERE number={0} AND numberOfLevel={1};", number, numberOfLevel), scon);
                int num = command.ExecuteNonQuery();

                command = new SQLiteCommand(string.Format
                    ("SELECT id_training FROM Training WHERE numberOfLevel={0};", numberOfLevel), scon);
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
                command = new SQLiteCommand(string.Format("DELETE FROM StatisticsOfExercises WHERE id_training IN ({0}) AND number={1};", ids, number), scon);
                command.ExecuteNonQuery();
            }
            catch { }
            finally {
                wdb.closeConnection(); 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void renewList()
        {
            if (allExercisesRBut.Checked)
            {
                fillDefault();
            }
            else if (byLevelRB.Checked)
            {
                string level = numericUpDown1.Value.ToString();
                createCommandWithLevel(level);
            }
            else if (byKeyboardZoneRB.Checked)
            {
                checkedZone();
            }
        }
    }
}
