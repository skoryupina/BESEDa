namespace BESEDa.Administrative
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.workWithExBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.controlAccountsBut = new System.Windows.Forms.Button();
            this.amountOfExBox = new System.Windows.Forms.TextBox();
            this.amountOfTrainBox = new System.Windows.Forms.TextBox();
            this.amoutOfUsersBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workWithExBut
            // 
            this.workWithExBut.BackColor = System.Drawing.Color.Transparent;
            this.workWithExBut.BackgroundImage = global::BESEDa.Properties.Resources.button;
            this.workWithExBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.workWithExBut.FlatAppearance.BorderSize = 0;
            this.workWithExBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workWithExBut.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workWithExBut.ForeColor = System.Drawing.Color.White;
            this.workWithExBut.Location = new System.Drawing.Point(352, 91);
            this.workWithExBut.Name = "workWithExBut";
            this.workWithExBut.Size = new System.Drawing.Size(113, 34);
            this.workWithExBut.TabIndex = 20;
            this.workWithExBut.Text = "Упражнения";
            this.workWithExBut.UseVisualStyleBackColor = false;
            this.workWithExBut.Click += new System.EventHandler(this.workWithExBut_Click);
            // 
            // SettingsBut
            // 
            this.SettingsBut.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBut.BackgroundImage = global::BESEDa.Properties.Resources.button;
            this.SettingsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBut.FlatAppearance.BorderSize = 0;
            this.SettingsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBut.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBut.ForeColor = System.Drawing.Color.White;
            this.SettingsBut.Location = new System.Drawing.Point(243, 91);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(109, 34);
            this.SettingsBut.TabIndex = 19;
            this.SettingsBut.Text = "Настройка";
            this.SettingsBut.UseVisualStyleBackColor = false;
            this.SettingsBut.Click += new System.EventHandler(this.SettingsBut_Click);
            // 
            // controlAccountsBut
            // 
            this.controlAccountsBut.BackColor = System.Drawing.Color.Transparent;
            this.controlAccountsBut.BackgroundImage = global::BESEDa.Properties.Resources.button;
            this.controlAccountsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.controlAccountsBut.FlatAppearance.BorderSize = 0;
            this.controlAccountsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlAccountsBut.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlAccountsBut.ForeColor = System.Drawing.Color.White;
            this.controlAccountsBut.Location = new System.Drawing.Point(243, 27);
            this.controlAccountsBut.Name = "controlAccountsBut";
            this.controlAccountsBut.Size = new System.Drawing.Size(222, 61);
            this.controlAccountsBut.TabIndex = 18;
            this.controlAccountsBut.Text = "Управление\r\nучетными записями";
            this.controlAccountsBut.UseVisualStyleBackColor = false;
            this.controlAccountsBut.Click += new System.EventHandler(this.controlAccountsBut_Click);
            // 
            // amountOfExBox
            // 
            this.amountOfExBox.BackColor = System.Drawing.Color.White;
            this.amountOfExBox.Enabled = false;
            this.amountOfExBox.Location = new System.Drawing.Point(170, 103);
            this.amountOfExBox.Name = "amountOfExBox";
            this.amountOfExBox.ReadOnly = true;
            this.amountOfExBox.Size = new System.Drawing.Size(58, 20);
            this.amountOfExBox.TabIndex = 17;
            // 
            // amountOfTrainBox
            // 
            this.amountOfTrainBox.BackColor = System.Drawing.Color.White;
            this.amountOfTrainBox.Enabled = false;
            this.amountOfTrainBox.Location = new System.Drawing.Point(170, 69);
            this.amountOfTrainBox.Name = "amountOfTrainBox";
            this.amountOfTrainBox.ReadOnly = true;
            this.amountOfTrainBox.Size = new System.Drawing.Size(58, 20);
            this.amountOfTrainBox.TabIndex = 16;
            // 
            // amoutOfUsersBox
            // 
            this.amoutOfUsersBox.BackColor = System.Drawing.Color.White;
            this.amoutOfUsersBox.Enabled = false;
            this.amoutOfUsersBox.Location = new System.Drawing.Point(170, 37);
            this.amoutOfUsersBox.Name = "amoutOfUsersBox";
            this.amoutOfUsersBox.ReadOnly = true;
            this.amoutOfUsersBox.Size = new System.Drawing.Size(58, 20);
            this.amoutOfUsersBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Упражнений в системе:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainLabel
            // 
            this.TrainLabel.BackColor = System.Drawing.Color.White;
            this.TrainLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainLabel.Location = new System.Drawing.Point(9, 69);
            this.TrainLabel.Name = "TrainLabel";
            this.TrainLabel.Size = new System.Drawing.Size(152, 20);
            this.TrainLabel.TabIndex = 13;
            this.TrainLabel.Text = "Пройдено тренировок:";
            this.TrainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersLabel
            // 
            this.usersLabel.BackColor = System.Drawing.Color.White;
            this.usersLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersLabel.Location = new System.Drawing.Point(8, 37);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(152, 20);
            this.usersLabel.TabIndex = 12;
            this.usersLabel.Text = "Количество обучаемых:";
            this.usersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.выToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.выToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
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
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 131);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.workWithExBut);
            this.Controls.Add(this.SettingsBut);
            this.Controls.Add(this.controlAccountsBut);
            this.Controls.Add(this.amountOfExBox);
            this.Controls.Add(this.amountOfTrainBox);
            this.Controls.Add(this.amoutOfUsersBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainLabel);
            this.Controls.Add(this.usersLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button workWithExBut;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.Button controlAccountsBut;
        private System.Windows.Forms.TextBox amountOfExBox;
        private System.Windows.Forms.TextBox amountOfTrainBox;
        private System.Windows.Forms.TextBox amoutOfUsersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TrainLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}