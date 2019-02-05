using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Primitivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crear_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics obj = CreateGraphics();
            Pen pen = new Pen(Color.Black, 8);
            obj.DrawLine(pen, 100, 10, 200, 200);
            Graphics ob = this.CreateGraphics();
            Pen pe = new Pen(Color.Crimson,8);
            ob.DrawRectangle(pe, 300, 150, 100, 100);
            Graphics o = this.CreateGraphics();
            Pen p = new Pen(Color.DarkGoldenrod,8);
            o.DrawEllipse(p, 550, 150, 100, 100);
        }
    }
}
