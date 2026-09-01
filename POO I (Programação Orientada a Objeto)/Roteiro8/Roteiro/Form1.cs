using System.Runtime.InteropServices;

namespace Roteiro
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTOMDOWN = 0X00A1;
        public const int HT_CAPTION = 0X02;

        [DllImport("user32.dll")]

        public static extern int SendMenssage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        public static extern bool RealeseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panell_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RealeseCapture();
                SendMenssage(this.Handle, WM_NCLBUTTOMDOWN, HT_CAPTION, 0);
            }
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void Planilha_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Planilhas>();
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Relatorios>();
        }

        private void Planner_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Planner>();
        }
    }
}
