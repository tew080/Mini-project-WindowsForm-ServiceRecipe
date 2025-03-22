using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_ServiceRecipe.ServiceWikiFood;
using System.Windows.Forms;

namespace WindowsFormsApp_ServiceRecipe
{
    public partial class Form2_AddDataFood : Form
    {
        /*
         * ประกาศการเรียกใช้ WCF Service ServiceWikiFood ที่สามารถเรียกใช้ได้ทั้ง from
         */
        ServiceWikiFood.Service1Client client = new ServiceWikiFood.Service1Client();
        public Form2_AddDataFood()
        {
            InitializeComponent();
        }

        /*
         * Button AddDataFood 
         * จะมีเงื่อนไขว่า จะตรวจสอบค่าว่างโดย string.IsNullOrWhiteSpace() หาก TextBox ไม่มีการป้อนค่า และจะหยุดการทำงานหากมีค่าว่าง
         * จะโชว์ MessageBox แสดง "กรุณากรอกข้อมูลให้ครบทุกช่อง", "Warning"
         * string xxx = xxx.Text.Trim(); TextBox รับค่า เป็น string และ ลบช่องว่างหน้าสุดกับหลังสุดออกโดยใช้ Trim();
         * ดึงค่าจาก DataMember AddData ที่เก็บ FoodName, RawMaterial, Recipe 
         * หลังจากนั้น จะเรียกใช้ Service AddDataFood 
         * หากเพิ่มข้อมูลสำเร็จ จะโชว์ MessageBox แสดง "เพิ่มเมนูสำเร็จ", "Success"
         * หากไม่สำเร็จจะมีการตรวจสอบข้อผิดพลาดจาก catch (Exception ex) และ จะโชว์ MessageBox แสดง "มีเมนูนี้อยู่แล้ว" + ex.Message, "Error"
         * และจะล้างข้อความก่อนหน้าของ foodname.Clear();, rawmaterial.Clear();, recipe.Clear();
         */
        private void AddDataFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(foodname.Text) ||
                    string.IsNullOrWhiteSpace(rawmaterial.Text) ||
                    string.IsNullOrWhiteSpace(recipe.Text))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                string FoodName_input = foodname.Text.Trim();
                string RawMaterial_input = rawmaterial.Text.Trim();
                string Recipe_input = recipe.Text.Trim();
                AddData newData = new AddData
                {
                    FoodName = FoodName_input,
                    RawMaterial = RawMaterial_input,
                    Recipe = Recipe_input
                };
                client.AddDataFood(newData);
                MessageBox.Show("เพิ่มเมนูสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("มีเมนูนี้อยู่แล้ว" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foodname.Clear();
            rawmaterial.Clear();
            recipe.Clear();
        }
    }
}

