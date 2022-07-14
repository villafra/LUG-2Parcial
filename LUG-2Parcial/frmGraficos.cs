using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_2Parcial
{
    public partial class frmGraficos : Form
    {
        BLL.BLL_Ta_Te_Ti BLL;
        public frmGraficos()
        {
            InitializeComponent();
            BLL = new BLL.BLL_Ta_Te_Ti();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Datos Juegos.xml");
            ChartJuegos.DataSource = ds;

            ChartJuegos.Series[0].XValueMember = "Nombre";
            ChartJuegos.Series[0].YValueMembers = "Cantidad";
            ChartJuegos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            ChartJuegos.ChartAreas[0].Area3DStyle.Enable3D = true;
            ChartJuegos.Series[0].IsVisibleInLegend = false;
            ChartJuegos.DataBind();

            DataSet ds1 = new DataSet();
            ds1.ReadXml("Estadisticas PPT.xml");
            ChartPPT.DataSource = ds1;

            ChartPPT.Series[0].XValueMember = "Jugador";
            ChartPPT.Series[0].YValueMembers = "Victorias";
            ChartPPT.Series[0].Name = "Victorias";
            ChartPPT.Series[0].IsVisibleInLegend = true;
            ChartPPT.Series.Add("Empates").YValueMembers = "Empates";
            ChartPPT.Series.Add("Derrotas").YValueMembers = "Derrotas";
            ChartPPT.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            ChartPPT.ChartAreas[0].Area3DStyle.Enable3D = true;
            ChartPPT.Series[0].IsVisibleInLegend = false;
            ChartPPT.DataBind();

            DataSet ds2 = new DataSet();
            ds2.ReadXml("Estadisticas TaTeTi.xml");
            ChartTaTeTi.DataSource = ds2;

            ChartTaTeTi.Series[0].XValueMember = "Jugador";
            ChartTaTeTi.Series[0].YValueMembers = "Victorias";
            ChartTaTeTi.Series[0].Name = "Victorias";
            ChartTaTeTi.Series[0].IsVisibleInLegend = true;
            ChartTaTeTi.Series.Add("Empates").YValueMembers = "Empates";
            ChartTaTeTi.Series.Add("Derrotas").YValueMembers = "Derrotas";
            ChartTaTeTi.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            ChartTaTeTi.ChartAreas[0].Area3DStyle.Enable3D = true;
            ChartTaTeTi.Series[0].IsVisibleInLegend = false;
            ChartTaTeTi.DataBind();
        }
    }
}
