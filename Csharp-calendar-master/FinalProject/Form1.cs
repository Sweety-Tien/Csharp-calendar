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
        public 行事曆()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2(); //產生Form2的物件，才可以使用它所提供的Method


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void 行事曆_Load(object sender, EventArgs e)
        {

        }



        private void tabMonth_Click(object sender, EventArgs e)
        {
            
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tab.SelectedIndex == 0)
            {
                

            }

            if (tab.SelectedIndex == 1)
            {         

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            f2.Show(this);
        }
    }
}


