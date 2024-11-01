using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i;
            int a = 0;
            int b = 10;
            for (i = 1; i <= 10; i++)
            {
                
                a = a + 50;
                TestButton testButton = new TestButton(i,a, b, 50, 50);

                Controls.Add(testButton);

                //TestButton testButton2 = new TestButton(100, 100, 100, 100);

                //Controls.Add(testButton2);
            }

        }
    }
}
