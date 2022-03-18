using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кп_с_17._03
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Car car;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //g = pictureBox1.
            /*car car = new car(100,200);
            car.draw(g); 
            */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            g.Clear(Color.Gray);
            car.MoveUp();
            car.Draw(g);
            car.Location();
            car.Draw(g);
            if (car.FlagX) car.DrawAgainByX(g);
            if (car.FlagY) car.DrawAgainByY(g);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            car.MoveLeft();
            car.Draw(g);
            car.Location();
            car.Draw(g);
            if (car.FlagX) car.DrawAgainByX(g);
            if (car.FlagY) car.DrawAgainByY(g);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            car.MoveRight();
            car.Draw(g);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            car.MoveDown();
            car.Draw(g);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            car = new Car();
            car.Draw(g);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            
        }
    }
}
