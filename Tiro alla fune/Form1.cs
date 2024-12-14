namespace Tiro_alla_fune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        bool win = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Corda_Ondulata.Location = new Point((ClientSize.Width - Corda_Ondulata.Width) / 2, (ClientSize.Height - Corda_Ondulata.Height) / 2);
            Corda_Dura.Location = new Point((ClientSize.Width - Corda_Dura.Width) / 2, (ClientSize.Height - Corda_Dura.Height) / 2);
            Start.Location = new Point(((ClientSize.Width - Start.Width) / 2), 50);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Corda_Ondulata.Hide();
            Corda_Dura.Show();

            Thread CPU = new Thread(Easy);
            CPU.Start();
        }

        private void Easy()
        {
            while (! (Corda_Dura.Location.X > ClientSize.Width / 2) && Corda_Dura.Location.X + Corda_Dura.Width > ClientSize.Width/2)
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X - 5, Corda_Dura.Location.Y);
                Thread.Sleep(250);
            }
            win = true;
            MessageBox.Show("");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(win == false) 
            {
                Corda_Dura.Location = new Point(Corda_Dura.Location.X + 25, Corda_Dura.Location.Y);
            }
            
        }

        private void Corda_Dura_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}