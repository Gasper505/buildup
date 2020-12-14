using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BuildUp
{

    public partial class frmReportesProduccionJA : Form
    {

        ReportesProduccionWS.ReportesProduccionClient daoReportesProduccion;

        public frmReportesProduccionJA()
        {
            daoReportesProduccion = new ReportesProduccionWS.ReportesProduccionClient();
            InitializeComponent();
            
            int currentYear = DateTime.Today.Year;
            for (int i = 2017; i <= currentYear; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                cboAnho.Items.Add(item.Content);
            }
        }

        private void btnReporteDiario_Click(object sender, EventArgs e)
        {
            sfdReportesProduccion.ShowDialog();
            if (sfdReportesProduccion.FileName != null && sfdReportesProduccion.FileName != "")
            {
                byte[] arreglo = daoReportesProduccion.generarReporteProduccionDiario(dtpFecha.Value);
                //frmBuscarIncidencia formJefeArea = new frmBuscarIncidencia();
                //formJefeArea.Show();
                sfdReportesProduccion.FileName = "ReporteDiarioProduccion.pdf";
                File.WriteAllBytes(sfdReportesProduccion.FileName, arreglo);
                //formJefeArea.Hide();
                MessageBox.Show("El reporte se ha guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnReporteMensual_Click(object sender, EventArgs e)
        {
            sfdReportesProduccion.ShowDialog();
            if (sfdReportesProduccion.FileName != null && sfdReportesProduccion.FileName != "")
            {

                int mes = 0;
                switch (cboMes.Text)
                {
                    case "Enero":
                        mes = 1;
                        break;
                    case "Febrero":
                        mes = 2;
                        break;
                    case "Marzo":
                        mes = 3;
                        break;
                    case "Abril":
                        mes = 4;
                        break;
                    case "Mayo":
                        mes = 5;
                        break;
                    case "Junio":
                        mes = 6;
                        break;
                    case "Julio":
                        mes = 7;
                        break;
                    case "Agosto":
                        mes = 8;
                        break;
                    case "Setiembre":
                        mes = 9;
                        break;
                    case "Octubre":
                        mes = 10;
                        break;
                    case "Noviembre":
                        mes = 11;
                        break;
                    case "Diciembre":
                        mes = 12;
                        break;
                }

                byte[] arreglo = daoReportesProduccion.generarReporteProduccionMensual(mes, Int32.Parse(cboAnho.Text));
                sfdReportesProduccion.FileName = "ReporteMensualProduccion.pdf";
                File.WriteAllBytes(sfdReportesProduccion.FileName, arreglo);
                MessageBox.Show("El reporte se ha guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
