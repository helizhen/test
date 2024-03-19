namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ÎÄ¼þ°æ±¾£º" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
