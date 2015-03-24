using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture06_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Height = labelClock.Height + 80;
            this.Width = labelClock.Width + 50;

            Timer timer = new Timer();
            timer.Interval = 1000;          
            timer.Tick += ((x, y) => labelClock.Text = DateTime.Now.ToLongTimeString());           
            timer.Start();
        }      
    }
}
