using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кп_с_17._03
{
    
    class Car
    {
        //поля
        int speed;
        int x;
        int y;
        bool s;
        public bool FlagX;
        public bool FlagY;  
        Color color;

        //конструктор
        public Car()
        {
            this.speed = 50;
            this.x = 0;
            this.y = 0;
            this.color = Color.Red;

        }
        public Car(int x,int y)
        {
            this.x = x;
            this.y = y;
            this.speed = 50;
        }

        //методы
        public void Draw(Graphics g)
        {
            SolidBrush b1 = new SolidBrush(this.color);
            g.FillRectangle(b1, x, y, 100, 50);

            SolidBrush b2 = new SolidBrush(Color.Black);
            g.FillEllipse(b2, x + 20, y + 50, 15, 15);
            g.FillEllipse(b2, x + 70, y + 50, 15, 15);
        }

        public void DrawAgainByX(Graphics g)
        {
            int xNew = this.x - 300;
            SolidBrush b1 = new SolidBrush(this.color);
            g.FillRectangle(b1, xNew, y, 100, 50);

            SolidBrush b2 = new SolidBrush(Color.Black);
            g.FillEllipse(b2, xNew + 20, y + 50, 15, 15);
            g.FillEllipse(b2, xNew + 70, y + 50, 15, 15);
        }
        public void DrawAgainByY(Graphics g)
        {
            int yNew = this.y - 325;
            SolidBrush b1 = new SolidBrush(this.color);
            g.FillRectangle(b1, x, yNew, 100, 50);

            SolidBrush b2 = new SolidBrush(Color.Black);
            g.FillEllipse(b2, x + 20, yNew + 50, 15, 15);
            g.FillEllipse(b2, x + 70, yNew + 50, 15, 15);
        }
        public void MoveLeft()
        {
            this.x -= speed;

        }

        public void MoveRight()
        {
            this.x += speed;

        }

        public void MoveDown()
        {
            this.y += speed;

        }
        public void MoveUp()
        {
            this.y -= speed;
            MessageBox.Show(x.ToString() + " " + y.ToString());


            /*if (this.y < 0)
            {
                this.y = 290;
            }
            */

        }
        public void Location()
        {
            if (this.x < 0)
            {
                this.x = 300 + this.x;//TODO: resolve location problem 
                // s = true;
            }
            if (this.x >= 200) FlagX = true;


            if (this.y < 0)
            {
                this.y = 325 + this.y;//TODO: resolve location problem 

            }
            if (this.y >= 260) FlagY = true;
            //MessageBox.Show(x.ToString() + " " + y.ToString());

        }



    }
}
