using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BESEDa.Administrative
{
    public partial class AddExercise : Form
    {
        WorkWithExercises main;
        Exercise newExercise;
        Settings currentSettings;
        List<char> usingSymbols;
        public AddExercise()
        {
            InitializeComponent();
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExercise_Load(object sender, EventArgs e)
        {
            main = this.Owner as WorkWithExercises;
            if (main != null)
            {
                currentSettings = main.CurrentSettings;
                getUsingSymbols();
            }
            
            // сделать вызов метода который по номеру уровня и по номеру зоны будет определять 
            // используемые символы
            // также этот метод должен выполняться при смене уровня и при изменении 
            // значения чекбоксов
             
        }
        /// <summary>
        /// Возвращает строковое представление выбранных зон по чек боксам
        /// </summary>
        /// <returns>Список зон</returns>
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
        private void saveBut_Click(object sender, EventArgs e)
        {
            string text = textExerRichTB.Text.Replace(" ","");
            if(text.Equals(""))
                MessageBox.Show("Текст упражнения не введен. ");
            else 
            {
                string zones = defZones();
                if (zones.Equals(""))
                    MessageBox.Show("Не выбраны зоны для пальцев");
                else
                {
                    newExercise = new Exercise(zones, Convert.ToInt32(numericUpDownLevel.Value), 
                        textExerRichTB.Text, textBoxSymbols.Text);
                    int code = newExercise.insertExercise();
                    if (code == 1)
                        MessageBox.Show("Упражнение добавлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        DialogResult result = MessageBox.Show(string.Format("Упражнение уже существует в базе. Хотите его заменить?"), "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            code = newExercise.updateExercise();
                            if (code == 1)
                                MessageBox.Show("Упражнение обновлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                            else 
                            {
                                MessageBox.Show("Запрос завершился с ошибкой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                    }
                    this.Close();


                }
                
            }
        }
        private void getUsingSymbols()
        {
            int level = (int)numericUpDownLevel.Value;
            string defZone = defZones();
           
            if(defZone.Equals(""))
            {
                textBoxSymbols.Text="Зоны не выбраны";
            }
            else
            {
                string[] zones = defZone.Split(',');
                int size = zones.Length;
                int[] zoneNumber = new int[size];
                for (int i = 0; i < size; i++)
                    zoneNumber[i] = Convert.ToInt32(zones[i]);
                string symbols = currentSettings.getSymbols(level, zoneNumber);
                string[] splitSymbols = symbols.Split(',');
                int length = splitSymbols.Length;
                usingSymbols = new List<char>(length);
                for (int i = 0; i < length; i++)
                    usingSymbols.Add(Convert.ToChar(splitSymbols[i]));
                textBoxSymbols.Text = symbols;
            }
            
        }

        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            getUsingSymbols();
        }

        private void zone1CB_CheckedChanged(object sender, EventArgs e)
        {
            getUsingSymbols();
        }

        private void zone2CB_CheckedChanged(object sender, EventArgs e)
        {
            getUsingSymbols();
        }

        private void zone3CB_CheckedChanged(object sender, EventArgs e)
        {
            getUsingSymbols();
        }

        private void zone4CB_CheckedChanged(object sender, EventArgs e)
        {
            getUsingSymbols();
        }

        private void textExerRichTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSymbols.Equals("Зоны не выбраны"))
                e.Handled = true;
            else
            {
                char currentChar = e.KeyChar;
                if (currentChar.Equals((char)Keys.Enter))
                    e.Handled = true;
                else if (char.IsLetterOrDigit(currentChar)) // если введена цифра
                {
                    if (usingSymbols.Contains(currentChar))
                        return;
                    else
                        e.Handled = true; // обработка завершена и не передается главному обработчику
                }
                else if ((char.IsWhiteSpace(currentChar)) || (char.IsControl(currentChar)))
                // если '.' или пробел или клавиша управления
                {
                    return;
                }
                else
                    e.Handled = true;
            }
        }

       

        private void textExerRichTB_TextChanged(object sender, EventArgs e)
        {
              restSymbLabel.Text = Convert.ToString(200 - textExerRichTB.TextLength);
        }

        private void textExerRichTB_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            generateExercise();
        }
        /// <summary>
        /// Автоматическая генерация упражнения
        /// </summary>
        private void generateExercise()
        {
            int level = (int)numericUpDownLevel.Value;
            string defZone = defZones();
            if (defZone.Equals(""))
            {
                MessageBox.Show("Не выбраны зоны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int amountOfSymbols = usingSymbols.Count;
                if (amountOfSymbols == 0)
                {
                    MessageBox.Show("Список символов пуст", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    int length = 200;                           // длина упражнения
                    int meetSymbol = length / amountOfSymbols;  // показывает сколько раз должна встретиться каждая буква
                    string forShuffle = "";
                    foreach (char c in usingSymbols)
                    {
                        forShuffle+= new string(c,meetSymbol);
                    }
                    
                    Random random = new Random(DateTime.Now.Millisecond);
                    char[] shuffle = forShuffle.ToArray();
                    shuffle = shuffle.OrderBy(x => random.Next()).ToArray();
                    forShuffle = new string(shuffle);
                    for (int i = 1; i < 19; i += 2)
                        forShuffle = forShuffle.Remove(i, 1).Insert(i, " ");
                    for (int i = 19; i < 64; i += 3)
                        forShuffle = forShuffle.Remove(i, 1).Insert(i, " ");
                    for (int i = 64; i<124;i+=4)
                        forShuffle = forShuffle.Remove(i, 1).Insert(i, " ");
                    for (int i = 124; i < forShuffle.Length; i += 5)
                        forShuffle = forShuffle.Remove(i, 1).Insert(i, " ");
                    textExerRichTB.Text = forShuffle;
                }
            }
        }
    }
}
