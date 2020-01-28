using CommonDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountaNew
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-6).Date;
            dtpToDate.Value = DateTime.Now.Date;
            cboChartType.DataSource = Enum.GetValues(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesChartType));
            cboChartType.SelectedIndex = -1;
            GetChart();
            GetChartPermission();
        }

        private void GetChart()
        {
            DataTable dat = new DALCommon().SalesRegister(ClsCommonSettings.GlobalCompanyID, ClsCommonSettings.FinYearID, dtpFromDate.Value.Date, dtpToDate.Value.Date);
            MonthlyChart(cSales, dat, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column);

            if (dat != null && dat.Rows.Count > 0)
                lblSaleTotal.Text = dat.Rows.Cast<DataRow>().Sum(t => t["NetAmount"].ToDecimal()).ToStringCustom();
            else
                lblSaleTotal.Text = "0.00";

            dat = new DALCommon().ReceiptRegister(ClsCommonSettings.GlobalCompanyID, ClsCommonSettings.FinYearID, dtpFromDate.Value.Date, dtpToDate.Value.Date);
            MonthlyChart(cReceipt, dat, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea);

            if (dat != null && dat.Rows.Count > 0)
                lblReceiptTotal.Text = dat.Rows.Cast<DataRow>().Sum(t => t["NetAmount"].ToDecimal()).ToStringCustom();
            else
                lblReceiptTotal.Text = "0.00";

            dat = new DALCommon().PurchaseRegister(ClsCommonSettings.GlobalCompanyID, ClsCommonSettings.FinYearID, dtpFromDate.Value.Date, dtpToDate.Value.Date);
            MonthlyChart(cPurchase, dat, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area);

            if (dat != null && dat.Rows.Count > 0)
                lblPurchaseTotal.Text = dat.Rows.Cast<DataRow>().Sum(t => t["NetAmount"].ToDecimal()).ToStringCustom();
            else
                lblPurchaseTotal.Text = "0.00";

            dat = new DALCommon().PaymentRegister(ClsCommonSettings.GlobalCompanyID, ClsCommonSettings.FinYearID, dtpFromDate.Value.Date, dtpToDate.Value.Date);
            MonthlyChart(cPayment, dat, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar);

            if (dat != null && dat.Rows.Count > 0)
                lblPaymentTotal.Text = dat.Rows.Cast<DataRow>().Sum(t => t["NetAmount"].ToDecimal()).ToStringCustom();
            else
                lblPaymentTotal.Text = "0.00";

            SetDecimals();
        }

        private void SetDecimals()
        {
            decimal value;
            int iDecimalPlace = ClsCommonSettings.DecimalPlaces.ToInt32();

            if (lblSaleTotal.Text != string.Empty && decimal.TryParse(lblSaleTotal.Text.ToStringCustom(), out value))
                lblSaleTotal.Text = value.ToString(new string('#', 12) + "0." + new string('0', iDecimalPlace));

            if (lblReceiptTotal.Text != string.Empty && decimal.TryParse(lblReceiptTotal.Text.ToStringCustom(), out value))
                lblReceiptTotal.Text = value.ToString(new string('#', 12) + "0." + new string('0', iDecimalPlace));

            if (lblPurchaseTotal.Text != string.Empty && decimal.TryParse(lblPurchaseTotal.Text.ToStringCustom(), out value))
                lblPurchaseTotal.Text = value.ToString(new string('#', 12) + "0." + new string('0', iDecimalPlace));

            if (lblPaymentTotal.Text != string.Empty && decimal.TryParse(lblPaymentTotal.Text.ToStringCustom(), out value))
                lblPaymentTotal.Text = value.ToString(new string('#', 12) + "0." + new string('0', iDecimalPlace));
        }

        private void MonthlyChart(System.Windows.Forms.DataVisualization.Charting.Chart objChart, DataTable dt1,
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType objDefaultChartType)
        {
            string[] XValue1 = GetXValues(dt1);
            double[] YValue1 = GetYValues(dt1);
            objChart.Series[0].Points.DataBindXY(XValue1, YValue1);
            objChart.Series[0].ChartType = objDefaultChartType;

            if (cboChartType.SelectedValue.ToStringCustom() != string.Empty)
            {
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType objChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cboChartType.SelectedValue;
                objChart.Series[0].ChartType = objChartType;
            }
        }

        private string[] GetXValues(DataTable dt)
        {
            string[] points = new string[dt.Rows.Count];
            Random rnd = new Random();

            for (int i = 0; i < dt.Rows.Count; i++)
                points[i] = dt.Rows[i]["BillDate"].ToStringCustom().Split(' ').FirstOrDefault();

            return points;
        }

        private double[] GetYValues(DataTable dt)
        {
            double[] points = new double[dt.Rows.Count];
            Random rnd = new Random();

            for (int i = 0; i < dt.Rows.Count; i++)
                points[i] = dt.Rows[i]["NetAmount"].ToDouble();

            return points;
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            GetChart();
        }

        private void GetChartPermission()
        {
            pnlSales.Visible = cSales.Visible = lblSalesWidth.Visible = pnlReceipt.Visible = cReceipt.Visible = lblReceiptWidth.Visible =
                pnlPayment.Visible = cPayment.Visible = lblPaymentWidth.Visible = pnlPurchase.Visible = cPurchase.Visible = lblPurchaseWidth.Visible = false;
            DataTable datMaster = new DALCommon().GetReferenceTable("FormName,SEL", "FormID", "MenuPermission", "");

            if (datMaster != null && datMaster.Rows.Count > 0)
            {
                pnlSales.Visible = cSales.Visible = lblSalesWidth.Visible = datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.Sale).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;

                if (!pnlSales.Visible)
                    pnlSales.Visible = cSales.Visible = lblSalesWidth.Visible = datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.Sale2).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;

                pnlReceipt.Visible = cReceipt.Visible = lblReceiptWidth.Visible = pnlPayment.Visible = cPayment.Visible = lblPaymentWidth.Visible = 
                    datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.CrossEntry).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;

                if (!pnlReceipt.Visible)
                    pnlReceipt.Visible = cReceipt.Visible = lblReceiptWidth.Visible = pnlPayment.Visible = cPayment.Visible = lblPaymentWidth.Visible = 
                        datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.Sale2).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;

                pnlPurchase.Visible = cPurchase.Visible = lblPurchaseWidth.Visible = datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.Purchase).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;

                if (!pnlPurchase.Visible)
                    pnlPurchase.Visible = cPurchase.Visible = lblPurchaseWidth.Visible = datMaster.AsEnumerable().Where(t => t["FormID"].ToInt32() == (int)clsCommonItems.Forms.Purchase2).Select(t => Convert.ToBoolean(t["SEL"])).FirstOrDefault() == true;
            }

            pnlFilter.Visible = pnlTile.Visible = (pnlSales.Visible || pnlReceipt.Visible || pnlPayment.Visible || pnlPurchase.Visible);
        }
    }
}
