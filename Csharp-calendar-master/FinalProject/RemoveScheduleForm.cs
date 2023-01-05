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
    public partial class RemoveScheduleForm : Form
    {
        Calender mainForm;
        List<TodoItem> filteredList;
        public RemoveScheduleForm(Calender form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void RemoveScheduleForm_Load(object sender, EventArgs e)
        {
            filterComboBox(dateTimePicker1.Value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                mainForm.RemoveItem(filteredList[comboBox1.SelectedIndex]);
                mainForm.Display();
            }
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filterComboBox(dateTimePicker1.Value);
        }
        private void filterComboBox(DateTime pickDate)
        {
            comboBox1.Items.Clear();
            filteredList = new List<TodoItem>();
            foreach (var item in mainForm.TodoList)
            {
                var itemDate = item.Date;
                bool IsSameYear = itemDate.Year == pickDate.Date.Year;
                bool IsSameMonth = itemDate.Month == pickDate.Date.Month;
                bool IsSameDay = itemDate.Day == pickDate.Date.Day;
                if (IsSameYear && IsSameMonth && IsSameDay)
                {
                    filteredList.Add(item);
                    comboBox1.Items.Add(item.Title);
                }
            }
            if (filteredList.Count() > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
