using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace кп_с_17._03
{
    class car
    {
        //поля
        int speed;
        int x;
        int y;
        Color color;

        //конструктор
        public car()
        {
            this.speed = 50;
            this.x = 10;
            this.y = 10;
            this.color = Color.Red;

        }
        public car(int x,int y)
        {
            this.x = x;
            this.y = y;
            this.speed = 50;
        }

        //методы
        public void draw(Graphics g)
        {
            SolidBrush b1 = new SolidBrush(color);
            g.FillRectangle(b1, x, y, 100, 50);

            SolidBrush b2 = new SolidBrush(color);
            g.FillEllipse(b1, x+20, y+50, 10, 10);
            g.FillEllipse(b1, x + 80, y + 50, 10, 10);


        }


    }
}
