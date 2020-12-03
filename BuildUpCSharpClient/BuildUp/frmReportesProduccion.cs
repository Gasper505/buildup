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
    public partial class frmReportesProduccion : Form
    {

        ReportesProduccionWS.ReportesProduccionClient daoReportesProd;

        public frmReportesProduccion()
        {
            daoReportesProd = new ReportesProduccionWS.ReportesProduccionClient();
            InitializeComponent();
        }

        private void btnGenerarRepProdDiario_Click(object sender, EventArgs e)
        {
            sfdReporteProdDiario.ShowDialog();
            if (sfdReporteProdDiario.FileName != null && sfdReporteProdDiario.FileName != "")
            {
                byte[] arreglo = daoReportesProd.generarReporteProduccionDiario(dateTimePicker1.Value);
                File.WriteAllBytes(sfdReporteProdDiario.FileName + ".pdf", arreglo);
            }
            MessageBox.Show("Se ha guardado correctamente", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sfdReporteProdMensual.ShowDialog();
            if (sfdReporteProdMensual.FileName != null && sfdReporteProdMensual.FileName != "")
            {
                byte[] arreglo = daoReportesProd.generarReporteProduccionMensual(Int32.Parse(comboBox1.Text));
                File.WriteAllBytes(sfdReporteProdMensual.FileName + ".pdf", arreglo);
            }
            MessageBox.Show("Se ha guardado correctamente", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
