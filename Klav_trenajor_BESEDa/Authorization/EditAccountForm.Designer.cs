namespace BESEDa
{
    partial class EditAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccountForm));
            this.signInBox = new System.Windows.Forms.GroupBox();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.apprPasswordBox = new System.Windows.Forms.TextBox();
            this.apprPasswordLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.signInBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInBox
            // 
            this.signInBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.signInBox.Controls.Add(this.newPasswordBox);
            this.signInBox.Controls.Add(this.newPasswordLabel);
            this.signInBox.Controls.Add(this.apprPasswordBox);
            this.signInBox.Controls.Add(this.apprPasswordLabel);
            this.signInBox.Controls.Add(this.cancelButton);
            this.signInBox.Controls.Add(this.okButton);
            this.signInBox.Controls.Add(this.passwordBox);
            this.signInBox.Controls.Add(this.loginBox);
            this.signInBox.Controls.Add(this.passwordLabel);
            this.signInBox.Controls.Add(this.loginLabel);
            this.signInBox.ForeColor = System.Drawing.Color.White;
            this.signInBox.Location = new System.Drawing.Point(4, 5);
            this.signInBox.Name = "signInBox";
            this.signInBox.Size = new System.Drawing.Size(345, 153);
            this.signInBox.TabIndex = 2;
            this.signInBox.TabStop = false;
            this.signInBox.Text = "Введите новые данные учетной записи";
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(148, 76);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(184, 20);
            this.newPasswordBox.TabIndex = 9;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(11, 79);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(96, 13);
            this.newPasswordLabel.TabIndex = 8;
            this.newPasswordLabel.Text = "Новый пароль:";
            // 
            // apprPasswordBox
            // 
            this.apprPasswordBox.Location = new System.Drawing.Point(148, 100);
            this.apprPasswordBox.Name = "apprPasswordBox";
            this.apprPasswordBox.Size = new System.Drawing.Size(184, 20);
            this.apprPasswordBox.TabIndex = 7;
            // 
            // apprPasswordLabel
            // 
            this.apprPasswordLabel.AutoSize = true;
            this.apprPasswordLabel.Location = new System.Drawing.Point(11, 103);
            this.apprPasswordLabel.Name = "apprPasswordLabel";
            this.apprPasswordLabel.Size = new System.Drawing.Size(134, 13);
            this.apprPasswordLabel.TabIndex = 6;
            this.apprPasswordLabel.Text = "Подтвердите пароль:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(228, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okButton.BackgroundImage")));
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(120, 126);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Изменить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(148, 50);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(184, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(148, 24);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(184, 20);
            this.loginBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(109, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Текущий пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(11, 27);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources._1277440441_woods4;
            this.ClientSize = new System.Drawing.Size(353, 160);
            this.Controls.Add(this.signInBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование учетной записи";
            this.Load += new System.EventHandler(this.EditAccountForm_Load);
            this.signInBox.ResumeLayout(false);
            this.signInBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signInBox;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox apprPasswordBox;
        private System.Windows.Forms.Label apprPasswordLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}