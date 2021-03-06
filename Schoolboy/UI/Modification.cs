﻿using System;
using System.Windows.Forms;

namespace Schoolboy
{
    public partial class Modification : Form
    {
        public Modification(bool isUpdate)
        {
            InitializeComponent();
            IsUpdate = isUpdate;
        }

        private bool IsUpdate;

        private void Modification_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                this.Text = "Добавление данных";
                Spisok_LB_school.Text = "Добавление данных";               
            }
            else
            {
                this.Text = "Изменение данных";
                Spisok_LB_school.Text = "Изменение данных";
            }
        }

        private void Modification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {                    
                    if (Averagerating_TB.Text.Trim() == "")
                    {
                        Averagerating_TB.Focus();
                        throw new Exception("Средняя оценка должна содержать значение");
                    }

                    if (Age_TB.Text.Trim() == "")
                    {
                        Age_TB.Focus();
                        throw new Exception("Введите возраст");
                    }

                    String Name = Name_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        throw new Exception("Введите имя");
                    }

                    String Surname = Surname_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Surname))
                    {
                        throw new Exception("Введите фамилию");
                    }

                    String Middlename = Middlename_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Middlename))
                    {
                        throw new Exception("Введите отчество");
                    }

                    if (Class_TB.Text.Trim() == "")
                    {
                        Class_TB.Focus();
                        throw new Exception("Введите класс");
                    }

                    int c = Convert.ToInt32(Class_TB.Text);

                    if (c < 1 || c > 11)
                    {
                        Class_TB.Focus();
                        throw new Exception("Номер класса должнен находиться в диапазоне от 1 до 11");
                    }

                    if (Ranked_TB.Text.Trim() == "")
                    {
                        Ranked_TB.Focus();
                        throw new Exception("Введите занятое место");
                    }

                    int r = Convert.ToInt32(Ranked_TB.Text);

                    if (r < 1 || r > 3)
                    {
                        Ranked_TB.Focus();
                        throw new Exception("Занятое место находиться в диапазоне от 1 до 3");
                    }
                }
                catch (FormatException Fex)
                {
                    e.Cancel = true;
                    MessageBox.Show(Fex.Message,"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }       
    }
}
