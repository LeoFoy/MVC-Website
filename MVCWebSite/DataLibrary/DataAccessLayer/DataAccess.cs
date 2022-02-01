using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        private string _connectionString;
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<object> PopulateData(string storedProcName, Dictionary<string, object> parameters)
        {
            List<Object> dataList = new List<Object>();
            try
            {
                using (SqlConnection connnection = new SqlConnection(_connectionString))
                {
                    //SQL connection
                    connnection.Open();

                    //Create sql command for stored proc
                    SqlCommand cmd = new SqlCommand(storedProcName, connnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Loop thorugh and add params
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                    }
                    //Create sql reader and execute command
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Object[] dataObject = new Object[reader.FieldCount];

                            reader.GetValues(dataObject);

                            dataList.Add(dataObject);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dataList;
        }

        public DataTable PopulateTable(string storedProcName, Dictionary<string, object> parameters)
        {
            DataTable _dataTable = new DataTable();

            try
            {
                using (SqlConnection connnection = new SqlConnection(_connectionString))
                {
                    //SQL connection
                    connnection.Open();

                    //Create sql command for stored proc
                    SqlCommand cmd = new SqlCommand(storedProcName, connnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Loop thorugh and add params
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                    }
                    //Create sql reader and execute command
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(_dataTable);
                    }
                    connnection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return _dataTable;
        }

        public List<T> ReadData<T>(string storedProcName, Dictionary<string, object> parameters)
        {
            List<T> dataList = new List<T>();
            try
            {
                using (SqlConnection connnection = new SqlConnection(_connectionString))
                {
                    //SQL connection
                    connnection.Open();

                    //Create sql command for stored proc
                    SqlCommand cmd = new SqlCommand(storedProcName, connnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Loop thorugh and add params
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                    }
                    //Create sql reader and execute command
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var value = reader.GetValue(0);
                            try
                            {
                                dataList.Add((T)Convert.ChangeType(value, typeof(T)));
                            }
                            catch (InvalidCastException)
                            {
                                dataList.Add(default(T));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dataList;
        }
    }
}
