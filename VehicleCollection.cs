using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VehicleUsingAdoDotNet
{
    class VehicleCollection : List<Vehicle>
    {
        public override string ToString()
        {
            string str = "";
            foreach (var vehicleitem in this)
            {
                str += string.Format("RegNo:{0},Make:{1},Color:{3},Price:{4},DateOfManufacture{6} \r\n" + vehicleitem.RegNo, vehicleitem.Make, vehicleitem.Color, vehicleitem.Price, vehicleitem.Speed, vehicleitem.DateOfManufacture);
            }
            return str;
        }
        public void SaveToDatabase()
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string str = "";
            cmd.CommandType = CommandType.Text;
            foreach (var item in this)
            {
                cmd.CommandText = "Select VehicleId from VehicleDetails where RegNo=" + item.RegNo;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    item.VehicleId = dr.GetInt32(dr.GetOrdinal("VehicleId"));
                }
                else
                {
                    item.VehicleId = 0;
                }
                dr.Close();
                if (item.VehicleId == 0)
                {
                    str = string.Format("Insert into VehicleDetails(RegNo,DateOfManufacture,ColorOfVehicle,Make,Price,TypeOfVehicle) Values('" + item.RegNo + "' , '" + item.DateOfManufacture + "', '" + item.Color + "','" + "','" + item.Make + "','" + item.Price + "','" + item.TypeOfVehicle + "')");
                }
                else
                {
                    str = string.Format("update  VehicleDetails set RegNo='" + item.RegNo + "',DateOfManufacture= '" + item.DateOfManufacture + "',ColorOfVehicle='" + item.Color + "',Make='" + item.Make + "',Price='" + item.Price + "',TypeOfVehicle='" + item.TypeOfVehicle + "' where VehicleId='" + item.VehicleId + "'");
                }
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                item.VehicleId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
        }
        public List<int> LoadFromDatabase()
        {
            VehicleForm objVehicleForm = new VehicleForm();
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            this.Clear();
            cmd.CommandText = ("Select * From VehicleDetails");
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<int> lstRegisterNo = new List<int>();

            while (dr.Read())
            {
                lstRegisterNo.Add(Convert.ToInt32(dr["RegNo"]));
                
            }
            dr.Close();
            con.Close();

            return lstRegisterNo;
        }
    }
}

