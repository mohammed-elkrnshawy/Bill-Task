using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill
{
    public partial class Form_Bill_Customer_Purchasing : Form
    {
        int Bill_ID;
        string custome_name;
        double Bill_Total;
        public Form_Bill_Customer_Purchasing(int bill_ID, string customername,double billtotal)
        {
            InitializeComponent();
            this.Bill_ID = bill_ID;
            this.custome_name = customername;
            this.Bill_Total = billtotal;
        }
        
        private void Form_Bill_Customer_Purchasing_Load_1(object sender, EventArgs e)
        {

            string path = Application.StartupPath;
            string directory = Path.GetDirectoryName(path); //without file name
            string oneUp = Path.GetDirectoryName(directory); // Temp folder


            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + @"\CrystalBill.rpt");



            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();




            crParameterDiscreteValue.Value = Bill_ID;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@ID"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);




            crParameterDiscreteValue.Value = custome_name;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Name"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);



            
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}