﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Schoolboy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                context = new Data.ApplicationContext();

                InitializeListOfSchoolboys();

                if (Spisok_LB.Items.Count > 0)
                {
                    StateButton(true);
                }
                else
                {
                    StateButton(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Application.Exit();
            }
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                Modification modificationModel = new Modification(true);

                if (modificationModel.ShowDialog() == DialogResult.OK)
                {
                    Schoolboy SchoolboyDB = new Schoolboy
                    {
                        Averagerating = Convert.ToDouble(modificationModel.Averagerating_TB.Text.Trim()),
                        Age = Convert.ToInt32(modificationModel.Age_TB.Text.Trim()),
                        Name = modificationModel.Name_TB.Text.Trim(),
                        Surname = modificationModel.Surname_TB.Text.Trim(),
                        Middlename = modificationModel.Middlename_TB.Text.Trim(),
                        Class = Convert.ToInt32(modificationModel.Class_TB.Text.Trim()),
                        Ranked = Convert.ToInt32(modificationModel.Ranked_TB.Text.Trim()),
                    };

                    context.Schoolboys.Add(SchoolboyDB);
                    context.SaveChanges();

                    Schoolboys.Add(SchoolboyDB);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            try
            {
                Modification modificationModel = new Modification(false);

                Schoolboy SchoolboyDB = Spisok_LB.SelectedItem as Schoolboy;

                if (SchoolboyDB == null)
                {
                    throw new Exception("Необходимо выбрать объект");
                }

                modificationModel.Averagerating_TB.Text = SchoolboyDB.Averagerating.ToString();
                modificationModel.Age_TB.Text = SchoolboyDB.Age.ToString();
                modificationModel.Name_TB.Text = SchoolboyDB.Name.ToString();
                modificationModel.Surname_TB.Text = SchoolboyDB.Surname.ToString();
                modificationModel.Middlename_TB.Text = SchoolboyDB.Middlename.ToString();
                modificationModel.Class_TB.Text = SchoolboyDB.Class.ToString();
                modificationModel.Ranked_TB.Text = SchoolboyDB.Ranked.ToString();               

                if (modificationModel.ShowDialog() == DialogResult.OK)
                {
                    Schoolboy SchoolboyContext = Spisok_LB.SelectedItem as Schoolboy;                   

                    SchoolboyDB.Averagerating = Convert.ToDouble(modificationModel.Averagerating_TB.Text.Trim());
                    SchoolboyDB.Age = Convert.ToInt32(modificationModel.Age_TB.Text.Trim());
                    SchoolboyDB.Name = modificationModel.Name_TB.Text.Trim();
                    SchoolboyDB.Surname = modificationModel.Surname_TB.Text.Trim();
                    SchoolboyDB.Middlename = modificationModel.Middlename_TB.Text.Trim();
                    SchoolboyDB.Class = Convert.ToInt32(modificationModel.Class_TB.Text.Trim());
                    SchoolboyDB.Ranked = Convert.ToInt32(modificationModel.Ranked_TB.Text.Trim());

                    context.SaveChanges();

                    Schoolboys.Remove(SchoolboyDB);
                    Schoolboys.Add(SchoolboyContext);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Schoolboy SchoolboyDB = Spisok_LB.SelectedItem as Schoolboy;

                    if (SchoolboyDB == null)
                    {
                        throw new Exception("Необходимо выбрать объект");
                    }

                    context.Schoolboys.Remove(SchoolboyDB);
                    context.SaveChanges();

                    Schoolboys.Remove(SchoolboyDB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Data.ApplicationContext context;
        private BindingList<Schoolboy> Schoolboys;

        private void InitializeListOfSchoolboys()
        {
            Schoolboys = new BindingList<Schoolboy>(context.Schoolboys.ToList());

            Spisok_LB.DataSource = Schoolboys;           
        }

        private void Spisok_LB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Spisok_LB.SelectedItem != null)
            {
                Schoolboy SchoolboyDB = Spisok_LB.SelectedItem as Schoolboy;

                if (SchoolboyDB != null)
                {
                    Averagerating_TB.Text = SchoolboyDB.Averagerating.ToString();
                    Age_TB.Text = SchoolboyDB.Age.ToString();
                    Name_TB.Text = SchoolboyDB.Name;
                    Surname_TB.Text = SchoolboyDB.Surname;
                    Middlename_TB.Text = SchoolboyDB.Middlename;
                    Class_TB.Text = SchoolboyDB.Class.ToString();
                    Ranked_TB.Text = SchoolboyDB.Ranked.ToString();
                }

                StateButton(true);
            }
            else
            {               
                Averagerating_TB.Clear();
                Age_TB.Clear();
                Name_TB.Clear();
                Surname_TB.Clear();
                Middlename_TB.Clear();
                Class_TB.Clear();
                Ranked_TB.Clear();

                StateButton(false);
            }
        }

        private void StateButton(bool state)
        {
            Update_B.Enabled = state;
            Del_B.Enabled = state;
        }       
    }
}
