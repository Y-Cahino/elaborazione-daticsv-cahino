namespace elaborazione_daticsv_cahino
{
    public partial class Form1 : Form
    {
        funzioni f;
        string filename;
        string filename1;
        char lim = ';';
        public Form1()
        {
            string filename = @"Cahino1.csv";
            string filename1 = @"Cahino.csv";
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero di campi presenti nel file è di: "+f.campi(filename,lim));
        }
    }
}