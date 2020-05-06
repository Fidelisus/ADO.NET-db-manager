using System;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        // Storage for IDENTITY values returned from database.
        private int parsedCustomerID;
        private int orderID;

        /// <summary>
        /// Verifies that the customer name text box is not empty.
        /// </summary>
        private bool IsCustomerNameValid()
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Verifies that a customer ID and order amount have been provided.
        /// </summary>
        private bool IsOrderDataValid()
        {
            // Verify that CustomerID is present.
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please create customer account before placing order.");
                return false;
            }
            // Verify that Amount isn't 0.
            else if ((numOrderAmount.Value < 1))
            {
                MessageBox.Show("Please specify an order amount.");
                return false;
            }
            else
            {
                // Order can be submitted.
                return true;
            }
        }

        /// <summary>
        /// Clears the form data.
        /// </summary>
        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtCustomerID.Clear();
            dtpOrderDate.Value = DateTime.Now;
            numOrderAmount.Value = 0;
            this.parsedCustomerID = 0;
        }
    }
}
