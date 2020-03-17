using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace VehicleUsingAdoDotNet
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();

        }

        List<Vehicle> vehicles = new List<Vehicle>();


        protected void VehicleForm_Load(object sender, EventArgs e)
        {
            dgvVehicleDetails.AutoGenerateColumns = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Excel File|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    readExcel(fileName);
                }
            }
            dgvVehicleDetails.DataSource = vehicles;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var rowIndex = dgvVehicleDetails.CurrentCell.RowIndex;
            VehicleDialog objDialog = new VehicleDialog(vehicles[rowIndex]);
            //objDialog.GetAllColors();
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                dgvVehicleDetails.Update();
                dgvVehicleDetails.Refresh();
            }

        }

        //read excel file
        private void readExcel(string sFile)
        {
            IWorkbook book;
            Vehicle vehicle;
            using (FileStream file = new FileStream(sFile, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    book = new XSSFWorkbook(file);
                }
                catch
                {
                    book = null;
                }

                // If reading fails, try to read workbook as XLS:
                if (book == null)
                {
                    book = new HSSFWorkbook(file);
                }
            }

            ISheet sheet = book.GetSheetAt(0);
            for (int row = 1; row <= sheet.LastRowNum; row++)
            {
                if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                {
                    string typeofVehicle = sheet.GetRow(row).GetCell(0).ToString();

                    string RegNo = sheet.GetRow(row).GetCell(1).ToString();
                    DateTime DateOfManufacture = sheet.GetRow(row).GetCell(2).DateCellValue;
                    Color color;
                    Enum.TryParse(sheet.GetRow(row).GetCell(3).ToString(), out color);
                    string Make = sheet.GetRow(row).GetCell(4).ToString();
                    string Model = sheet.GetRow(row).GetCell(5).ToString();
                    int speed = Convert.ToInt32(sheet.GetRow(row).GetCell(7).ToString());
                    decimal Price = Convert.ToDecimal(sheet.GetRow(row).GetCell(6).ToString());
                    if (typeofVehicle == "Car")
                    {
                        vehicle = new Car(RegNo, typeofVehicle, Make, Model, color, Price, DateOfManufacture);
                        vehicle.Speed = speed;
                    }
                    else
                    {
                        vehicle = new Truck(RegNo, typeofVehicle, Make, Model, color, Price, DateOfManufacture);
                        vehicle.Speed = speed;
                    }
                    vehicles.Add(vehicle);

                }
            }

        }

        private void dgvVehicleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter myOutputStream = new StreamWriter("Myfile.csv");
            foreach (var vehicle in vehicles)
            {
                string line = $"{vehicle.TypeOfVehicle},{vehicle.RegNo},{vehicle.DateOfManufacture},{vehicle.Color},{vehicle.Make},{vehicle.Model},{vehicle.Price},{vehicle.Speed}";
                myOutputStream.WriteLine(line);
            }
            myOutputStream.Close();
            MessageBox.Show("File Saved at:" + Directory.GetCurrentDirectory());
        }

        private void slected_changed(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvVehicleDetails.CurrentCell.RowIndex;
            dgvVehicleDetails.DataSource = null;
            vehicles.RemoveAt(rowIndex);
            dgvVehicleDetails.DataSource = vehicles;
            dgvVehicleDetails.Update();
            dgvVehicleDetails.Refresh();
        }
    }
}
