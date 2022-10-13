using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDC
{
    public partial class frmPrint : Form
    {
        // Used a list 'cuz the ReportDataSource needed it 
        List<EDC> _data = new List<EDC>();

        public frmPrint(EDC data)
        {
            InitializeComponent();
            _data.Add(data);
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("CurrentDate", DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt")),
                new ReportParameter("Total", String.Format("{0:n0}", _data[0].Total) + "R"),
                new ReportParameter("InUSD", String.Format("{0:n}", ((double)_data[0].Total / 4100)))
            };
            
            ReportDataSource ds = new ReportDataSource("EDC_DataSet", _data);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.RefreshReport();
        }
    }
}
