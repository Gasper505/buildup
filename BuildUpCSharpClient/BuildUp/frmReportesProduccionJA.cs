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

namespace BuildUp
{

    public partial class frmReportesProduccionJA : Form
    {

        ReportesProduccionWS.ReportesProduccionClient daoReportesProduccion;

        public frmReportesProduccionJA()
        {
            daoReportesProduccion = new ReportesProduccionWS.ReportesProduccionClient();
            InitializeComponent();
        }

        private void btnReporteDiario_Click(object sender, EventArgs e)
        {
            sfdReportesProduccion.ShowDialog();
            if (sfdReportesProduccion.FileName != null && sfdReportesProduccion.FileName != "")
            {
                byte[] arreglo = daoReportesProduccion.generarReporteProduccionDiario(dtpFecha.Value);
                File.WriteAllBytes(sfdReportesProduccion.FileName + ".pdf", arreglo);
            }
            MessageBox.Show("Se ha guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                byte[] arreglo = daoReportesProduccion.generarReporteProduccionMensual(mes);
                File.WriteAllBytes(sfdReportesProduccion.FileName + ".pdf", arreglo);
            }
            MessageBox.Show("Se ha guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
