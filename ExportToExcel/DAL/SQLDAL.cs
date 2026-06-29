using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportToExcel.DAL
{
    public class SQLDAL
    {
        string LogFolder = ExportToExcel.BL.Common.LogFilePath;

        public DataTable GetAllDBList(string SQLServerName, string UserName, string Password)
        {
            //the datetime and Log folder will be used for error log file in case error occured
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            
            DataSet dsDBList = new DataSet();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = " + SQLServerName + "; User Id =" + UserName + "; Password = " + Password + ";";

            try
            {
                string selectQuery = "SELECT [Name], database_id, create_date FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb') ORDER BY name;";

                SqlDataAdapter daDBList = new SqlDataAdapter(selectQuery, connection);
                daDBList.SelectCommand.CommandType = System.Data.CommandType.Text;
                daDBList.Fill(dsDBList);

            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }
            }
            finally 
            {
                connection.Close();
            }
            return dsDBList.Tables[0];
        }

        public DataTable GetAllTableList(string SQLServerName, string UserName, string Password,string DBName)
        {
            //the datetime and Log folder will be used for error log file in case error occured
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            
            DataSet dsTableList = new DataSet();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = " + SQLServerName + "; User Id =" + UserName + "; Password = " + Password + "; Initial Catalog=" + DBName + ";";

            try
            {
                string selectQuery = "SELECT SCHEMA_NAME(schema_id) + '.' + name AS TableID ,name AS TableName FROM sys.objects WHERE type = 'U' and name <>'sysdiagrams' ORDER BY TableName";
                SqlDataAdapter daTableList = new SqlDataAdapter(selectQuery, connection);
                daTableList.SelectCommand.CommandType = System.Data.CommandType.Text;
                daTableList.Fill(dsTableList);

            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }
            }
            finally
            {
                connection.Close();
            }
            return dsTableList.Tables[0];
        }

        public DataTable GetTableData(string SQLServerName, string UserName, string Password, string DBName,string TableName)
        {
            //the datetime and Log folder will be used for error log file in case error occured
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            
            DataSet dsTableData = new DataSet();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = " + SQLServerName + "; User Id =" + UserName + "; Password = " + Password + "; Initial Catalog=" + DBName + ";";

            try
            {
                string selectQuery = "SELECT * FROM "+ TableName +";";

                SqlDataAdapter daTableData = new SqlDataAdapter(selectQuery, connection);
                daTableData.SelectCommand.CommandType = System.Data.CommandType.Text;
                daTableData.Fill(dsTableData);

            }
            catch (Exception exception)
            {
                // Create Log File for Errors
                using (StreamWriter sw = File.CreateText(LogFolder
                    + "\\" + "ErrorLog_" + datetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }
            }
            finally
            {
                connection.Close();
            }
            return dsTableData.Tables[0];
        }
    }
}
