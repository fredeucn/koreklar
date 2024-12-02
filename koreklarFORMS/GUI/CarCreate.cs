using koreklarFORMS.ControllerLayer;
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
    public partial class CarCreate : Form
    {
        CarController carController;
        byte[] image;

        public CarCreate()
        {
            InitializeComponent();
        }

        private void CarCreate_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            carController = new CarController();

            txtFuelType.SelectedIndex = 0;
            txtCondition.SelectedIndex = 0;
        }

        private void imgUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Vælg et billede";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    image = File.ReadAllBytes(imagePath);

                    try
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            imgUpload.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Billedet kunne ikke indlæses.");
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYear.Text, out int year) || year < 1800 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Angiv et gyldigt modelår.");
                return;
            }

            if (!int.TryParse(txtDistance.Value.ToString(), out int distance))
            {
                MessageBox.Show("Angiv et gyldigt kilometertal.");
                return;
            }

            if (!int.TryParse(txtTopSpeed.Value.ToString(), out int topSpeed))
            {
                MessageBox.Show("Angiv en gyldig tophastighed.");
                return;
            }

            if (!double.TryParse(txtPrice.Value.ToString(), out double price))
            {
                MessageBox.Show("Angiv en gyldig pris.");
                return;
            }

            Car newCar = new Car(year, distance, topSpeed, price, image, txtCondition.Text, txtDescription.Text, txtVin.Text, txtColor.Text, txtFuelType.Text, txtBrand.Text, txtModel.Text, txtType.Text, txtLicensePlate.Text);

            carController.CreateCar(newCar);
        }
    }
}
