namespace BESEDa.Administrative
{
    partial class AddExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExercise));
            this.zone2CB = new System.Windows.Forms.CheckBox();
            this.zone3CB = new System.Windows.Forms.CheckBox();
            this.zone4CB = new System.Windows.Forms.CheckBox();
            this.zone1CB = new System.Windows.Forms.CheckBox();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.textExer = new System.Windows.Forms.GroupBox();
            this.restSymbLabel = new System.Windows.Forms.Label();
            this.textExerRichTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSymbols = new System.Windows.Forms.TextBox();
            this.saveBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.textExer.SuspendLayout();
            this.SuspendLayout();
            // 
            // zone2CB
            // 
            this.zone2CB.AutoSize = true;
            this.zone2CB.Location = new System.Drawing.Point(111, 49);
            this.zone2CB.Name = "zone2CB";
            this.zone2CB.Size = new System.Drawing.Size(33, 17);
            this.zone2CB.TabIndex = 12;
            this.zone2CB.Text = "2";
            this.zone2CB.UseVisualStyleBackColor = true;
            this.zone2CB.CheckedChanged += new System.EventHandler(this.zone2CB_CheckedChanged);
            // 
            // zone3CB
            // 
            this.zone3CB.AutoSize = true;
            this.zone3CB.Location = new System.Drawing.Point(147, 49);
            this.zone3CB.Name = "zone3CB";
            this.zone3CB.Size = new System.Drawing.Size(33, 17);
            this.zone3CB.TabIndex = 11;
            this.zone3CB.Text = "3";
            this.zone3CB.UseVisualStyleBackColor = true;
            this.zone3CB.CheckedChanged += new System.EventHandler(this.zone3CB_CheckedChanged);
            // 
            // zone4CB
            // 
            this.zone4CB.AutoSize = true;
            this.zone4CB.Location = new System.Drawing.Point(185, 49);
            this.zone4CB.Name = "zone4CB";
            this.zone4CB.Size = new System.Drawing.Size(33, 17);
            this.zone4CB.TabIndex = 10;
            this.zone4CB.Text = "4";
            this.zone4CB.UseVisualStyleBackColor = true;
            this.zone4CB.CheckedChanged += new System.EventHandler(this.zone4CB_CheckedChanged);
            // 
            // zone1CB
            // 
            this.zone1CB.AutoSize = true;
            this.zone1CB.Checked = true;
            this.zone1CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zone1CB.Location = new System.Drawing.Point(81, 49);
            this.zone1CB.Name = "zone1CB";
            this.zone1CB.Size = new System.Drawing.Size(33, 17);
            this.zone1CB.TabIndex = 9;
            this.zone1CB.Text = "1";
            this.zone1CB.UseVisualStyleBackColor = true;
            this.zone1CB.CheckedChanged += new System.EventHandler(this.zone1CB_CheckedChanged);
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownLevel.Location = new System.Drawing.Point(81, 23);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.ReadOnly = true;
            this.numericUpDownLevel.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownLevel.TabIndex = 8;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.ValueChanged += new System.EventHandler(this.numericUpDownLevel_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Уровень:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zone2CB);
            this.groupBox1.Controls.Add(this.numericUpDownLevel);
            this.groupBox1.Controls.Add(this.zone3CB);
            this.groupBox1.Controls.Add(this.zone1CB);
            this.groupBox1.Controls.Add(this.zone4CB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры упражнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Зоны:";
            // 
            // genButton
            // 
            this.genButton.BackColor = System.Drawing.Color.Transparent;
            this.genButton.BackgroundImage = global::BESEDa.Properties.Resources.button;
            this.genButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genButton.FlatAppearance.BorderSize = 0;
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genButton.ForeColor = System.Drawing.Color.White;
            this.genButton.Location = new System.Drawing.Point(242, 12);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(137, 79);
            this.genButton.TabIndex = 15;
            this.genButton.Text = "Сгенерировать автоматически";
            this.genButton.UseVisualStyleBackColor = false;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // textExer
            // 
            this.textExer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.textExer.Controls.Add(this.restSymbLabel);
            this.textExer.Controls.Add(this.textExerRichTB);
            this.textExer.Controls.Add(this.label4);
            this.textExer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textExer.ForeColor = System.Drawing.Color.White;
            this.textExer.Location = new System.Drawing.Point(12, 97);
            this.textExer.Name = "textExer";
            this.textExer.Size = new System.Drawing.Size(358, 206);
            this.textExer.TabIndex = 16;
            this.textExer.TabStop = false;
            this.textExer.Text = "Текст упражнения";
            // 
            // restSymbLabel
            // 
            this.restSymbLabel.AutoSize = true;
            this.restSymbLabel.Location = new System.Drawing.Point(213, 181);
            this.restSymbLabel.Name = "restSymbLabel";
            this.restSymbLabel.Size = new System.Drawing.Size(28, 13);
            this.restSymbLabel.TabIndex = 22;
            this.restSymbLabel.Text = "200";
            // 
            // textExerRichTB
            // 
            this.textExerRichTB.Location = new System.Drawing.Point(11, 19);
            this.textExerRichTB.MaxLength = 200;
            this.textExerRichTB.Name = "textExerRichTB";
            this.textExerRichTB.Size = new System.Drawing.Size(333, 159);
            this.textExerRichTB.TabIndex = 0;
            this.textExerRichTB.Text = "";
            this.textExerRichTB.TextChanged += new System.EventHandler(this.textExerRichTB_TextChanged);
            this.textExerRichTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textExerRichTB_KeyDown);
            this.textExerRichTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textExerRichTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Осталось количество символов:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Доступные символы на выбранном уровне:";
            // 
            // textBoxSymbols
            // 
            this.textBoxSymbols.Location = new System.Drawing.Point(12, 326);
            this.textBoxSymbols.Multiline = true;
            this.textBoxSymbols.Name = "textBoxSymbols";
            this.textBoxSymbols.Size = new System.Drawing.Size(358, 38);
            this.textBoxSymbols.TabIndex = 18;
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.Color.Transparent;
            this.saveBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBut.BackgroundImage")));
            this.saveBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBut.FlatAppearance.BorderSize = 0;
            this.saveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBut.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.ForeColor = System.Drawing.Color.White;
            this.saveBut.Location = new System.Drawing.Point(136, 368);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(113, 23);
            this.saveBut.TabIndex = 19;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.BackColor = System.Drawing.Color.Transparent;
            this.cancelBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBut.BackgroundImage")));
            this.cancelBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBut.FlatAppearance.BorderSize = 0;
            this.cancelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBut.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBut.ForeColor = System.Drawing.Color.White;
            this.cancelBut.Location = new System.Drawing.Point(255, 368);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(113, 23);
            this.cancelBut.TabIndex = 20;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = false;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources._1277440441_woods4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 395);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.textBoxSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textExer);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить упражнение";
            this.Load += new System.EventHandler(this.AddExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.textExer.ResumeLayout(false);
            this.textExer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zone2CB;
        private System.Windows.Forms.CheckBox zone3CB;
        private System.Windows.Forms.CheckBox zone4CB;
        private System.Windows.Forms.CheckBox zone1CB;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.GroupBox textExer;
        private System.Windows.Forms.RichTextBox textExerRichTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSymbols;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Label restSymbLabel;
        private System.Windows.Forms.Label label4;
    }
}