namespace WindowsFormsApp_ServiceRecipe
{
    partial class Form4
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
            this.foodname = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(225, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "ป้อนชื่ออาหารที่ต้องการลบ";
            // 
            // foodname
            // 
            this.foodname.Location = new System.Drawing.Point(232, 224);
            this.foodname.Multiline = true;
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(342, 65);
            this.foodname.TabIndex = 8;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Delete.Location = new System.Drawing.Point(331, 332);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(151, 57);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "ลบข้อมูล";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foodname);
            this.Controls.Add(this.Delete);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.Button Delete;
    }
}