using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    internal class ShippingService
    {
        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;
        private string carrier;

        public ShippingService()
        {
            
        }

        public ShippingService(string carrier) 
        {
            this.carrier = carrier;
        }

        public List<string> loadShippingServList()
        {
            List<string> shippingServList = new List<string>();

            DatabaseAccess databaseObject = new DatabaseAccess();
            sqlQuery = "SELECT SHIPPING_COMPANY_Name from SHIPPING_COMPANY";
            sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@projectVer", projectVer);

            databaseObject.OpenConnection();
            result = sqlCommand.ExecuteReader();

            //int moduleID = 0;

            if (result.HasRows)
            {
                while (result.Read())
                {
                    shippingServList.Add(result[0].ToString());
                }
            }

            result.Close();
            databaseObject.CloseConnection();

            return shippingServList;
        }
        //Get carried ID from database
        public int getCarrierID()
        {
            DatabaseAccess databaseObject = new DatabaseAccess();
            sqlQuery = "select shipping_company_id from SHIPPING_COMPANY where shipping_company_name = @carrier";
            sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@carrier", this.carrier);
            databaseObject.OpenConnection();

            result = sqlCommand.ExecuteReader();

            int carrierID = 0;

            if (result.HasRows)
            {
                if (result.Read())
                {
                    if (result[0].ToString() == string.Empty)
                    {
                        result.Close();
                        databaseObject.CloseConnection();
                        return 0;
                    }

                    carrierID = int.Parse(result[0].ToString());
                }
            }

            result.Close();
            databaseObject.CloseConnection();

            return carrierID;
        }
    }
}
