﻿namespace WindowsFormsApp_ServiceRecipe
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.foodname = new System.Windows.Forms.TextBox();
            this.rawmaterial = new System.Windows.Forms.TextBox();
            this.recipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(492, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "เพิ่มเมนูทำอาหาร";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(558, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "เพิ่ม";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foodname
            // 
            this.foodname.AcceptsReturn = true;
            this.foodname.AcceptsTab = true;
            this.foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.foodname.Location = new System.Drawing.Point(103, 261);
            this.foodname.Margin = new System.Windows.Forms.Padding(2);
            this.foodname.Multiline = true;
            this.foodname.Name = "foodname";
            this.foodname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foodname.Size = new System.Drawing.Size(223, 257);
            this.foodname.TabIndex = 14;
            this.foodname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rawmaterial
            // 
            this.rawmaterial.AcceptsReturn = true;
            this.rawmaterial.AcceptsTab = true;
            this.rawmaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rawmaterial.Location = new System.Drawing.Point(522, 261);
            this.rawmaterial.Margin = new System.Windows.Forms.Padding(2);
            this.rawmaterial.Multiline = true;
            this.rawmaterial.Name = "rawmaterial";
            this.rawmaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawmaterial.Size = new System.Drawing.Size(223, 257);
            this.rawmaterial.TabIndex = 17;
            this.rawmaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recipe
            // 
            this.recipe.AcceptsReturn = true;
            this.recipe.AcceptsTab = true;
            this.recipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.recipe.Location = new System.Drawing.Point(914, 261);
            this.recipe.Margin = new System.Windows.Forms.Padding(2);
            this.recipe.Multiline = true;
            this.recipe.Name = "recipe";
            this.recipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipe.Size = new System.Drawing.Size(223, 257);
            this.recipe.TabIndex = 18;
            this.recipe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(108, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 58);
            this.label1.TabIndex = 19;
            this.label1.Text = "ชื่ออาหาร";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(548, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 58);
            this.label3.TabIndex = 20;
            this.label3.Text = "วัตถุดิบ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(904, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 58);
            this.label4.TabIndex = 21;
            this.label4.Text = "สูตรอาหาร";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipe);
            this.Controls.Add(this.rawmaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.foodname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.TextBox rawmaterial;
        private System.Windows.Forms.TextBox recipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}