namespace WindowsFormsApp_ServiceRecipe
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.foodid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.foodname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rawmaterial = new System.Windows.Forms.TextBox();
            this.recipe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(109, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "ป้อน Food_iD";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(129, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "แก้ไข";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foodid
            // 
            this.foodid.AcceptsReturn = true;
            this.foodid.AcceptsTab = true;
            this.foodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.foodid.Location = new System.Drawing.Point(115, 288);
            this.foodid.Multiline = true;
            this.foodid.Name = "foodid";
            this.foodid.Size = new System.Drawing.Size(170, 59);
            this.foodid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(543, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "แก้ไขข้อมูล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(347, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "ป้อนชื่ออาหาร";
            // 
            // foodname
            // 
            this.foodname.AcceptsReturn = true;
            this.foodname.AcceptsTab = true;
            this.foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.foodname.Location = new System.Drawing.Point(353, 222);
            this.foodname.Multiline = true;
            this.foodname.Name = "foodname";
            this.foodname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foodname.Size = new System.Drawing.Size(161, 242);
            this.foodname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(632, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "ป้อนชื่ออาหาร";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(993, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "ป้อนชื่ออาหาร";
            // 
            // rawmaterial
            // 
            this.rawmaterial.AcceptsReturn = true;
            this.rawmaterial.AcceptsTab = true;
            this.rawmaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.rawmaterial.Location = new System.Drawing.Point(551, 222);
            this.rawmaterial.Multiline = true;
            this.rawmaterial.Name = "rawmaterial";
            this.rawmaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawmaterial.Size = new System.Drawing.Size(333, 242);
            this.rawmaterial.TabIndex = 26;
            // 
            // recipe
            // 
            this.recipe.AcceptsReturn = true;
            this.recipe.AcceptsTab = true;
            this.recipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.recipe.Location = new System.Drawing.Point(929, 222);
            this.recipe.Multiline = true;
            this.recipe.Name = "recipe";
            this.recipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipe.Size = new System.Drawing.Size(301, 242);
            this.recipe.TabIndex = 27;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1258, 629);
            this.Controls.Add(this.recipe);
            this.Controls.Add(this.rawmaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foodname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.foodid);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox foodid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rawmaterial;
        private System.Windows.Forms.TextBox recipe;
    }
}