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
                // ตรวจสอบค่าว่าง
                if (string.IsNullOrWhiteSpace(foodname.Text) ||
                    string.IsNullOrWhiteSpace(rawmaterial.Text) ||
                    string.IsNullOrWhiteSpace(recipe.Text))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // หยุดการทำงานหากมีค่าว่าง
                }

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

                MessageBox.Show("เพิ่มเมนูสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("มีเมนูนี้อยู่แล้ว", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foodname.Clear();
            rawmaterial.Clear();
            recipe.Clear();
        }
    }
}

