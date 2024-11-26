﻿using koreklarFORMS.Controllers;
using Models.Models;
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
    public partial class Create : Form
    {
        CarController carController;
        byte[] image;
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            carController = new CarController();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Debug.WriteLine("Confirm Check 1");
            if (!int.TryParse(txtYear.Text, out int year) || year < 1800 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year between 1800 and the current year.");
                return;
            }

            if (!int.TryParse(txtOdometer.Text, out int odometer))
            {
                MessageBox.Show("Please enter a positive value for odometer");
                return;
            }

            if (!int.TryParse(txtTopSpeed.Text, out int topSpeed))
            {
                MessageBox.Show("Please enter a positive value for top speed");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a positive value for price");
                return;
            }
            


            Car newCar = new Car(year, odometer, topSpeed, price, image, txtCondition.Text, txtDescription.Text, txtVin.Text, txtColor.Text, txtFuelType.Text, txtBrand.Text, txtModel.Text, txtType.Text);

            MessageBox.Show("Car Created!" + newCar.ToString());

            carController.CreateCar(newCar);

            //this.DestroyHandle();
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Image check 1");
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    image = File.ReadAllBytes(imagePath);
                    System.Diagnostics.Debug.WriteLine("Image check 2");
                }
            }
        }

        private void txt_Year_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
            (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
            e.KeyCode == Keys.Back))
            {
                e.SuppressKeyPress = true; // Prevent the key from being processed
            }
        }
    }
}
