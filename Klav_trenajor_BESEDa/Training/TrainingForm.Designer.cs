using BESEDa.Properties;
namespace BESEDa
{
    partial class TrainingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.уровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упражнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextExercise = new System.Windows.Forms.Button();
            this.nextLevel = new System.Windows.Forms.Button();
            this.speedProgress = new System.Windows.Forms.ProgressBar();
            this.speedTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.speedLabel = new System.Windows.Forms.Label();
            this.timeTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerLable = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerForLetter = new System.Windows.Forms.Timer(this.components);
            this.timerInSec = new System.Windows.Forms.Timer(this.components);
            this.startMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.letter1 = new BESEDa.Letter(this.components);
            this.keyBoard1 = new BESEDa.Vizualization.KeyBoard();
            this.menuStrip1.SuspendLayout();
            this.speedTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.timeTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.progressTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уровеньToolStripMenuItem,
            this.упражнениеToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // уровеньToolStripMenuItem
            // 
            this.уровеньToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.уровеньToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.уровеньToolStripMenuItem.Name = "уровеньToolStripMenuItem";
            this.уровеньToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.уровеньToolStripMenuItem.Text = "Уровень: ";
            // 
            // упражнениеToolStripMenuItem
            // 
            this.упражнениеToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.упражнениеToolStripMenuItem.Name = "упражнениеToolStripMenuItem";
            this.упражнениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.упражнениеToolStripMenuItem.Text = "Упражнение:";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выToolStripMenuItem
            // 
            this.выToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.выToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.выToolStripMenuItem.Name = "выToolStripMenuItem";
            this.выToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.выToolStripMenuItem.Text = "Вы: ";
            // 
            // nextExercise
            // 
            this.nextExercise.BackColor = System.Drawing.Color.White;
            this.nextExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextExercise.Location = new System.Drawing.Point(8, 15);
            this.nextExercise.Name = "nextExercise";
            this.nextExercise.Size = new System.Drawing.Size(124, 30);
            this.nextExercise.TabIndex = 23;
            this.nextExercise.TabStop = false;
            this.nextExercise.Text = "След.упражнение >";
            this.nextExercise.UseVisualStyleBackColor = false;
            this.nextExercise.Click += new System.EventHandler(this.nextExercise_Click);
            // 
            // nextLevel
            // 
            this.nextLevel.BackColor = System.Drawing.Color.White;
            this.nextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextLevel.Location = new System.Drawing.Point(8, 48);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(124, 30);
            this.nextLevel.TabIndex = 24;
            this.nextLevel.TabStop = false;
            this.nextLevel.Text = "След.уровень >";
            this.nextLevel.UseVisualStyleBackColor = false;
            this.nextLevel.Click += new System.EventHandler(this.nextLevel_Click);
            // 
            // speedProgress
            // 
            this.speedProgress.Location = new System.Drawing.Point(0, 0);
            this.speedProgress.Name = "speedProgress";
            this.speedProgress.Size = new System.Drawing.Size(117, 32);
            this.speedProgress.TabIndex = 25;
            // 
            // speedTab
            // 
            this.speedTab.Controls.Add(this.tabPage1);
            this.speedTab.Enabled = false;
            this.speedTab.Location = new System.Drawing.Point(9, 84);
            this.speedTab.Name = "speedTab";
            this.speedTab.SelectedIndex = 0;
            this.speedTab.Size = new System.Drawing.Size(128, 58);
            this.speedTab.TabIndex = 26;
            this.speedTab.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.speedLabel);
            this.tabPage1.Controls.Add(this.speedProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(120, 32);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скорость";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.MintCream;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.speedLabel.Location = new System.Drawing.Point(75, 6);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(40, 21);
            this.speedLabel.TabIndex = 35;
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeTab
            // 
            this.timeTab.Controls.Add(this.tabPage2);
            this.timeTab.Enabled = false;
            this.timeTab.Location = new System.Drawing.Point(10, 145);
            this.timeTab.Name = "timeTab";
            this.timeTab.SelectedIndex = 0;
            this.timeTab.Size = new System.Drawing.Size(128, 58);
            this.timeTab.TabIndex = 27;
            this.timeTab.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.timerLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(120, 32);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Время";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerLable
            // 
            this.timerLable.AutoSize = true;
            this.timerLable.BackColor = System.Drawing.Color.Transparent;
            this.timerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLable.ForeColor = System.Drawing.Color.Maroon;
            this.timerLable.Location = new System.Drawing.Point(8, 7);
            this.timerLable.Name = "timerLable";
            this.timerLable.Size = new System.Drawing.Size(0, 18);
            this.timerLable.TabIndex = 26;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(117, 32);
            this.progressBar.TabIndex = 25;
            // 
            // progressTab
            // 
            this.progressTab.Controls.Add(this.tabPage3);
            this.progressTab.Enabled = false;
            this.progressTab.Location = new System.Drawing.Point(10, 205);
            this.progressTab.Name = "progressTab";
            this.progressTab.SelectedIndex = 0;
            this.progressTab.Size = new System.Drawing.Size(128, 58);
            this.progressTab.TabIndex = 28;
            this.progressTab.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(120, 32);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Прогресс";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "_аапы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(646, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 111);
            this.label3.TabIndex = 32;
            // 
            // timerForLetter
            // 
            this.timerForLetter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerInSec
            // 
            this.timerInSec.Tick += new System.EventHandler(this.timerInSec_Tick);
            // 
            // startMessage
            // 
            this.startMessage.BackColor = System.Drawing.Color.SaddleBrown;
            this.startMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMessage.ForeColor = System.Drawing.Color.Moccasin;
            this.startMessage.Location = new System.Drawing.Point(6, 99);
            this.startMessage.Name = "startMessage";
            this.startMessage.Size = new System.Drawing.Size(491, 100);
            this.startMessage.TabIndex = 1;
            this.startMessage.Text = "Для начала выполнения упражнения \r\nнажмите пробел...";
            this.startMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.BackgroundImage = global::BESEDa.Properties.Resources.BURLOAK;
            this.groupBox1.Controls.Add(this.nextExercise);
            this.groupBox1.Controls.Add(this.nextLevel);
            this.groupBox1.Controls.Add(this.speedTab);
            this.groupBox1.Controls.Add(this.timeTab);
            this.groupBox1.Controls.Add(this.progressTab);
            this.groupBox1.Location = new System.Drawing.Point(501, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 268);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // letter1
            // 
            this.letter1.Location = new System.Drawing.Point(12, 68);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(61, 65);
            this.letter1.TabIndex = 34;
            this.letter1.UserFontSize = 30;
            this.letter1.VisibleChanged += new System.EventHandler(this.letter1_VisibleChanged);
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.Color.SaddleBrown;
            this.keyBoard1.BackgroundImage = global::BESEDa.Properties.Resources.BURLOAK;
            this.keyBoard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keyBoard1.ForeColor = System.Drawing.Color.Black;
            this.keyBoard1.Location = new System.Drawing.Point(0, 298);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(649, 203);
            this.keyBoard1.TabIndex = 33;
            this.keyBoard1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyBoard1_KeyDown);
            this.keyBoard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyBoard1_KeyPress);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources.light_wooden_background;
            this.ClientSize = new System.Drawing.Size(649, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startMessage);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренировка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.Shown += new System.EventHandler(this.TrainingForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.speedTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.timeTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.progressTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem уровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упражнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выToolStripMenuItem;
        private System.Windows.Forms.Button nextExercise;
        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.ProgressBar speedProgress;
        private System.Windows.Forms.TabControl speedTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl timeTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabControl progressTab;
        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
     
        private Vizualization.KeyBoard keyBoard1;
        private Letter letter1;
        private System.Windows.Forms.Timer timerForLetter;
        private System.Windows.Forms.Timer timerInSec;
        private System.Windows.Forms.Label timerLable;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label startMessage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}