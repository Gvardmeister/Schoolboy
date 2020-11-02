namespace Schoolboy
{
    partial class Modification
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
            this.Spisok_LB_school = new System.Windows.Forms.Label();
            this.Age_LB = new System.Windows.Forms.Label();
            this.Averagerating_LB = new System.Windows.Forms.Label();
            this.Name_LB = new System.Windows.Forms.Label();
            this.Surname_LB = new System.Windows.Forms.Label();
            this.Middlename_LB = new System.Windows.Forms.Label();
            this.Class_LB = new System.Windows.Forms.Label();
            this.Save_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Class_TB = new System.Windows.Forms.TextBox();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.Age_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Averagerating_TB = new System.Windows.Forms.TextBox();
            this.Ranked_TB = new System.Windows.Forms.TextBox();
            this.Middlename_TB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ranked_LB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_LB_school
            // 
            this.Spisok_LB_school.AutoSize = true;
            this.Spisok_LB_school.BackColor = System.Drawing.Color.Tan;
            this.tableLayoutPanel1.SetColumnSpan(this.Spisok_LB_school, 4);
            this.Spisok_LB_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spisok_LB_school.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spisok_LB_school.Location = new System.Drawing.Point(3, 0);
            this.Spisok_LB_school.Name = "Spisok_LB_school";
            this.Spisok_LB_school.Size = new System.Drawing.Size(516, 55);
            this.Spisok_LB_school.TabIndex = 0;
            this.Spisok_LB_school.Text = "Список школьников";
            this.Spisok_LB_school.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Age_LB
            // 
            this.Age_LB.AutoSize = true;
            this.Age_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_LB.Location = new System.Drawing.Point(3, 85);
            this.Age_LB.Name = "Age_LB";
            this.Age_LB.Size = new System.Drawing.Size(113, 30);
            this.Age_LB.TabIndex = 3;
            this.Age_LB.Text = "Количество лет";
            // 
            // Averagerating_LB
            // 
            this.Averagerating_LB.AutoSize = true;
            this.Averagerating_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Averagerating_LB.Location = new System.Drawing.Point(3, 55);
            this.Averagerating_LB.Name = "Averagerating_LB";
            this.Averagerating_LB.Size = new System.Drawing.Size(113, 30);
            this.Averagerating_LB.TabIndex = 1;
            this.Averagerating_LB.Text = "Средняя оценка";
            // 
            // Name_LB
            // 
            this.Name_LB.AutoSize = true;
            this.Name_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_LB.Location = new System.Drawing.Point(3, 115);
            this.Name_LB.Name = "Name_LB";
            this.Name_LB.Size = new System.Drawing.Size(113, 30);
            this.Name_LB.TabIndex = 5;
            this.Name_LB.Text = "Имя";
            // 
            // Surname_LB
            // 
            this.Surname_LB.AutoSize = true;
            this.Surname_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surname_LB.Location = new System.Drawing.Point(3, 145);
            this.Surname_LB.Name = "Surname_LB";
            this.Surname_LB.Size = new System.Drawing.Size(113, 30);
            this.Surname_LB.TabIndex = 7;
            this.Surname_LB.Text = "Фамилия";
            // 
            // Middlename_LB
            // 
            this.Middlename_LB.AutoSize = true;
            this.Middlename_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middlename_LB.Location = new System.Drawing.Point(3, 175);
            this.Middlename_LB.Name = "Middlename_LB";
            this.Middlename_LB.Size = new System.Drawing.Size(113, 30);
            this.Middlename_LB.TabIndex = 9;
            this.Middlename_LB.Text = "Отчество";
            // 
            // Class_LB
            // 
            this.Class_LB.AutoSize = true;
            this.Class_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Class_LB.Location = new System.Drawing.Point(3, 205);
            this.Class_LB.Name = "Class_LB";
            this.Class_LB.Size = new System.Drawing.Size(113, 30);
            this.Class_LB.TabIndex = 11;
            this.Class_LB.Text = "Класс";
            // 
            // Save_B
            // 
            this.Save_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Save_B, 2);
            this.Save_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_B.Location = new System.Drawing.Point(3, 269);
            this.Save_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(255, 34);
            this.Save_B.TabIndex = 15;
            this.Save_B.Text = "&Сохранить";
            this.Save_B.UseVisualStyleBackColor = false;
            // 
            // Cancel_B
            // 
            this.Cancel_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Cancel_B, 2);
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_B.Location = new System.Drawing.Point(264, 269);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(255, 34);
            this.Cancel_B.TabIndex = 16;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = false;
            // 
            // Class_TB
            // 
            this.Class_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Class_TB, 3);
            this.Class_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Class_TB.Location = new System.Drawing.Point(122, 209);
            this.Class_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class_TB.Name = "Class_TB";
            this.Class_TB.Size = new System.Drawing.Size(397, 22);
            this.Class_TB.TabIndex = 12;
            // 
            // Surname_TB
            // 
            this.Surname_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Surname_TB, 3);
            this.Surname_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surname_TB.Location = new System.Drawing.Point(122, 149);
            this.Surname_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.Size = new System.Drawing.Size(397, 22);
            this.Surname_TB.TabIndex = 8;
            // 
            // Age_TB
            // 
            this.Age_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Age_TB, 3);
            this.Age_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_TB.Location = new System.Drawing.Point(122, 89);
            this.Age_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Age_TB.Name = "Age_TB";
            this.Age_TB.Size = new System.Drawing.Size(397, 22);
            this.Age_TB.TabIndex = 4;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Name_TB, 3);
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(122, 119);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(397, 22);
            this.Name_TB.TabIndex = 6;
            // 
            // Averagerating_TB
            // 
            this.Averagerating_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Averagerating_TB, 3);
            this.Averagerating_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Averagerating_TB.Location = new System.Drawing.Point(122, 59);
            this.Averagerating_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Averagerating_TB.Name = "Averagerating_TB";
            this.Averagerating_TB.Size = new System.Drawing.Size(397, 22);
            this.Averagerating_TB.TabIndex = 2;
            // 
            // Ranked_TB
            // 
            this.Ranked_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Ranked_TB, 3);
            this.Ranked_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ranked_TB.Location = new System.Drawing.Point(122, 239);
            this.Ranked_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ranked_TB.Name = "Ranked_TB";
            this.Ranked_TB.Size = new System.Drawing.Size(397, 22);
            this.Ranked_TB.TabIndex = 14;
            // 
            // Middlename_TB
            // 
            this.Middlename_TB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.Middlename_TB, 3);
            this.Middlename_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middlename_TB.Location = new System.Drawing.Point(122, 179);
            this.Middlename_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Middlename_TB.Name = "Middlename_TB";
            this.Middlename_TB.Size = new System.Drawing.Size(397, 22);
            this.Middlename_TB.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.Ranked_LB, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Ranked_TB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Class_TB, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Surname_TB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Middlename_TB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Name_TB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_B, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.Age_TB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Save_B, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Spisok_LB_school, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Averagerating_LB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Age_LB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Surname_LB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Name_LB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Middlename_LB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Class_LB, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Averagerating_TB, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 307);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Ranked_LB
            // 
            this.Ranked_LB.AutoSize = true;
            this.Ranked_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ranked_LB.Location = new System.Drawing.Point(3, 235);
            this.Ranked_LB.Name = "Ranked_LB";
            this.Ranked_LB.Size = new System.Drawing.Size(113, 30);
            this.Ranked_LB.TabIndex = 13;
            this.Ranked_LB.Text = "Занятое место";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(522, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modification";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modification_FormClosing);
            this.Load += new System.EventHandler(this.Modification_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Spisok_LB_school;
        private System.Windows.Forms.Label Averagerating_LB;
        private System.Windows.Forms.Label Age_LB;
        private System.Windows.Forms.Label Name_LB;
        private System.Windows.Forms.Label Surname_LB;
        private System.Windows.Forms.Label Middlename_LB;
        private System.Windows.Forms.Label Class_LB;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Ranked_LB;
        public System.Windows.Forms.TextBox Class_TB;
        public System.Windows.Forms.TextBox Surname_TB;
        public System.Windows.Forms.TextBox Age_TB;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Averagerating_TB;
        public System.Windows.Forms.TextBox Ranked_TB;
        public System.Windows.Forms.TextBox Middlename_TB;
    }
}