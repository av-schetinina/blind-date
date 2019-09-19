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

namespace Blind_dating.Web_forms
{
    public partial class Admin : Form
    {
        //Data Source=WIN-5C2I3KIDP3I\SQLEXPRESS;Initial Catalog=blinddating;Integrated Security=True
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();

        public Admin()
        {
            InitializeComponent();
        }

        private void CityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.blinddatingDataSet);

        }

        private void CityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.blinddatingDataSet);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "blinddatingDataSet.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.blinddatingDataSet.City);



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name ="id_city";
            dataGridView1.Columns[1].Name="city";

            btnShowCities.Enabled = false;
            btnShowCities.BackColor = Color.LightGray;
            List<City> cities = new List<City>();



            string connectString = @"Data Source=WIN-5C2I3KIDP3I\SQLEXPRESS;Initial Catalog=blinddating;Integrated Security=True;";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string sql = "SELECT *  FROM  City ORDER BY id_city";
            SqlCommand command = new SqlCommand(sql, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            
                        while (reader.Read())
                        {
                            var c = new City
                            {
                                id_city = reader[0].ToString(),
                                name = reader[1].ToString()
                            };

                            cities.Add(c);
                        }
                        reader.Close();
                        myConnection.Close();

            foreach (var item in cities)
            {
                dataGridView1.Rows.Add(item.id_city, item.name);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void SaveChanging_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Changes saved");

            }
        }
    }
}
