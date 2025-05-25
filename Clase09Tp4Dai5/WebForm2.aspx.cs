using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase09Tp4Dai5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //obtención de datos y almacenamiento en variable
                var adapter = new _ISSD_TP4_202501DataSetTableAdapters.PeliculasConDetallesTableAdapter();
                var dt = adapter.GetData();

                ReportDataSource rds = new ReportDataSource("PeliculasConDetalles", (DataTable)dt);

                //Base de datos
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report1.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);

                //Pasar Parámetro
                ReportParameter param = new ReportParameter("Parametro1", "Reporte de Peliculas") ;
                ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { param} );


                ReportViewer1.LocalReport.Refresh();

            }
        }
    }
}