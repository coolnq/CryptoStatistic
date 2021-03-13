using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace CryptoStatistic.Components
{
    public partial class IncomePlot : UserControl
    {
        PlotModel basePlot = new PlotModel { Title = "Доход в день" };
        ScatterSeries paymentSeries = new ScatterSeries();
        LineSeries incomeSeries = new LineSeries();
        public IncomePlot()
        {
            InitializeComponent();

            DateTimeAxis xAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd.MM",
                Title = "Дата",
                MinorIntervalType = DateTimeIntervalType.Hours,
                IntervalType = DateTimeIntervalType.Days,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Solid
            };

            LinearAxis yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                StringFormat = "0.########",
                Title = "BTC",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Solid
            };

            basePlot.Axes.Add(xAxis);
            basePlot.Axes.Add(yAxis);

            paymentSeries.MarkerType = MarkerType.Circle;
            paymentSeries.MarkerSize = 3.0;
            paymentSeries.MarkerFill = OxyColor.FromRgb(255, 255, 0);
            paymentSeries.TrackerFormatString = "Payment time:\n{2:dd.MM.yy hh:mm}";
            incomeSeries.TrackerFormatString = "Доход: {4:0.########}\nДата: {2:dd.MM.yy}";

            basePlot.Series.Add(incomeSeries);
            basePlot.Series.Add(paymentSeries);
            
            this.plotView1.Model = basePlot;
        }

        public void LoadIncome(DataPoint[] points)
        {
            incomeSeries.Points.AddRange(points);
            
        }

        public void LoadPayment(ScatterPoint[] points)
        {
            paymentSeries.Points.AddRange(points);
        }

        public void UpdatePlot()
        {
            basePlot.InvalidatePlot(true);
            basePlot.ResetAllAxes();
        }
    }
}
