namespace Schoolboy
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.TLP_2 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Ranked_LB = new System.Windows.Forms.Label();
            this.Averagerating_LB = new System.Windows.Forms.Label();
            this.Update_B = new System.Windows.Forms.Button();
            this.Class_LB = new System.Windows.Forms.Label();
            this.Add_B = new System.Windows.Forms.Button();
            this.Name_LB = new System.Windows.Forms.Label();
            this.Ranked_TB = new System.Windows.Forms.TextBox();
            this.Class_TB = new System.Windows.Forms.TextBox();
            this.Middlename_TB = new System.Windows.Forms.TextBox();
            this.Age_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.Middlename_LB = new System.Windows.Forms.Label();
            this.Averagerating_TB = new System.Windows.Forms.TextBox();
            this.Age_LB = new System.Windows.Forms.Label();
            this.Surname_LB = new System.Windows.Forms.Label();
            this.Data_LB_School = new System.Windows.Forms.Label();
            this.Spisok_LB_school = new System.Windows.Forms.Label();
            this.TLP_1.SuspendLayout();
            this.TLP_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_1
            // 
            this.TLP_1.BackColor = System.Drawing.Color.OldLace;
            this.TLP_1.ColumnCount = 2;
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP_1.Controls.Add(this.Spisok_LB, 0, 1);
            this.TLP_1.Controls.Add(this.TLP_2, 1, 1);
            this.TLP_1.Controls.Add(this.Data_LB_School, 1, 0);
            this.TLP_1.Controls.Add(this.Spisok_LB_school, 0, 0);
            this.TLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLP_1.Location = new System.Drawing.Point(0, 0);
            this.TLP_1.Name = "TLP_1";
            this.TLP_1.RowCount = 2;
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_1.Size = new System.Drawing.Size(954, 536);
            this.TLP_1.TabIndex = 0;
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.BackColor = System.Drawing.Color.FloralWhite;
            this.Spisok_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spisok_LB.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.ItemHeight = 16;
            this.Spisok_LB.Location = new System.Drawing.Point(5, 55);
            this.Spisok_LB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(657, 476);
            this.Spisok_LB.TabIndex = 2;
            this.Spisok_LB.SelectedValueChanged += new System.EventHandler(this.Spisok_LB_SelectedValueChanged);
            // 
            // TLP_2
            // 
            this.TLP_2.BackColor = System.Drawing.Color.OldLace;
            this.TLP_2.ColumnCount = 2;
            this.TLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.TLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_2.Controls.Add(this.Exit_B, 0, 11);
            this.TLP_2.Controls.Add(this.Del_B, 0, 9);
            this.TLP_2.Controls.Add(this.Ranked_LB, 0, 6);
            this.TLP_2.Controls.Add(this.Averagerating_LB, 0, 0);
            this.TLP_2.Controls.Add(this.Update_B, 0, 8);
            this.TLP_2.Controls.Add(this.Class_LB, 0, 5);
            this.TLP_2.Controls.Add(this.Add_B, 0, 7);
            this.TLP_2.Controls.Add(this.Name_LB, 0, 2);
            this.TLP_2.Controls.Add(this.Ranked_TB, 1, 6);
            this.TLP_2.Controls.Add(this.Class_TB, 1, 5);
            this.TLP_2.Controls.Add(this.Middlename_TB, 1, 4);
            this.TLP_2.Controls.Add(this.Age_TB, 1, 1);
            this.TLP_2.Controls.Add(this.Name_TB, 1, 2);
            this.TLP_2.Controls.Add(this.Surname_TB, 1, 3);
            this.TLP_2.Controls.Add(this.Middlename_LB, 0, 4);
            this.TLP_2.Controls.Add(this.Averagerating_TB, 1, 0);
            this.TLP_2.Controls.Add(this.Age_LB, 0, 1);
            this.TLP_2.Controls.Add(this.Surname_LB, 0, 3);
            this.TLP_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_2.Location = new System.Drawing.Point(667, 55);
            this.TLP_2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.TLP_2.Name = "TLP_2";
            this.TLP_2.RowCount = 12;
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_2.Size = new System.Drawing.Size(287, 476);
            this.TLP_2.TabIndex = 23;
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLP_2.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.Location = new System.Drawing.Point(0, 437);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(282, 34);
            this.Exit_B.TabIndex = 20;
            this.Exit_B.Text = "&Выход";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLP_2.SetColumnSpan(this.Del_B, 2);
            this.Del_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del_B.Location = new System.Drawing.Point(0, 267);
            this.Del_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(282, 34);
            this.Del_B.TabIndex = 19;
            this.Del_B.Text = "&Удалить";
            this.Del_B.UseVisualStyleBackColor = false;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Ranked_LB
            // 
            this.Ranked_LB.AutoSize = true;
            this.Ranked_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ranked_LB.Location = new System.Drawing.Point(0, 162);
            this.Ranked_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Ranked_LB.Name = "Ranked_LB";
            this.Ranked_LB.Size = new System.Drawing.Size(118, 22);
            this.Ranked_LB.TabIndex = 15;
            this.Ranked_LB.Text = "Занятое место";
            // 
            // Averagerating_LB
            // 
            this.Averagerating_LB.AutoSize = true;
            this.Averagerating_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Averagerating_LB.Location = new System.Drawing.Point(0, 0);
            this.Averagerating_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Averagerating_LB.Name = "Averagerating_LB";
            this.Averagerating_LB.Size = new System.Drawing.Size(118, 22);
            this.Averagerating_LB.TabIndex = 3;
            this.Averagerating_LB.Text = "Средняя оценка";
            // 
            // Update_B
            // 
            this.Update_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLP_2.SetColumnSpan(this.Update_B, 2);
            this.Update_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_B.Location = new System.Drawing.Point(0, 228);
            this.Update_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(282, 34);
            this.Update_B.TabIndex = 18;
            this.Update_B.Text = "&Изменить";
            this.Update_B.UseVisualStyleBackColor = false;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Class_LB
            // 
            this.Class_LB.AutoSize = true;
            this.Class_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Class_LB.Location = new System.Drawing.Point(0, 135);
            this.Class_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Class_LB.Name = "Class_LB";
            this.Class_LB.Size = new System.Drawing.Size(118, 22);
            this.Class_LB.TabIndex = 13;
            this.Class_LB.Text = "Класс";
            // 
            // Add_B
            // 
            this.Add_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLP_2.SetColumnSpan(this.Add_B, 2);
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Location = new System.Drawing.Point(0, 189);
            this.Add_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(282, 34);
            this.Add_B.TabIndex = 17;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = false;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Name_LB
            // 
            this.Name_LB.AutoSize = true;
            this.Name_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_LB.Location = new System.Drawing.Point(0, 54);
            this.Name_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_LB.Name = "Name_LB";
            this.Name_LB.Size = new System.Drawing.Size(118, 22);
            this.Name_LB.TabIndex = 7;
            this.Name_LB.Text = "Имя";
            // 
            // Ranked_TB
            // 
            this.Ranked_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Ranked_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ranked_TB.Location = new System.Drawing.Point(123, 162);
            this.Ranked_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Ranked_TB.Name = "Ranked_TB";
            this.Ranked_TB.ReadOnly = true;
            this.Ranked_TB.Size = new System.Drawing.Size(159, 22);
            this.Ranked_TB.TabIndex = 16;
            // 
            // Class_TB
            // 
            this.Class_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Class_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Class_TB.Location = new System.Drawing.Point(123, 135);
            this.Class_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Class_TB.Name = "Class_TB";
            this.Class_TB.ReadOnly = true;
            this.Class_TB.Size = new System.Drawing.Size(159, 22);
            this.Class_TB.TabIndex = 14;
            // 
            // Middlename_TB
            // 
            this.Middlename_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Middlename_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middlename_TB.Location = new System.Drawing.Point(123, 108);
            this.Middlename_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Middlename_TB.Name = "Middlename_TB";
            this.Middlename_TB.ReadOnly = true;
            this.Middlename_TB.Size = new System.Drawing.Size(159, 22);
            this.Middlename_TB.TabIndex = 12;
            // 
            // Age_TB
            // 
            this.Age_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Age_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_TB.Location = new System.Drawing.Point(123, 27);
            this.Age_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Age_TB.Name = "Age_TB";
            this.Age_TB.ReadOnly = true;
            this.Age_TB.Size = new System.Drawing.Size(159, 22);
            this.Age_TB.TabIndex = 6;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(123, 54);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(159, 22);
            this.Name_TB.TabIndex = 8;
            // 
            // Surname_TB
            // 
            this.Surname_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Surname_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surname_TB.Location = new System.Drawing.Point(123, 81);
            this.Surname_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.ReadOnly = true;
            this.Surname_TB.Size = new System.Drawing.Size(159, 22);
            this.Surname_TB.TabIndex = 10;
            // 
            // Middlename_LB
            // 
            this.Middlename_LB.AutoSize = true;
            this.Middlename_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middlename_LB.Location = new System.Drawing.Point(0, 108);
            this.Middlename_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Middlename_LB.Name = "Middlename_LB";
            this.Middlename_LB.Size = new System.Drawing.Size(118, 22);
            this.Middlename_LB.TabIndex = 11;
            this.Middlename_LB.Text = "Отчество";
            // 
            // Averagerating_TB
            // 
            this.Averagerating_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.Averagerating_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Averagerating_TB.Location = new System.Drawing.Point(123, 0);
            this.Averagerating_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Averagerating_TB.Name = "Averagerating_TB";
            this.Averagerating_TB.ReadOnly = true;
            this.Averagerating_TB.Size = new System.Drawing.Size(159, 22);
            this.Averagerating_TB.TabIndex = 4;
            // 
            // Age_LB
            // 
            this.Age_LB.AutoSize = true;
            this.Age_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_LB.Location = new System.Drawing.Point(0, 27);
            this.Age_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Age_LB.Name = "Age_LB";
            this.Age_LB.Size = new System.Drawing.Size(118, 22);
            this.Age_LB.TabIndex = 5;
            this.Age_LB.Text = "Количество лет";
            // 
            // Surname_LB
            // 
            this.Surname_LB.AutoSize = true;
            this.Surname_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surname_LB.Location = new System.Drawing.Point(0, 81);
            this.Surname_LB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Surname_LB.Name = "Surname_LB";
            this.Surname_LB.Size = new System.Drawing.Size(118, 22);
            this.Surname_LB.TabIndex = 9;
            this.Surname_LB.Text = "Фамилия";
            // 
            // Data_LB_School
            // 
            this.Data_LB_School.AutoSize = true;
            this.Data_LB_School.BackColor = System.Drawing.Color.Tan;
            this.Data_LB_School.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_LB_School.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_LB_School.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Data_LB_School.Location = new System.Drawing.Point(667, 5);
            this.Data_LB_School.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.Data_LB_School.Name = "Data_LB_School";
            this.Data_LB_School.Size = new System.Drawing.Size(282, 45);
            this.Data_LB_School.TabIndex = 1;
            this.Data_LB_School.Text = "Данные о школьнике";
            this.Data_LB_School.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spisok_LB_school
            // 
            this.Spisok_LB_school.AutoSize = true;
            this.Spisok_LB_school.BackColor = System.Drawing.Color.Tan;
            this.Spisok_LB_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spisok_LB_school.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spisok_LB_school.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spisok_LB_school.Location = new System.Drawing.Point(5, 5);
            this.Spisok_LB_school.Margin = new System.Windows.Forms.Padding(5);
            this.Spisok_LB_school.Name = "Spisok_LB_school";
            this.Spisok_LB_school.Size = new System.Drawing.Size(657, 45);
            this.Spisok_LB_school.TabIndex = 0;
            this.Spisok_LB_school.Text = "Список школьников";
            this.Spisok_LB_school.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.TLP_1);
            this.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(970, 575);
            this.Name = "Main";
            this.Text = "Список моделей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TLP_1.ResumeLayout(false);
            this.TLP_1.PerformLayout();
            this.TLP_2.ResumeLayout(false);
            this.TLP_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_1;
        private System.Windows.Forms.ListBox Spisok_LB;
        private System.Windows.Forms.Label Data_LB_School;
        private System.Windows.Forms.Label Spisok_LB_school;
        private System.Windows.Forms.TableLayoutPanel TLP_2;
        private System.Windows.Forms.Label Ranked_LB;
        private System.Windows.Forms.Label Averagerating_LB;
        private System.Windows.Forms.Label Class_LB;
        private System.Windows.Forms.Label Name_LB;
        private System.Windows.Forms.Label Middlename_LB;
        private System.Windows.Forms.Label Age_LB;
        private System.Windows.Forms.Label Surname_LB;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.TextBox Ranked_TB;
        private System.Windows.Forms.TextBox Class_TB;
        private System.Windows.Forms.TextBox Middlename_TB;
        private System.Windows.Forms.TextBox Age_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Surname_TB;
        private System.Windows.Forms.TextBox Averagerating_TB;
    }
}

