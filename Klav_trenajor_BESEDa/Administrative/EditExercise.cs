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
    public partial class EditExercise : Form
    {
        Exercise currentExercise;
        List<char> usingSymbols;
        public EditExercise()
        {
            InitializeComponent();
        }

        private void EditExercise_Load(object sender, EventArgs e)
        {
            WorkWithExercises main = this.Owner as WorkWithExercises;
            if (main != null)
            {
                currentExercise = main.ChosenExercise;
                textExerRichTB.Text = currentExercise.Text;
                string symbols= currentExercise.UsingSymbols;
                textBoxSymbols.Text = symbols;
                string[] splitSymb = symbols.Split(',');
                int size = splitSymb.Length;
                usingSymbols= new List<char>(size);
                for (int i = 0; i < size; i++)
                    usingSymbols.Add(Convert.ToChar(splitSymb[i]));
                restSymbLabel.Text = Convert.ToString(200 - textExerRichTB.TextLength);

            }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            string text = textExerRichTB.Text.Replace(" ","");
            if (text.Equals(""))
                MessageBox.Show("Текст упражнения не введен. ");
            else 
            {
                if (currentExercise != null)
                {
                    currentExercise.Text = textExerRichTB.Text;
                    currentExercise.AllowedMistakes = Convert.ToInt32(textExerRichTB.Text.Length * 0.1);
                    int code = currentExercise.updateExercise();
                    if (code == 1)
                    {
                        MessageBox.Show("Упражнение отредактировано", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Запрос завершился с ошибкой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Close();
        }


        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textExerRichTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textExerRichTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
        }

        private void textExerRichTB_TextChanged(object sender, EventArgs e)
        {
            restSymbLabel.Text = Convert.ToString(200 - textExerRichTB.TextLength);
        }
    }
}
