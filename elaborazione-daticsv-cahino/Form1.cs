namespace elaborazione_daticsv_cahino
{
    public partial class Form1 : Form
    {
        funzioni f;
        string filename;
        string filename1;
        public int d;
        char lim = ';';
        public Form1()
        {
            string filename = @"Cahino1.csv";
            string filename1 = @"Cahino.csv";
            d = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero di campi presenti nel file è di: " + f.campi(filename, lim));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.RandeLog(filename, filename1, lim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il campo più lungo è " + f.Long(filename1, lim) + " avente " + f.Long(filename1, lim).Length + " caratteri");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f.spnec(filename, filename1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f.TriRec(filename, lim, listView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] temp = new string[f.campi(filename, lim)];
            string[] split = textBox6.Text.Split();
            temp[0] = textBox1.Text;
            temp[1] = textBox2.Text;
            temp[2] = textBox3.Text;
            temp[3] = textBox4.Text;
            temp[4] = textBox5.Text;
            f.NewRec(filename, lim, temp);
            groupBox1.Hide();
        }
    }
}