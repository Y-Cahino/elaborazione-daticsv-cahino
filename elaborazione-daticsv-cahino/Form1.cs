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
    }
}