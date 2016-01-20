namespace BESEDa.Administrative
{
    partial class EditExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExercise));
            this.textExer = new System.Windows.Forms.GroupBox();
            this.restSymbLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textExerRichTB = new System.Windows.Forms.RichTextBox();
            this.cancelBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.textBoxSymbols = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textExer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textExer
            // 
            this.textExer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.textExer.Controls.Add(this.restSymbLabel);
            this.textExer.Controls.Add(this.label1);
            this.textExer.Controls.Add(this.textExerRichTB);
            this.textExer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textExer.ForeColor = System.Drawing.Color.White;
            this.textExer.Location = new System.Drawing.Point(12, 12);
            this.textExer.Name = "textExer";
            this.textExer.Size = new System.Drawing.Size(358, 203);
            this.textExer.TabIndex = 17;
            this.textExer.TabStop = false;
            this.textExer.Text = "Текст упражнения";
            // 
            // restSymbLabel
            // 
            this.restSymbLabel.AutoSize = true;
            this.restSymbLabel.Location = new System.Drawing.Point(190, 182);
            this.restSymbLabel.Name = "restSymbLabel";
            this.restSymbLabel.Size = new System.Drawing.Size(28, 13);
            this.restSymbLabel.TabIndex = 2;
            this.restSymbLabel.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Осталось количество символов:";
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
            // cancelBut
            // 
            this.cancelBut.BackColor = System.Drawing.Color.Transparent;
            this.cancelBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBut.BackgroundImage")));
            this.cancelBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBut.FlatAppearance.BorderSize = 0;
            this.cancelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBut.ForeColor = System.Drawing.Color.White;
            this.cancelBut.Location = new System.Drawing.Point(256, 276);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(113, 23);
            this.cancelBut.TabIndex = 24;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = false;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.Color.Transparent;
            this.saveBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBut.BackgroundImage")));
            this.saveBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBut.FlatAppearance.BorderSize = 0;
            this.saveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.ForeColor = System.Drawing.Color.White;
            this.saveBut.Location = new System.Drawing.Point(138, 276);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(113, 23);
            this.saveBut.TabIndex = 23;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // textBoxSymbols
            // 
            this.textBoxSymbols.Location = new System.Drawing.Point(12, 236);
            this.textBoxSymbols.Multiline = true;
            this.textBoxSymbols.Name = "textBoxSymbols";
            this.textBoxSymbols.Size = new System.Drawing.Size(358, 34);
            this.textBoxSymbols.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(111)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Доступные символы на выбранном уровне:";
            // 
            // EditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BESEDa.Properties.Resources._1277440441_woods4;
            this.ClientSize = new System.Drawing.Size(381, 303);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.textBoxSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textExer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование упражнения";
            this.Load += new System.EventHandler(this.EditExercise_Load);
            this.textExer.ResumeLayout(false);
            this.textExer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox textExer;
        private System.Windows.Forms.RichTextBox textExerRichTB;
        private System.Windows.Forms.Label restSymbLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.TextBox textBoxSymbols;
        private System.Windows.Forms.Label label3;
    }
}