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
    public partial class Form1 : Form
    {


        public Form1()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();


            InitializeComponent();
        }

        private void GetAllFoodName_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            // เรียกใช้ WCF Service เพื่อดึงรายการสินค้า
            ShowAll[] FoodNames = client.ShowAllFoods();

            if (FoodNames != null && FoodNames.Length > 0)
            {
                // ล้าง DataGridView ก่อนเพิ่มข้อมูลใหม่
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                // ก าหนดคอลัมน์เอง
                dataGridView2.Columns.Add("FoodID", "รหัสอาหาร");
                dataGridView2.Columns.Add("FoodName", "รายชื่อเมนู");


                // เพิ่มข้อมูลเข้าไปทีละแถว
                foreach (var product in FoodNames)
                {
                    dataGridView2.Rows.Add(product.FoodID, product.FoodName);
                }
            }
            else
            {
                MessageBox.Show("ไม่พบเมนูในขณะนี้", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // ซ่อนฟอร์มแรก

            // เพิ่ม event handler เมื่อฟอร์ม 2 ถูกปิด ให้แสดงฟอร์ม 1 อีกครั้ง
            form2.FormClosed += (s, args) => this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // ซ่อนฟอร์มแรก

            // เพิ่ม event handler เมื่อฟอร์ม 2 ถูกปิด ให้แสดงฟอร์ม 1 อีกครั้ง
            form3.FormClosed += (s, args) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide(); // ซ่อนฟอร์มแรก

            // เพิ่ม event handler เมื่อฟอร์ม 2 ถูกปิด ให้แสดงฟอร์ม 1 อีกครั้ง
            form4.FormClosed += (s, args) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            {
                string menuName = txtSearchMenu.Text; // รับค่าจากช่องค้นหา

                //var recipe = client.SearchFoodName(); // ดึงข้อมูลจาก Web Service โดยไม่ส่ง parameter

                SearchAndUpdate food = client.SearchFoodName(menuName);

                if (food != null)
                {
                    // ล้าง DataGridView ก่อนเพิ่มข้อมูลใหม่
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("FoodName", "ชื่ออาหาร");
                    dataGridView1.Columns.Add("RawMaterial", "วัตถุดิบ");
                    dataGridView1.Columns.Add("Recipe", "สูตรอาหาร");

                    dataGridView1.Rows.Add(food.FoodName, food.RawMaterial, food.Recipe);
                }
                else
                {
                    MessageBox.Show("ไม่พบเมนูนี้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtSearchMenu.Clear();
            }
        }
    }
}

