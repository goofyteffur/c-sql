
using System;

namespace laba_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Услуга = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Цена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Услуга,
            this.Цена,
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(186, 380);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(823, 183);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Услуга
            // 
            this.Услуга.Text = "Номер Общежития";
            this.Услуга.Width = 384;
            // 
            // Цена
            // 
            this.Цена.Text = "Телефон";
            this.Цена.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Цена.Width = 189;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "График Работы";
            this.columnHeader1.Width = 396;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button12.BackgroundImage = global::laba_1.Properties.Resources._6i270ibows9d;
            this.button12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button12.Location = new System.Drawing.Point(12, 391);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(152, 155);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.UseWaitCursor = true;
            this.button12.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::laba_1.Properties.Resources.mP_PGglDw0w;
            this.pictureBox1.Location = new System.Drawing.Point(2, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 617);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 575);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Услуга;
        private System.Windows.Forms.ColumnHeader Цена;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

