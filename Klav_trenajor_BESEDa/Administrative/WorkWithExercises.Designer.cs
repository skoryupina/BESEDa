﻿namespace BESEDa.Administrative
{
    partial class WorkWithExercises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithExercises));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOfExercises = new System.Windows.Forms.DataGridView();
            this.filterGB = new System.Windows.Forms.GroupBox();
            this.zone2CB = new System.Windows.Forms.CheckBox();
            this.zone3CB = new System.Windows.Forms.CheckBox();
            this.zone4CB = new System.Windows.Forms.CheckBox();
            this.zone1CB = new System.Windows.Forms.CheckBox();
            this.byKeyboardZoneRB = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.byLevelRB = new System.Windows.Forms.RadioButton();
            this.allExercisesRBut = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfExercises)).BeginInit();
            this.filterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.добавитьToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.редактироватьToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.статистикаToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.groupBox1.Controls.Add(this.listOfExercises);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список упражнений";
            // 
            // listOfExercises
            // 
            this.listOfExercises.AllowUserToAddRows = false;
            this.listOfExercises.AllowUserToDeleteRows = false;
            this.listOfExercises.AllowUserToResizeColumns = false;
            this.listOfExercises.AllowUserToResizeRows = false;
            this.listOfExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfExercises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listOfExercises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.listOfExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfExercises.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.listOfExercises.Location = new System.Drawing.Point(6, 19);
            this.listOfExercises.MultiSelect = false;
            this.listOfExercises.Name = "listOfExercises";
            this.listOfExercises.ReadOnly = true;
            this.listOfExercises.RowHeadersVisible = false;
            this.listOfExercises.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfExercises.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listOfExercises.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.listOfExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfExercises.Size = new System.Drawing.Size(528, 188);
            this.listOfExercises.TabIndex = 1;
            // 
            // filterGB
            // 
            this.filterGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.filterGB.Controls.Add(this.zone2CB);
            this.filterGB.Controls.Add(this.zone3CB);
            this.filterGB.Controls.Add(this.zone4CB);
            this.filterGB.Controls.Add(this.zone1CB);
            this.filterGB.Controls.Add(this.byKeyboardZoneRB);
            this.filterGB.Controls.Add(this.numericUpDown1);
            this.filterGB.Controls.Add(this.byLevelRB);
            this.filterGB.Controls.Add(this.allExercisesRBut);
            this.filterGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterGB.ForeColor = System.Drawing.Color.White;
            this.filterGB.Location = new System.Drawing.Point(12, 27);
            this.filterGB.Name = "filterGB";
            this.filterGB.Size = new System.Drawing.Size(540, 49);
            this.filterGB.TabIndex = 3;
            this.filterGB.TabStop = false;
            this.filterGB.Text = "Фильтр";
            // 
            // zone2CB
            // 
            this.zone2CB.AutoSize = true;
            this.zone2CB.Location = new System.Drawing.Point(428, 21);
            this.zone2CB.Name = "zone2CB";
            this.zone2CB.Size = new System.Drawing.Size(33, 17);
            this.zone2CB.TabIndex = 7;
            this.zone2CB.Text = "2";
            this.zone2CB.UseVisualStyleBackColor = true;
            this.zone2CB.CheckedChanged += new System.EventHandler(this.zone2CB_CheckedChanged);
            // 
            // zone3CB
            // 
            this.zone3CB.AutoSize = true;
            this.zone3CB.Location = new System.Drawing.Point(464, 21);
            this.zone3CB.Name = "zone3CB";
            this.zone3CB.Size = new System.Drawing.Size(33, 17);
            this.zone3CB.TabIndex = 6;
            this.zone3CB.Text = "3";
            this.zone3CB.UseVisualStyleBackColor = true;
            this.zone3CB.CheckedChanged += new System.EventHandler(this.zone3CB_CheckedChanged);
            // 
            // zone4CB
            // 
            this.zone4CB.AutoSize = true;
            this.zone4CB.Location = new System.Drawing.Point(502, 21);
            this.zone4CB.Name = "zone4CB";
            this.zone4CB.Size = new System.Drawing.Size(33, 17);
            this.zone4CB.TabIndex = 5;
            this.zone4CB.Text = "4";
            this.zone4CB.UseVisualStyleBackColor = true;
            this.zone4CB.CheckedChanged += new System.EventHandler(this.zone4CB_CheckedChanged);
            // 
            // zone1CB
            // 
            this.zone1CB.AutoSize = true;
            this.zone1CB.Checked = true;
            this.zone1CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zone1CB.Location = new System.Drawing.Point(398, 21);
            this.zone1CB.Name = "zone1CB";
            this.zone1CB.Size = new System.Drawing.Size(33, 17);
            this.zone1CB.TabIndex = 4;
            this.zone1CB.Text = "1";
            this.zone1CB.UseVisualStyleBackColor = true;
            this.zone1CB.CheckedChanged += new System.EventHandler(this.zone1CB_CheckedChanged);
            // 
            // byKeyboardZoneRB
            // 
            this.byKeyboardZoneRB.AutoSize = true;
            this.byKeyboardZoneRB.Location = new System.Drawing.Point(253, 20);
            this.byKeyboardZoneRB.Name = "byKeyboardZoneRB";
            this.byKeyboardZoneRB.Size = new System.Drawing.Size(147, 17);
            this.byKeyboardZoneRB.TabIndex = 3;
            this.byKeyboardZoneRB.TabStop = true;
            this.byKeyboardZoneRB.Text = "По зоне клавиатуры";
            this.byKeyboardZoneRB.UseVisualStyleBackColor = true;
            this.byKeyboardZoneRB.CheckedChanged += new System.EventHandler(this.byKeyboardZoneRB_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // byLevelRB
            // 
            this.byLevelRB.AutoSize = true;
            this.byLevelRB.Location = new System.Drawing.Point(125, 19);
            this.byLevelRB.Name = "byLevelRB";
            this.byLevelRB.Size = new System.Drawing.Size(88, 17);
            this.byLevelRB.TabIndex = 1;
            this.byLevelRB.Text = "По уровню";
            this.byLevelRB.UseVisualStyleBackColor = true;
            this.byLevelRB.CheckedChanged += new System.EventHandler(this.byLevelRB_CheckedChanged);
            // 
            // allExercisesRBut
            // 
            this.allExercisesRBut.AutoSize = true;
            this.allExercisesRBut.Checked = true;
            this.allExercisesRBut.Location = new System.Drawing.Point(6, 19);
            this.allExercisesRBut.Name = "allExercisesRBut";
            this.allExercisesRBut.Size = new System.Drawing.Size(122, 17);
            this.allExercisesRBut.TabIndex = 0;
            this.allExercisesRBut.TabStop = true;
            this.allExercisesRBut.Text = "Все упражнения";
            this.allExercisesRBut.UseVisualStyleBackColor = true;
            this.allExercisesRBut.CheckedChanged += new System.EventHandler(this.allExercisesRBut_CheckedChanged);
            // 
            // WorkWithExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources._1277440441_woods4;
            this.ClientSize = new System.Drawing.Size(557, 302);
            this.Controls.Add(this.filterGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WorkWithExercises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с упражнениями";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkWithExercises_FormClosing);
            this.Load += new System.EventHandler(this.WorkWithExercises_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfExercises)).EndInit();
            this.filterGB.ResumeLayout(false);
            this.filterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listOfExercises;
        private System.Windows.Forms.GroupBox filterGB;
        private System.Windows.Forms.CheckBox zone2CB;
        private System.Windows.Forms.CheckBox zone3CB;
        private System.Windows.Forms.CheckBox zone4CB;
        private System.Windows.Forms.CheckBox zone1CB;
        private System.Windows.Forms.RadioButton byKeyboardZoneRB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton byLevelRB;
        private System.Windows.Forms.RadioButton allExercisesRBut;
    }
}