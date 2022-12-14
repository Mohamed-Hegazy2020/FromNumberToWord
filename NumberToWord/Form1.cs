using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using ConvertNumberToWord;
namespace NumberToWord
{
    public partial class Form1 : Form
    {
        //List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        public Form1()
        {
            InitializeComponent();
        }
        FromNumberToWord obj ;
        private void Form1_Load(object sender, EventArgs e)
        {
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Egypt));
            obj = new FromNumberToWord();
            cboCurrency.DataSource = obj.currencies;

            cboCurrency_DropDownClosed(null, null);
        }

        private void cboCurrency_DropDownClosed(object sender, EventArgs e)
        {
            txtNumber_TextChanged(null, null);
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //ToWord toWord = new ToWord(Convert.ToDecimal(txtNumber.Text), currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);  
                //txtArabicWord.Text = toWord.ConvertToArabic();
                //txtEnglishWord.Text = toWord.ConvertToEnglish();

                txtArabicWord.Text = obj.ConvertArabic(Convert.ToDecimal(txtNumber.Text), obj.currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);
                txtEnglishWord.Text = obj.ConvertEnglish(Convert.ToDecimal(txtNumber.Text), obj.currencies[Convert.ToInt32(cboCurrency.SelectedValue)]);
            }
            catch (Exception ex)
            {
                txtEnglishWord.Text = String.Empty;
                txtArabicWord.Text = String.Empty;
            }
        }
    }
}
