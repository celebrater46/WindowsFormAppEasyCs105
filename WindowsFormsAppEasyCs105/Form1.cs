using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs105
{
    public partial class Form1 : Form
    {
        private PictureBox[] pb;
        private TabControl tc;
        private TabPage[] tp;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tab Control Test";
            this.Width = 300;
            this.Height = 200;
            tc = new TabControl();

            string dir = "C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs105\\WindowsFormsAppEasyCs105\\img\\";
            string[] fls = Directory.GetFiles(dir, "*.bmp");
            pb = new PictureBox[fls.Length];
            tp = new TabPage[fls.Length];

            for (int i = 0; i < fls.Length; i++)
            {
                pb[i] = new PictureBox();
                // tp[i] = new TabPage(fls[i]);
                // string temp = ToString(i); // Error: No overload for method
                string temp = i.ToString();
                tp[i] = new TabPage(temp);

                pb[i].Image = Image.FromFile(fls[i]);
                tp[i].Controls.Add(pb[i]);
                tc.Controls.Add(tp[i]);
            }

            tc.Parent = this;
        }
    }
}