using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinalProject
{
    public partial class Calender : Form
    {
        public List<TodoItem> TodoList;
        Form2 form2;
        Label monthLabel;
        Label[] MonthDayLabels;
        string DataPath = "";

        public Calender()
        {
            InitializeComponent();
            TodoList = new List<TodoItem>();
            form2 = new Form2(this);
            DataPath = Application.StartupPath + Path.AltDirectorySeparatorChar + "data.json";
            if (File.Exists(DataPath))
            {
                LoadData();
            } else
            {
                SaveData();
            }
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            labelDate.Text = monthCalendar.TodayDate.ToLongDateString();
            Display();

            // Month Calender
            monthLabel = new Label();
            monthLabel.Font = new Font("Arial", 22, FontStyle.Bold);
            monthLabel.SetBounds(15, 300, 100, 100);
            tabMonth.Controls.Add(monthLabel);

            string[] weekday = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < 7; i++)
            {
                var label = new Label();
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = weekday[i];
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.SetBounds(200 + i * 105, 30, 100, 40);
                label.BackColor = Color.AntiqueWhite;
                tabMonth.Controls.Add(label);
            }

            MonthDayLabels = new Label[35];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var label = new Label();
                    label.SetBounds(200 + j * 105, 80 + i * 105, 100, 100);
                    label.BackColor = Color.AntiqueWhite;
                    MonthDayLabels[i * 7 + j] = label;
                    tabMonth.Controls.Add(label);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
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
                checkBoxToDo.Items.Add(item.Title + item.Date.ToShortDateString(), false);
            }
            checkBoxToDo.Sorted = true;
            txtDay.Text = "";

            for (int i = 0; i < 24; i++)
            {
                if (i == 0)
                    txtDay.Text += "上午12點".PadRight(110, '-') + "\r\n\r\n";
                else if (i > 0 && i < 12)
                    txtDay.Text += ("上午" + i + "點").PadRight(110, '-') + "\r\n\r\n";
                else if (i == 12)
                    txtDay.Text += "下午12點".PadRight(110, '-') + "\r\n\r\n";
                else if (i > 12)
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

        private void showMonthCalender(DateTime date)
        {
            DateTime firstDay = new DateTime(date.Year, date.Month, 1);

            monthLabel.Text = firstDay.ToString("MMM");

            int day = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var label = MonthDayLabels[i * 7 + j];
                    label.Text = "";
                    if ((i * 7 + j) > (int)(firstDay.DayOfWeek) &&
                        day <= DateTime.DaysInMonth(firstDay.Year, firstDay.Month))
                    {
                        label.Text = $"{day}\n";
                        var pickDate = new DateTime(date.Year, date.Month, day);
                        foreach (var item in TodoList)
                        {
                            var itemDate = item.Date;
                            bool IsSameYear = itemDate.Year == pickDate.Date.Year;
                            bool IsSameMonth = itemDate.Month == pickDate.Date.Month;
                            bool IsSameDay = itemDate.Day == pickDate.Date.Day;
                            if (IsSameYear && IsSameMonth && IsSameDay)
                            {
                                label.Text += item.Title + "\n";
                            }
                        }
                        day += 1;
                    }
                }
            }
        }

        public void SaveData()
        {
            string json = JsonSerializer.Serialize<List<TodoItem>>(TodoList);
            var writer = new StreamWriter(DataPath);
            writer.Write(json);
            writer.Flush();
            writer.Close();
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(DataPath);
            string json = reader.ReadToEnd();
            TodoList = JsonSerializer.Deserialize<List<TodoItem>>(json);
            reader.Close();
        }

        public void AddItem(TodoItem item)
        {
            TodoList.Add(item);
            SaveData();
        }
        public void RemoveItem(TodoItem item)
        {
            TodoList.Remove(item);
            SaveData();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RemoveScheduleForm form = new RemoveScheduleForm(this);
            form.ShowDialog();
        }

        private void tabMonth_Enter(object sender, EventArgs e)
        {
            showMonthCalender(monthCalendar.TodayDate);
        }
    }
}


