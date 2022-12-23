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
        public List<TodoItem> TodoList;
        private EventType SelectedType;
        public Form2(List<TodoItem> todoList)
        {
            InitializeComponent();
            TodoList = todoList;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            btnColor();
            txtAdd.Text = "新增事項";
            txtAdd.ForeColor = Color.LightGray;
            this.ActiveControl = txtAdd;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            txtAdd.ForeColor = Color.Black;
        }
        void btnColor()
        {
            btnActivity.BackColor = Color.LightBlue;
            btnWork.BackColor = Color.LightBlue;
            btnRemind.BackColor = Color.LightBlue;
            btnParty.BackColor = Color.LightBlue;
            btnOther.BackColor = Color.LightBlue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var todoItem = new TodoItem("Hello", "Test", 2022, 12, 23, EventType.Party);
            TodoList.Add(todoItem);
        }
    }
}
