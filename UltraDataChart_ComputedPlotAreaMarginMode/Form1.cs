using Infragistics.Win.DataVisualization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraDataChart_ComputedPlotAreaMarginMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var data = new EnergyDataSource();

            var xAxis = new CategoryXAxis
            {
                Label = "Region",
                DataSource = data
            };

            var yAxis = new NumericYAxis();

            LineSeries series = new LineSeries();
            series.XAxis = xAxis;
            series.YAxis = yAxis;
            series.ValueMemberPath = "Coal";
            series.DataSource = data;

            ultraDataChart1.Axes.Add(xAxis);
            ultraDataChart1.Axes.Add(yAxis);
            ultraDataChart1.Series.Add(series);

            ultraDataChart1.ComputedPlotAreaMarginMode = ComputedPlotAreaMarginMode.Series;
        }
    }

    public class EnergyDataSource : List<EnergyProduction>
    {
        public EnergyDataSource()
        {
            this.Add(new EnergyProduction { Region = "America", Country = "CAN", Coal = 400, Oil = 100, Gas = 175, Nuclear = 225, Hydro = 350 });
            this.Add(new EnergyProduction { Region = "Asia", Country = "CHN", Coal = 925, Oil = 200, Gas = 350, Nuclear = 400, Hydro = 625 });
            this.Add(new EnergyProduction { Region = "Europe", Country = "RUS", Coal = 550, Oil = 200, Gas = 250, Nuclear = 475, Hydro = 425 });
            this.Add(new EnergyProduction { Region = "Asia", Country = "AUS", Coal = 450, Oil = 100, Gas = 150, Nuclear = 175, Hydro = 350 });
            this.Add(new EnergyProduction { Region = "America", Country = "USA", Coal = 800, Oil = 250, Gas = 475, Nuclear = 575, Hydro = 750 });
            this.Add(new EnergyProduction { Region = "Europe", Country = "FRA", Coal = 375, Oil = 150, Gas = 350, Nuclear = 275, Hydro = 325 });
        }
    }

    public class EnergyProduction
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Year { get; set; }

        // Non-Renewable Energy Sources
        public double Nuclear { get; set; }
        public double Coal { get; set; }
        public double Oil { get; set; }
        public double Gas { get; set; }
        // Renewable Energy Sources
        public double Hydro { get; set; }
    }
}
