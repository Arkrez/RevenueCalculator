namespace RevenuCalculator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_taxes = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.txt_average_bills = new System.Windows.Forms.TextBox();
            this.txt_investment = new System.Windows.Forms.TextBox();
            this.txt_pos_flat_fee = new System.Windows.Forms.TextBox();
            this.txt_pos_fee_percent = new System.Windows.Forms.TextBox();
            this.txt_profit_margin = new System.Windows.Forms.TextBox();
            this.txt_cost_of_goods = new System.Windows.Forms.TextBox();
            this.txt_account_balance = new System.Windows.Forms.TextBox();
            this.lbl_inventory_cost = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_pos_flat_fee = new System.Windows.Forms.Label();
            this.lbl_investment = new System.Windows.Forms.Label();
            this.lbl_average_bills = new System.Windows.Forms.Label();
            this.lbl_pos_fee = new System.Windows.Forms.Label();
            this.lbl_average_profit_margin = new System.Windows.Forms.Label();
            this.lbl_cost_of_goods_sold = new System.Windows.Forms.Label();
            this.lbl_bank_account_balance = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_bank_growth = new System.Windows.Forms.Label();
            this.chrt_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_margins = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_margins)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_taxes);
            this.groupBox1.Controls.Add(this.txt_inventory);
            this.groupBox1.Controls.Add(this.txt_average_bills);
            this.groupBox1.Controls.Add(this.txt_investment);
            this.groupBox1.Controls.Add(this.txt_pos_flat_fee);
            this.groupBox1.Controls.Add(this.txt_pos_fee_percent);
            this.groupBox1.Controls.Add(this.txt_profit_margin);
            this.groupBox1.Controls.Add(this.txt_cost_of_goods);
            this.groupBox1.Controls.Add(this.txt_account_balance);
            this.groupBox1.Controls.Add(this.lbl_inventory_cost);
            this.groupBox1.Controls.Add(this.lbl_tax);
            this.groupBox1.Controls.Add(this.lbl_pos_flat_fee);
            this.groupBox1.Controls.Add(this.lbl_investment);
            this.groupBox1.Controls.Add(this.lbl_average_bills);
            this.groupBox1.Controls.Add(this.lbl_pos_fee);
            this.groupBox1.Controls.Add(this.lbl_average_profit_margin);
            this.groupBox1.Controls.Add(this.lbl_cost_of_goods_sold);
            this.groupBox1.Controls.Add(this.lbl_bank_account_balance);
            this.groupBox1.Controls.Add(this.btn_calculate);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_taxes
            // 
            this.txt_taxes.Location = new System.Drawing.Point(169, 340);
            this.txt_taxes.Name = "txt_taxes";
            this.txt_taxes.Size = new System.Drawing.Size(125, 20);
            this.txt_taxes.TabIndex = 17;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Location = new System.Drawing.Point(169, 311);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(126, 20);
            this.txt_inventory.TabIndex = 16;
            // 
            // txt_average_bills
            // 
            this.txt_average_bills.Location = new System.Drawing.Point(169, 265);
            this.txt_average_bills.Name = "txt_average_bills";
            this.txt_average_bills.Size = new System.Drawing.Size(126, 20);
            this.txt_average_bills.TabIndex = 15;
            // 
            // txt_investment
            // 
            this.txt_investment.Location = new System.Drawing.Point(169, 228);
            this.txt_investment.Name = "txt_investment";
            this.txt_investment.Size = new System.Drawing.Size(126, 20);
            this.txt_investment.TabIndex = 14;
            // 
            // txt_pos_flat_fee
            // 
            this.txt_pos_flat_fee.Location = new System.Drawing.Point(169, 188);
            this.txt_pos_flat_fee.Name = "txt_pos_flat_fee";
            this.txt_pos_flat_fee.Size = new System.Drawing.Size(126, 20);
            this.txt_pos_flat_fee.TabIndex = 13;
            // 
            // txt_pos_fee_percent
            // 
            this.txt_pos_fee_percent.Location = new System.Drawing.Point(169, 138);
            this.txt_pos_fee_percent.Name = "txt_pos_fee_percent";
            this.txt_pos_fee_percent.Size = new System.Drawing.Size(126, 20);
            this.txt_pos_fee_percent.TabIndex = 12;
            // 
            // txt_profit_margin
            // 
            this.txt_profit_margin.Location = new System.Drawing.Point(169, 95);
            this.txt_profit_margin.Name = "txt_profit_margin";
            this.txt_profit_margin.Size = new System.Drawing.Size(126, 20);
            this.txt_profit_margin.TabIndex = 11;
            // 
            // txt_cost_of_goods
            // 
            this.txt_cost_of_goods.Location = new System.Drawing.Point(169, 59);
            this.txt_cost_of_goods.Name = "txt_cost_of_goods";
            this.txt_cost_of_goods.Size = new System.Drawing.Size(126, 20);
            this.txt_cost_of_goods.TabIndex = 10;
            // 
            // txt_account_balance
            // 
            this.txt_account_balance.Location = new System.Drawing.Point(169, 25);
            this.txt_account_balance.Name = "txt_account_balance";
            this.txt_account_balance.Size = new System.Drawing.Size(126, 20);
            this.txt_account_balance.TabIndex = 9;
            // 
            // lbl_inventory_cost
            // 
            this.lbl_inventory_cost.AutoSize = true;
            this.lbl_inventory_cost.Location = new System.Drawing.Point(16, 314);
            this.lbl_inventory_cost.Name = "lbl_inventory_cost";
            this.lbl_inventory_cost.Size = new System.Drawing.Size(80, 13);
            this.lbl_inventory_cost.TabIndex = 8;
            this.lbl_inventory_cost.Text = "Inventory (cost)";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(16, 343);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(39, 13);
            this.lbl_tax.TabIndex = 1;
            this.lbl_tax.Text = "Taxes ";
            this.lbl_tax.Click += new System.EventHandler(this.lbl_tax_Click);
            // 
            // lbl_pos_flat_fee
            // 
            this.lbl_pos_flat_fee.AutoSize = true;
            this.lbl_pos_flat_fee.Location = new System.Drawing.Point(15, 191);
            this.lbl_pos_flat_fee.Name = "lbl_pos_flat_fee";
            this.lbl_pos_flat_fee.Size = new System.Drawing.Size(70, 13);
            this.lbl_pos_flat_fee.TabIndex = 7;
            this.lbl_pos_flat_fee.Text = "POS Flat Fee";
            // 
            // lbl_investment
            // 
            this.lbl_investment.AutoSize = true;
            this.lbl_investment.Location = new System.Drawing.Point(15, 235);
            this.lbl_investment.Name = "lbl_investment";
            this.lbl_investment.Size = new System.Drawing.Size(78, 13);
            this.lbl_investment.TabIndex = 6;
            this.lbl_investment.Text = "Investment/mo";
            // 
            // lbl_average_bills
            // 
            this.lbl_average_bills.AutoSize = true;
            this.lbl_average_bills.Location = new System.Drawing.Point(15, 268);
            this.lbl_average_bills.Name = "lbl_average_bills";
            this.lbl_average_bills.Size = new System.Drawing.Size(87, 13);
            this.lbl_average_bills.TabIndex = 5;
            this.lbl_average_bills.Text = "Average Bills/mo";
            // 
            // lbl_pos_fee
            // 
            this.lbl_pos_fee.AutoSize = true;
            this.lbl_pos_fee.Location = new System.Drawing.Point(15, 141);
            this.lbl_pos_fee.Name = "lbl_pos_fee";
            this.lbl_pos_fee.Size = new System.Drawing.Size(49, 13);
            this.lbl_pos_fee.TabIndex = 4;
            this.lbl_pos_fee.Text = "Pos Fee ";
            this.lbl_pos_fee.Click += new System.EventHandler(this.lbl_pos_fee_Click);
            // 
            // lbl_average_profit_margin
            // 
            this.lbl_average_profit_margin.AutoSize = true;
            this.lbl_average_profit_margin.Location = new System.Drawing.Point(15, 98);
            this.lbl_average_profit_margin.Name = "lbl_average_profit_margin";
            this.lbl_average_profit_margin.Size = new System.Drawing.Size(109, 13);
            this.lbl_average_profit_margin.TabIndex = 3;
            this.lbl_average_profit_margin.Text = "Average Profit Margin";
            // 
            // lbl_cost_of_goods_sold
            // 
            this.lbl_cost_of_goods_sold.AutoSize = true;
            this.lbl_cost_of_goods_sold.Location = new System.Drawing.Point(16, 59);
            this.lbl_cost_of_goods_sold.Name = "lbl_cost_of_goods_sold";
            this.lbl_cost_of_goods_sold.Size = new System.Drawing.Size(98, 13);
            this.lbl_cost_of_goods_sold.TabIndex = 2;
            this.lbl_cost_of_goods_sold.Text = "Cost of Goods Sold";
            // 
            // lbl_bank_account_balance
            // 
            this.lbl_bank_account_balance.AutoSize = true;
            this.lbl_bank_account_balance.Location = new System.Drawing.Point(15, 28);
            this.lbl_bank_account_balance.Name = "lbl_bank_account_balance";
            this.lbl_bank_account_balance.Size = new System.Drawing.Size(117, 13);
            this.lbl_bank_account_balance.TabIndex = 1;
            this.lbl_bank_account_balance.Text = "Bank Account Balance";
            this.lbl_bank_account_balance.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(71, 373);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(176, 45);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate!";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button_calculate);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_bank_growth);
            this.groupBox2.Controls.Add(this.chrt_data);
            this.groupBox2.Location = new System.Drawing.Point(325, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(397, 365);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Investment";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Taxes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(211, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Inventory Growth";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "POS fees";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Bills";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Profit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total Sales (+tax)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cost of Goods";
            // 
            // lbl_bank_growth
            // 
            this.lbl_bank_growth.AutoSize = true;
            this.lbl_bank_growth.Location = new System.Drawing.Point(29, 302);
            this.lbl_bank_growth.Name = "lbl_bank_growth";
            this.lbl_bank_growth.Size = new System.Drawing.Size(69, 13);
            this.lbl_bank_growth.TabIndex = 2;
            this.lbl_bank_growth.Text = "Bank Growth";
            // 
            // chrt_data
            // 
            this.chrt_data.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            chartArea1.Name = "ChartArea1";
            this.chrt_data.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_data.Legends.Add(legend1);
            this.chrt_data.Location = new System.Drawing.Point(22, 22);
            this.chrt_data.Name = "chrt_data";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Bank Account";
            this.chrt_data.Series.Add(series1);
            this.chrt_data.Size = new System.Drawing.Size(620, 257);
            this.chrt_data.TabIndex = 0;
            this.chrt_data.Text = "Projection";
            this.chrt_data.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chrt_margins
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_margins.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_margins.Legends.Add(legend2);
            this.chrt_margins.Location = new System.Drawing.Point(979, 35);
            this.chrt_margins.Name = "chrt_margins";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Margins";
            this.chrt_margins.Series.Add(series2);
            this.chrt_margins.Size = new System.Drawing.Size(231, 257);
            this.chrt_margins.TabIndex = 11;
            this.chrt_margins.Text = "Margins";
            this.chrt_margins.Click += new System.EventHandler(this.chrt_margins_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.chrt_margins);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_margins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.TextBox txt_average_bills;
        private System.Windows.Forms.TextBox txt_investment;
        private System.Windows.Forms.TextBox txt_pos_flat_fee;
        private System.Windows.Forms.TextBox txt_pos_fee_percent;
        private System.Windows.Forms.TextBox txt_profit_margin;
        private System.Windows.Forms.TextBox txt_cost_of_goods;
        private System.Windows.Forms.TextBox txt_account_balance;
        private System.Windows.Forms.Label lbl_inventory_cost;
        private System.Windows.Forms.Label lbl_pos_flat_fee;
        private System.Windows.Forms.Label lbl_investment;
        private System.Windows.Forms.Label lbl_average_bills;
        private System.Windows.Forms.Label lbl_pos_fee;
        private System.Windows.Forms.Label lbl_average_profit_margin;
        private System.Windows.Forms.Label lbl_cost_of_goods_sold;
        private System.Windows.Forms.Label lbl_bank_account_balance;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_data;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_bank_growth;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.TextBox txt_taxes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_margins;
    }
}

