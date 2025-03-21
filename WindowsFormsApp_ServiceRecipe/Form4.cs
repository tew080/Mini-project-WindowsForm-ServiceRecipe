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
            try
            {
                string FoodName_input = foodname.Text.Trim();

                DeleteData newData = new DeleteData
                {
                    FoodName = FoodName_input,
                };

                bool isSuccess = client.DeleteDataFood(newData); // ให้ฟังก์ชันนี้คืนค่า true/false

                if (isSuccess)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // กรณีที่ลบไม่สำเร็จ (ไม่พบข้อมูลหรือมีปัญหาอื่นๆ)
                    MessageBox.Show("โปรดป้อนชื่ออาหารที่ต้องการลบ หรือ ไม่มีชื่อเมนูที่ต้องการลบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
