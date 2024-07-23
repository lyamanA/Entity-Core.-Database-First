namespace Entity_Core._Database_First
{
    public partial class Form1 : Form
    {
        private CarContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new CarContext();
            LoadCars();
        }

        private void LoadCars()
        {
            Car_listBox.Items.Clear();
            var cars = _context.Car.ToList();
            foreach (var car in cars)
            {
                Car_listBox.Items.Add(car.ToString());
            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var brandCar = Brand_textBox.Text;
                var modelCar = Model_textBox.Text;
                var yearCar = int.TryParse(Year_textBox.Text, out int year) ? year : 0;
                var stNumberCar = STNumber_textBox.Text;

                if (string.IsNullOrEmpty(brandCar) ||
                    string.IsNullOrEmpty(modelCar) ||
                    yearCar == 0 ||
                    string.IsNullOrEmpty(stNumberCar))
                {
                    MessageBox.Show("Fill all fields correctly.");
                    return;
                }

                var newCar = new Car
                {
                    Brand = brandCar,
                    Model = modelCar,
                    Year = yearCar,
                    ST_Number = stNumberCar
                };

                _context.Car.Add(newCar);
                _context.SaveChanges();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the car: {ex.Message}");
            }

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Car_listBox.SelectedItem == null)
            {
                MessageBox.Show("Select a car to update.");
                return;
            }

            var selectedCar = _context.Car.ToList()[Car_listBox.SelectedIndex];

            var brandCar = Brand_textBox.Text;
            var modelCar = Model_textBox.Text;
            var yearCar = int.Parse(Year_textBox.Text);
            var stNumberCar = STNumber_textBox.Text;

            try
            {
                selectedCar.Brand = brandCar;
                selectedCar.Model = modelCar;
                selectedCar.Year = yearCar;
                selectedCar.ST_Number = stNumberCar;

                _context.Car.Update(selectedCar);
                _context.SaveChanges();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the car: {ex.Message}");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Car_listBox.SelectedItem == null)
            {
                MessageBox.Show("Select a car to delete.");
                return;
            }

            var selectedCar = _context.Car.ToList()[Car_listBox.SelectedIndex];

            try
            {
                _context.Car.Remove(selectedCar);
                _context.SaveChanges();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the car: {ex.Message}");
            }
        }

        private void Car_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Car_listBox.SelectedItem != null)
            {
                var selectedCar = _context.Car.ToList()[Car_listBox.SelectedIndex];
                Brand_textBox.Text = selectedCar.Brand;
                Model_textBox.Text = selectedCar.Model;
                Year_textBox.Text = selectedCar.Year.ToString();
                STNumber_textBox.Text = selectedCar.ST_Number;
            }
        }
    }
}
