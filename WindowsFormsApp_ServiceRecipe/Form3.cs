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
    public partial class Form3 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public Form3()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int foodId = int.Parse(foodid.Text);
                string FoodName_input = foodname.Text.Trim();
                string RawMaterial_input = rawmaterial.Text.Trim();
                string Recipe_input = recipe.Text.Trim();

                SearchAndUpdate updata = new SearchAndUpdate
                {
                    FoodID = foodId,
                    FoodName = FoodName_input,
                    RawMaterial = RawMaterial_input,
                    Recipe = Recipe_input

                };

                // เรียกใช้เมทอด UpdateDataFood เพื่ออัปเดตข้อมูล
                client.UpdateDataFood(updata);

                MessageBox.Show("เพิ่มเมนูสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ข้อผิดพลาด", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foodid.Clear();
            foodname.Clear();
            rawmaterial.Clear();
            recipe.Clear();
        }
    }
}
