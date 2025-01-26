namespace Personal_Expense_Management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.expense_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addCataegory_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new Personal_Expense_Management.DashboardForm();
            this.expenseForm1 = new Personal_Expense_Management.expenseForm();
            this.incomeForm1 = new Personal_Expense_Management.incomeForm();
            this.categoryForm1 = new Personal_Expense_Management.CategoryForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 45);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Budget Tracker";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1336, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.expense_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.addCataegory_btn);
            this.panel2.Controls.Add(this.greetUser);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 795);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 733);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(261, 50);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // expense_btn
            // 
            this.expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expense_btn.FlatAppearance.BorderSize = 0;
            this.expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_btn.ForeColor = System.Drawing.Color.White;
            this.expense_btn.Image = ((System.Drawing.Image)(resources.GetObject("expense_btn.Image")));
            this.expense_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expense_btn.Location = new System.Drawing.Point(12, 434);
            this.expense_btn.Name = "expense_btn";
            this.expense_btn.Size = new System.Drawing.Size(261, 50);
            this.expense_btn.TabIndex = 6;
            this.expense_btn.Text = "Expense";
            this.expense_btn.UseVisualStyleBackColor = false;
            this.expense_btn.Click += new System.EventHandler(this.expense_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.Color.White;
            this.income_btn.Image = ((System.Drawing.Image)(resources.GetObject("income_btn.Image")));
            this.income_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_btn.Location = new System.Drawing.Point(12, 359);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(261, 50);
            this.income_btn.TabIndex = 5;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addCataegory_btn
            // 
            this.addCataegory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.addCataegory_btn.FlatAppearance.BorderSize = 0;
            this.addCataegory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCataegory_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCataegory_btn.ForeColor = System.Drawing.Color.White;
            this.addCataegory_btn.Image = ((System.Drawing.Image)(resources.GetObject("addCataegory_btn.Image")));
            this.addCataegory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCataegory_btn.Location = new System.Drawing.Point(12, 292);
            this.addCataegory_btn.Name = "addCataegory_btn";
            this.addCataegory_btn.Size = new System.Drawing.Size(261, 50);
            this.addCataegory_btn.TabIndex = 4;
            this.addCataegory_btn.Text = "Add Category";
            this.addCataegory_btn.UseVisualStyleBackColor = false;
            this.addCataegory_btn.Click += new System.EventHandler(this.addCataegory_btn_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.Color.White;
            this.greetUser.Location = new System.Drawing.Point(21, 161);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(103, 24);
            this.greetUser.TabIndex = 3;
            this.greetUser.Text = "Welcome";
            this.greetUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Image")));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 217);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(261, 50);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.expenseForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(289, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 795);
            this.panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1081, 795);
            this.dashboardForm1.TabIndex = 3;
            // 
            // expenseForm1
            // 
            this.expenseForm1.Location = new System.Drawing.Point(0, 0);
            this.expenseForm1.Name = "expenseForm1";
            this.expenseForm1.Size = new System.Drawing.Size(1081, 795);
            this.expenseForm1.TabIndex = 2;
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(0, 0);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(1081, 795);
            this.incomeForm1.TabIndex = 1;
            this.incomeForm1.Load += new System.EventHandler(this.incomeForm1_Load);
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1081, 795);
            this.categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button expense_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addCataegory_btn;
        private System.Windows.Forms.Panel panel3;
        private CategoryForm categoryForm1;
        private incomeForm incomeForm1;
        private expenseForm expenseForm1;
        private DashboardForm dashboardForm1;
    }
}