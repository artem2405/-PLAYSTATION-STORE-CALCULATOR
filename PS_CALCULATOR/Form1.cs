using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_CALCULATOR
{
    public partial class MainForm : Form
    {
        private double RublePrice;
        public MainForm()
        {
            InitializeComponent();
        }

        private void lira_price_TextChanged(object sender, EventArgs e)
        {
            if (lira_price.Text != "")
            {
                if (lira_price.Text[lira_price.Text.Length - 1] >= 48
                && lira_price.Text[lira_price.Text.Length - 1] <= 57)
                {
                    double price = Math.Ceiling(double.Parse(lira_price.Text));
                    if (price < 100) { RublePrice = price * 5.2; }
                    if (price >= 100 && price <= 698) { RublePrice = Math.Ceiling(price * 1.07) * 4.75; }
                    if (price >= 699 && price <= 1198) { RublePrice = Math.Ceiling(price * 1.07) * 4.5; }
                    if (price >= 1199 && price <= 1798) { RublePrice = Math.Ceiling(price * 1.07) * 4.3; }
                    if (price >= 1799) { RublePrice = Math.Ceiling(price * 1.07) * 4.1; }
                    RublePrice = Round10(RublePrice);
                    ruble_price.Text = RublePrice.ToString();
                }
                else if (lira_price.Text[lira_price.Text.Length - 1] != 44)
                { lira_price.Text = lira_price.Text.Substring(0, lira_price.Text.Length - 1); }
            }
            else { ruble_price.Text = ""; }
        }

        private double Round10(double value)
        {
            value = value / 10;
            value = Math.Ceiling(value);
            value = value * 10;
            return value;
        }

        private void ruble_price_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
