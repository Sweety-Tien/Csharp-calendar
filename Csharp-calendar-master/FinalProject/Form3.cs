using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public int select;
        public List<WeekPlanItem> WeekPlanList;
        private WeekOfDay week;

        public Form3(List<WeekPlanItem> weekPlanList)
        {
            InitializeComponent();
            WeekPlanList = weekPlanList;
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            txtAdd.ForeColor = Color.Black;
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            color();
            btnMon.BackColor = Color.LightBlue;
            week = WeekOfDay.mon;
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            color();
            btnTue.BackColor = Color.LightBlue;
            week = WeekOfDay.tue;
        }

        private void btnWed_Click(object sender, EventArgs e)
        {
            color();
            btnWed.BackColor = Color.LightBlue;
            week = WeekOfDay.wed;
        }

        private void btnThur_Click(object sender, EventArgs e)
        {
            color();
            btnThur.BackColor = Color.LightBlue;
            week = WeekOfDay.thur;
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            color();
            btnFri.BackColor = Color.LightBlue;
            week = WeekOfDay.fri;
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            color();
            btnSat.BackColor = Color.LightBlue;
            week = WeekOfDay.sat;
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            color();
            btnSun.BackColor = Color.LightBlue;
            week = WeekOfDay.sun;
        }

        void color()
        {
            btnMon.BackColor = Color.White;
            btnTue.BackColor = Color.White;
            btnWed.BackColor = Color.White;
            btnThur.BackColor = Color.White;
            btnFri.BackColor = Color.White;
            btnSat.BackColor = Color.White;
            btnSun.BackColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (txtAdd.Text == "" || txtAdd.Text == "Add Week Plan")
                {
                    MessageBox.Show("標題不可為空");
                    this.ActiveControl = txtAdd;
                }
                else
                {
                    var weekPlan = new WeekPlanItem(txtAdd.Text, week);
                    WeekPlanList.Add(weekPlan);
                    this.Close();
                }
            }
            else
            {
                if (txtAdd.Text == "" || txtAdd.Text == "Delete Week Plan")
                {
                    MessageBox.Show("標題不可為空");
                    this.ActiveControl = txtAdd;
                }
                else
                {
                    Boolean found = false;
                    foreach (var item in WeekPlanList)
                    {
                        if (item.Task == txtAdd.Text && week == item.Week)
                        {
                            WeekPlanList.Remove(item);
                            found = true;
                            break;
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("該計畫不存在");
                    }
                    this.Close();
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            color();
            txtAdd.ForeColor = Color.LightGray;
            if (select == 1)
            {
                this.Text = "新增周計畫";
                btnSave.Text = "新增";
                txtAdd.Text = "Add Week Plan";
            }

            if (select == 2)
            {
                this.Text = "刪除周計畫";
                btnSave.Text = "刪除";
                txtAdd.Text = "Delete Week Plan";
            }

        }
    }


}

