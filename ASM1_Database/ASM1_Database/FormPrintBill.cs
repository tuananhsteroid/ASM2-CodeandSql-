using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class FormPrintBill : Form
    {
        public FormPrintBill()
        {
            InitializeComponent();
        }

        public void SetBillDetails(string customerID, string customerName, string Phone, string Address, string PurchaseID, string PurchaseDate, string productName, int quantity, decimal totalAmount)
        {
            lbcusID.Text = $"Customer ID: {customerID}";
            lbcusName.Text = $"Customer Name: {customerName}";
            lbcusPhone.Text = $"Customer Phone: {Phone}";
            lbcusAddress.Text = $"Customer Address: {Address}";
            lbpurID.Text = $"PurchaseID: {PurchaseID}";

            // Nếu PurchaseDate là chuỗi, chuyển nó thành DateTime và lấy định dạng ngày
            if (DateTime.TryParse(PurchaseDate, out DateTime parsedDate))
            {
                lbpurDate.Text = $"Date: {parsedDate.ToString("dd/MM/yyyy")}";
            }
            else
            {
                lbpurDate.Text = $"Date: {PurchaseDate}"; // Nếu không chuyển đổi được, hiển thị chuỗi gốc
            }

            lbproName.Text = $"Name: {productName}";
            lbQuantity.Text = $"Quantity: {quantity}";
            lbTotal.Text = $"Total: {totalAmount}";
        }


        
    }
}
