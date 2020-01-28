namespace AccountaNew
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cReceipt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cPurchase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cPayment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSales = new DevComponents.DotNetBar.PanelEx();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblSaleTotal = new System.Windows.Forms.Label();
            this.pnlReceipt = new DevComponents.DotNetBar.PanelEx();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblReceiptTotal = new System.Windows.Forms.Label();
            this.pnlPurchase = new DevComponents.DotNetBar.PanelEx();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.lblPurchaseTotal = new System.Windows.Forms.Label();
            this.pnlPayment = new DevComponents.DotNetBar.PanelEx();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentTotal = new System.Windows.Forms.Label();
            this.lblSubmit = new DevComponents.DotNetBar.LabelX();
            this.lblChart = new DevComponents.DotNetBar.LabelX();
            this.lblToDate = new DevComponents.DotNetBar.LabelX();
            this.lblFromDate = new DevComponents.DotNetBar.LabelX();
            this.dtpToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboChartType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtpFromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pnlFilter = new DevComponents.DotNetBar.PanelEx();
            this.pnlTile = new DevComponents.DotNetBar.PanelEx();
            this.lblPaymentWidth = new DevComponents.DotNetBar.LabelX();
            this.lblPurchaseWidth = new DevComponents.DotNetBar.LabelX();
            this.lblReceiptWidth = new DevComponents.DotNetBar.LabelX();
            this.lblSalesWidth = new DevComponents.DotNetBar.LabelX();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPayment)).BeginInit();
            this.pnlSales.SuspendLayout();
            this.pnlReceipt.SuspendLayout();
            this.pnlPurchase.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.cSales);
            this.flowLayoutPanel1.Controls.Add(this.cReceipt);
            this.flowLayoutPanel1.Controls.Add(this.cPurchase);
            this.flowLayoutPanel1.Controls.Add(this.cPayment);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 139);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 394);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // cSales
            // 
            this.cSales.BackColor = System.Drawing.Color.LightGray;
            this.cSales.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.ScaleView.Size = 5D;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.cSales.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.cSales.Legends.Add(legend1);
            this.cSales.Location = new System.Drawing.Point(5, 5);
            this.cSales.Margin = new System.Windows.Forms.Padding(5);
            this.cSales.Name = "cSales";
            series1.BorderColor = System.Drawing.Color.RoyalBlue;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.cSales.Series.Add(series1);
            this.cSales.Size = new System.Drawing.Size(600, 450);
            this.cSales.TabIndex = 0;
            this.cSales.Text = "chart1";
            // 
            // cReceipt
            // 
            this.cReceipt.BackColor = System.Drawing.Color.LightGray;
            this.cReceipt.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScaleView.Size = 5D;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.cReceipt.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.cReceipt.Legends.Add(legend2);
            this.cReceipt.Location = new System.Drawing.Point(5, 465);
            this.cReceipt.Margin = new System.Windows.Forms.Padding(5);
            this.cReceipt.Name = "cReceipt";
            this.cReceipt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderColor = System.Drawing.Color.DarkGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Receipt";
            this.cReceipt.Series.Add(series2);
            this.cReceipt.Size = new System.Drawing.Size(600, 450);
            this.cReceipt.TabIndex = 1;
            this.cReceipt.Text = "chart1";
            // 
            // cPurchase
            // 
            this.cPurchase.BackColor = System.Drawing.Color.LightGray;
            this.cPurchase.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.ScaleView.Size = 5D;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.cPurchase.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.cPurchase.Legends.Add(legend3);
            this.cPurchase.Location = new System.Drawing.Point(5, 925);
            this.cPurchase.Margin = new System.Windows.Forms.Padding(5);
            this.cPurchase.Name = "cPurchase";
            this.cPurchase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.BorderColor = System.Drawing.Color.DarkGoldenrod;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Purchase";
            this.cPurchase.Series.Add(series3);
            this.cPurchase.Size = new System.Drawing.Size(600, 450);
            this.cPurchase.TabIndex = 2;
            this.cPurchase.Text = "chart1";
            // 
            // cPayment
            // 
            this.cPayment.BackColor = System.Drawing.Color.LightGray;
            this.cPayment.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.ScaleView.Size = 5D;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.cPayment.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.cPayment.Legends.Add(legend4);
            this.cPayment.Location = new System.Drawing.Point(5, 1385);
            this.cPayment.Margin = new System.Windows.Forms.Padding(5);
            this.cPayment.Name = "cPayment";
            this.cPayment.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.BorderColor = System.Drawing.Color.Maroon;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Payment";
            this.cPayment.Series.Add(series4);
            this.cPayment.Size = new System.Drawing.Size(600, 450);
            this.cPayment.TabIndex = 3;
            this.cPayment.Text = "chart1";
            // 
            // pnlSales
            // 
            this.pnlSales.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSales.Controls.Add(this.lblSales);
            this.pnlSales.Controls.Add(this.lblSaleTotal);
            this.pnlSales.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSales.Location = new System.Drawing.Point(12, 0);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 106);
            this.pnlSales.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSales.Style.BackColor1.Color = System.Drawing.Color.SkyBlue;
            this.pnlSales.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.pnlSales.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlSales.Style.BorderColor.Color = System.Drawing.Color.DodgerBlue;
            this.pnlSales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSales.Style.GradientAngle = 90;
            this.pnlSales.TabIndex = 21;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSales.ForeColor = System.Drawing.Color.White;
            this.lblSales.Location = new System.Drawing.Point(0, 0);
            this.lblSales.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(43, 16);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales";
            // 
            // lblSaleTotal
            // 
            this.lblSaleTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSaleTotal.ForeColor = System.Drawing.Color.White;
            this.lblSaleTotal.Location = new System.Drawing.Point(0, 84);
            this.lblSaleTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaleTotal.Name = "lblSaleTotal";
            this.lblSaleTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSaleTotal.Size = new System.Drawing.Size(200, 22);
            this.lblSaleTotal.TabIndex = 1;
            this.lblSaleTotal.Text = "0.00";
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlReceipt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlReceipt.Controls.Add(this.lblReceipt);
            this.pnlReceipt.Controls.Add(this.lblReceiptTotal);
            this.pnlReceipt.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReceipt.Location = new System.Drawing.Point(224, 0);
            this.pnlReceipt.Margin = new System.Windows.Forms.Padding(5);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(200, 106);
            this.pnlReceipt.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlReceipt.Style.BackColor1.Color = System.Drawing.Color.SeaGreen;
            this.pnlReceipt.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.pnlReceipt.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlReceipt.Style.BorderColor.Color = System.Drawing.Color.Green;
            this.pnlReceipt.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlReceipt.Style.GradientAngle = 90;
            this.pnlReceipt.TabIndex = 22;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReceipt.ForeColor = System.Drawing.Color.White;
            this.lblReceipt.Location = new System.Drawing.Point(0, 0);
            this.lblReceipt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(57, 16);
            this.lblReceipt.TabIndex = 0;
            this.lblReceipt.Text = "Receipt";
            // 
            // lblReceiptTotal
            // 
            this.lblReceiptTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReceiptTotal.ForeColor = System.Drawing.Color.White;
            this.lblReceiptTotal.Location = new System.Drawing.Point(0, 84);
            this.lblReceiptTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReceiptTotal.Name = "lblReceiptTotal";
            this.lblReceiptTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReceiptTotal.Size = new System.Drawing.Size(200, 22);
            this.lblReceiptTotal.TabIndex = 1;
            this.lblReceiptTotal.Text = "0.00";
            // 
            // pnlPurchase
            // 
            this.pnlPurchase.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPurchase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlPurchase.Controls.Add(this.lblPurchase);
            this.pnlPurchase.Controls.Add(this.lblPurchaseTotal);
            this.pnlPurchase.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlPurchase.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPurchase.Location = new System.Drawing.Point(436, 0);
            this.pnlPurchase.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPurchase.Name = "pnlPurchase";
            this.pnlPurchase.Size = new System.Drawing.Size(200, 106);
            this.pnlPurchase.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlPurchase.Style.BackColor1.Color = System.Drawing.Color.Goldenrod;
            this.pnlPurchase.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.pnlPurchase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlPurchase.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlPurchase.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPurchase.Style.GradientAngle = 90;
            this.pnlPurchase.TabIndex = 23;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPurchase.ForeColor = System.Drawing.Color.White;
            this.lblPurchase.Location = new System.Drawing.Point(0, 0);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(68, 16);
            this.lblPurchase.TabIndex = 0;
            this.lblPurchase.Text = "Purchase";
            // 
            // lblPurchaseTotal
            // 
            this.lblPurchaseTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPurchaseTotal.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseTotal.Location = new System.Drawing.Point(0, 84);
            this.lblPurchaseTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPurchaseTotal.Name = "lblPurchaseTotal";
            this.lblPurchaseTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPurchaseTotal.Size = new System.Drawing.Size(200, 22);
            this.lblPurchaseTotal.TabIndex = 1;
            this.lblPurchaseTotal.Text = "0.00";
            // 
            // pnlPayment
            // 
            this.pnlPayment.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPayment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlPayment.Controls.Add(this.lblPayment);
            this.pnlPayment.Controls.Add(this.lblPaymentTotal);
            this.pnlPayment.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPayment.Location = new System.Drawing.Point(648, 0);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(200, 106);
            this.pnlPayment.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlPayment.Style.BackColor1.Color = System.Drawing.Color.Tomato;
            this.pnlPayment.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.pnlPayment.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlPayment.Style.BorderColor.Color = System.Drawing.Color.IndianRed;
            this.pnlPayment.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPayment.Style.GradientAngle = 90;
            this.pnlPayment.TabIndex = 24;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(0, 0);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(65, 16);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            // 
            // lblPaymentTotal
            // 
            this.lblPaymentTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPaymentTotal.ForeColor = System.Drawing.Color.White;
            this.lblPaymentTotal.Location = new System.Drawing.Point(0, 84);
            this.lblPaymentTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaymentTotal.Name = "lblPaymentTotal";
            this.lblPaymentTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentTotal.Size = new System.Drawing.Size(200, 22);
            this.lblPaymentTotal.TabIndex = 1;
            this.lblPaymentTotal.Text = "0.00";
            // 
            // lblSubmit
            // 
            this.lblSubmit.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSubmit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSubmit.Location = new System.Drawing.Point(564, 6);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(22, 22);
            this.lblSubmit.Symbol = "";
            this.lblSubmit.SymbolColor = System.Drawing.Color.RoyalBlue;
            this.lblSubmit.TabIndex = 25;
            this.lblSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblChart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblChart.Location = new System.Drawing.Point(8, 8);
            this.lblChart.Margin = new System.Windows.Forms.Padding(5);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(38, 18);
            this.lblChart.TabIndex = 0;
            this.lblChart.Text = "Chart";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblToDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblToDate.Location = new System.Drawing.Point(393, 8);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(18, 18);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblFromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFromDate.Location = new System.Drawing.Point(202, 8);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(36, 18);
            this.lblFromDate.TabIndex = 2;
            this.lblFromDate.Text = "From";
            // 
            // dtpToDate
            // 
            // 
            // 
            // 
            this.dtpToDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpToDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpToDate.ButtonClear.Tooltip = "";
            this.dtpToDate.ButtonCustom.Tooltip = "";
            this.dtpToDate.ButtonCustom2.Tooltip = "";
            this.dtpToDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpToDate.ButtonDropDown.Tooltip = "";
            this.dtpToDate.ButtonDropDown.Visible = true;
            this.dtpToDate.ButtonFreeText.Tooltip = "";
            this.dtpToDate.IsPopupCalendarOpen = false;
            this.dtpToDate.Location = new System.Drawing.Point(422, 5);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.dtpToDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpToDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpToDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpToDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpToDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpToDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dtpToDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpToDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpToDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpToDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpToDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpToDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpToDate.MonthCalendar.TodayButtonVisible = true;
            this.dtpToDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(133, 23);
            this.dtpToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpToDate.TabIndex = 5;
            // 
            // cboChartType
            // 
            this.cboChartType.DisplayMember = "Text";
            this.cboChartType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChartType.DropDownHeight = 120;
            this.cboChartType.FormattingEnabled = true;
            this.cboChartType.IntegralHeight = false;
            this.cboChartType.ItemHeight = 17;
            this.cboChartType.Location = new System.Drawing.Point(58, 5);
            this.cboChartType.Margin = new System.Windows.Forms.Padding(5);
            this.cboChartType.Name = "cboChartType";
            this.cboChartType.Size = new System.Drawing.Size(134, 23);
            this.cboChartType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboChartType.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            // 
            // 
            // 
            this.dtpFromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFromDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFromDate.ButtonClear.Tooltip = "";
            this.dtpFromDate.ButtonCustom.Tooltip = "";
            this.dtpFromDate.ButtonCustom2.Tooltip = "";
            this.dtpFromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFromDate.ButtonDropDown.Tooltip = "";
            this.dtpFromDate.ButtonDropDown.Visible = true;
            this.dtpFromDate.ButtonFreeText.Tooltip = "";
            this.dtpFromDate.IsPopupCalendarOpen = false;
            this.dtpFromDate.Location = new System.Drawing.Point(249, 5);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.dtpFromDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFromDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFromDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFromDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFromDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFromDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dtpFromDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFromDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFromDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFromDate.MonthCalendar.TodayButtonVisible = true;
            this.dtpFromDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(133, 23);
            this.dtpFromDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFromDate.TabIndex = 3;
            // 
            // pnlFilter
            // 
            this.pnlFilter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFilter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFilter.Controls.Add(this.lblSubmit);
            this.pnlFilter.Controls.Add(this.dtpToDate);
            this.pnlFilter.Controls.Add(this.lblToDate);
            this.pnlFilter.Controls.Add(this.dtpFromDate);
            this.pnlFilter.Controls.Add(this.lblFromDate);
            this.pnlFilter.Controls.Add(this.cboChartType);
            this.pnlFilter.Controls.Add(this.lblChart);
            this.pnlFilter.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(800, 33);
            this.pnlFilter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFilter.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlFilter.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlFilter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFilter.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlFilter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFilter.Style.GradientAngle = 90;
            this.pnlFilter.TabIndex = 25;
            // 
            // pnlTile
            // 
            this.pnlTile.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlTile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlTile.Controls.Add(this.pnlPayment);
            this.pnlTile.Controls.Add(this.lblPaymentWidth);
            this.pnlTile.Controls.Add(this.pnlPurchase);
            this.pnlTile.Controls.Add(this.lblPurchaseWidth);
            this.pnlTile.Controls.Add(this.pnlReceipt);
            this.pnlTile.Controls.Add(this.lblReceiptWidth);
            this.pnlTile.Controls.Add(this.pnlSales);
            this.pnlTile.Controls.Add(this.lblSalesWidth);
            this.pnlTile.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTile.Location = new System.Drawing.Point(0, 33);
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Size = new System.Drawing.Size(800, 106);
            this.pnlTile.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlTile.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlTile.Style.BackColor2.Color = System.Drawing.Color.LightGray;
            this.pnlTile.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlTile.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTile.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlTile.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTile.Style.GradientAngle = 90;
            this.pnlTile.TabIndex = 26;
            // 
            // lblPaymentWidth
            // 
            this.lblPaymentWidth.AutoSize = true;
            this.lblPaymentWidth.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPaymentWidth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPaymentWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPaymentWidth.Location = new System.Drawing.Point(636, 0);
            this.lblPaymentWidth.Margin = new System.Windows.Forms.Padding(5);
            this.lblPaymentWidth.Name = "lblPaymentWidth";
            this.lblPaymentWidth.Size = new System.Drawing.Size(12, 18);
            this.lblPaymentWidth.TabIndex = 28;
            this.lblPaymentWidth.Text = " ";
            // 
            // lblPurchaseWidth
            // 
            this.lblPurchaseWidth.AutoSize = true;
            this.lblPurchaseWidth.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPurchaseWidth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPurchaseWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPurchaseWidth.Location = new System.Drawing.Point(424, 0);
            this.lblPurchaseWidth.Margin = new System.Windows.Forms.Padding(5);
            this.lblPurchaseWidth.Name = "lblPurchaseWidth";
            this.lblPurchaseWidth.Size = new System.Drawing.Size(12, 18);
            this.lblPurchaseWidth.TabIndex = 26;
            this.lblPurchaseWidth.Text = " ";
            // 
            // lblReceiptWidth
            // 
            this.lblReceiptWidth.AutoSize = true;
            this.lblReceiptWidth.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblReceiptWidth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblReceiptWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReceiptWidth.Location = new System.Drawing.Point(212, 0);
            this.lblReceiptWidth.Margin = new System.Windows.Forms.Padding(5);
            this.lblReceiptWidth.Name = "lblReceiptWidth";
            this.lblReceiptWidth.Size = new System.Drawing.Size(12, 18);
            this.lblReceiptWidth.TabIndex = 27;
            this.lblReceiptWidth.Text = " ";
            // 
            // lblSalesWidth
            // 
            this.lblSalesWidth.AutoSize = true;
            this.lblSalesWidth.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSalesWidth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSalesWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSalesWidth.Location = new System.Drawing.Point(0, 0);
            this.lblSalesWidth.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalesWidth.Name = "lblSalesWidth";
            this.lblSalesWidth.Size = new System.Drawing.Size(12, 18);
            this.lblSalesWidth.TabIndex = 25;
            this.lblSalesWidth.Text = " ";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlTile);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPayment)).EndInit();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            this.pnlPurchase.ResumeLayout(false);
            this.pnlPurchase.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTile.ResumeLayout(false);
            this.pnlTile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.PanelEx pnlSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblSaleTotal;
        private DevComponents.DotNetBar.PanelEx pnlReceipt;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label lblReceiptTotal;
        private DevComponents.DotNetBar.PanelEx pnlPurchase;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label lblPurchaseTotal;
        private DevComponents.DotNetBar.PanelEx pnlPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentTotal;
        public System.Windows.Forms.DataVisualization.Charting.Chart cSales;
        public System.Windows.Forms.DataVisualization.Charting.Chart cReceipt;
        public System.Windows.Forms.DataVisualization.Charting.Chart cPurchase;
        public System.Windows.Forms.DataVisualization.Charting.Chart cPayment;
        private DevComponents.DotNetBar.LabelX lblChart;
        private DevComponents.DotNetBar.LabelX lblToDate;
        private DevComponents.DotNetBar.LabelX lblFromDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpToDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboChartType;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFromDate;
        private DevComponents.DotNetBar.LabelX lblSubmit;
        private DevComponents.DotNetBar.PanelEx pnlFilter;
        private DevComponents.DotNetBar.PanelEx pnlTile;
        private DevComponents.DotNetBar.LabelX lblPurchaseWidth;
        private DevComponents.DotNetBar.LabelX lblReceiptWidth;
        private DevComponents.DotNetBar.LabelX lblSalesWidth;
        private DevComponents.DotNetBar.LabelX lblPaymentWidth;
    }
}