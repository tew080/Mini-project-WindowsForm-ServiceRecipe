using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_ServiceRecipe.ServiceReference1;

namespace WindowsFormsApp_ServiceRecipe
{
    public partial class Form4 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public Form4()
        {
            InitializeComponent();
        }  

        private void Delete_Click(object sender, EventArgs e)
        {

            string FoodName_input = foodname.Text.Trim();


            DeleteData newData = new DeleteData
            {
                FoodName = FoodName_input,
            };

            client.DeleteDataFood(newData);

            MessageBox.Show("Delete successfully!", "Success", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
