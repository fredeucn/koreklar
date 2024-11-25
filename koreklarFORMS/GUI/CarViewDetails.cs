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

        public CarViewDetails(Car car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void CarViewDetails_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblCarName.Text = car.getName();
        }
    }
}
