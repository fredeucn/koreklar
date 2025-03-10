﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koreklarFORMS.GUI
{
    public partial class CustomCarListView : UserControl
    {
        private Car car;

        public CustomCarListView(Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void CustomCarListView_Load(object sender, EventArgs e)
        {
            lblCarName.Text = car.Brand + car.Model;
            lblPrice.Text = car.Price.ToString() + " kr.";
        }
    }
}
