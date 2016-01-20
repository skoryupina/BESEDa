using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Training;
using BESEDa.Authorization;
namespace BESEDa
{
    public partial class TrainingParametersForm : Form
    {
        UTraining currentTraining;
        User currentUser;
        TrainedForm main;
        int numberOfCurrentExercise;

        private const string helpfile = "spravka.chm";
        private const string Topic = "nastrojka_parametrov_trenirovki.htm";
        public TrainingParametersForm()
        {
            InitializeComponent();
        }
        public UTraining CurrentTraining
        {
            get { return currentTraining; }
            set { currentTraining = value; }
        }
        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            currentTraining = new UTraining(currentUser.Login, (int)numericUpDownLevel.Value,
                (int)sizeOfFontControl.Value, keyLightCHBox.Checked, numberOfCurrentExercise);
            int code = currentTraining.getLastId();
            if (code == 0)
            {
                TrainingForm trainingForm = new TrainingForm();
                trainingForm.Owner = this;
                trainingForm.ShowDialog();
                
            }
            else
                MessageBox.Show("Файл БД не найден","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrainingParametersForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as TrainedForm;
            if (main != null)
            {
                currentUser = main.CurrentUser;
                if (currentUser.NumberOfLastLevel != 0)
                {
                    numericUpDownLevel.Value = currentUser.NumberOfLastLevel;
                    if (!currentUser.DateofLastTraining.ToString().Equals("01.01.0001 0:00:00"))
                    {
                        numberOfCurrentExercise = currentUser.getLastNumberOfEx();
                        numberOfCurrentExercise++;
                        switch (numberOfCurrentExercise)
                        {
                            case 0: break;
                            case 1: exercise1RButton.Checked = true; break;
                            case 2: exercise2RButton.Checked = true; break;
                            case 3: exercise3RButton.Checked = true; break;
                            case 4: exercise4RButton.Checked = true; break;
                            case 5: exercise5RButton.Checked = true; break;
                            case 6: exercise6RButton.Checked = true; break;
                            case 7: exercise7RButton.Checked = true; break;
                            case 8: exercise8RButton.Checked = true; break;
                            case 9: exercise9RButton.Checked = true; break;
                            case 10: exercise10RButton.Checked = true; break;
                            case 11: exercise11RButton.Checked = true; break;
                            case 12: exercise12RButton.Checked = true; break;
                            case 13: exercise13RButton.Checked = true; break;
                            case 14: exercise14RButton.Checked = true; break;
                            case 15: exercise15RButton.Checked = true; break;
                        }
                    }
                }
              
            }
        }

        private void TrainingParametersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.CurrentUser = currentUser;
        }

        private void exercise1RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise1RButton.Checked)
                numberOfCurrentExercise = 1;
        }

        private void exercise2RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise2RButton.Checked)
                numberOfCurrentExercise = 2;
        }

        private void exercise3RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise3RButton.Checked)
                numberOfCurrentExercise = 3;
        }

        private void exercise4RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise4RButton.Checked)
                numberOfCurrentExercise = 4;
        }

        private void exercise5RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise5RButton.Checked)
                numberOfCurrentExercise = 5;
        }

        private void exercise6RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise6RButton.Checked)
                numberOfCurrentExercise = 6;
        }

        private void exercise7RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise7RButton.Checked)
                numberOfCurrentExercise = 7;
        }

        private void exercise8RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise8RButton.Checked)
                numberOfCurrentExercise = 8;
        }

        private void exercise9RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise9RButton.Checked)
                numberOfCurrentExercise = 9;
        }

        private void exercise10RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise10RButton.Checked)
                numberOfCurrentExercise = 10;
        }

        private void exercise11RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise11RButton.Checked)
                numberOfCurrentExercise = 11;
        }

        private void exercise12RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise12RButton.Checked)
                numberOfCurrentExercise = 12;
        }

        private void exercise13RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise13RButton.Checked)
                numberOfCurrentExercise = 13;
        }

        private void exercise14RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise14RButton.Checked)
                numberOfCurrentExercise = 14;
        }

        private void exercise15RButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exercise15RButton.Checked)
                numberOfCurrentExercise = 15;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic);
        }
    }
}
