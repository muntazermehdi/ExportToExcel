using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ExportToExcel.DAL;

namespace ExportToExcel.BL
{
    public class SQLBL
    {
        public DataTable GetAllDBList(string SQLServerName, string UserName, string Password)
        {

            SQLDAL sqlDAL = new SQLDAL();

            DataTable dtDBList;

            try
            {
                dtDBList = sqlDAL.GetAllDBList(SQLServerName, UserName, Password);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {

            }
            return dtDBList;
        }

        public DataTable GetAllTableList(string SQLServerName, string UserName, string Password,string DBName)
        {

            SQLDAL sqlDAL = new SQLDAL();

            DataTable dtTableList;

            try
            {
                dtTableList = sqlDAL.GetAllTableList(SQLServerName, UserName, Password, DBName);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {

            }
            return dtTableList;
        }

        public DataTable GetTableData(string SQLServerName, string UserName, string Password, string DBName,string TableName)
        {

            SQLDAL sqlDAL = new SQLDAL();
            DataTable dtTableData;

            try
            {
                dtTableData = sqlDAL.GetTableData(SQLServerName, UserName, Password, DBName, TableName);

            }
            catch (Exception ex)
            {
               
                throw new Exception(ex.Message.ToString());
            }
            finally
            {

            }
            return dtTableData;
        }
    }
}
