using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleUsingAdoDotNet
{
    public partial class VehicleDialog : Form
    {
        public VehicleDialog()
        {
            InitializeComponent();
            cmbColor.DataSource = Enum.GetValues(typeof(Color));
        }
        Vehicle vehicle;
        public VehicleDialog(Vehicle vehicle)
        {
            InitializeComponent();
           
            this.vehicle = vehicle;
            txtRegNo.Text = vehicle.RegNo;
            if (vehicle.TypeOfVehicle == "Car")
                rbnCar.Checked = true;
            else if(vehicle.TypeOfVehicle == "Truck")
                rbnTruck.Checked = true;
            GetAllColors();
            GetAllMake();
            GetAllModel();
            cmbMake.SelectedItem = vehicle.Make;
            cmbModel.SelectedItem = vehicle.Model;
            cmbColor.SelectedItem = vehicle.Color.ToString();
            txtPrice.Text = vehicle.Price.ToString();
            txtSpeed.Text = vehicle.Speed.ToString();
            dtpdate.Text = vehicle.DateOfManufacture.ToString();
        }
        VehicleForm objForm = new VehicleForm();
        List<Vehicle> lstVehicle = new List<Vehicle>();

        public string TypeOfVehicle
        {
            get
            {
                if (this.rbnCar.Checked)
                    return rbnCar.Text;
                else
                    return rbnTruck.Text;
            }
            set
            {
                if(this.rbnCar.Checked)
                {
                    rbnCar.Text = value;
                }
                else
                {
                    rbnTruck.Text = value;
                }
            }
        }
        public string RegNo
        {
            get
            {
                return txtRegNo.Text;
            }
            set
            {
                txtRegNo.Text = value;
            }
        }
        public DateTime DateOfManufacture
        {
            get
            {
                return Convert.ToDateTime(dtpdate.Text);
            }
            set
            {
                dtpdate.Text = value.ToString();
            }
        }
        public string Color
        {
            get
            {
                return cmbColor.Text;
            }
            set
            {
                cmbColor.Text = value;
            }
        }
        public string Make
        {
            get
            {
                return cmbMake.Text;
            }
            set
            {
                cmbMake.Text = value;
            }
        }
        public string Model
        {
            get
            {
                return cmbModel.Text;
            }
            set
            {
                cmbModel.Text = value;
            }
        }
        public string Speed
        {
            get
            {
                return txtSpeed.Text;
            }
            set
            {
                txtSpeed.Text = value;
            }
        }
        public decimal Price
        {
            get
            {
                return decimal.Parse(txtPrice.Text);
            }
            //set
            //{
            //    txtPrice.Text = value.ToString();
            //}
        }
        private void VehicleDialog_Load(object sender, EventArgs e)
        {

        }
        public void GetAllColors()
        {
            cmbColor.Items.Clear();
            cmbColor.Items.Add("Select Color");
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Brown");
            cmbColor.Items.Add("Grey");
            cmbColor.Items.Add("White");
            cmbColor.Items.Add("Red");
            cmbColor.SelectedIndex = 0;
        }
        public void GetAllMake()
        {
            cmbMake.Items.Clear();
            cmbMake.Items.Add("--Select--");
            if (this.rbnCar.Checked)
            {
                cmbMake.Items.Clear();
                cmbMake.Items.Add("Hyundai");
                cmbMake.Items.Add("Nexa");
                cmbMake.Items.Add("Ford Motor");
                cmbMake.Items.Add("Renault-Nissan Alliance");
            }
            else if (this.rbnTruck.Checked)
            {
                cmbMake.Items.Clear();
                cmbMake.Items.Add("Benz");
                cmbMake.Items.Add("Tata");
                cmbMake.Items.Add("Ashok Leyland");
                cmbMake.Items.Add("Mahendra");
            }
            cmbMake.SelectedIndex = 0;
        }
        public void GetAllModel()
        {
            cmbModel.Items.Clear();
            if (this.rbnCar.Checked)
            {
                switch (cmbMake.SelectedIndex)
                {
                    case 0:
                        cmbModel.Items.Add("Four doors");
                        cmbModel.Items.Add("Four doors");
                        cmbModel.Items.Add("Four doors");
                        break;
                    case 1:
                        cmbModel.Items.Add("Four doors");
                        cmbModel.Items.Add("Four doors");
                        break;
                    case 2:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                    case 3:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                }
            }
            else if (this.rbnTruck.Checked)
            {
                switch (cmbMake.SelectedIndex)
                {
                    case 0:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                    case 1:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                    case 2:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                    case 3:
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        cmbModel.Items.Add("Two doors");
                        break;
                }
            }
            else
            {
                cmbModel.Items.Add("Select Model");
                cmbColor.SelectedIndex = 0;
            }
        }
        private void btnAddToCollection_Click(object sender, EventArgs e)
        {
            if (TypeOfVehicle == "Car")
            {
                lstVehicle.Add(new Car()
                {
                    TypeOfVehicle = this.TypeOfVehicle,
                    RegNo = this.RegNo,
                    DateOfManufacture = this.DateOfManufacture,
                    //Color = this.Color,
                    Make = this.Make,
                    Model = this.Model,
                    //Price = this.Price
                });
            }
            else if (TypeOfVehicle == "Truck")
            {
                lstVehicle.Add(new Truck()
                {
                    TypeOfVehicle = this.TypeOfVehicle,
                    RegNo = this.RegNo,
                    DateOfManufacture = this.DateOfManufacture,
                    //Color = this.Color,
                    Make = this.Make,
                    Model = this.Model,
                    //Price = this.Price
                });
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Color color;
            Enum.TryParse(cmbColor.SelectedItem.ToString(), out color);
            vehicle.Color = color;
            //vehicle.Price = Convert.ToDecimal(txtPrice.Text);
            vehicle.Make = cmbMake.SelectedItem.ToString();
            vehicle.Model = cmbModel.SelectedItem.ToString();
            vehicle.RegNo = txtRegNo.Text;
            vehicle.DateOfManufacture = dtpdate.Value;
            vehicle.Speed =Convert.ToInt32(txtSpeed.Text.ToString());
            if (rbnCar.Checked)
                vehicle.TypeOfVehicle = "Car";
            else
                vehicle.TypeOfVehicle = "Truck";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rbnTruck_CheckedChanged(object sender, EventArgs e)
        {
            //GetAllColors();
            //GetAllMake();
            ////GetAllModel();
        }

        private void rbnCar_CheckedChanged(object sender, EventArgs e)
        {
            //GetAllColors();
            //GetAllMake();
            ////GetAllModel();
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllModel();
        }
    }
}
