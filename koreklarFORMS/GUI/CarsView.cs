using koreklarFORMS.ControllerLayer;
using koreklarFORMS.GUI;
using Models.Models;

namespace koreklarFORMS
{
    public partial class CarsView : Form
    {
        private CarController carController;

        public CarsView()
        {
            InitializeComponent();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            carController = new CarController();
            reloadCarView();
        }

        private async void reloadCarView()
        {
            List<Car> cars = await carController.GetAllCars();
            foreach (Car currentCar in cars)
            {
                CustomCarListView cclv = new CustomCarListView(currentCar);
                PanelCarList.Controls.Add(cclv);
            }
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            CarCreate carCreate = new CarCreate();
            carCreate.Show();
        }
    }
}
