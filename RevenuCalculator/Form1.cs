using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevenuCalculator
{
    
    public partial class Form1 : Form
    {
        public string[] months = new string[] { 
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void button_calculate(object sender, EventArgs e)
        {
            chrt_data.Series["Bank Account"].Points.Clear();
            chrt_margins.Series["Margins"].Points.Clear();
            
            double inverseProfitMargin, costOfGoods, accountBal, posFeePercent, posFlatFee, inventory, investment, averageBills, taxes;
            try
            {
                
                inverseProfitMargin = Math.Abs(1 - Convert.ToDouble(txt_profit_margin.Text) / 100);
                costOfGoods = Convert.ToDouble(txt_cost_of_goods.Text);
                accountBal = Convert.ToDouble(txt_account_balance.Text);
                posFeePercent = Convert.ToDouble(txt_pos_fee_percent.Text) / 100;
                posFlatFee =Convert.ToDouble(txt_pos_flat_fee.Text);
                inventory = Convert.ToDouble(txt_inventory.Text);
                investment = Convert.ToDouble(txt_investment.Text);
                averageBills = Convert.ToDouble(txt_average_bills.Text);
                taxes = Convert.ToDouble(txt_taxes.Text) / 100;
            }
            catch
            {
                MessageBox.Show(" Fields with a * are  required. All fields must contain numbers. If a field doesn't apply to you, please put a 0.");
                return;
            }
            double totalRevenue = costOfGoods / inverseProfitMargin;

            double cost = costOfGoods + totalRevenue * posFeePercent + posFlatFee + investment + averageBills;
            double profit = totalRevenue - cost;
            chrt_margins.Series["Margins"].Points.AddXY("Profit", profit);
            //chrt_margins.Series["Margins"].Points.AddXY("Sales", totalRevenue);
            chrt_margins.Series["Margins"].Points.AddXY("Cost", cost);

            for (int i = 0; i < months.Length; i++)
            {
                accountBal += profit;
                chrt_data.Series["Bank Account"].Points.AddXY(months[i], accountBal);
                
            }
            


        }

        private void lbl_pos_fee_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tax_Click(object sender, EventArgs e)
        {

        }

        private void chrt_margins_Click(object sender, EventArgs e)
        {

        }
    }
}
