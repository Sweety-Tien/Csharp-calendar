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
            txtDay.Text = "";
            for (int i = 1; i < 13; i++)
            {
                string str = "上午" + i + "點";             
                str = str.PadRight(110, '-');
                txtDay.Text += str + "\r\n\r\n";
                foreach(var item in TodoList)
                {
                    string[] Time = item.Date.ToShortTimeString().Split(' ');
                    string[] Hour = Time[1].Split(':');
                    if (item.Date == monthCalendar.SelectionRange.Start && Time[0]== "上午"&& Hour[0] == i.ToString())
                    {
                        txtDay.Text += item.Date.ToShortTimeString() + "\r\n";
                    }
                }
                txtDay.Text += "\r\n";
            }
            for (int i = 1; i < 13; i++)
            {
                string str = "下午" + i + "點";
                str = str.PadRight(110, '-');
                txtDay.Text += str + "\r\n\r\n";
                foreach (var item in TodoList)
                {
                    string[] Time = item.Date.ToShortTimeString().Split(' ');
                    string[] Hour = Time[1].Split(':');
                    if (item.Date == monthCalendar.SelectionRange.Start && Time[0] == "下午" && Hour[0] == i.ToString())
                    {
                        txtDay.Text += item.Date.ToShortTimeString() + "\r\n";
                    }
                }
                txtDay.Text += "\r\n";
            }
        }
    }
}


