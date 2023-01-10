namespace CurrencyConverterv1
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startConverting_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Form new_Form = new New_Form();
            new_Form.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}