using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CurrencyConverter = CurrencyConverterv1.CurrencyConverter;

namespace CurrencyConverterv1
{
    public partial class New_Form : Form
    {
        CurrencyConverter converter;   
        public New_Form()
        {
            InitializeComponent();
            converter = new CurrencyConverter();

        }


       

        private void New_Form_Load(object sender, EventArgs e)
        {
           Dictionary<string, string> symbolData = converter.GetSymbols();
            fromCurrency.Items.Clear();
            toCurrency.Items.Clear();

            fromCurrency.DataSource = new BindingSource(symbolData, null);
            fromCurrency.DisplayMember = "Value";
            fromCurrency.ValueMember = "Key";

            toCurrency.DataSource = new BindingSource(symbolData, null);
            toCurrency.DisplayMember = "Value";
            toCurrency.ValueMember = "Key";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromCurr =((KeyValuePair<string, string>)fromCurrency.SelectedItem).Key;
            string toCurr = ((KeyValuePair<string, string>)toCurrency.SelectedItem).Key;

            double amount = double.Parse(txt_from.Text);
            double result = converter.Convert(fromCurr, toCurr, amount);

            txt_to.Text = result.ToString();
        }

        
    }
}
