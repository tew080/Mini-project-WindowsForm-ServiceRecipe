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
    public partial class Form4_DeleteDataFood : Form
    {
        /*
         * ประกาศการเรียกใช้ WCF Service ServiceWikiFood ที่สามารถเรียกใช้ได้ทั้ง from
         */
        ServiceWikiFood.Service1Client client = new ServiceWikiFood.Service1Client();
        public Form4_DeleteDataFood()
        {
            InitializeComponent();
        }

        /*
         * Button DeleteDataFood
         * string xxx = xxx.Text.Trim(); TextBox รับค่า เป็น string และ ลบช่องว่างหน้าสุดกับหลังสุดออกโดยใช้ Trim();
         * ดึงค่าจาก DataMember DeleteData ที่เก็บ FoodName
         * หลังจากนั้น จะเรียกใช้ Service UpdateDataFood เป็น bool ที่สามาถส่งค่ากลับได้
         * หากเพิ่มข้อมูลสำเร็จ จะโชว์ MessageBox แสดง "ลบข้อมูลสำเร็จ", "Success"
         * หรือ นอกเหนือจากนี้ จะโชว์ MessageBox แสดง "โปรดป้อนชื่ออาหารที่ต้องการลบ หรือ ไม่มีชื่อเมนูที่ต้องการลบ", "Warning"
         * หากไม่สำเร็จจะมีการตรวจสอบข้อผิดพลาดจาก catch (Exception ex) และ จะโชว์ MessageBox แสดง "เกิดข้อผิดพลาด: " + ex.Message, "Error"
         * และจะล้างข้อความก่อนหน้าของ foodname.Clear();
         */
        private void DeleteDataFood_Click(object sender, EventArgs e)
        {
            try
            {
                string FoodName_input = foodname.Text.Trim();

                DeleteData newData = new DeleteData
                {
                    FoodName = FoodName_input,
                };

                bool isSuccess = client.DeleteDataFood(newData); 

                if (isSuccess)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("โปรดป้อนชื่ออาหารที่ต้องการลบ หรือ ไม่มีชื่อเมนูที่ต้องการลบ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foodname.Clear();
        }
    }
}
