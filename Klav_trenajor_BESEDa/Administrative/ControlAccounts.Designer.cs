namespace BESEDa
{
    partial class ControlAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAccounts));
            this.listOfUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.distrExercisesOfUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.distrMistakesOfUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.listOfUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distrExercisesOfUsers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distrMistakesOfUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfUsers
            // 
            this.listOfUsers.AllowUserToAddRows = false;
            this.listOfUsers.AllowUserToDeleteRows = false;
            this.listOfUsers.AllowUserToResizeColumns = false;
            this.listOfUsers.AllowUserToResizeRows = false;
            this.listOfUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listOfUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.listOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listOfUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.listOfUsers.Location = new System.Drawing.Point(6, 19);
            this.listOfUsers.MultiSelect = false;
            this.listOfUsers.Name = "listOfUsers";
            this.listOfUsers.ReadOnly = true;
            this.listOfUsers.RowHeadersVisible = false;
            this.listOfUsers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.listOfUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listOfUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.listOfUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfUsers.Size = new System.Drawing.Size(492, 207);
            this.listOfUsers.TabIndex = 0;
            this.listOfUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfUsers_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.groupBox1.Controls.Add(this.listOfUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите пользователя для просмотра статистики или удаления";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выToolStripMenuItem,
            this.открытьСтатистикуToolStripMenuItem,
            this.удалитьПользователяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            // открытьСтатистикуToolStripMenuItem
            // 
            this.открытьСтатистикуToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.открытьСтатистикуToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.открытьСтатистикуToolStripMenuItem.Name = "открытьСтатистикуToolStripMenuItem";
            this.открытьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.открытьСтатистикуToolStripMenuItem.Text = "Открыть статистику";
            this.открытьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.открытьСтатистикуToolStripMenuItem_Click);
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            this.удалитьПользователяToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.удалитьПользователяToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            this.удалитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            this.удалитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.удалитьПользователяToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.groupBox2.Controls.Add(this.distrExercisesOfUsers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Распределение упражнений, пройденных пользователями";
            // 
            // distrExercisesOfUsers
            // 
            this.distrExercisesOfUsers.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.distrExercisesOfUsers.ChartAreas.Add(chartArea1);
            this.distrExercisesOfUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.distrExercisesOfUsers.Legends.Add(legend1);
            this.distrExercisesOfUsers.Location = new System.Drawing.Point(3, 55);
            this.distrExercisesOfUsers.Name = "distrExercisesOfUsers";
            this.distrExercisesOfUsers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series0";
            this.distrExercisesOfUsers.Series.Add(series1);
            this.distrExercisesOfUsers.Size = new System.Drawing.Size(239, 118);
            this.distrExercisesOfUsers.TabIndex = 1;
            this.distrExercisesOfUsers.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.groupBox3.Controls.Add(this.distrMistakesOfUsers);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(263, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 176);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Распределение суммарного числа ошибок, допущенных пользователями";
            // 
            // distrMistakesOfUsers
            // 
            this.distrMistakesOfUsers.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.distrMistakesOfUsers.ChartAreas.Add(chartArea2);
            this.distrMistakesOfUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.distrMistakesOfUsers.Legends.Add(legend2);
            this.distrMistakesOfUsers.Location = new System.Drawing.Point(3, 55);
            this.distrMistakesOfUsers.Name = "distrMistakesOfUsers";
            this.distrMistakesOfUsers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series0";
            this.distrMistakesOfUsers.Series.Add(series2);
            this.distrMistakesOfUsers.Size = new System.Drawing.Size(247, 118);
            this.distrMistakesOfUsers.TabIndex = 2;
            this.distrMistakesOfUsers.Text = "chart1";
            // 
            // ControlAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources._1277440441_woods4;
            this.ClientSize = new System.Drawing.Size(521, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление учетными записями";
            this.Load += new System.EventHandler(this.ControlAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distrExercisesOfUsers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distrMistakesOfUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart distrExercisesOfUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart distrMistakesOfUsers;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

