﻿using System;
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
                    if (price < 100) { RublePrice = price * 4.8; }
                    if (price >= 100 && price <= 698) { RublePrice = Math.Ceiling(price * 1.07) * 4.5; }
                    if (price >= 699 && price <= 1198) { RublePrice = Math.Ceiling(price * 1.07) * 4.15; }
                    if (price >= 1199 && price <= 1798) { RublePrice = Math.Ceiling(price * 1.07) * 4; }
                    if (price >= 1799) { RublePrice = Math.Ceiling(price * 1.07) * 3.9; }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
