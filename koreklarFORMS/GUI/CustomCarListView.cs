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
            // Car picture
            try
            {
                if (car.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(car.Image))
                    {
                        picCar.Image = Image.FromStream(ms);
                    }
                }
            } catch 
            {

            }
            

            // Car Name and Price
            lblCarName.Text = car.GetName();
            lblPrice.Text = "Fra: " + (200 + car.Price).ToString() + " kr.";
        }

        private void PicCar_Click(object sender, EventArgs e)
        {
            CarViewDetails cvd = new CarViewDetails(car);
            cvd.Show();
        }
    }
}
