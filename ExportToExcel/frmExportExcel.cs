using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExportToExcel.BL;
using OfficeOpenXml;

namespace ExportToExcel
{
    public partial class frmExportExcel : Form
    {
        #region Constructors
        public frmExportExcel()
        {
            InitializeComponent();
        }
        #endregion

        #region EventHandlers
        private void btnLoadDBList_Click(object sender, EventArgs e)
        {
            cmbDBList.DisplayMember = "Name";
            cmbDBList.ValueMember = "Name";
            cmbDBList.DataSource = GetAllDBList(txtServerName.Text, txtUserName.Text, txtPassword.Text);


        }
        private void cmbDBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDBList.SelectedValue.ToString()))
            {
                cmbTable.DisplayMember = "TableName";
                cmbTable.ValueMember = "TableID";
                cmbTable.DataSource = GetAllTableList(txtServerName.Text, txtUserName.Text, txtPassword.Text, cmbDBList.SelectedValue.ToString());
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (cmbDBList.SelectedValue == null && cmbTable.SelectedValue == null)
                MessageBox.Show("Please select database and table to export!", "Info");
            else
            {
                DataTable dtData = LoadTableData(txtServerName.Text, txtUserName.Text, txtPassword.Text, cmbDBList.SelectedValue.ToString(), cmbTable.SelectedValue.ToString());
                ExportToExcel(dtData, cmbTable.Text);
            }

        }

        #endregion

        #region Methods

        private DataTable GetAllDBList(string SQLServerName, string UserName, string Password)
        {
            SQLBL sqlBL = new SQLBL();
            DataTable dtDBList = sqlBL.GetAllDBList(SQLServerName, UserName,Password);
            return dtDBList; 
        }
        private DataTable GetAllTableList(string SQLServerName, string UserName, string Password,string DBName)
        {
            SQLBL sqlBL = new SQLBL();
            DataTable dtTableList = sqlBL.GetAllTableList(SQLServerName, UserName, Password,DBName);
            return dtTableList;
        }
        private DataTable LoadTableData(string SQLServerName, string UserName, string Password, string DBName, string TableName)
        {
            SQLBL sqlBL = new SQLBL();
            DataTable dtTableData = sqlBL.GetTableData(SQLServerName, UserName, Password, DBName, TableName);
            return dtTableData;
        }
        private void ExportToExcel(DataTable dtDBData, string tableName)
        {
            string fileName = tableName + ".xlsx";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";

                saveFileDialog.FileName = tableName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        fileName = saveFileDialog.FileName;

                        var newFile = new System.IO.FileInfo(fileName);

                        // Delete existing file If User choose to overright
                        if (newFile.Exists == true && saveFileDialog.OverwritePrompt == true) 
                            newFile.Delete();
                        
                        using (ExcelPackage pck = new ExcelPackage(newFile))
                        {
                            ExcelWorksheet ws = pck.Workbook.Worksheets.Add(tableName);
                            ws.Cells["A1"].LoadFromDataTable(dtDBData, true);
                            pck.SaveAs(newFile);
                        }

                        MessageBox.Show("Export Completed!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }

        }

        #endregion
    }
}
