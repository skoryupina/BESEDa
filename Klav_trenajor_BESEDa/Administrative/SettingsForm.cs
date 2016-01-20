using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using BESEDa.Vizualization;
namespace BESEDa.Administrative
{
    public partial class SettingsForm : Form
    {
        private const string row1 = "Ряд 1 (\"Ё\",\"1\",\"2\",\"3\",\"4\"...)";
        private const string row2 = "Ряд 2 (\"Й\",\"Ц\",\"У\",\"К\",\"Е\"...)";
        private const string row3 = "Ряд 3 (\"Ф\",\"Ы\",\"В\",\"А\",\"П\"...)";
        private const string row4 = "Ряд 4 (\"Я\",\"Ч\",\"С\",\"М\",\"И\"...)";

        private const string helpfile = "spravka.chm";
        private const string Topic = "nastrojka_trenazhyera.htm";

        Settings _currentSettings;
        TrainerForm main;
        public SettingsForm()
        {
            InitializeComponent();
            _currentSettings = new Settings();
            
        }
       

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as TrainerForm;
            if (main != null)
                _currentSettings = main.CurrentSettings;
            saveTenLevel();
            numberOfLevelCB.SelectedIndex = 0;
            string[] rows = new string[]{row1,row2,row3,row4};
            rowsCB1.Items.AddRange(rows);
            rowsCB1.Enabled = true;
            rowsCB1.SelectedIndex = 2;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int code= onClose();
            if (code == 0)
                this.Close();
        }
        private int onClose()
        {
            int count = _currentSettings.Count;
            if (count < 10)
            {
                string levels = _currentSettings.notConfigured();

                MessageBox.Show("Остались не заполненные уровни: " + levels
                    + ". Прежде чем покинуть настройку все уровни должны быть настроены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
                return 0;
          
        }
        private void numberOfLevelCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string level = numberOfLevelCB.GetItemText(numberOfLevelCB.SelectedItem);
            
            switch (level)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    {
                        rowsCB2.Items.Clear();
                        rowsCB2.Enabled = false;
                        rowsCB3.Items.Clear();
                        rowsCB3.Enabled = false;
                    }
                    break;
                case "5":
                case "6":
                case "7":
                    {
                        rowsCB2.Enabled = true; 
                        changeItems(1);
                        rowsCB3.Items.Clear();
                        rowsCB3.Enabled = false;
                    } break;
                case "8":
                case "9":
                    {
                        rowsCB2.Enabled = true; 
                        rowsCB3.Enabled = true;
                        changeItems(1);
                    } break;
            }
        }
        /// <summary>
        /// Удаляет дупликаты из рядов
        /// </summary>
        private void changeItems(int numberOfCB)
        {

            if (rowsCB2.Enabled)
            {
                string[] rows;
                if (numberOfCB == 1) // если изменился первый чекбокс, обновляем второй
                {
                    ComboBox.ObjectCollection first = rowsCB1.Items;
                    ComboBox.ObjectCollection second = rowsCB2.Items;
                    rows = new string[4];
                    first.CopyTo(rows, 0);
                    string currentFirst = rowsCB1.GetItemText(rowsCB1.SelectedItem);
                    rowsCB2.Items.Clear();
                    rowsCB2.Items.AddRange(rows);
                    second.Remove(currentFirst);
                    rowsCB2.SelectedIndex = 0;
                }
                if (rowsCB3.Enabled)
                {
                    ComboBox.ObjectCollection second = rowsCB2.Items;
                    ComboBox.ObjectCollection third = rowsCB3.Items;
                    rows = new string[3];
                    second.CopyTo(rows, 0);
                    string currentSecond = rowsCB2.GetItemText(rowsCB2.SelectedItem);
                    rowsCB3.Items.Clear();
                    rowsCB3.Items.AddRange(rows);
                    third.Remove(currentSecond);
                    rowsCB3.SelectedIndex = 0;
                    
                }

            }
        }

        private void rowsCB2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changeItems(2);
        }

        private void rowsCB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changeItems(1);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveOneLevel();
        }
        private void saveOneLevel()
        {
            int numberOfLevel = Convert.ToInt32(numberOfLevelCB.GetItemText(numberOfLevelCB.SelectedItem));
            List<Row> listOfRows = new List<Row>();
            string numberOfRow = rowsCB1.GetItemText(rowsCB1.SelectedItem);
            Row nRow = getRow(numberOfRow);
            if(nRow!=null)
                listOfRows.Add(nRow);
            if (rowsCB2.Enabled)
            {
                numberOfRow = rowsCB2.GetItemText(rowsCB2.SelectedItem);
                nRow = getRow(numberOfRow);
                if (nRow != null)
                    listOfRows.Add(nRow);
                if (rowsCB3.Enabled)
                {
                    numberOfRow = rowsCB3.GetItemText(rowsCB3.SelectedItem);
                    nRow = getRow(numberOfRow);
                    if (nRow != null)
                        listOfRows.Add(nRow);
                }
            }
            _currentSettings.NumberOfLevel = numberOfLevel;
            _currentSettings.ListOfRows = listOfRows;
            int number = _currentSettings.existRows();
            if (number == 0)
                _currentSettings.addToCollection();
            else
            {
                if (number != numberOfLevel)
                {
                    DialogResult result = MessageBox.Show(
                        "Данные ряды уже используются в уровне " + number
                        + ". Заменить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Exercise cur = new Exercise(0, numberOfLevel);
                        cur.replaceExercises(number);
                        _currentSettings.changeOrDeleteRow(number);
                    }

                } else
                    _currentSettings.changeOrDeleteRow(number);
            }
        }
        
        private Row getRow(string numberOfRow)
        {
            Row parseRow = null;
            switch (numberOfRow)
            {
                case row1: parseRow = new Row(1); break;
                case row2: parseRow = new Row(2); break;
                case row3: parseRow = new Row(3); break;
                case row4: parseRow = new Row(4); break;
            }
            return parseRow;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            saveOneLevel();
            if (_currentSettings.Count < 10)
            {
                string levels = _currentSettings.notConfigured();
                MessageBox.Show("Остались не заполненные уровни: " + levels
                    + ". Прежде чем покинуть настройку все уровни должны быть настроены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }
        private void saveTenLevel()
        {
            Row first = new Row(1);
            Row second = new Row(2);
            Row third = new Row(3);
            Row fourth = new Row(4);
            List<Row> listOfRows = new List<Row>() { first, second, third, fourth };
            _currentSettings.NumberOfLevel = 10;
            _currentSettings.ListOfRows = listOfRows;
            _currentSettings.addToCollection();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (main != null)
                main.CurrentSettings = _currentSettings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic);
        }


    }
}
