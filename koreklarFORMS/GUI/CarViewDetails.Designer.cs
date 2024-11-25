namespace koreklarFORMS.GUI
{
    partial class CarViewDetails
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
            layoutMain = new TableLayoutPanel();
            lblSelectPlan = new Label();
            panelTopBar = new Panel();
            layoutTopBar = new TableLayoutPanel();
            topBarFlowButtons = new FlowLayoutPanel();
            btnLogin = new Button();
            btnBiler = new Button();
            btnContact = new Button();
            btnBack = new Button();
            btnSubscribe = new Button();
            lblCarName = new Label();
            PanelCarDetails = new FlowLayoutPanel();
            picCar = new PictureBox();
            panelTableCarDetails = new TableLayoutPanel();
            lblKmDisplay = new Label();
            lblColorDisplay = new Label();
            lblTopSpeedDisplay = new Label();
            lblFuelTypeDisplay = new Label();
            lbl1InfoDisplay = new Label();
            lbl2InfoDisplay = new Label();
            lbl3InfoDisplay = new Label();
            lbl4InfoDisplay = new Label();
            lbl1InfoData = new Label();
            lbl2InfoData = new Label();
            lbl3InfoData = new Label();
            lbl4InfoData = new Label();
            lblKmData = new Label();
            lblColorData = new Label();
            lblTopSpeedData = new Label();
            lblFuelTypeData = new Label();
            PanelSelectPlan = new FlowLayoutPanel();
            btn1Month = new RadioButton();
            btn3Months = new RadioButton();
            btn6Months = new RadioButton();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            PanelCarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            panelTableCarDetails.SuspendLayout();
            PanelSelectPlan.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            layoutMain.Controls.Add(lblSelectPlan, 1, 1);
            layoutMain.Controls.Add(panelTopBar, 0, 0);
            layoutMain.Controls.Add(btnSubscribe, 1, 3);
            layoutMain.Controls.Add(lblCarName, 0, 1);
            layoutMain.Controls.Add(PanelCarDetails, 0, 2);
            layoutMain.Controls.Add(PanelSelectPlan, 1, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 5, 4, 5);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(29, 33, 29, 33);
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(1104, 765);
            layoutMain.TabIndex = 3;
            // 
            // lblSelectPlan
            // 
            lblSelectPlan.AutoSize = true;
            lblSelectPlan.Dock = DockStyle.Bottom;
            lblSelectPlan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectPlan.Location = new Point(660, 100);
            lblSelectPlan.Margin = new Padding(4, 0, 4, 0);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new Size(411, 40);
            lblSelectPlan.TabIndex = 10;
            lblSelectPlan.Text = "Vælg abonnement";
            lblSelectPlan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelTopBar
            // 
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(panelTopBar, 2);
            panelTopBar.Controls.Add(layoutTopBar);
            panelTopBar.Dock = DockStyle.Fill;
            panelTopBar.Location = new Point(33, 38);
            panelTopBar.Margin = new Padding(4, 5, 4, 5);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1038, 57);
            panelTopBar.TabIndex = 6;
            // 
            // layoutTopBar
            // 
            layoutTopBar.ColumnCount = 2;
            layoutTopBar.ColumnStyles.Add(new ColumnStyle());
            layoutTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTopBar.Controls.Add(topBarFlowButtons, 1, 0);
            layoutTopBar.Controls.Add(btnBack, 0, 0);
            layoutTopBar.Dock = DockStyle.Fill;
            layoutTopBar.Location = new Point(0, 0);
            layoutTopBar.Margin = new Padding(4, 5, 4, 5);
            layoutTopBar.Name = "layoutTopBar";
            layoutTopBar.RowCount = 1;
            layoutTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTopBar.Size = new Size(1036, 55);
            layoutTopBar.TabIndex = 5;
            // 
            // topBarFlowButtons
            // 
            topBarFlowButtons.Controls.Add(btnLogin);
            topBarFlowButtons.Controls.Add(btnBiler);
            topBarFlowButtons.Controls.Add(btnContact);
            topBarFlowButtons.Dock = DockStyle.Fill;
            topBarFlowButtons.FlowDirection = FlowDirection.RightToLeft;
            topBarFlowButtons.Location = new Point(55, 5);
            topBarFlowButtons.Margin = new Padding(4, 5, 4, 5);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(977, 45);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(866, 5);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(751, 5);
            btnBiler.Margin = new Padding(4, 5, 4, 5);
            btnBiler.Name = "btnBiler";
            btnBiler.Size = new Size(107, 50);
            btnBiler.TabIndex = 1;
            btnBiler.Text = "Biler";
            btnBiler.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 12F);
            btnContact.Location = new Point(636, 5);
            btnContact.Margin = new Padding(4, 5, 4, 5);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(107, 50);
            btnContact.TabIndex = 3;
            btnContact.Text = "Kontakt";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(4, 5);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(43, 45);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Dock = DockStyle.Top;
            btnSubscribe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscribe.Location = new Point(659, 383);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(413, 66);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Opret Abonnement";
            btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Dock = DockStyle.Bottom;
            lblCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(33, 100);
            lblCarName.Margin = new Padding(4, 0, 4, 0);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(619, 40);
            lblCarName.TabIndex = 6;
            lblCarName.Text = "Bil navn";
            lblCarName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PanelCarDetails
            // 
            PanelCarDetails.AutoSize = true;
            PanelCarDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelCarDetails.Controls.Add(picCar);
            PanelCarDetails.Controls.Add(panelTableCarDetails);
            PanelCarDetails.Dock = DockStyle.Fill;
            PanelCarDetails.Location = new Point(33, 145);
            PanelCarDetails.Margin = new Padding(4, 5, 4, 5);
            PanelCarDetails.Name = "PanelCarDetails";
            layoutMain.SetRowSpan(PanelCarDetails, 2);
            PanelCarDetails.Size = new Size(619, 582);
            PanelCarDetails.TabIndex = 8;
            // 
            // picCar
            // 
            picCar.Dock = DockStyle.Top;
            picCar.Location = new Point(3, 3);
            picCar.Name = "picCar";
            picCar.Size = new Size(400, 164);
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // panelTableCarDetails
            // 
            panelTableCarDetails.ColumnCount = 4;
            panelTableCarDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTableCarDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTableCarDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTableCarDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTableCarDetails.Controls.Add(lblKmDisplay, 0, 0);
            panelTableCarDetails.Controls.Add(lblColorDisplay, 0, 1);
            panelTableCarDetails.Controls.Add(lblTopSpeedDisplay, 0, 2);
            panelTableCarDetails.Controls.Add(lblFuelTypeDisplay, 0, 3);
            panelTableCarDetails.Controls.Add(lbl1InfoDisplay, 2, 0);
            panelTableCarDetails.Controls.Add(lbl2InfoDisplay, 2, 1);
            panelTableCarDetails.Controls.Add(lbl3InfoDisplay, 2, 2);
            panelTableCarDetails.Controls.Add(lbl4InfoDisplay, 2, 3);
            panelTableCarDetails.Controls.Add(lbl1InfoData, 3, 0);
            panelTableCarDetails.Controls.Add(lbl2InfoData, 3, 1);
            panelTableCarDetails.Controls.Add(lbl3InfoData, 3, 2);
            panelTableCarDetails.Controls.Add(lbl4InfoData, 3, 3);
            panelTableCarDetails.Controls.Add(lblKmData, 1, 0);
            panelTableCarDetails.Controls.Add(lblColorData, 1, 1);
            panelTableCarDetails.Controls.Add(lblTopSpeedData, 1, 2);
            panelTableCarDetails.Controls.Add(lblFuelTypeData, 1, 3);
            panelTableCarDetails.Location = new Point(3, 173);
            panelTableCarDetails.Name = "panelTableCarDetails";
            panelTableCarDetails.RowCount = 4;
            panelTableCarDetails.RowStyles.Add(new RowStyle());
            panelTableCarDetails.RowStyles.Add(new RowStyle());
            panelTableCarDetails.RowStyles.Add(new RowStyle());
            panelTableCarDetails.RowStyles.Add(new RowStyle());
            panelTableCarDetails.Size = new Size(506, 284);
            panelTableCarDetails.TabIndex = 1;
            // 
            // lblKmDisplay
            // 
            lblKmDisplay.AutoSize = true;
            lblKmDisplay.Dock = DockStyle.Top;
            lblKmDisplay.ImageAlign = ContentAlignment.TopCenter;
            lblKmDisplay.Location = new Point(0, 5);
            lblKmDisplay.Margin = new Padding(0, 5, 0, 5);
            lblKmDisplay.Name = "lblKmDisplay";
            lblKmDisplay.Padding = new Padding(0, 5, 0, 5);
            lblKmDisplay.Size = new Size(126, 35);
            lblKmDisplay.TabIndex = 0;
            lblKmDisplay.Text = "Kilometer:";
            lblKmDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lblColorDisplay
            // 
            lblColorDisplay.AutoSize = true;
            lblColorDisplay.Dock = DockStyle.Top;
            lblColorDisplay.ImageAlign = ContentAlignment.TopCenter;
            lblColorDisplay.Location = new Point(0, 50);
            lblColorDisplay.Margin = new Padding(0, 5, 0, 5);
            lblColorDisplay.Name = "lblColorDisplay";
            lblColorDisplay.Padding = new Padding(0, 5, 0, 5);
            lblColorDisplay.Size = new Size(126, 35);
            lblColorDisplay.TabIndex = 1;
            lblColorDisplay.Text = "Farve:";
            lblColorDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTopSpeedDisplay
            // 
            lblTopSpeedDisplay.AutoSize = true;
            lblTopSpeedDisplay.Dock = DockStyle.Top;
            lblTopSpeedDisplay.ImageAlign = ContentAlignment.TopCenter;
            lblTopSpeedDisplay.Location = new Point(0, 95);
            lblTopSpeedDisplay.Margin = new Padding(0, 5, 0, 5);
            lblTopSpeedDisplay.Name = "lblTopSpeedDisplay";
            lblTopSpeedDisplay.Padding = new Padding(0, 5, 0, 5);
            lblTopSpeedDisplay.Size = new Size(126, 35);
            lblTopSpeedDisplay.TabIndex = 2;
            lblTopSpeedDisplay.Text = "Top fart:";
            lblTopSpeedDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lblFuelTypeDisplay
            // 
            lblFuelTypeDisplay.AutoSize = true;
            lblFuelTypeDisplay.Dock = DockStyle.Top;
            lblFuelTypeDisplay.ImageAlign = ContentAlignment.TopCenter;
            lblFuelTypeDisplay.Location = new Point(0, 140);
            lblFuelTypeDisplay.Margin = new Padding(0, 5, 0, 5);
            lblFuelTypeDisplay.Name = "lblFuelTypeDisplay";
            lblFuelTypeDisplay.Padding = new Padding(0, 5, 0, 5);
            lblFuelTypeDisplay.Size = new Size(126, 35);
            lblFuelTypeDisplay.TabIndex = 3;
            lblFuelTypeDisplay.Text = "Brændstof:";
            lblFuelTypeDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl1InfoDisplay
            // 
            lbl1InfoDisplay.AutoSize = true;
            lbl1InfoDisplay.Dock = DockStyle.Top;
            lbl1InfoDisplay.ImageAlign = ContentAlignment.TopCenter;
            lbl1InfoDisplay.Location = new Point(252, 5);
            lbl1InfoDisplay.Margin = new Padding(0, 5, 0, 5);
            lbl1InfoDisplay.Name = "lbl1InfoDisplay";
            lbl1InfoDisplay.Padding = new Padding(0, 5, 0, 5);
            lbl1InfoDisplay.Size = new Size(126, 35);
            lbl1InfoDisplay.TabIndex = 4;
            lbl1InfoDisplay.Text = "Info 1:";
            lbl1InfoDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl2InfoDisplay
            // 
            lbl2InfoDisplay.AutoSize = true;
            lbl2InfoDisplay.Dock = DockStyle.Top;
            lbl2InfoDisplay.ImageAlign = ContentAlignment.TopCenter;
            lbl2InfoDisplay.Location = new Point(252, 50);
            lbl2InfoDisplay.Margin = new Padding(0, 5, 0, 5);
            lbl2InfoDisplay.Name = "lbl2InfoDisplay";
            lbl2InfoDisplay.Padding = new Padding(0, 5, 0, 5);
            lbl2InfoDisplay.Size = new Size(126, 35);
            lbl2InfoDisplay.TabIndex = 5;
            lbl2InfoDisplay.Text = "Info 2:";
            lbl2InfoDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl3InfoDisplay
            // 
            lbl3InfoDisplay.AutoSize = true;
            lbl3InfoDisplay.Dock = DockStyle.Top;
            lbl3InfoDisplay.ImageAlign = ContentAlignment.TopCenter;
            lbl3InfoDisplay.Location = new Point(252, 95);
            lbl3InfoDisplay.Margin = new Padding(0, 5, 0, 5);
            lbl3InfoDisplay.Name = "lbl3InfoDisplay";
            lbl3InfoDisplay.Padding = new Padding(0, 5, 0, 5);
            lbl3InfoDisplay.Size = new Size(126, 35);
            lbl3InfoDisplay.TabIndex = 6;
            lbl3InfoDisplay.Text = "Info 3:";
            lbl3InfoDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl4InfoDisplay
            // 
            lbl4InfoDisplay.AutoSize = true;
            lbl4InfoDisplay.Dock = DockStyle.Top;
            lbl4InfoDisplay.ImageAlign = ContentAlignment.TopCenter;
            lbl4InfoDisplay.Location = new Point(252, 140);
            lbl4InfoDisplay.Margin = new Padding(0, 5, 0, 5);
            lbl4InfoDisplay.Name = "lbl4InfoDisplay";
            lbl4InfoDisplay.Padding = new Padding(0, 5, 0, 5);
            lbl4InfoDisplay.Size = new Size(126, 35);
            lbl4InfoDisplay.TabIndex = 7;
            lbl4InfoDisplay.Text = "Info 4:";
            lbl4InfoDisplay.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl1InfoData
            // 
            lbl1InfoData.AutoSize = true;
            lbl1InfoData.Dock = DockStyle.Top;
            lbl1InfoData.ImageAlign = ContentAlignment.TopCenter;
            lbl1InfoData.Location = new Point(378, 5);
            lbl1InfoData.Margin = new Padding(0, 5, 0, 5);
            lbl1InfoData.Name = "lbl1InfoData";
            lbl1InfoData.Padding = new Padding(0, 5, 0, 5);
            lbl1InfoData.Size = new Size(128, 35);
            lbl1InfoData.TabIndex = 8;
            lbl1InfoData.Text = "xxx";
            // 
            // lbl2InfoData
            // 
            lbl2InfoData.AutoSize = true;
            lbl2InfoData.Dock = DockStyle.Top;
            lbl2InfoData.ImageAlign = ContentAlignment.TopCenter;
            lbl2InfoData.Location = new Point(378, 50);
            lbl2InfoData.Margin = new Padding(0, 5, 0, 5);
            lbl2InfoData.Name = "lbl2InfoData";
            lbl2InfoData.Padding = new Padding(0, 5, 0, 5);
            lbl2InfoData.Size = new Size(128, 35);
            lbl2InfoData.TabIndex = 9;
            lbl2InfoData.Text = "xxx";
            // 
            // lbl3InfoData
            // 
            lbl3InfoData.AutoSize = true;
            lbl3InfoData.Dock = DockStyle.Top;
            lbl3InfoData.ImageAlign = ContentAlignment.TopCenter;
            lbl3InfoData.Location = new Point(378, 95);
            lbl3InfoData.Margin = new Padding(0, 5, 0, 5);
            lbl3InfoData.Name = "lbl3InfoData";
            lbl3InfoData.Padding = new Padding(0, 5, 0, 5);
            lbl3InfoData.Size = new Size(128, 35);
            lbl3InfoData.TabIndex = 10;
            lbl3InfoData.Text = "xxx";
            // 
            // lbl4InfoData
            // 
            lbl4InfoData.AutoSize = true;
            lbl4InfoData.Dock = DockStyle.Top;
            lbl4InfoData.ImageAlign = ContentAlignment.TopCenter;
            lbl4InfoData.Location = new Point(378, 140);
            lbl4InfoData.Margin = new Padding(0, 5, 0, 5);
            lbl4InfoData.Name = "lbl4InfoData";
            lbl4InfoData.Padding = new Padding(0, 5, 0, 5);
            lbl4InfoData.Size = new Size(128, 35);
            lbl4InfoData.TabIndex = 11;
            lbl4InfoData.Text = "xxx";
            // 
            // lblKmData
            // 
            lblKmData.AutoSize = true;
            lblKmData.Dock = DockStyle.Top;
            lblKmData.ImageAlign = ContentAlignment.TopCenter;
            lblKmData.Location = new Point(126, 5);
            lblKmData.Margin = new Padding(0, 5, 0, 5);
            lblKmData.Name = "lblKmData";
            lblKmData.Padding = new Padding(0, 5, 0, 5);
            lblKmData.Size = new Size(126, 35);
            lblKmData.TabIndex = 12;
            lblKmData.Text = "xxx";
            // 
            // lblColorData
            // 
            lblColorData.AutoSize = true;
            lblColorData.Dock = DockStyle.Top;
            lblColorData.ImageAlign = ContentAlignment.TopCenter;
            lblColorData.Location = new Point(126, 50);
            lblColorData.Margin = new Padding(0, 5, 0, 5);
            lblColorData.Name = "lblColorData";
            lblColorData.Padding = new Padding(0, 5, 0, 5);
            lblColorData.Size = new Size(126, 35);
            lblColorData.TabIndex = 13;
            lblColorData.Text = "xxx";
            // 
            // lblTopSpeedData
            // 
            lblTopSpeedData.AutoSize = true;
            lblTopSpeedData.Dock = DockStyle.Top;
            lblTopSpeedData.ImageAlign = ContentAlignment.TopCenter;
            lblTopSpeedData.Location = new Point(126, 95);
            lblTopSpeedData.Margin = new Padding(0, 5, 0, 5);
            lblTopSpeedData.Name = "lblTopSpeedData";
            lblTopSpeedData.Padding = new Padding(0, 5, 0, 5);
            lblTopSpeedData.Size = new Size(126, 35);
            lblTopSpeedData.TabIndex = 14;
            lblTopSpeedData.Text = "xxx";
            // 
            // lblFuelTypeData
            // 
            lblFuelTypeData.AutoSize = true;
            lblFuelTypeData.Dock = DockStyle.Top;
            lblFuelTypeData.ImageAlign = ContentAlignment.TopCenter;
            lblFuelTypeData.Location = new Point(126, 140);
            lblFuelTypeData.Margin = new Padding(0, 5, 0, 5);
            lblFuelTypeData.Name = "lblFuelTypeData";
            lblFuelTypeData.Padding = new Padding(0, 5, 0, 5);
            lblFuelTypeData.Size = new Size(126, 35);
            lblFuelTypeData.TabIndex = 15;
            lblFuelTypeData.Text = "xxx";
            // 
            // PanelSelectPlan
            // 
            PanelSelectPlan.AutoSize = true;
            PanelSelectPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSelectPlan.BorderStyle = BorderStyle.FixedSingle;
            PanelSelectPlan.Controls.Add(btn1Month);
            PanelSelectPlan.Controls.Add(btn3Months);
            PanelSelectPlan.Controls.Add(btn6Months);
            PanelSelectPlan.Dock = DockStyle.Fill;
            PanelSelectPlan.FlowDirection = FlowDirection.TopDown;
            PanelSelectPlan.Location = new Point(660, 145);
            PanelSelectPlan.Margin = new Padding(4, 5, 4, 5);
            PanelSelectPlan.Name = "PanelSelectPlan";
            PanelSelectPlan.Size = new Size(411, 230);
            PanelSelectPlan.TabIndex = 9;
            // 
            // btn1Month
            // 
            btn1Month.AutoSize = true;
            btn1Month.Font = new Font("Segoe UI", 12F);
            btn1Month.Location = new Point(20, 20);
            btn1Month.Margin = new Padding(20);
            btn1Month.Name = "btn1Month";
            btn1Month.Size = new Size(222, 36);
            btn1Month.TabIndex = 0;
            btn1Month.TabStop = true;
            btn1Month.Text = "1 måned / 200 kr";
            btn1Month.UseVisualStyleBackColor = true;
            // 
            // btn3Months
            // 
            btn3Months.AutoSize = true;
            btn3Months.Font = new Font("Segoe UI", 12F);
            btn3Months.Location = new Point(20, 96);
            btn3Months.Margin = new Padding(20);
            btn3Months.Name = "btn3Months";
            btn3Months.Size = new Size(243, 36);
            btn3Months.TabIndex = 1;
            btn3Months.TabStop = true;
            btn3Months.Text = "3 måneder / 500 kr";
            btn3Months.UseVisualStyleBackColor = true;
            // 
            // btn6Months
            // 
            btn6Months.AutoSize = true;
            btn6Months.Font = new Font("Segoe UI", 12F);
            btn6Months.Location = new Point(20, 172);
            btn6Months.Margin = new Padding(20);
            btn6Months.Name = "btn6Months";
            btn6Months.Size = new Size(243, 36);
            btn6Months.TabIndex = 2;
            btn6Months.TabStop = true;
            btn6Months.Text = "6 måneder / 800 kr";
            btn6Months.UseVisualStyleBackColor = true;
            // 
            // CarViewDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 765);
            Controls.Add(layoutMain);
            Name = "CarViewDetails";
            Text = "CarViewDetails";
            Load += CarViewDetails_Load;
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            layoutTopBar.ResumeLayout(false);
            topBarFlowButtons.ResumeLayout(false);
            PanelCarDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            panelTableCarDetails.ResumeLayout(false);
            panelTableCarDetails.PerformLayout();
            PanelSelectPlan.ResumeLayout(false);
            PanelSelectPlan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutMain;
        private Panel panelTopBar;
        private TableLayoutPanel layoutTopBar;
        private FlowLayoutPanel topBarFlowButtons;
        private Button btnLogin;
        private Button btnBiler;
        private Button btnContact;
        private Button btnBack;
        private Label lblCarName;
        private FlowLayoutPanel PanelCarDetails;
        private FlowLayoutPanel PanelSelectPlan;
        private Label lblSelectPlan;
        private PictureBox picCar;
        private TableLayoutPanel panelTableCarDetails;
        private Label lblKmDisplay;
        private Label lblColorDisplay;
        private Label lblTopSpeedDisplay;
        private Label lblFuelTypeDisplay;
        private Label lbl1InfoDisplay;
        private Label lbl2InfoDisplay;
        private Label lbl3InfoDisplay;
        private Label lbl4InfoDisplay;
        private Label lbl1InfoData;
        private Label lbl2InfoData;
        private Label lbl3InfoData;
        private Label lbl4InfoData;
        private Label lblKmData;
        private Label lblColorData;
        private Label lblTopSpeedData;
        private Label lblFuelTypeData;
        private RadioButton btn1Month;
        private RadioButton btn3Months;
        private RadioButton btn6Months;
        private Button btnSubscribe;
    }
}