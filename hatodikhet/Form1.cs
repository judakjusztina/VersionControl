﻿using hatodikhet.Entities;
using hatodikhet.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hatodikhet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GetExchangeRates();
            BindingList<RateData> rates= new BindingList<RateData>();
            dataGridView1.DataSource = rates;
        }
        public void GetExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }
    }
}
