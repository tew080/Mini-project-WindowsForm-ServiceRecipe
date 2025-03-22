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
    public partial class Form1_Index : Form
    {
        /*
         * ประกาศการเรียกใช้ WCF Service ServiceWikiFood ที่สามารถเรียกใช้ได้ทั้ง from
         */
        ServiceWikiFood.Service1Client client = new ServiceWikiFood.Service1Client();
        public Form1_Index()
        {
            InitializeComponent();
        }

        /*
         * Button GetAllFoodName จะเรียกใช้ Service GetAllFoodName และ ดึงค่าจาก DataMember ShowAll[] ที่เก็บ FoodID และ FoodName
         * โดย ถ้า มีข้อมูลอาหาร มากกว่า 0 ถ้าตรงตามเงื่อนไข ล้างข้อมูลที่แสดงก่อนหน่าโดยใช้ .Rows.Clear(); และ .Columns.Clear(); 
         * ต่อจากนั้นจะ ดึงข้อมูล จาก  Columns FoodID และ FoodName เเละจะเรียกแสดงข้อมูลทีละแถว โดยใช้การวนรอบ foreach 
         * หรือ หากไม่ตรงกับเงื่อนไขข้างบน จะโชว์ MessageBox แสดง ไม่พบเมนูในขณะนี้", "Info"
         */
        private void GetAllFoodName_Click(object sender, EventArgs e)
        {
            ShowAll[] FoodNames = client.ShowAllFoods();
            if (FoodNames != null && FoodNames.Length > 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                dataGridView2.Columns.Add("FoodID", "รหัสอาหาร");
                dataGridView2.Columns.Add("FoodName", "รายชื่อเมนู");
                foreach (var Food in FoodNames)
                {
                    dataGridView2.Rows.Add(Food.FoodID, Food.FoodName);
                }
            }
            else
            {
                MessageBox.Show("ไม่พบเมนูในขณะนี้", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /*
         * Button SearchFoodName จะเรียกใช้ Service SearchFoodName ดึงค่าจาก DataMember SearchAndUpdate ที่เก็บ FoodName, RawMaterial, Recipe
         * และ รับค่าชื่อเมนู หรือ idเมนู เพื่อค้นหา วัตถุดิบและสูตรอาหาร 
         * โดย ถ้า มีข้อมูลอาหาร จะล้างข้อมูลที่แสดงก่อนหน้าโดยใช้ richTextBox1.Clear();
         * โดยใช้ richTextBox เป็นตัวแสดงผลซื่งช่วยให้การแสดง วัตถุดิบและสูตรอาหาร มีรูปแบบที่อ่านง่ายและรองรับข้อความที่มีขนาดยาว 
         * และใช้.AppendText();เพื่อให้แสดงผลได้ต่อเนื่องกัน 
         * และหากไม่พบข้อมูล จะโชว์ MessageBox แสดง "ไม่พบเมนูนี้", "Error"
         * และจะล้างข้อความก่อนหน้าของ txtSearchMenu.Text;
         */
        private void SearchFoodName_Click(object sender, EventArgs e)
        { 
            {
                string menuName = txtSearchMenu.Text; 
                SearchAndUpdate food = client.SearchFoodName(menuName);
                if (food != null)
                {
                    richTextBox1.Clear();

                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️ชื่ออาหาร⬇️⬇️⬇️\n------------------------------\n : " + food.FoodName + "\n------------------------------\n\n");
                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️วัตถุดิบ⬇️⬇️⬇️\n------------------------------\n" + food.RawMaterial + "\n------------------------------\n\n");
                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️สูตรอาหาร⬇️⬇️⬇️\n------------------------------\n" + food.Recipe);
                }
                else
                {
                    MessageBox.Show("ไม่พบเมนูนี้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtSearchMenu.Clear();
            }
        }

        /*
         * Button Form x _AddDataFood_Click, Button Form x _UpdateDataFood_Click, Button Form x _DeleteDataFood_Click 
         * จะเป็นการสลับไปยังfromที่ต้องการ โดยกำหนด Object = Form x _AddDataFood โดยจะเรีดกใช้ด้วยตัวแปร  SwitchToform2
         * SwitchToform x .Show(); จะเป็นการโชว์ Form x _AddDataFood
         * และจะซ้อน from ก่อนหน้านี้โดยใช้ this.Hide(); 
         * และเมื่อปิก from ปัจจุบัน จะทำการโชว์ from ที่ปิดไปก่อนหน้าขึ้นมา SwitchToform x .FormClosed += (s, args) => this.Show();
         */
        private void Form2_AddDataFood_Click(object sender, EventArgs e)
        {
            Form2_AddDataFood SwitchToform2 = new Form2_AddDataFood();
            SwitchToform2.Show();
            this.Hide(); 
            SwitchToform2.FormClosed += (s, args) => this.Show();
        }
        private void Form3_UpdateDataFood_Click(object sender, EventArgs e)
        {
            Form3_UpdateDataFood SwitchToform3 = new Form3_UpdateDataFood();
            SwitchToform3.Show();
            this.Hide(); 
            SwitchToform3.FormClosed += (s, args) => this.Show();
        }
        private void Form4_DeleteDataFood_Click(object sender, EventArgs e)
        {
            Form4_DeleteDataFood SwitchToform4 = new Form4_DeleteDataFood();
            SwitchToform4.Show();
            this.Hide(); 
            SwitchToform4.FormClosed += (s, args) => this.Show();
        }
    }
}

