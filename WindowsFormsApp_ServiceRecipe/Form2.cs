using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_ServiceRecipe.ServiceReference1;
using System.Windows.Forms;

namespace WindowsFormsApp_ServiceRecipe
{
    public partial class Form2 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string FoodName_input = foodname.Text.Trim();
                string RawMaterial_input = rawmaterial.Text.Trim();
                string Recipe_input = recipe.Text.Trim();

                // เรียกใช้งาน WCF Service เพื่อเพิ่มสินค้า
                AddData newData = new AddData
                {

                    FoodName = FoodName_input,
                    RawMaterial = RawMaterial_input,
                    Recipe = Recipe_input
                };

                client.AddDataFood(newData);

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ชื่อซ้ำกัน!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }

}

