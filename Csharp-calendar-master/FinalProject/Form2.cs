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
        public Form2(List<TodoItem> todoList)
        {
            InitializeComponent();
            TodoList = todoList;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtAdd.Text = "新增事項";
            txtAdd.ForeColor = Color.LightGray;
            this.ActiveControl = txtAdd;
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            btnActivity.BackColor = Color.LightBlue;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.LightBlue;
        }

        private void btnRemind_Click(object sender, EventArgs e)
        {
            btnRemind.BackColor = Color.LightBlue;
        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            btnParty.BackColor = Color.LightBlue;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            btnOther.BackColor = Color.LightBlue;
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var todoItem = new TodoItem("Hello", "Test", 2022, 12, 23, EventType.Party);
            TodoList.Add(todoItem);
        }
    }
}
