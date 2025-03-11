using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_ServiceRecipe.ServiceRecipe;

namespace WindowsFormsApp_ServiceRecipe
{
    public partial class Form1 : Form
    {
        ServiceRecipe.Service1Client client = new ServiceRecipe.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAllFoodName_Click(object sender, EventArgs e)
        {
            // เรียกใช้ WCF Service เพื่อดึงรายการสินค้า
            GetAllFoodName[] FoodNames = client.GetAllFoodName();

            if (FoodNames != null && FoodNames.Length > 0)
            {
                // ล้าง DataGridView ก่อนเพิ่มข้อมูลใหม่
                dgvFoodName.Rows.Clear();
                dgvFoodName.Columns.Clear();

                // ก าหนดคอลัมน์เอง
                dgvFoodName.Columns.Add("FoodName","รายชื่อเมนู");


                // เพิ่มข้อมูลเข้าไปทีละแถว
                foreach (var product in FoodNames)
                {
                    dgvFoodName.Rows.Add(product.FoodName);
                }
            }
            else
            {
                MessageBox.Show("No products found.", "Info", MessageBoxButtons.OK,
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
    }
}
