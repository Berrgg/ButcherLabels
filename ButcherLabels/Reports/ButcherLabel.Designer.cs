namespace ButcherLabels.Reports
{
    partial class ButcherLabel
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters xmlFileConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButcherLabel));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblSignature = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBatch = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblBatch = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblLot = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLot = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKillDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblKillDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblOrigin = new DevExpress.XtraReports.UI.XRLabel();
            this.lblOrigin = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCut = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblCut = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblSlaughtered = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSlaughtered = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPalletId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblPalletId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblFinishProd = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFinishProd = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRawMaterial = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblRawMaterial = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.lblShift = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblShift = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblProdDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblProdDate = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrControlStyleFields = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Signature = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSignature,
            this.xrlblSignature,
            this.lblBatch,
            this.xrlblBatch,
            this.xrlblLot,
            this.lblLot,
            this.lblKillDate,
            this.xrlblKillDate,
            this.xrlblOrigin,
            this.lblOrigin,
            this.lblCut,
            this.xrlblCut,
            this.xrlblSlaughtered,
            this.lblSlaughtered,
            this.lblPalletId,
            this.xrlblPalletId,
            this.xrlblFinishProd,
            this.lblFinishProd,
            this.lblRawMaterial,
            this.xrlblRawMaterial,
            this.xrlblCustomer,
            this.lblCustomer,
            this.lblShift,
            this.xrlblShift,
            this.xrLblProdDate,
            this.xrBarCode1,
            this.xrLabel1,
            this.lblProdDate});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 1402.94F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblSignature
            // 
            this.lblSignature.Dpi = 254F;
            this.lblSignature.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblSignature.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1262.652F);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblSignature.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblSignature.StyleName = "xrControlStyleFields";
            this.lblSignature.Text = "Signature:";
            // 
            // xrlblSignature
            // 
            this.xrlblSignature.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Signature")});
            this.xrlblSignature.Dpi = 254F;
            this.xrlblSignature.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblSignature.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 1262.652F);
            this.xrlblSignature.Name = "xrlblSignature";
            this.xrlblSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblSignature.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblSignature.StyleName = "xrControlStyleFields";
            // 
            // lblBatch
            // 
            this.lblBatch.Dpi = 254F;
            this.lblBatch.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblBatch.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1325.322F);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblBatch.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblBatch.StyleName = "xrControlStyleFields";
            this.lblBatch.Text = "Batch:";
            // 
            // xrlblBatch
            // 
            this.xrlblBatch.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Batch")});
            this.xrlblBatch.Dpi = 254F;
            this.xrlblBatch.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblBatch.LocationFloat = new DevExpress.Utils.PointFloat(157.4055F, 1325.322F);
            this.xrlblBatch.Name = "xrlblBatch";
            this.xrlblBatch.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblBatch.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblBatch.StyleName = "xrControlStyleFields";
            // 
            // xrlblLot
            // 
            this.xrlblLot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Lot")});
            this.xrlblLot.Dpi = 254F;
            this.xrlblLot.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblLot.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 1208.594F);
            this.xrlblLot.Name = "xrlblLot";
            this.xrlblLot.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblLot.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblLot.StyleName = "xrControlStyleFields";
            // 
            // lblLot
            // 
            this.lblLot.Dpi = 254F;
            this.lblLot.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblLot.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1208.594F);
            this.lblLot.Name = "lblLot";
            this.lblLot.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblLot.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblLot.StyleName = "xrControlStyleFields";
            this.lblLot.Text = "Lot:";
            // 
            // lblKillDate
            // 
            this.lblKillDate.Dpi = 254F;
            this.lblKillDate.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblKillDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1147.895F);
            this.lblKillDate.Name = "lblKillDate";
            this.lblKillDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKillDate.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblKillDate.StyleName = "xrControlStyleFields";
            this.lblKillDate.Text = "Kill date:";
            // 
            // xrlblKillDate
            // 
            this.xrlblKillDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.KillDate", "{0:dd/MM/yyyy}")});
            this.xrlblKillDate.Dpi = 254F;
            this.xrlblKillDate.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblKillDate.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 1147.895F);
            this.xrlblKillDate.Name = "xrlblKillDate";
            this.xrlblKillDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblKillDate.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblKillDate.StyleName = "xrControlStyleFields";
            // 
            // xrlblOrigin
            // 
            this.xrlblOrigin.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Udf2")});
            this.xrlblOrigin.Dpi = 254F;
            this.xrlblOrigin.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblOrigin.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 1079.104F);
            this.xrlblOrigin.Name = "xrlblOrigin";
            this.xrlblOrigin.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblOrigin.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblOrigin.StyleName = "xrControlStyleFields";
            // 
            // lblOrigin
            // 
            this.lblOrigin.Dpi = 254F;
            this.lblOrigin.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblOrigin.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1079.104F);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblOrigin.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblOrigin.StyleName = "xrControlStyleFields";
            this.lblOrigin.Text = "Origin:";
            // 
            // lblCut
            // 
            this.lblCut.Dpi = 254F;
            this.lblCut.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblCut.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1012.819F);
            this.lblCut.Name = "lblCut";
            this.lblCut.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCut.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblCut.StyleName = "xrControlStyleFields";
            this.lblCut.Text = "Cut in:";
            // 
            // xrlblCut
            // 
            this.xrlblCut.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Udf4")});
            this.xrlblCut.Dpi = 254F;
            this.xrlblCut.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblCut.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 1012.819F);
            this.xrlblCut.Name = "xrlblCut";
            this.xrlblCut.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblCut.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblCut.StyleName = "xrControlStyleFields";
            // 
            // xrlblSlaughtered
            // 
            this.xrlblSlaughtered.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Udf3")});
            this.xrlblSlaughtered.Dpi = 254F;
            this.xrlblSlaughtered.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblSlaughtered.LocationFloat = new DevExpress.Utils.PointFloat(157.4055F, 929.1734F);
            this.xrlblSlaughtered.Name = "xrlblSlaughtered";
            this.xrlblSlaughtered.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblSlaughtered.SizeF = new System.Drawing.SizeF(220.6995F, 58.42004F);
            this.xrlblSlaughtered.StyleName = "xrControlStyleFields";
            // 
            // lblSlaughtered
            // 
            this.lblSlaughtered.Dpi = 254F;
            this.lblSlaughtered.Font = new System.Drawing.Font("Georgia", 6.75F);
            this.lblSlaughtered.LocationFloat = new DevExpress.Utils.PointFloat(0F, 929.1734F);
            this.lblSlaughtered.Name = "lblSlaughtered";
            this.lblSlaughtered.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblSlaughtered.SizeF = new System.Drawing.SizeF(141.204F, 58.42004F);
            this.lblSlaughtered.StyleName = "xrControlStyleFields";
            this.lblSlaughtered.StylePriority.UseFont = false;
            this.lblSlaughtered.Text = "Slaughtered in:";
            // 
            // lblPalletId
            // 
            this.lblPalletId.Dpi = 254F;
            this.lblPalletId.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblPalletId.LocationFloat = new DevExpress.Utils.PointFloat(0F, 849.984F);
            this.lblPalletId.Name = "lblPalletId";
            this.lblPalletId.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblPalletId.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblPalletId.StyleName = "xrControlStyleFields";
            this.lblPalletId.Text = "Pallet ID:";
            // 
            // xrlblPalletId
            // 
            this.xrlblPalletId.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.PalletId")});
            this.xrlblPalletId.Dpi = 254F;
            this.xrlblPalletId.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblPalletId.LocationFloat = new DevExpress.Utils.PointFloat(159.3706F, 849.9839F);
            this.xrlblPalletId.Name = "xrlblPalletId";
            this.xrlblPalletId.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblPalletId.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblPalletId.StyleName = "xrControlStyleFields";
            // 
            // xrlblFinishProd
            // 
            this.xrlblFinishProd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.ProdDescription")});
            this.xrlblFinishProd.Dpi = 254F;
            this.xrlblFinishProd.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblFinishProd.LocationFloat = new DevExpress.Utils.PointFloat(157.4056F, 718.0173F);
            this.xrlblFinishProd.Name = "xrlblFinishProd";
            this.xrlblFinishProd.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblFinishProd.SizeF = new System.Drawing.SizeF(220.6994F, 100.7534F);
            this.xrlblFinishProd.StyleName = "xrControlStyleFields";
            // 
            // lblFinishProd
            // 
            this.lblFinishProd.Dpi = 254F;
            this.lblFinishProd.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblFinishProd.LocationFloat = new DevExpress.Utils.PointFloat(0F, 718.0173F);
            this.lblFinishProd.Name = "lblFinishProd";
            this.lblFinishProd.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblFinishProd.SizeF = new System.Drawing.SizeF(141.204F, 100.7534F);
            this.lblFinishProd.StyleName = "xrControlStyleFields";
            this.lblFinishProd.Text = "Finish Product:";
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.Dpi = 254F;
            this.lblRawMaterial.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblRawMaterial.LocationFloat = new DevExpress.Utils.PointFloat(0F, 614.0872F);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblRawMaterial.SizeF = new System.Drawing.SizeF(141.204F, 81.35059F);
            this.lblRawMaterial.StyleName = "xrControlStyleFields";
            this.lblRawMaterial.Text = "Raw material:";
            // 
            // xrlblRawMaterial
            // 
            this.xrlblRawMaterial.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.RawMaterialDescription")});
            this.xrlblRawMaterial.Dpi = 254F;
            this.xrlblRawMaterial.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblRawMaterial.LocationFloat = new DevExpress.Utils.PointFloat(157.4056F, 614.0872F);
            this.xrlblRawMaterial.Name = "xrlblRawMaterial";
            this.xrlblRawMaterial.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblRawMaterial.SizeF = new System.Drawing.SizeF(220.6994F, 81.35059F);
            this.xrlblRawMaterial.StyleName = "xrControlStyleFields";
            // 
            // xrlblCustomer
            // 
            this.xrlblCustomer.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Customer")});
            this.xrlblCustomer.Dpi = 254F;
            this.xrlblCustomer.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblCustomer.LocationFloat = new DevExpress.Utils.PointFloat(157.4056F, 558.1996F);
            this.xrlblCustomer.Name = "xrlblCustomer";
            this.xrlblCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblCustomer.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblCustomer.StyleName = "xrControlStyleFields";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Dpi = 254F;
            this.lblCustomer.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblCustomer.LocationFloat = new DevExpress.Utils.PointFloat(0F, 558.1997F);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCustomer.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblCustomer.StyleName = "xrControlStyleFields";
            this.lblCustomer.Text = "Customer:";
            // 
            // lblShift
            // 
            this.lblShift.Dpi = 254F;
            this.lblShift.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblShift.LocationFloat = new DevExpress.Utils.PointFloat(0F, 489.9651F);
            this.lblShift.Name = "lblShift";
            this.lblShift.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblShift.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblShift.StyleName = "xrControlStyleFields";
            this.lblShift.Text = "Shift:";
            // 
            // xrlblShift
            // 
            this.xrlblShift.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Shift")});
            this.xrlblShift.Dpi = 254F;
            this.xrlblShift.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrlblShift.LocationFloat = new DevExpress.Utils.PointFloat(157.4056F, 489.965F);
            this.xrlblShift.Name = "xrlblShift";
            this.xrlblShift.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrlblShift.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrlblShift.StyleName = "xrControlStyleFields";
            // 
            // xrLblProdDate
            // 
            this.xrLblProdDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.ProductionDate", "{0:dd/MM/yyyy}")});
            this.xrLblProdDate.Dpi = 254F;
            this.xrLblProdDate.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLblProdDate.LocationFloat = new DevExpress.Utils.PointFloat(157.4056F, 426.6581F);
            this.xrLblProdDate.Name = "xrLblProdDate";
            this.xrLblProdDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLblProdDate.SizeF = new System.Drawing.SizeF(220.6995F, 34.7468F);
            this.xrLblProdDate.StyleName = "xrControlStyleFields";
            this.xrLblProdDate.Text = "xrLblProdDate";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Lot")});
            this.xrBarCode1.Dpi = 254F;
            this.xrBarCode1.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(11.75929F, 293.8608F);
            this.xrBarCode1.Module = 5.08F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(368.3108F, 109.5682F);
            this.xrBarCode1.StylePriority.UseFont = false;
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Angle = 90F;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblPalletBatch.Color")});
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Georgia", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(132.7901F, 25.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(93.01573F, 245.4467F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "lblColor";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblProdDate
            // 
            this.lblProdDate.Dpi = 254F;
            this.lblProdDate.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblProdDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 426.6581F);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblProdDate.SizeF = new System.Drawing.SizeF(141.204F, 34.74677F);
            this.lblProdDate.StyleName = "xrControlStyleFields";
            this.lblProdDate.Text = "Date:";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 5F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 5F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PalletBatch";
            xmlFileConnectionParameters1.FileName = "C:\\Users\\krzysztof.matyja\\Dropbox\\Employee365 Projects\\Traceability\\PalletBatch.x" +
    "sd";
            this.sqlDataSource1.ConnectionParameters = xmlFileConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ProductionDate";
            table1.Name = "tblPalletBatch";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProdDescription";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "RawMaterialDescription";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Customer";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Shift";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Color";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Lot";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "PalletId";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Udf2";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Udf3";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Udf4";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "KillDate";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Batch";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Name = "tblPalletBatch";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrControlStyleFields
            // 
            this.xrControlStyleFields.Font = new System.Drawing.Font("Georgia", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrControlStyleFields.Name = "xrControlStyleFields";
            this.xrControlStyleFields.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Signature
            // 
            this.Signature.DataMember = "tblPalletBatch";
            this.Signature.Expression = "DateDiffDay([KillDate], Now())";
            this.Signature.Name = "Signature";
            // 
            // ButcherLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Signature});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "tblPalletBatch";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(3, 3, 5, 5);
            this.PageHeight = 1400;
            this.PageWidth = 390;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyleFields});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLblProdDate;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyleFields;
        private DevExpress.XtraReports.UI.XRLabel lblProdDate;
        private DevExpress.XtraReports.UI.XRLabel lblShift;
        private DevExpress.XtraReports.UI.XRLabel xrlblShift;
        private DevExpress.XtraReports.UI.XRLabel xrlblOrigin;
        private DevExpress.XtraReports.UI.XRLabel lblOrigin;
        private DevExpress.XtraReports.UI.XRLabel lblCut;
        private DevExpress.XtraReports.UI.XRLabel xrlblCut;
        private DevExpress.XtraReports.UI.XRLabel xrlblSlaughtered;
        private DevExpress.XtraReports.UI.XRLabel lblSlaughtered;
        private DevExpress.XtraReports.UI.XRLabel lblPalletId;
        private DevExpress.XtraReports.UI.XRLabel xrlblPalletId;
        private DevExpress.XtraReports.UI.XRLabel xrlblFinishProd;
        private DevExpress.XtraReports.UI.XRLabel lblFinishProd;
        private DevExpress.XtraReports.UI.XRLabel lblRawMaterial;
        private DevExpress.XtraReports.UI.XRLabel xrlblRawMaterial;
        private DevExpress.XtraReports.UI.XRLabel xrlblCustomer;
        private DevExpress.XtraReports.UI.XRLabel lblCustomer;
        private DevExpress.XtraReports.UI.XRLabel xrlblLot;
        private DevExpress.XtraReports.UI.XRLabel lblLot;
        private DevExpress.XtraReports.UI.XRLabel lblKillDate;
        private DevExpress.XtraReports.UI.XRLabel xrlblKillDate;
        private DevExpress.XtraReports.UI.XRLabel lblBatch;
        private DevExpress.XtraReports.UI.XRLabel xrlblBatch;
        private DevExpress.XtraReports.UI.CalculatedField Signature;
        private DevExpress.XtraReports.UI.XRLabel lblSignature;
        private DevExpress.XtraReports.UI.XRLabel xrlblSignature;
    }
}
