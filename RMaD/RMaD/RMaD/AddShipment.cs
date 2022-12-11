using RMaD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RMaD
{
    public partial class AddShipment : Form
    {
        private string originalTrackID;
        public AddShipment()
        {
            InitializeComponent();
            populateCarrier();
            populateStatus();

        }
        public AddShipment(string trackID)
        {
            InitializeComponent();
            populateCarrier();
            populateStatus();
            this.originalTrackID = trackID;
        }

        private void dtpShipped_ValueChanged(object sender, EventArgs e)
        {

        }

        private void populateCarrier()
        {
            ShippingService shipServ = new ShippingService();
            tbCarrierdpdn.Items.Clear();

            List<string> ls = new List<string>();

            ls = shipServ.loadShippingServList();
            foreach (string item in ls)
            {
                tbCarrierdpdn.Items.Add(item);
            }
        }

        private void populateStatus()
        {
            ShippingStatus shipStatus = new ShippingStatus();
            cbStatus.Items.Clear();

            List<string> ls = new List<string>();

            ls = shipStatus.loadShippingStatus();
            foreach (string item in ls)
            {
                cbStatus.Items.Add(item);
            }
        }

        private void AddShipment_Load(object sender, EventArgs e)
        {

        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {

            if (this.lblCreateShipment.Text != "Edit Shipment")
            {              

                if (string.IsNullOrEmpty(mtbTracking.Text))
                {
                    MessageBox.Show("Tracking number is required.", "Failed!");
                    return;
                }

                if (string.IsNullOrEmpty(tbCarrierdpdn.Text))
                {
                    MessageBox.Show("Shipping carrier is required.", "Failed!");
                    return;
                }

                Shipment newShipment = new Shipment(mtbTracking.Text, dtpShipped.Value.Date.ToString("yyyy-MM-dd"), dtpArrival.Value.Date.ToString("yyyy-MM-dd"), tbCarrierdpdn.Text, cbStatus.Text);

                if (newShipment.trackIDExists())
                {
                    MessageBox.Show("Tracking Number already exists.", "Adding new shipment tracking failed!");
                    return;
                }
                else
                {
                    Boolean addShipment = newShipment.addShipment();
                    if (addShipment)
                    {
                        Utils.emailShipment(mtbTracking.Text, dtpShipped.Value.Date.ToString("yyyy-MM-dd"), dtpArrival.Value.Date.ToString("yyyy-MM-dd"), tbCarrierdpdn.Text);
                        MessageBox.Show("Tracking number has been added successfully.", "Add new Shipment!");
                    }
                    else
                    {
                        MessageBox.Show("Error occured. New Tracking number was not added.", "Add Shipment failed!");
                    }
                }
            }
            else 
            {
                Shipment uShipment = new Shipment(mtbTracking.Text, dtpShipped.Value.Date.ToString("yyyy-MM-dd"), dtpArrival.Value.Date.ToString("yyyy-MM-dd"), tbCarrierdpdn.Text,cbStatus.Text);
                uShipment.updateShipment(this.originalTrackID);
            }
        }

        public void populateEditForm(DataGridViewRow dv)
        {            
            this.mtbTracking.Text = dv.Cells["Tracking"].Value.ToString();
            this.dtpShipped.Text = dv.Cells["Shipped Date"].Value.ToString();
            this.dtpArrival.Text = dv.Cells["Arrival Date"].Value.ToString();
            this.tbCarrierdpdn.Text = dv.Cells["Carrier"].Value.ToString();
            this.cbStatus.Text = dv.Cells["Status"].Value.ToString();
            this.lblCreateShipment.Text = "Edit Shipment";

        }
    }
}
