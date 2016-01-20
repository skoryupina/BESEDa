using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BESEDa.Vizualization;
using BESEDa.Authorization;
using BESEDa.Training;
using BESEDa.Administrative;
using System.Threading;
using System.Timers;

namespace BESEDa
{
    public partial class TrainingForm : Form
    {
        EventWaitHandle progressIncEvent; // событие для увеличения прогресс бара
        EventWaitHandle speedIncEvent;// событие для изменения показания скорости набора
        BackgroundWorker bwForProgressBar;
        BackgroundWorker bwForSpeed;
        string currentLetter; // подсветка на клаве текущей буквы ?
        User currentUser; // Текущий польз-ль
        UTraining currentTraining; // Текущая тренировка
        TrainingParametersForm main; // Форма-родитель
        string lastkey;// последняя нажатая клавиша
        bool isLabel = true; // флаг для отрезания первого символа лейбла

        bool continues = false; // флаг остановки упражнения (?)

        int tickLength = 50; // реакция таймера для отрисовки
        int timerInterval = 1000;
        int maxSpeed = 500;
        DateTime timeOfTraining; // длительность упражнения
        Point startCoordinate = new Point(12, 68);// нач. координаты юзерконтрола с падающей буквой
        int textLength; // полный размер текста упражнения
        Color lastColor; // для возвращения цвета клавиши
        StatisticsOfExercise statistics;
        bool isNotDone = true; // Не пройдено ни одно упражнение
        string usingSymbol=null;
        public TrainingForm()
        {
            InitializeComponent();
            progressIncEvent = new AutoResetEvent(false); // событие для увеличения прогресс бара
            speedIncEvent = new AutoResetEvent(false);// событие для изменения показания скорости набора
            bwForProgressBar = new BackgroundWorker();
            bwForSpeed = new BackgroundWorker();
            keyBoard1.Focus();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
        }

        /// <summary>
        /// Задает интервал  по которому происходит событие tick и запускает таймеры
        /// </summary>
        public void keepingTime()
        {
            timerForLetter.Interval = tickLength;
            timerInSec.Interval = timerInterval;
            timerForLetter.Start();
            timerInSec.Start();
        }
        /// <summary>
        /// Устанавливает флаг прохождения тренировки и запускает фоновые процессы расчета скорости и увеличение прогресса
        /// </summary>
        public void start()
        {
            continues = true;
            if (!bwForProgressBar.IsBusy)
                bwForProgressBar.RunWorkerAsync();
            if (!bwForSpeed.IsBusy)
                bwForSpeed.RunWorkerAsync();
            timeOfTraining = new DateTime(0, 0);
            textLength = label1.Text.Length;
            keepingTime();
            keyBoard1.Focus();

        }
        /// <summary>
        /// Переход на след. упражнение в уровне
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextExercise_Click(object sender, EventArgs e)
        {
            doOnCloseOrTransition();
            completionOfTraining(false);
        }
        /// <summary>
        /// Падение буквы
        /// </summary>
        private void fallLetter()
        {
            if (letter1.Location.Y + letter1.Height < keyBoard1.Location.Y)
            {
                int y = letter1.Location.Y;
                int x = letter1.Location.X;
                letter1.Location = new Point(x, y = y + 2);
                letter1.Refresh();
            }
            else
            {
                if (continues)
                {
                    letter1.Location = startCoordinate;
                    isLabel = true;
                    letter1.Visible = false;
                }
            }

                
        }

        /// <summary>
        /// "Отрезает" первую букву лейбла с текстом упражнения
        /// </summary>
        private void cutLabel()
        {
            isLabel = false;
            if (label1.Text.Length > 0)
            {
                letter1.Letterl = label1.Text[0].ToString();
                letter1.Refresh();
                letter1.Visible = true;
                label1.Text = label1.Text.Substring(1);
                label1.Refresh();
                progressIncEvent.Set();
            }

        }
        /// <summary>
        /// Переход. на след уровень и первое упражнение в нем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextLevel_Click(object sender, EventArgs e)
        {
            
            if (currentTraining.NumberOfLevel != 10)
            {
                doOnCloseOrTransition();
                completionOfTraining(true);
            }
        }
        /// <summary>
        /// Метод работы фонового потока, ожидает когда придет событие для обновления прогрессбара.
        /// После выполнения переходит в метод завершения работы фонового потока bw_RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwForProgressBar_DoWork(object sender, DoWorkEventArgs e)
        {
            progressIncEvent.WaitOne();
        }
        /// <summary>
        /// Метод завершения работы фонового потока прогрессбара.
        /// Расчитывает в % пройденную часть упражнения от всей длинны упражнения.
        /// Затем вновь запускает фоновый процесс ожидания события обновления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                progressBar.Value = ((textLength - label1.Text.Length) * 100) / textLength;
                if (!bwForProgressBar.IsBusy)
                    bwForProgressBar.RunWorkerAsync();
        }
        /// <summary>
        /// Метод работы фонового потока, ожидает когда придет событие для обновления прогрессбара скорости набора.
        /// После выполнения переходит в метод завершения работы фонового потока bwForSpeed_RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwForSpeed_DoWork(object sender, DoWorkEventArgs e)
        {
            speedIncEvent.WaitOne();
        }
        /// <summary>
        /// Метод завершения работы фонового потока прогрессбара скорости набора.
        /// Расчитывает скорость набора, затем в % от максимальной скорости набора 500 символов.
        /// Затем вновь запускает фоновый процесс ожидания события обновления. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwForSpeed_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                int sec = Convert.ToInt32(timeOfTraining.Minute) * 60 + Convert.ToInt32(timeOfTraining.Second); // время выполнения упражнения
                if (sec == 0)
                    sec = 1;
                double speed = ((double)(textLength - label1.Text.Length) / sec) * 60;
                double percent = (speed * 100) / maxSpeed;
                speedLabel.Text = ((int)speed).ToString();
                speedProgress.Value = Convert.ToInt32(percent);
                if (!bwForSpeed.IsBusy)
                    bwForSpeed.RunWorkerAsync();
        }
        /// <summary>
        /// Анализ нажатой клавиши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyBoard1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (continues)
            {
                if ((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar.Equals(' ')) || (e.KeyChar.Equals('.')))
                {
                    if ((e.KeyChar == Convert.ToChar(letter1.Letterl.ToLower())) || (e.KeyChar == Convert.ToChar(letter1.Letterl.ToUpper())) || (e.KeyChar.Equals(' ') && letter1.Letterl.Equals("_")) || (e.KeyChar.Equals('.') && letter1.Letterl.Equals(".")))
                    {
                        this.letter1.Enabled = false;
                        letter1.Visible = false;
                        this.letter1.Location = startCoordinate;
                        isLabel = true;
                        speedIncEvent.Set();
                    }
                    else
                    {
                        statistics.AmountOfMistakes++;
                    }
                }
                else
                    e.Handled = true;
                
            }
            else
            {
                if (e.KeyChar.Equals(' '))
                {
                    label1.Visible = true;
                    letter1.Visible = true;
                    startMessage.Visible = false;
                    
                    if (currentTraining.StartDateOfTraining.ToString().Equals("01.01.0001 0:00:00"))
                    {
                        currentTraining.StartDateOfTraining = DateTime.Now;
                        currentTraining.insertTraining(); // Сохраняем тренировку
                    }
                    statistics = new StatisticsOfExercise(currentTraining.NumberOfCurrentExercise, currentTraining.TrainingID);
                    liteUsedSymbols(usingSymbol, false);
                    start();
                }
            }
        }
        /// <summary>
        /// Действия выполняемые при отрисовке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrainingForm_Shown(object sender, EventArgs e)
        {
            keyBoard1.Focus();
            letter1.Letterl = label1.Text[0].ToString();
            currentLetter = label1.Text[0].ToString();
            bwForProgressBar.DoWork += bwForProgressBar_DoWork;
            bwForProgressBar.RunWorkerCompleted += bw_RunWorkerCompleted;
            bwForProgressBar.WorkerSupportsCancellation = true;
            bwForSpeed.DoWork += bwForSpeed_DoWork;
            bwForSpeed.RunWorkerCompleted += bwForSpeed_RunWorkerCompleted;
            bwForSpeed.WorkerSupportsCancellation = true;
        }
        /// <summary>
        /// Обработчик события закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            doOnCloseOrTransition();
            main.Close();
        }
        /// <summary>
        /// Проверяет было ли выполнено до конца хоть одно упражнение. 
        /// Если нет, то производит удаление тренировки из БД
        /// </summary>
        private void doOnCloseOrTransition()
        {
            if (isNotDone)
            {
                currentTraining.deleteTraining();
            }
            else
            {
                currentUser.NumberOfLastLevel = currentTraining.NumberOfLevel;
                currentUser.DateofLastTraining = currentTraining.StartDateOfTraining;
                currentUser.updateUsersTraining();
                main.CurrentUser = currentUser;

            }
        }
        /// <summary>
        /// Обработчик события тика от таймера. 
        /// Используется для процессов визуализации: падение буквы, отрезание первого символа лейбла и подсветки клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (continues)
            {
                if (label1.Text.Length > 0)
                {
                    if (isLabel)
                    {
                        letter1.Visible = true;
                        if (currentTraining.BackliteKeyBoard)
                        {
                            string pressedKey = label1.Text[0].ToString().ToUpper();
                            if (pressedKey.Equals("."))
                                pressedKey="Point";
                            if (lastkey != null)
                            {
                                if (lastkey.Equals("."))
                                    lastkey = "Point";
                                keyBoard1.Controls["but" + lastkey].BackColor = lastColor;
                            }
                            lastkey = pressedKey;
                            lastColor = keyBoard1.Controls["but" + pressedKey].BackColor;
                            keyBoard1.Controls["but" + pressedKey].BackColor = Color.Green;
                        }
                        cutLabel();
                    }
                }
            }
            fallLetter();
        }
        /// <summary>
        /// Действия при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as TrainingParametersForm;
            if (main != null)
            {
                currentUser = main.CurrentUser;
                выToolStripMenuItem.Text = "Вы: " + currentUser.Login;
                currentTraining = main.CurrentTraining;
                letter1.UserFontSize = currentTraining.FontSize;
                letter1.Refresh();
                уровеньToolStripMenuItem.Text = "Уровень: " + currentTraining.NumberOfLevel;
                упражнениеToolStripMenuItem.Text = "Упражнение: " + currentTraining.NumberOfCurrentExercise;
                Exercise newEx = new Exercise(currentTraining.NumberOfCurrentExercise, currentTraining.NumberOfLevel);
                int code = newEx.selectExercise();
                label1.Visible = false;
                label1.Text = newEx.Text.Replace(' ', '_');
                letter1.Visible=false;
                usingSymbol = newEx.UsingSymbols;
                liteUsedSymbols(usingSymbol,true);
                keyBoard1.Focus();
            }
        }
        /// <summary>
        /// Затемняет используемые символы в упражнении на виртуальной клавиатуре
        /// </summary>
        /// <param name="usedSymbols">Используемые символы</param>
        /// <param name="light"></param>
        private void liteUsedSymbols(string usedSymbols, bool light)
        {
            string[] splitSymb = usedSymbols.Split(',');
           
            if (light)
            {
                for (int i = 0; i < splitSymb.Length; i++)
                {
                    if (splitSymb[i].Equals("."))
                        splitSymb[i] = "Point";
                    Color oldColor = keyBoard1.Controls["but" + splitSymb[i]].BackColor;
                    Color newColor = Color.FromArgb(oldColor.A, oldColor.R - 70, oldColor.G - 70, oldColor.B - 70);
                    keyBoard1.Controls["but" + splitSymb[i]].BackColor = newColor;
                }
            }
            else
            {
                for (int i = 0; i < splitSymb.Length; i++)
                {
                    if (splitSymb[i].Equals("."))
                        splitSymb[i] = "Point";
                    Color oldColor = keyBoard1.Controls["but" + splitSymb[i]].BackColor;
                    Color newColor = Color.FromArgb(oldColor.A, oldColor.R + 70, oldColor.G + 70, oldColor.B + 70);
                    keyBoard1.Controls["but" + splitSymb[i]].BackColor = newColor;
                }
            }
        }
        /// <summary>
        /// Загрузка нового упражнения, обновление текста упражнения.
        /// Если текущего запрошенного упражнения нет
        /// выполняет поиск следующего доступного, пока не пройдет по всем уровням и упражнениям.
        /// </summary>
        /// <param name="isNextLevel"></param>
        private void selectExercise(bool isNextLevel)
        {
            int curLevel;
            int curExercise;
            if (isNextLevel)
            {
                curExercise = 15;
            }
            else
            {
                curExercise = currentTraining.NumberOfCurrentExercise;
            }
            curLevel = currentTraining.NumberOfLevel;
            changeLeverOrExercise(ref curLevel, ref curExercise);
            Exercise newEx = new Exercise(curExercise, curLevel);
            int code = newEx.selectExercise();
            
            while ((code == 0) && (curLevel < 11))
            {
                changeLeverOrExercise(ref curLevel,ref curExercise);
                newEx.NumberOfLevel = curLevel;
                newEx.Number = curExercise;
                code = newEx.selectExercise();
            }
            if (curLevel < 11)
            {
                
                if (curLevel != currentTraining.NumberOfLevel)
                {
                    currentTraining.NumberOfLevel = curLevel;
                    currentTraining.getLastId();
                    currentTraining.insertTraining();
                    isNotDone = true;
                }
                currentTraining.NumberOfLevel = curLevel;
                currentTraining.NumberOfCurrentExercise = curExercise;
                label1.Text = newEx.Text.Replace(' ', '_');
                textLength = label1.Text.Length;
                usingSymbol = newEx.UsingSymbols;
                liteUsedSymbols(usingSymbol,true);
                упражнениеToolStripMenuItem.Text = "Упражнение: " + curExercise;
                уровеньToolStripMenuItem.Text = "Уровень: " + curLevel;
                keyBoard1.Focus();
            }
            else 
            {
                MessageBox.Show("В системе больше нет упражнений", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.Close();            
            }
        }
        /// <summary>
        /// Событие тика для таймера, показывающего время прохождения упражнения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerInSec_Tick(object sender, EventArgs e)
        {
            timeOfTraining = timeOfTraining.AddSeconds(1);
            timerLable.Text = timeOfTraining.ToString("mm:ss");
        }
        /// <summary>
        /// Проверяет завершено ли прохождение упражнения.
        /// При удовлетворительном ответе устанавливает флаг, что было выполнено хотя бы одно упражнение
        /// в тренировке и сохраняет статистику
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void letter1_VisibleChanged(object sender, EventArgs e)
        {
            if ((label1.Text.Length == 0) && (!letter1.Visible))
            {
                if (isNotDone)
                    isNotDone = false;
                saveStatistics();
                completionOfTraining(false);
            }
        }
        /// <summary>
        /// Сохраняет статистику прохождения упр-ния.
        /// </summary>
        private void saveStatistics()
        {
            statistics.Speed = Convert.ToInt32(speedLabel.Text);
            statistics.DataAndTime = DateTime.Now;
            statistics.insertStastics();
        }
        /// <summary>
        /// Завершение прохождения упражнения
        /// </summary>
        /// <param name="isLevel"></param>
        private void completionOfTraining(bool isLevel)
        {
            if (lastkey != null)
            {
                if (lastkey.Equals("."))
                    lastkey = "Point";
                keyBoard1.Controls["but" + lastkey].BackColor = lastColor;
                lastkey = null;
            }
            bwForSpeed.CancelAsync();
            bwForSpeed.Dispose();
            bwForProgressBar.CancelAsync();
            bwForProgressBar.Dispose();
            continues = false;
            timerInSec.Stop();
            timerForLetter.Stop();
            label1.Visible = false;
            letter1.Visible = false;
            speedLabel.Text = "0";
            timerLable.Text = "00:00";
            speedProgress.Value = 0;
            speedProgress.Refresh();
            progressBar.Value = 0;
            progressBar.Refresh();
            selectExercise(isLevel);
            startMessage.Visible = true;
            keyBoard1.Focus();
        }
        /// <summary>
        /// Выполняет смену номера упражнения или уровня
        /// </summary>
        /// <param name="curLevel"></param>
        /// <param name="curExercise"></param>
        private void changeLeverOrExercise(ref int curLevel, ref int curExercise)
        {
            if (curExercise == 15)
            {
                curLevel++;
                curExercise = 1;
            }
            else
                curExercise++;
        }
        /// <summary>
        /// Убирает обработку клавиш контролов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyBoard1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                e.Handled = true;
        }
        
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
