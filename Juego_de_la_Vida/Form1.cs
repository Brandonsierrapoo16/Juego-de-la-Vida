using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
            Tablero t;
            int turno;
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(10);
            label1.Text = "Turno : " + turno;
            label2.Text = "Numero vivas: " + t.numero_vivas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t.next();
            label2.Text = "Celulas vivas: " + t.numero_vivas;
            t.update();
            this.Invalidate();
            turno++;
            label1.Text = "Turno: " + turno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Tablero((int)numericUpDown1.Value);
            turno = 0;
            timer1.Enabled = true;
        }
    }
}