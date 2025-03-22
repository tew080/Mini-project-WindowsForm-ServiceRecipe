namespace WindowsFormsApp_ServiceRecipe
{
    partial class Form1_Index
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Index));
            this.GetAllFoodName = new System.Windows.Forms.Button();
            this.SearchFoodName = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearchMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAllFoodName
            // 
            this.GetAllFoodName.BackColor = System.Drawing.Color.Ivory;
            this.GetAllFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GetAllFoodName.Location = new System.Drawing.Point(104, 176);
            this.GetAllFoodName.Name = "GetAllFoodName";
            this.GetAllFoodName.Size = new System.Drawing.Size(285, 63);
            this.GetAllFoodName.TabIndex = 0;
            this.GetAllFoodName.Text = "แสดงเมนูทั้งหมด";
            this.GetAllFoodName.UseVisualStyleBackColor = false;
            this.GetAllFoodName.Click += new System.EventHandler(this.GetAllFoodName_Click);
            // 
            // SearchFoodName
            // 
            this.SearchFoodName.BackColor = System.Drawing.Color.Ivory;
            this.SearchFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchFoodName.Location = new System.Drawing.Point(695, 120);
            this.SearchFoodName.Name = "SearchFoodName";
            this.SearchFoodName.Size = new System.Drawing.Size(154, 50);
            this.SearchFoodName.TabIndex = 2;
            this.SearchFoodName.Text = "ค้นหาเมนู";
            this.SearchFoodName.UseVisualStyleBackColor = false;
            this.SearchFoodName.Click += new System.EventHandler(this.SearchFoodName_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(1023, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "ลบข้อมูล";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Form4_DeleteDataFood_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(1023, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "อัพเดทข้อมูล";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Form3_UpdateDataFood_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.Location = new System.Drawing.Point(1023, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 90);
            this.button4.TabIndex = 5;
            this.button4.Text = "เพิ่มข้อมูล";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Form2_AddDataFood_Click);
            // 
            // txtSearchMenu
            // 
            this.txtSearchMenu.AcceptsReturn = true;
            this.txtSearchMenu.AcceptsTab = true;
            this.txtSearchMenu.BackColor = System.Drawing.Color.Ivory;
            this.txtSearchMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtSearchMenu.Location = new System.Drawing.Point(495, 125);
            this.txtSearchMenu.Multiline = true;
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(194, 37);
            this.txtSearchMenu.TabIndex = 6;
            this.txtSearchMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "โปรแกรมแสดงสูตรการทำอาหาร ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(58, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(362, 356);
            this.dataGridView2.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(450, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(522, 411);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1_Index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApp_ServiceRecipe.Properties.Resources._04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 629);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchMenu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchFoodName);
            this.Controls.Add(this.GetAllFoodName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAllFoodName;
        private System.Windows.Forms.Button SearchFoodName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearchMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

