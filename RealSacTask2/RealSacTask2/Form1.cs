using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealSacTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Filedialog = new OpenFileDialog();
            
            if (Filedialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = Filedialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                // Sets the value of the Total Profit
                float Totalprofit = 0f; ;

                foreach (string line in lines)
                {
                    // Splits the data in to seperate columns
                    List<string> fields = line.Split(',').ToList();
                    float profit;
                    //store sale price and purchased price from each line in the file into variables
                    string salePrice = fields[5];
                    float purchasedPrice = float.Parse(fields[4]);

                    // Calculate the profit of the textbooks 
                    if (float.TryParse(salePrice, out float saleprice))
                    {
                        profit = saleprice - purchasedPrice;
                    }
                    else
                    {
                        // The item never got sold, meaning it is a loss and its purchase price is subtracted from the total profit
                        profit = purchasedPrice * -1;
                    }
                    // Add the profit amount to the total profit amount
                    Totalprofit += profit;
                    //append the profit field into fields so it is ready to populate the datagridview
                    fields.Add(profit.ToString());

                    dgvBookSales.Rows.Add(fields.ToArray());
                }

                //creates an empty row in the datagridview table
                dgvBookSales.Rows.Add();
                //counts the length of the rows in the datagridview table
                int rowCount = dgvBookSales.Rows.Count;
                //creates and sets the value of the second last cell with text "Total Profit" at the end of the data
                dgvBookSales.Rows[rowCount - 1].Cells[5].Value = "Total Profit";
                //creates and sets value of the last cell with the value of the total profit at the end of the data
                dgvBookSales.Rows[rowCount - 1].Cells[6].Value = $"${Totalprofit.ToString()}";

            }
        }

    }
}
