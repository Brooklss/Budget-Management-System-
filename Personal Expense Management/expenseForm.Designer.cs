namespace Personal_Expense_Management
{
    partial class expenseForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Expense_Clearbtn = new System.Windows.Forms.Button();
            this.Expense_Deletebtn = new System.Windows.Forms.Button();
            this.Expense_Updatebtn = new System.Windows.Forms.Button();
            this.Expense_Addbtn = new System.Windows.Forms.Button();
            this.expense_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.expense_Discription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expense_Cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expense_Item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expense_Category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Expense_Clearbtn);
            this.panel2.Controls.Add(this.Expense_Deletebtn);
            this.panel2.Controls.Add(this.Expense_Updatebtn);
            this.panel2.Controls.Add(this.Expense_Addbtn);
            this.panel2.Controls.Add(this.expense_Date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.expense_Discription);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.expense_Cost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.expense_Item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.expense_Category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 320);
            this.panel2.TabIndex = 4;
            // 
            // Expense_Clearbtn
            // 
            this.Expense_Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Expense_Clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Clearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Expense_Clearbtn.Location = new System.Drawing.Point(701, 241);
            this.Expense_Clearbtn.Name = "Expense_Clearbtn";
            this.Expense_Clearbtn.Size = new System.Drawing.Size(138, 53);
            this.Expense_Clearbtn.TabIndex = 14;
            this.Expense_Clearbtn.Text = "Clear";
            this.Expense_Clearbtn.UseVisualStyleBackColor = false;
            this.Expense_Clearbtn.Click += new System.EventHandler(this.Expense_Clearbtn_Click);
            // 
            // Expense_Deletebtn
            // 
            this.Expense_Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Expense_Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Deletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Expense_Deletebtn.Location = new System.Drawing.Point(527, 241);
            this.Expense_Deletebtn.Name = "Expense_Deletebtn";
            this.Expense_Deletebtn.Size = new System.Drawing.Size(138, 53);
            this.Expense_Deletebtn.TabIndex = 13;
            this.Expense_Deletebtn.Text = "Delete";
            this.Expense_Deletebtn.UseVisualStyleBackColor = false;
            this.Expense_Deletebtn.Click += new System.EventHandler(this.Expense_Deletebtn_Click);
            // 
            // Expense_Updatebtn
            // 
            this.Expense_Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Expense_Updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Updatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Expense_Updatebtn.Location = new System.Drawing.Point(317, 241);
            this.Expense_Updatebtn.Name = "Expense_Updatebtn";
            this.Expense_Updatebtn.Size = new System.Drawing.Size(138, 53);
            this.Expense_Updatebtn.TabIndex = 12;
            this.Expense_Updatebtn.Text = "Update";
            this.Expense_Updatebtn.UseVisualStyleBackColor = false;
            this.Expense_Updatebtn.Click += new System.EventHandler(this.Expense_Updatebtn_Click);
            // 
            // Expense_Addbtn
            // 
            this.Expense_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Expense_Addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.Expense_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expense_Addbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Addbtn.ForeColor = System.Drawing.Color.White;
            this.Expense_Addbtn.Location = new System.Drawing.Point(143, 241);
            this.Expense_Addbtn.Name = "Expense_Addbtn";
            this.Expense_Addbtn.Size = new System.Drawing.Size(138, 53);
            this.Expense_Addbtn.TabIndex = 11;
            this.Expense_Addbtn.Text = "Add";
            this.Expense_Addbtn.UseVisualStyleBackColor = false;
            this.Expense_Addbtn.Click += new System.EventHandler(this.Expense_Addbtn_Click);
            // 
            // expense_Date
            // 
            this.expense_Date.Location = new System.Drawing.Point(618, 156);
            this.expense_Date.Name = "expense_Date";
            this.expense_Date.Size = new System.Drawing.Size(240, 22);
            this.expense_Date.TabIndex = 10;
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
            // expense_Discription
            // 
            this.expense_Discription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_Discription.Location = new System.Drawing.Point(617, 46);
            this.expense_Discription.Multiline = true;
            this.expense_Discription.Name = "expense_Discription";
            this.expense_Discription.Size = new System.Drawing.Size(367, 88);
            this.expense_Discription.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // expense_Cost
            // 
            this.expense_Cost.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_Cost.Location = new System.Drawing.Point(171, 155);
            this.expense_Cost.Name = "expense_Cost";
            this.expense_Cost.Size = new System.Drawing.Size(230, 29);
            this.expense_Cost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost:";
            // 
            // expense_Item
            // 
            this.expense_Item.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_Item.Location = new System.Drawing.Point(171, 105);
            this.expense_Item.Name = "expense_Item";
            this.expense_Item.Size = new System.Drawing.Size(230, 29);
            this.expense_Item.TabIndex = 4;
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
            // expense_Category
            // 
            this.expense_Category.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_Category.FormattingEnabled = true;
            this.expense_Category.Location = new System.Drawing.Point(171, 51);
            this.expense_Category.Name = "expense_Category";
            this.expense_Category.Size = new System.Drawing.Size(230, 30);
            this.expense_Category.TabIndex = 2;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 395);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense List";
            // 
            // expenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "expenseForm";
            this.Size = new System.Drawing.Size(1081, 795);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Expense_Deletebtn;
        private System.Windows.Forms.Button Expense_Updatebtn;
        private System.Windows.Forms.Button Expense_Addbtn;
        private System.Windows.Forms.DateTimePicker expense_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expense_Discription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expense_Cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expense_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expense_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Expense_Clearbtn;
    }
}
