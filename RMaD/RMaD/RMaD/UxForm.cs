using RMaD.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RMaD
{
    public partial class UxForm : Form
    {
        List<Panel> panelList = new List<Panel>();
        List<Button> buttonList = new List<Button>();
        private int _shipments;

        private SQLiteDataReader result;
        private SQLiteCommand sqlCommand;
        string sqlQuery;

        /// <summary>
        /// Counts the amount of shipments in the Flow Layout Panel 
        /// countained in the shipments panel
        /// </summary>
        public int Shipments { get; set; }

        public UxForm()
        {
            InitializeComponent();
        }

        private void UxForm_Load(object sender, EventArgs e)
        {
            // List indexes the panels from 0..4
            panelList.Add(pnlShipments);
            panelList.Add(pnlGroups);
            panelList.Add(pnlReports);
            panelList.Add(pnlUser);
            panelList.Add(pnlSettings);

            buttonList.Add(btnShipmentMenu);
            buttonList.Add(btnGroupMenu);
            buttonList.Add(btnReportsMenu);
            buttonList.Add(btnUserMenu);
            buttonList.Add(btnSettingsMenu);

            //this._shipments = this.flpShipments.Controls.Count;
            changePanel(0);
            populateDataGridView();
        }

        private void btnShipmentMenu_Click(object sender, EventArgs e)
        {
            changePanel(0);
        }

        private void btnGroupMenu_Click(object sender, EventArgs e)
        {
            changePanel(1);
        }

        private void btnReportsMenu_Click(object sender, EventArgs e)
        {
            changePanel(2);
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            changePanel(3);
        }

        private void btnSettingsMenu_Click(object sender, EventArgs e)
        {
            changePanel(4);
        }

        /// <summary>
        /// Change Panel will show the panel sent to the method and deactivate the button used
        /// to change to a new panel. It will then hide the panels that are not in use and will
        /// enable the buttons needed to change to those panels.
        /// </summary>
        /// <param name="panel">Index of panel being changed to</param>
        private void changePanel(int panel)
        {
            panelList[panel].Show();
            buttonList[panel].Enabled = false;

            for (int i = 0; i < panelList.Count; i++)
            {
                if (i != panel)
                {
                    panelList[i].Hide();
                    buttonList[i].Enabled = true;
                }
            }

            if (panel == 3)
                if (panel == 3)
                {
                    User user = new User(LoginInfo.loggedInUser);
                    lblUser.Text = user.UserName();
                    tbFirstname.Text = user.FirstName();
                    tbLastname.Text = user.Lastname();
                    tbEmail.Text = user.Email();
                    tbToken.Text = user.Token();
                }
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            bool creating = true;
            AddShipment ship = new AddShipment();
            DialogResult drShip = new DialogResult();

            while (creating == true)
            {
                if (drShip == DialogResult.OK)
                {
                    this.Shipments++;
                    populateDataGridView();
                    creating = false;
                }
                else if (drShip == DialogResult.Cancel)
                {
                    creating = false;
                }
                else
                {
                    drShip = ship.ShowDialog();
                }
            }

        }

        /// <summary>
        /// Creates a new shipment button within the Flow Layout Panel.
        /// </summary>
        /// <param name="shipNum">The index of the new button</param>
        //private void newShipment(int shipNum)
        //{
        //    Button btnShipment = new Button();
        //    btnShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
        //        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnShipment.Name = "btnShipment";
        //    btnShipment.Size = new System.Drawing.Size(450, 50);
        //    btnShipment.TabIndex = 1;
        //    btnShipment.Text = "Shipment " + shipNum.ToString(); // change to data pull from data tables
        //    btnShipment.UseVisualStyleBackColor = true;
        //    //flpShipments.Controls.Add(btnShipment);
        //}

        /// <summary>
        /// Populate grid with shipments queried from database
        /// </summary>
        /// <param> </param>
        private void populateDataGridView()
        {
            dataGridViewShipment.DataSource = null;
            DatabaseAccess databaseObject = new DatabaseAccess();
            databaseObject.OpenConnection();
            DataTable dt = new DataTable();

            sqlQuery = "select S.tracking_id as [Tracking], S.shipped_on as [Shipped Date], S.arrive_on as [Arrival Date], SC.shipping_company_name as [Carrier], SS.status as Status " +
                        "from SHIPMENT S " +
                        "INNER JOIN SHIPPING_COMPANY SC on S.shipping_company_id = SC.shipping_company_id " +
                        "INNER JOIN SHIPMENT_STATUS SS on S.shipment_status_id = SS.shipment_status_id " +
                        "order by S.shipment_id DESC";

            SQLiteDataAdapter sqdt = new SQLiteDataAdapter(sqlQuery, databaseObject.sqlConnection);
            sqdt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewShipment.DataSource = dt;

                for (int i = 0; i < dataGridViewShipment.Columns.Count; i++)
                {
                    dataGridViewShipment.Columns[i].Frozen = false;
                }

                dataGridViewShipment.Columns["Tracking"].DefaultCellStyle.Format = "N2";
                dataGridViewShipment.RowHeadersVisible = false;
            }
            databaseObject.CloseConnection();
        }

        private void pnlShipments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (tbFirstname.ReadOnly == true)
            {
                tbFirstname.ReadOnly = false;
                tbLastname.ReadOnly = false;
                tbEmail.ReadOnly = false;
                tbToken.ReadOnly = false;
                btnEditUser.Text = "Done";
                btnCancelEdit.Visible = true;
                btnCancelEdit.Enabled = true;
                this.tbFirstname.Focus();
            }
            else
            {
                tbFirstname.ReadOnly = true;
                tbLastname.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbToken.ReadOnly = true;
                // if changes are made update database
                btnEditUser.Text = "Edit";
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            // Discard changes
            // Reload Fields from database
            tbFirstname.ReadOnly = true;
            tbLastname.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbToken.ReadOnly = true;
            btnEditUser.Text = "Edit";
            btnCancelEdit.Visible = false;
            btnCancelEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool creating = true;

            if (dataGridViewShipment.CurrentRow == null)
            {
                MessageBox.Show("Please select the item", "Warning!");
                return;
            }

            if (dataGridViewShipment.CurrentRow != null)
            {

                if (dataGridViewShipment.CurrentRow == null)
                {
                    MessageBox.Show("Please select the item");
                    return;
                }

                AddShipment editShipmentForm = new AddShipment();
                DialogResult drShip = editShipmentForm.ShowDialog();

                while (creating == true)
                {
                    if (drShip == DialogResult.OK)
                    {
                        this.Shipments++;
                        //populateDataGridView();
                        creating = false;
                    }
                    else if (drShip == DialogResult.Cancel)
                    {
                        creating = false;
                    }
                    else
                    {
                        drShip = editShipmentForm.ShowDialog();
                    }
                }

                //editShipmentForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                DataGridViewRow curRow = dataGridViewShipment.CurrentRow;
                editShipmentForm.populateEditForm(curRow);
                //bugForm.Text = "Status: " + dvr.Cells["Status"].Value.ToString();
                editShipmentForm.BringToFront();
                editShipmentForm.Show();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
            if (dataGridViewShipment.CurrentRow == null)
            {
                MessageBox.Show("Please select the item");
                return;
            }          

            DataGridViewRow curRow = dataGridViewShipment.CurrentRow;

            AddShipment editShipmentForm = new AddShipment(curRow.Cells["Tracking"].Value.ToString());
            editShipmentForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            editShipmentForm.Text = "Edit Shipment";
            editShipmentForm.StartPosition = FormStartPosition.CenterScreen;
            editShipmentForm.populateEditForm(curRow);            
            editShipmentForm.BringToFront();
            editShipmentForm.Show();            
            
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            AddShipment editShipmentForm = (AddShipment)sender;            
            populateDataGridView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewShipment.CurrentRow == null)
            {
                MessageBox.Show("Please select the item");
                return;
            }

            DataGridViewRow curRow = dataGridViewShipment.CurrentRow;

            if (MessageBox.Show("Are you sure you want to delete a TrackingID: " + curRow.Cells["Tracking"].Value.ToString() + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;   

            Shipment selectedShip = new Shipment(curRow.Cells["Tracking"].Value.ToString(), curRow.Cells["Shipped Date"].Value.ToString(), curRow.Cells["Arrival Date"].Value.ToString(), curRow.Cells["Carrier"].Value.ToString(), curRow.Cells["Status"].Value.ToString());
            selectedShip.deleteShipment();
            populateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgReport.DataSource = null;
            DatabaseAccess databaseObject = new DatabaseAccess();
            databaseObject.OpenConnection();
            DataTable dt = new DataTable();

            sqlQuery = "select S.tracking_id as [Tracking], S.shipped_on as [Shipped Date], S.arrive_on as [Arrival Date], SC.shipping_company_name as [Carrier], SS.status as Status " +
                        "from SHIPMENT S " +
                        "INNER JOIN SHIPPING_COMPANY SC on S.shipping_company_id = SC.shipping_company_id " +
                        "INNER JOIN SHIPMENT_STATUS SS on S.shipment_status_id = SS.shipment_status_id " +
                        "WHERE S.arrive_on BETWEEN '@startDate' AND '@endDate' " +
                        "order by S.shipment_id DESC";

            sqlQuery = sqlQuery.Replace("@startDate", dtStartDate.Value.Date.ToString("yyyy-MM-dd"));
            sqlQuery = sqlQuery.Replace("@endDate", dtEndDate.Value.Date.ToString("yyyy-MM-dd"));

            SQLiteDataAdapter sqdt = new SQLiteDataAdapter(sqlQuery, databaseObject.sqlConnection);            
            sqdt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgReport.DataSource = dt;

                for (int i = 0; i < dgReport.Columns.Count; i++)
                {
                    dgReport.Columns[i].Frozen = false;
                }

                dgReport.Columns["Tracking"].DefaultCellStyle.Format = "N2";
                dgReport.RowHeadersVisible = false;
            }
            databaseObject.CloseConnection();
        }
    }
}
