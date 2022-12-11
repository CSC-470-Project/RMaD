using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RMaD.Classes
{
    internal class Shipment
    {
        private string _trackNumber;
        private string _dateShipped;
        private string _dateArrival;
        private string _carrier;
        private string _status;

        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;

        private ShippingService shipServ;
        private ShippingStatus shipStatus;

        public Shipment(string trackNumber, string dateShipped, string dateArrival, string carrier, string status)
        {
            _trackNumber = trackNumber;
            _dateShipped = dateShipped;
            _dateArrival = dateArrival;
            _carrier = carrier;
            _status = status;
        }

        public Boolean addShipment() {     


            sqlQuery = "INSERT INTO SHIPMENT (tracking_id, shipped_on, arrive_on, shipping_company_id,shipment_status_id)" + 
                      "VALUES(@trackingId, @dateShipped, @dateArrival, @shippingCompany, @shippingStatus)";

            try
            {
                shipServ = new ShippingService(this._carrier);    
                //int carrierID = shipServ.getCarrierID();//getting carrier ID from database
                shipStatus = new ShippingStatus(this._status);                

                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@trackingId", this._trackNumber);
                sqlCommand.Parameters.AddWithValue("@dateShipped", this._dateShipped);
                sqlCommand.Parameters.AddWithValue("@dateArrival", this._dateArrival);
                sqlCommand.Parameters.AddWithValue("@shippingCompany", shipServ.getCarrierID());
                sqlCommand.Parameters.AddWithValue("@shippingStatus", shipStatus.getStatusID());

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Add new shipment failed.");
                return false;
            }
        }

        public void updateShipment(string originalTrackID)
        {
            sqlQuery = "UPDATE SHIPMENT SET shipped_on = @shipdt, arrive_on = @arrdt, shipping_company_id = @shipID, shipment_status_id=@shipStatus, tracking_id = @trackID " + 
                         "WHERE tracking_id = @trackID1";

            shipServ = new ShippingService(this._carrier);
            shipStatus = new ShippingStatus(this._status);

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@shipdt", this._dateShipped);
                sqlCommand.Parameters.AddWithValue("@arrdt", this._dateArrival);
                sqlCommand.Parameters.AddWithValue("@shipID", shipServ.getCarrierID());
                sqlCommand.Parameters.AddWithValue("@shipStatus", shipStatus.getStatusID());
                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);
                sqlCommand.Parameters.AddWithValue("@trackID1", originalTrackID);

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();

                MessageBox.Show("Shipment has been updated!");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Update failed");
            }

            //sreturn res;
        }

        public void deleteShipment()
        {
            sqlQuery = "DELETE FROM SHIPMENT WHERE tracking_id = @trackID ";

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);                
                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();

                MessageBox.Show("Shipment has been deleted!");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Delete failed");
            }

            //sreturn res;
        }


        public Boolean trackIDExists()
        {
            Boolean recExists = false;

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlQuery = "select * from SHIPMENT where tracking_id =@trackID";
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);                
                databaseObject.OpenConnection();
                result = sqlCommand.ExecuteReader();

                if (result.HasRows)
                {
                    recExists = true;
                }

                result.Close();
                databaseObject.CloseConnection();
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Failed.");
            }

            return recExists;
        }

    }
}
