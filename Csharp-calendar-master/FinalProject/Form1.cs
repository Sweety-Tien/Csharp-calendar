using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FinalProject
{
    public partial class 行事曆 : Form
    {
        public List<TodoItem> TodoList;
        Form2 f2;

        public 行事曆()
        {
            InitializeComponent();
            TodoList = new List<TodoItem>();
            f2 = new Form2(TodoList);
        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void 行事曆_Load(object sender, EventArgs e)
        {
            labelDate.Text = monthCalendar.TodayDate.ToLongDateString();
            Display();
        }



        private void tabMonth_Click(object sender, EventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {


            }

            if (tab.SelectedIndex == 1)
            {

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            Display();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = monthCalendar.SelectionStart.ToLongDateString();
            Display();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            var date = monthCalendar.SelectionRange.Start;
            monthCalendar.SetDate(date.AddDays(1));
            labelDate.Text = monthCalendar.SelectionStart.ToLongDateString();
            Display();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            var date = monthCalendar.SelectionRange.Start;
            monthCalendar.SetDate(date.AddDays(-1));
            labelDate.Text = monthCalendar.SelectionStart.ToLongDateString();
            Display();
        }
        public void Display()
        {
            checkBoxToDo.Items.Clear();
            foreach (var item in TodoList)
            {
                checkBoxToDo.Items.Add(item.Title+item.Date.ToShortDateString(), false);
            }
            checkBoxToDo.Sorted = true;
            txtDay.Text = "";

            for (int i = 0; i < 24; i++)
            {
                if(i == 0)
                    txtDay.Text += "上午12點".PadRight(110, '-')+ "\r\n\r\n";                
                else if(i > 0 && i < 12)
                    txtDay.Text += ("上午" + i + "點").PadRight(110, '-') + "\r\n\r\n";
                else if(i == 12)
                    txtDay.Text += "下午12點".PadRight(110, '-') + "\r\n\r\n";               
                else if(i > 12)
                    txtDay.Text += ("下午" + (i - 12) + "點").PadRight(110, '-') + "\r\n\r\n";
                
                foreach (var item in TodoList)
                {
                    bool IsSameYear = item.Date.Year == monthCalendar.SelectionRange.Start.Date.Year;
                    bool IsSameMonth = item.Date.Month == monthCalendar.SelectionRange.Start.Date.Month;
                    bool IsSameDay = item.Date.Day == monthCalendar.SelectionRange.Start.Date.Day;
                    if (IsSameYear && IsSameMonth && IsSameDay && item.Date.Hour == i)
                    {
                        txtDay.Text += "     ";
                        txtDay.Text += item.Date.ToShortTimeString() + "  標題:" + item.Title + "  種類:" + item.Type + "  地點:" + item.Place + "  說明:" + item.Descripetion + "\r\n";
                    }
                }
                txtDay.Text += "\r\n";
            }

        }
    }
}


