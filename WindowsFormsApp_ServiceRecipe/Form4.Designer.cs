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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(415, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "ป้อนชื่ออาหารที่ต้องการลบ";
            // 
            // foodname
            // 
            this.foodname.BackColor = System.Drawing.Color.Ivory;
            this.foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.foodname.Location = new System.Drawing.Point(456, 256);
            this.foodname.Multiline = true;
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(342, 65);
            this.foodname.TabIndex = 8;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Ivory;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Delete.Location = new System.Drawing.Point(555, 362);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(151, 57);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "ลบข้อมูล";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::WindowsFormsApp_ServiceRecipe.Properties.Resources._01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 629);
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