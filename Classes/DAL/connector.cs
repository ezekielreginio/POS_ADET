using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_ADET.Classes.DB
{
    class connector:ParentConnector
    {
        /// <summary>
        /// titeeee
        /// </summary>
        /// <param name="procedure_name"></param>
        /// <param name="data"></param>
        public void writeProcedure(string procedure_name, Dictionary<string, string> data)
        {
            this.procedure_name = procedure_name;
            this.data = data;
            MySqlCommand mySqlCmd = createProcedure();
            mySqlCmd.ExecuteNonQuery();
            //MessageBox.Show("Query Successful");
        }

        public MySqlDataReader readProcedure(string procedure_name, Dictionary<string, string> data=null)
        {
            this.procedure_name = procedure_name;
            this.data = data;
            MySqlCommand mySqlCmd = createProcedure();
            
            MySqlDataReader reader  = mySqlCmd.ExecuteReader();
            return reader;
        }

        public DataTable getDataTable(string procedure_name, Dictionary<string, string> data = null)
        {
            this.procedure_name = procedure_name;
            this.data = data;
            MySqlCommand mySqlCmd = createProcedure();

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = mySqlCmd;
            da.Fill(dt);

            closeConn();
            return dt;
        }

        public string getLastID(string procedure_name)
        {
            this.procedure_name = procedure_name;
            this.data = null;

            string id = String.Empty;

            MySqlCommand mySqlCmd = createProcedure();
            MySqlDataReader reader = mySqlCmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader["last_inserted_id"].ToString();
            }
            return id;
        }
    }

    class ParentConnector
    {
        private MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=pos_adet");
        protected string procedure_name;
        protected Dictionary<string, string> data;
        protected MySqlCommand createProcedure()
        {
            try
            {
                conn.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(procedure_name, conn); //PreparedStatement
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                if(data != null)
                {
                    foreach (var item in data)
                    {
                        mySqlCmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                return mySqlCmd;
            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error: " + e.Message);
                return null;
            }
        }


        public void closeConn()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
