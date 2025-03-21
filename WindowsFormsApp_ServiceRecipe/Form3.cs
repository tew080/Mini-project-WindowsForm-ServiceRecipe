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
        public Form3()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int foodId = int.Parse(foodID.Text);
            
            SearchAndUpdate updata = new SearchAndUpdate
           
            {
                FoodName= foodname.Text,        // ชื่ออาหารใหม่
                Recipe = Recipe.Text,        // วิธีทำใหม่
                RawMaterial = Raw_material.Text // วัตถุดิบใหม่
            };

            // เรียกใช้เมทอด UpdateDataFood เพื่ออัปเดตข้อมูล
            client.UpdateDataFood(updata);

        }
    }
}
