using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsAndDogsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CatsAndDogsDB.Properties.Settings.PetsConnectionString"].ConnectionString;
        }
       

       







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCars();
        }
        private void ListCars()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CarMark", connection))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);

                listCars.DisplayMember = "CarMarkName";
                listCars.ValueMember = "Id";
                listCars.DataSource = carTable;



            }
        }
        private void listCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarNames();
        }

        private void CarNames()
        {
            string query = "SELECT CarMark.CarMarkName FROM CarInGarage INNER JOIN CarMark ON CarInGarage.CarMarkId = CarInGarage.CarMarkId = @CarMarkId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CarMarkId", listCars.SelectedValue);
                DataTable carNameTable = new DataTable();
                adapter.Fill(carNameTable);
                listCarName.DisplayMember = "CarModelName";
                listCarName.ValueMember = "Id";
                listCarName.DataSource = carNameTable;





            }




        }



    }
}
