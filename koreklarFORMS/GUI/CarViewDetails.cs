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
    public partial class CarViewDetails : Form
    {
        private Car car;
        private int months;
        private BookingController bookingController;

        public CarViewDetails(Car car)
        {
            InitializeComponent();
            this.car = car;
            this.bookingController = new BookingController();
        }

        private void CarViewDetails_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Car title
            lblCarName.Text = car.GetName();

            // Car picture
            if (car.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(car.Image))
                {
                    picCar.Image = Image.FromStream(ms);
                }
            }

            // Car info
            lblCarInfoLeft.Text =
                $"Kilometertal: {car.Kilometers_Driven}\n" +
                $"Drivmiddel: {car.Fuel_Type}\n" +
                $"Tophastighed: {car.Top_Speed}\n" +
                $"Farve: {car.Color}";

            lblCarInfoRight.Text =
                $"Modelår: {car.Year}\n" +
                $"Mærke: {car.Brand}\n" +
                $"Model: {car.Model}\n" +
                $"Type: {car.Type}";

            // Car description
            lblCarDescription.Text = car.Description;

            // Car subscriptions
            btnSubscription1.Checked = true;
            btnSubscription1_Clicked(sender, e);

            btnSubscription1.Text = "200 kr. / 1 måned";
            btnSubscription2.Text = "500 kr. / 3 måned";
            btnSubscription3.Text = "800 kr. / 6 måned";
        }


        // Subscription buttons
        private void btnSubscription1_Clicked(object sender, EventArgs e)
        {
            // Update car price description
            lblPriceText.Text = "Bil:\n" +
                "Abonnement:\n" +
                "Månedspris:\n" +
                "\n" +
                "Måneder:\n" +
                "Total:";

            lblPriceNumber.Text = $"+ {car.Price} kr.\n" +
                $"+ 200 kr.\n" +
                $"{Math.Ceiling(car.Price + 200)} kr.\n" +
                $"\n" +
                $"1 x {Math.Ceiling(car.Price + 200)} kr.\n" +
                $"{Math.Ceiling(car.Price + 200)} kr.";

            // Set months to selected subscription period
            months = 1;
        }

        private void btnSubscription2_Clicked(object sender, EventArgs e)
        {
            // Update car price description
            lblPriceText.Text = "Bil:\n" +
                "Abonnement:\n" +
                "Månedspris:\n" +
                "\n" +
                "Måneder:\n" +
                "Total:";

            lblPriceNumber.Text = $"+ {car.Price} kr.\n" +
                $"+ 166,66 kr.\n" +
                $"{Math.Ceiling(car.Price + 166.66)} kr.\n" +
                $"\n" +
                $"3 x {Math.Ceiling(car.Price + 166.66)} kr.\n" +
                $"{Math.Ceiling((car.Price + 166.66) * 3)} kr.";

            // Set months to selected subscription period
            months = 3;
        }

        private void btnSubscription3_Clicked(object sender, EventArgs e)
        {
            // Update car price description
            lblPriceText.Text = "Bil:\n" +
                "Abonnement:\n" +
                "Månedspris:\n" +
                "\n" +
                "Måneder:\n" +
                "Total:";

            lblPriceNumber.Text = $"+ {car.Price} kr.\n" +
                $"+ 133,33 kr.\n" +
                $"{Math.Ceiling(car.Price + 133.33)} kr.\n" +
                $"\n" +
                $"6 x {Math.Ceiling(car.Price + 133.33)} kr.\n" +
                $"{Math.Ceiling((car.Price + 133.33) * 6)} kr.";

            // Set months to selected subscription period
            months = 6;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            bookingController.CreateBooking(car, months);
            MessageBox.Show($"Abonnement oprettet!");
        }
    }
}
