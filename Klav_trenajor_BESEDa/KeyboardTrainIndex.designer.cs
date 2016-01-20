namespace BESEDa
{
    partial class KeyboardTrainIndex
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardTrainIndex));
            this.signInBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxEmblem = new System.Windows.Forms.PictureBox();
            this.signInBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // signInBox
            // 
            this.signInBox.BackColor = System.Drawing.Color.Transparent;
            this.signInBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInBox.BackgroundImage")));
            this.signInBox.Controls.Add(this.okButton);
            this.signInBox.Controls.Add(this.signUpButton);
            this.signInBox.Controls.Add(this.passwordBox);
            this.signInBox.Controls.Add(this.loginBox);
            this.signInBox.Controls.Add(this.passwordLabel);
            this.signInBox.Controls.Add(this.loginLabel);
            this.signInBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBox.ForeColor = System.Drawing.Color.SeaShell;
            this.signInBox.Location = new System.Drawing.Point(183, 48);
            this.signInBox.Name = "signInBox";
            this.signInBox.Size = new System.Drawing.Size(247, 131);
            this.signInBox.TabIndex = 0;
            this.signInBox.TabStop = false;
            this.signInBox.Text = "Авторизация";
            // 
            // okButton
            // 
            this.okButton.BackgroundImage = global::BESEDa.Properties.Resources.Enter;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButton.Location = new System.Drawing.Point(136, 81);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 35);
            this.okButton.TabIndex = 5;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackgroundImage = global::BESEDa.Properties.Resources.Registration;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signUpButton.Location = new System.Drawing.Point(10, 81);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(118, 35);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(82, 50);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(151, 21);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "Sara";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(82, 22);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(151, 21);
            this.loginBox.TabIndex = 2;
            this.loginBox.Text = "Sara";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(13, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(13, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 18);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmblem.BackgroundImage = global::BESEDa.Properties.Resources.Эмблема;
            this.pictureBoxEmblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEmblem.Location = new System.Drawing.Point(2, 26);
            this.pictureBoxEmblem.Name = "pictureBoxEmblem";
            this.pictureBoxEmblem.Size = new System.Drawing.Size(175, 178);
            this.pictureBoxEmblem.TabIndex = 2;
            this.pictureBoxEmblem.TabStop = false;
            // 
            // KeyboardTrainIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BESEDa.Properties.Resources.b448eP8faO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 204);
            this.Controls.Add(this.pictureBoxEmblem);
            this.Controls.Add(this.signInBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "KeyboardTrainIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клавиатурный тренажер \"БЕСЕДа\"";
            this.signInBox.ResumeLayout(false);
            this.signInBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signInBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxEmblem;
    }
}

