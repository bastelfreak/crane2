using DemoOpenGLBasicsCS.movements;
using System;
using System.Windows.Forms;
using System.Threading;


namespace DemoOpenGLBasicsCS
{
    public partial class GUI : Form

    {
        TView oglView = new TView();
        Boolean buttonDown;

        public GUI()
        {
            InitializeComponent();

            oglView.Dock = DockStyle.Fill;
            panel.Controls.Add(oglView);
            panel.Focus();
            this.buttonDown = false;
        }

        private void Movement(interfaces.IMovement b)
        {
            while (buttonDown)
            {
                oglView.Kran1.setMovement(b);
                oglView.Kran1.move();
                oglView.Kran1.zeichnung();
                oglView.Refresh();
                oglView.Focus();
                matrix.zielpunkt();
                lbl_x.Text = matrix.x;
                lbl_y.Text = matrix.y;
                lbl_z.Text = matrix.z;
                Thread.Sleep(50);
                Application.DoEvents();
            }
        }

        private void btn_links_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new left());
            }
        }

        private void btn_links_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void btn_rechts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new right());
            }
        }

        private void btn_rechts_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void btn_ausleger_vor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new forth());
            }
        }

        private void btn_ausleger_vor_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void btn_ausleger_zurueck_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new back());
            }
        }

        private void btn_ausleger_zurueck_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void btn_seil_hoch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new up());
            }
        }

        private void btn_seil_hoch_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void btn_seil_runter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                buttonDown = true;
                Movement(new down());
            }
        }

        private void btn_seil_runter_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
