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
    public partial class CarViewDetails : Form
    {
        private Car car;

        public CarViewDetails(Car car)
        {
            InitializeComponent();
            this.car = car;
        }



        private void CarViewDetails_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Car title
            lblCarName.Text = car.getName();

            // Car picture

            // Car description
            lblCarDescription.Text = car.Description;

            // Car info
            lblCarInfoLeft.Text =
                $"Kilometertal: {car.Kilometers_Driven}\n" +
                $"Drivmiddel: {car.FuelType}\n" +
                $"Tophastighed: {car.Top_Speed}\n" +
                $"Farve: {car.Color}";

            lblCarInfoRight.Text =
                $"Modelår: {car.Year}\n" +
                $"Mærke: {car.Brand}\n" +
                $"Model: {car.Model}\n" +
                $"Type: {car.Type}";
        }
    }
}
