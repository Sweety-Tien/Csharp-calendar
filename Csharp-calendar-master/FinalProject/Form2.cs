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
    public partial class Form2 : Form
    {
        public Calender Form1;
        private EventType SelectedType;
        public Form2(Calender f1)
        {
            InitializeComponent();
            Form1 = f1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            btnColor();
            txtAdd.Text = "新增事項";
            txtAddContent.Text = "無";
            txtAddPlace.Text = "無";
            txtAdd.ForeColor = Color.LightGray;
            txtAddPlace.ForeColor = Color.LightGray;
            txtAddContent.ForeColor = Color.LightGray;
            this.ActiveControl = txtAdd;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            btnColor();
            btnActivity.BackColor = Color.LightBlue;
            SelectedType = EventType.Activity;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            btnColor();
            btnWork.BackColor = Color.LightBlue;
            SelectedType = EventType.Work;
        }

        private void btnRemind_Click(object sender, EventArgs e)
        {
            btnColor();
            btnRemind.BackColor = Color.LightBlue;
            SelectedType = EventType.Remind;
        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            btnColor();
            btnParty.BackColor = Color.LightBlue;
            SelectedType = EventType.Party;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            btnColor();
            btnOther.BackColor = Color.LightBlue;
            SelectedType = EventType.Other;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnColor()
        {
            btnActivity.BackColor = Color.White;
            btnWork.BackColor = Color.White;
            btnRemind.BackColor = Color.White;
            btnParty.BackColor = Color.White;
            btnOther.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text == "" || txtAdd.Text == "新增事項")
            {
                MessageBox.Show("標題不可為空");
                this.ActiveControl = txtAdd;
            }
            else
            {
                var todoItem = new TodoItem(txtAdd.Text, txtAddPlace.Text, txtAddContent.Text, dateTimePicker1.Value, SelectedType);
                Form1.AddItem(todoItem);
                Form1.SaveData();
                this.Close();
            }
        }
        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            txtAdd.ForeColor = Color.Black;
        }

        private void txtAddPlace_TextChanged(object sender, EventArgs e)
        {
            txtAddPlace.ForeColor = Color.Black;
        }

        private void txtAddContent_TextChanged(object sender, EventArgs e)
        {
            txtAddContent.ForeColor = Color.Black;
        }
    }
}
