using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Authorization;
namespace BESEDa
{
    public partial class TrainedForm : Form
    {
        private User _currentUser;
        private KeyboardTrainIndex main;

        private const string helpfile = "spravka.chm";
        private const string Topic = "obuchaemyj.htm";

        public TrainedForm()
        {
            InitializeComponent();
        }
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccountForm edit = new EditAccountForm();
            edit.Owner = this;
            edit.ShowDialog();
            loginBox.Text = _currentUser.Login;
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
        }

        private void TrainedForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as KeyboardTrainIndex;
            _currentUser = main.CurrentUser;
            
            loginBox.Text = _currentUser.Login;
            if(_currentUser.NumberOfLastLevel==0)
                levelBox.Text = "-";
            else 
                levelBox.Text = Convert.ToString(_currentUser.NumberOfLastLevel);
            if(_currentUser.DateofLastTraining.ToString().Equals("01.01.0001 0:00:00"))
                dateLastTrainBox.Text = "-";
            else 
                dateLastTrainBox.Text = _currentUser.DateofLastTraining.ToString();
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            StatisticOfUser statOfUser = new StatisticOfUser();
            statOfUser.Owner = this;
            statOfUser.Show();
            _currentUser = main.CurrentUser;
            loginBox.Text = _currentUser.Login;
            выToolStripMenuItem.Text = "Вы: " + _currentUser.Login;
        }

        private void startTraining_Click(object sender, EventArgs e)
        {
            TrainingParametersForm param = new TrainingParametersForm();
            param.Owner = this;
            param.ShowDialog();
            levelBox.Text = Convert.ToString(_currentUser.NumberOfLastLevel);
            dateLastTrainBox.Text = _currentUser.DateofLastTraining.ToString();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic);
        }

    }
}
