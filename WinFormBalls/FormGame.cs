using System;
using System.Windows.Forms;

namespace WinFormBalls
{
    public partial class FormGame : Form
    {

        SimpleBall ball;

        public FormGame()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!(ball is null))
            {
                ball.Clear();
                ball.Move();
                ball.Show();
            }
        }

        private void FormGame_MouseDown(object sender, MouseEventArgs e)
        {
            // MessageBox.Show(e.X.ToString());
            ball = new SimpleBall(e.X, e.Y, this);
            ball.Show();
            ball.Pause();
        }
    }
}
