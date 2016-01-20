namespace BESEDa
{
    partial class TrainedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainedForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.dateLastTrainBox = new System.Windows.Forms.TextBox();
            this.startTraining = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.Color.White;
            this.userLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(12, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 20);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Пользователь:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.выToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выToolStripMenuItem
            // 
            this.выToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.выToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem});
            this.выToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.выToolStripMenuItem.Name = "выToolStripMenuItem";
            this.выToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.выToolStripMenuItem.Text = "Вы: ";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.Color.White;
            this.levelLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.Location = new System.Drawing.Point(12, 58);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(96, 20);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "№ Уровня:";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата последней тренировки:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.White;
            this.loginBox.Enabled = false;
            this.loginBox.Location = new System.Drawing.Point(114, 31);
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = true;
            this.loginBox.Size = new System.Drawing.Size(117, 20);
            this.loginBox.TabIndex = 6;
            // 
            // levelBox
            // 
            this.levelBox.BackColor = System.Drawing.Color.White;
            this.levelBox.Enabled = false;
            this.levelBox.Location = new System.Drawing.Point(114, 58);
            this.levelBox.Name = "levelBox";
            this.levelBox.ReadOnly = true;
            this.levelBox.Size = new System.Drawing.Size(117, 20);
            this.levelBox.TabIndex = 7;
            // 
            // dateLastTrainBox
            // 
            this.dateLastTrainBox.BackColor = System.Drawing.Color.White;
            this.dateLastTrainBox.Enabled = false;
            this.dateLastTrainBox.Location = new System.Drawing.Point(12, 111);
            this.dateLastTrainBox.Name = "dateLastTrainBox";
            this.dateLastTrainBox.ReadOnly = true;
            this.dateLastTrainBox.Size = new System.Drawing.Size(219, 20);
            this.dateLastTrainBox.TabIndex = 8;
            // 
            // startTraining
            // 
            this.startTraining.BackColor = System.Drawing.Color.Transparent;
            this.startTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startTraining.BackgroundImage")));
            this.startTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTraining.FlatAppearance.BorderSize = 0;
            this.startTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.startTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.startTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTraining.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTraining.ForeColor = System.Drawing.Color.White;
            this.startTraining.Location = new System.Drawing.Point(243, 36);
            this.startTraining.Name = "startTraining";
            this.startTraining.Size = new System.Drawing.Size(217, 52);
            this.startTraining.TabIndex = 9;
            this.startTraining.Text = "Начать тренировку";
            this.startTraining.UseVisualStyleBackColor = false;
            this.startTraining.Click += new System.EventHandler(this.startTraining_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.Transparent;
            this.statisticsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statisticsButton.BackgroundImage")));
            this.statisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.statisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Location = new System.Drawing.Point(243, 91);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(109, 34);
            this.statisticsButton.TabIndex = 10;
            this.statisticsButton.Text = "Статистика";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(351, 91);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(109, 34);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "Справка";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // TrainedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 138);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.startTraining);
            this.Controls.Add(this.dateLastTrainBox);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.TrainedForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выToolStripMenuItem;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.TextBox dateLastTrainBox;
        private System.Windows.Forms.Button startTraining;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}