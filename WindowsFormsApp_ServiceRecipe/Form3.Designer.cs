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
            this.foodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.foodname = new System.Windows.Forms.TextBox();
            this.Raw_material = new System.Windows.Forms.TextBox();
            this.Recipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(357, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "ป้อน Food_iD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "แก้ไข";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foodID
            // 
            this.foodID.Location = new System.Drawing.Point(484, 121);
            this.foodID.Name = "foodID";
            this.foodID.Size = new System.Drawing.Size(100, 22);
            this.foodID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "แก้ไขข้อมูล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(357, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "ป้อนชื่ออาหาร";
            // 
            // foodname
            // 
            this.foodname.Location = new System.Drawing.Point(485, 179);
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(100, 22);
            this.foodname.TabIndex = 23;
            // 
            // Raw_material
            // 
            this.Raw_material.Location = new System.Drawing.Point(277, 50);
            this.Raw_material.Name = "Raw_material";
            this.Raw_material.Size = new System.Drawing.Size(100, 22);
            this.Raw_material.TabIndex = 6;
            // 
            // Recipe
            // 
            this.Recipe.Location = new System.Drawing.Point(3, 50);
            this.Recipe.Name = "Recipe";
            this.Recipe.Size = new System.Drawing.Size(100, 22);
            this.Recipe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(276, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "วัตถุดิบ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "วิธีทำ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Recipe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Raw_material, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 243);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.51613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.48387F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 329);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 750);
            this.Controls.Add(this.foodname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.foodID);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox foodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.TextBox Raw_material;
        private System.Windows.Forms.TextBox Recipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}