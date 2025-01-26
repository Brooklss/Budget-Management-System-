namespace Personal_Expense_Management
{
    partial class incomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_Clearbtn = new System.Windows.Forms.Button();
            this.income_Deletebtn = new System.Windows.Forms.Button();
            this.income_Updatebtn = new System.Windows.Forms.Button();
            this.income_Addbtn = new System.Windows.Forms.Button();
            this.income_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.income_Discription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.income_Income = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_Item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_Category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 395);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(29, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 309);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.income_Clearbtn);
            this.panel2.Controls.Add(this.income_Deletebtn);
            this.panel2.Controls.Add(this.income_Updatebtn);
            this.panel2.Controls.Add(this.income_Addbtn);
            this.panel2.Controls.Add(this.income_Date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.income_Discription);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_Income);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.income_Item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_Category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 320);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // income_Clearbtn
            // 
            this.income_Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_Clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_Clearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Clearbtn.ForeColor = System.Drawing.Color.White;
            this.income_Clearbtn.Location = new System.Drawing.Point(701, 241);
            this.income_Clearbtn.Name = "income_Clearbtn";
            this.income_Clearbtn.Size = new System.Drawing.Size(138, 53);
            this.income_Clearbtn.TabIndex = 14;
            this.income_Clearbtn.Text = "Clear";
            this.income_Clearbtn.UseVisualStyleBackColor = false;
            this.income_Clearbtn.Click += new System.EventHandler(this.income_Clearbtn_Click);
            // 
            // income_Deletebtn
            // 
            this.income_Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_Deletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Deletebtn.ForeColor = System.Drawing.Color.White;
            this.income_Deletebtn.Location = new System.Drawing.Point(527, 241);
            this.income_Deletebtn.Name = "income_Deletebtn";
            this.income_Deletebtn.Size = new System.Drawing.Size(138, 53);
            this.income_Deletebtn.TabIndex = 13;
            this.income_Deletebtn.Text = "Delete";
            this.income_Deletebtn.UseVisualStyleBackColor = false;
            this.income_Deletebtn.Click += new System.EventHandler(this.income_Deletebtn_Click);
            // 
            // income_Updatebtn
            // 
            this.income_Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_Updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_Updatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Updatebtn.ForeColor = System.Drawing.Color.White;
            this.income_Updatebtn.Location = new System.Drawing.Point(317, 241);
            this.income_Updatebtn.Name = "income_Updatebtn";
            this.income_Updatebtn.Size = new System.Drawing.Size(138, 53);
            this.income_Updatebtn.TabIndex = 12;
            this.income_Updatebtn.Text = "Update";
            this.income_Updatebtn.UseVisualStyleBackColor = false;
            this.income_Updatebtn.Click += new System.EventHandler(this.income_Updatebtn_Click);
            // 
            // income_Addbtn
            // 
            this.income_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_Addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_Addbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Addbtn.ForeColor = System.Drawing.Color.White;
            this.income_Addbtn.Location = new System.Drawing.Point(143, 241);
            this.income_Addbtn.Name = "income_Addbtn";
            this.income_Addbtn.Size = new System.Drawing.Size(138, 53);
            this.income_Addbtn.TabIndex = 11;
            this.income_Addbtn.Text = "Add";
            this.income_Addbtn.UseVisualStyleBackColor = false;
            this.income_Addbtn.Click += new System.EventHandler(this.income_Addbtn_Click);
            // 
            // income_Date
            // 
            this.income_Date.Location = new System.Drawing.Point(618, 156);
            this.income_Date.Name = "income_Date";
            this.income_Date.Size = new System.Drawing.Size(240, 22);
            this.income_Date.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // income_Discription
            // 
            this.income_Discription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Discription.Location = new System.Drawing.Point(617, 46);
            this.income_Discription.Multiline = true;
            this.income_Discription.Name = "income_Discription";
            this.income_Discription.Size = new System.Drawing.Size(367, 88);
            this.income_Discription.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Discription:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // income_Income
            // 
            this.income_Income.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Income.Location = new System.Drawing.Point(171, 155);
            this.income_Income.Name = "income_Income";
            this.income_Income.Size = new System.Drawing.Size(230, 29);
            this.income_Income.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Income:";
            // 
            // income_Item
            // 
            this.income_Item.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Item.Location = new System.Drawing.Point(171, 105);
            this.income_Item.Name = "income_Item";
            this.income_Item.Size = new System.Drawing.Size(230, 29);
            this.income_Item.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // income_Category
            // 
            this.income_Category.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Category.FormattingEnabled = true;
            this.income_Category.Location = new System.Drawing.Point(171, 51);
            this.income_Category.Name = "income_Category";
            this.income_Category.Size = new System.Drawing.Size(230, 30);
            this.income_Category.TabIndex = 2;
            this.income_Category.SelectedIndexChanged += new System.EventHandler(this.income_Category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // incomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "incomeForm";
            this.Size = new System.Drawing.Size(1081, 795);
            this.Load += new System.EventHandler(this.incomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox income_Income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox income_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox income_Category;
        private System.Windows.Forms.TextBox income_Discription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker income_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button income_Updatebtn;
        private System.Windows.Forms.Button income_Addbtn;
        private System.Windows.Forms.Button income_Clearbtn;
        private System.Windows.Forms.Button income_Deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
