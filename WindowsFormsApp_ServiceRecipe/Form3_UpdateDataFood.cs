using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_ServiceRecipe.ServiceWikiFood;

namespace WindowsFormsApp_ServiceRecipe
{
    public partial class Form3_UpdateDataFood : Form
    {
        ServiceWikiFood.Service1Client client = new ServiceWikiFood.Service1Client();
        public Form3_UpdateDataFood()
        {
            InitializeComponent();
        }
        private void UpdateDataFood_Click(object sender, EventArgs e)
        {
            try
            {
                // ตรวจสอบค่าว่าง
                if (string.IsNullOrWhiteSpace(foodid.Text) || 
                    string.IsNullOrWhiteSpace(foodname.Text) ||
                    string.IsNullOrWhiteSpace(rawmaterial.Text) ||
                    string.IsNullOrWhiteSpace(recipe.Text))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // หยุดการทำงานหากมีค่าว่าง
                }
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
                MessageBox.Show("อัพเดทเมนูสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
