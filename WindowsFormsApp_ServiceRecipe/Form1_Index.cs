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
        ServiceWikiFood.Service1Client client = new ServiceWikiFood.Service1Client();
        public Form1_Index()
        {
            InitializeComponent();
        }

        private void GetAllFoodName_Click(object sender, EventArgs e)
        {
            // เรียกใช้ WCF Service เพื่อดึงรายการ Food
            ShowAll[] FoodNames = client.ShowAllFoods();
            if (FoodNames != null && FoodNames.Length > 0)
            {
                // ล้าง DataGridView ก่อนเพิ่มข้อมูลใหม่
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                // กำหนดคอลัมน์เอง
                dataGridView2.Columns.Add("FoodID", "รหัสอาหาร");
                dataGridView2.Columns.Add("FoodName", "รายชื่อเมนู");
                // เพิ่มข้อมูลเข้าไปทีละแถว
                foreach (var Food in FoodNames)
                {
                    dataGridView2.Rows.Add(Food.FoodID, Food.FoodName);
                }
            }
            else
            {
                MessageBox.Show("ไม่พบเมนูในขณะนี้", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void SearchFoodName_Click(object sender, EventArgs e)
        {
            {
                string menuName = txtSearchMenu.Text; // รับค่าจากช่องค้นหา
                SearchAndUpdate food = client.SearchFoodName(menuName);
                if (food != null)
                {
                    // ล้าง RichTextBox ก่อนเพิ่มข้อมูลใหม่
                    richTextBox1.Clear();

                    // AppendText ใช้สำหรับเพิ่มข้อความต่อท้ายข้อความเดิมที่มีอยู่แล้วในคอนโทรล RichTextBox
                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️ชื่ออาหาร⬇️⬇️⬇️\n------------------------------\n : " + food.FoodName + "\n------------------------------\n\n");
                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️วัตถุดิบ⬇️⬇️⬇️\n------------------------------\n" + food.RawMaterial + "\n------------------------------\n\n");
                    richTextBox1.AppendText("------------------------------\n⬇️⬇️⬇️สูตรอาหาร⬇️⬇️⬇️\n------------------------------\n" + food.Recipe);
                }
                else
                {
                    MessageBox.Show("ไม่พบเมนูนี้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtSearchMenu.Clear();
            }
        }

        private void Form2_AddDataFood_Click(object sender, EventArgs e)
        {
            Form2_AddDataFood SwitchToform2 = new Form2_AddDataFood();
            SwitchToform2.Show();
            // ซ่อนฟอร์มแรก
            this.Hide(); 
            // เพิ่ม event handler เมื่อฟอร์ม 2 ถูกปิด ให้แสดงฟอร์ม 1 อีกครั้ง
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

