using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormBalls
{
    public class SimpleBall
    {
        int radius = 20;
        int x, y;
        Color color = Color.Aqua;
        Color clearColor;
        Form form;
        Graphics g;
        int vx, vy;
        int MAXSpeed = 50;
        Timer timer;


        public SimpleBall(int x, int y, Form form)
        {
            this.x = x;
            this.y = y;
            g = form.CreateGraphics();
            this.form = form;
            Random rnd = new Random();
            vx = rnd.Next(-MAXSpeed, MAXSpeed);
            vy = rnd.Next(-MAXSpeed, MAXSpeed);
            clearColor = form.BackColor;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Clear();
            Move();
            Show();
        }

        public void Pause()
        {
            timer.Enabled = !timer.Enabled;
        }

        public void Show()
        {
            //Pen p = Pens.Aqua;
            //g.DrawEllipse(p, x, y, 2 * radius, 2 * radius);


            g.FillEllipse(Brushes.BlueViolet, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        public void Clear()
        {
            Brush br = new SolidBrush(clearColor);
            g.FillEllipse(br, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        public void Move()
        {
            x += vx;
            y += vy;
        }


    }
}
