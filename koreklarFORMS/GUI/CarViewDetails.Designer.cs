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
            PanelSelectPlan = new FlowLayoutPanel();
            btn1Month = new RadioButton();
            btn3Months = new RadioButton();
            btn6Months = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCarDetails = new Label();
            picCar = new PictureBox();
            lblCarDescription = new Label();
            lblCarInfoLeft = new Label();
            lblCarInfoRight = new Label();
            lblCarDescriptionDisplay = new Label();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            PanelSelectPlan.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
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
            layoutMain.Controls.Add(PanelSelectPlan, 1, 2);
            layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(20);
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(899, 677);
            layoutMain.TabIndex = 3;
            // 
            // lblSelectPlan
            // 
            lblSelectPlan.AutoSize = true;
            lblSelectPlan.Dock = DockStyle.Bottom;
            lblSelectPlan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectPlan.Location = new Point(538, 61);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new Size(338, 25);
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
            panelTopBar.Location = new Point(23, 23);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(853, 35);
            panelTopBar.TabIndex = 6;
            // 
            // layoutTopBar
            // 
            layoutTopBar.AutoSize = true;
            layoutTopBar.ColumnCount = 2;
            layoutTopBar.ColumnStyles.Add(new ColumnStyle());
            layoutTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTopBar.Controls.Add(topBarFlowButtons, 1, 0);
            layoutTopBar.Controls.Add(btnBack, 0, 0);
            layoutTopBar.Dock = DockStyle.Fill;
            layoutTopBar.Location = new Point(0, 0);
            layoutTopBar.Name = "layoutTopBar";
            layoutTopBar.RowCount = 1;
            layoutTopBar.RowStyles.Add(new RowStyle());
            layoutTopBar.Size = new Size(851, 33);
            layoutTopBar.TabIndex = 5;
            // 
            // topBarFlowButtons
            // 
            topBarFlowButtons.AutoSize = true;
            topBarFlowButtons.Controls.Add(btnLogin);
            topBarFlowButtons.Controls.Add(btnBiler);
            topBarFlowButtons.Controls.Add(btnContact);
            topBarFlowButtons.Dock = DockStyle.Fill;
            topBarFlowButtons.FlowDirection = FlowDirection.RightToLeft;
            topBarFlowButtons.Location = new Point(39, 3);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(809, 36);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(731, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(650, 3);
            btnBiler.Name = "btnBiler";
            btnBiler.Size = new Size(75, 30);
            btnBiler.TabIndex = 1;
            btnBiler.Text = "Biler";
            btnBiler.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 12F);
            btnContact.Location = new Point(569, 3);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(75, 30);
            btnContact.TabIndex = 3;
            btnContact.Text = "Kontakt";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 27);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Dock = DockStyle.Top;
            btnSubscribe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscribe.Location = new Point(537, 243);
            btnSubscribe.Margin = new Padding(2);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(340, 40);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Opret Abonnement";
            btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Dock = DockStyle.Bottom;
            lblCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(23, 61);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(509, 25);
            lblCarName.TabIndex = 6;
            lblCarName.Text = "Bil navn";
            lblCarName.TextAlign = ContentAlignment.BottomLeft;
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
            PanelSelectPlan.Location = new Point(538, 89);
            PanelSelectPlan.Name = "PanelSelectPlan";
            PanelSelectPlan.Size = new Size(338, 149);
            PanelSelectPlan.TabIndex = 9;
            // 
            // btn1Month
            // 
            btn1Month.AutoSize = true;
            btn1Month.Font = new Font("Segoe UI", 12F);
            btn1Month.Location = new Point(14, 12);
            btn1Month.Margin = new Padding(14, 12, 14, 12);
            btn1Month.Name = "btn1Month";
            btn1Month.Size = new Size(148, 25);
            btn1Month.TabIndex = 0;
            btn1Month.TabStop = true;
            btn1Month.Text = "1 måned / 200 kr";
            btn1Month.UseVisualStyleBackColor = true;
            // 
            // btn3Months
            // 
            btn3Months.AutoSize = true;
            btn3Months.Font = new Font("Segoe UI", 12F);
            btn3Months.Location = new Point(14, 61);
            btn3Months.Margin = new Padding(14, 12, 14, 12);
            btn3Months.Name = "btn3Months";
            btn3Months.Size = new Size(162, 25);
            btn3Months.TabIndex = 1;
            btn3Months.TabStop = true;
            btn3Months.Text = "3 måneder / 500 kr";
            btn3Months.UseVisualStyleBackColor = true;
            // 
            // btn6Months
            // 
            btn6Months.AutoSize = true;
            btn6Months.Font = new Font("Segoe UI", 12F);
            btn6Months.Location = new Point(14, 110);
            btn6Months.Margin = new Padding(14, 12, 14, 12);
            btn6Months.Name = "btn6Months";
            btn6Months.Size = new Size(162, 25);
            btn6Months.TabIndex = 2;
            btn6Months.TabStop = true;
            btn6Months.Text = "6 måneder / 800 kr";
            btn6Months.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblCarDetails, 0, 1);
            tableLayoutPanel1.Controls.Add(picCar, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCarDescription, 0, 4);
            tableLayoutPanel1.Controls.Add(lblCarInfoLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(lblCarInfoRight, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCarDescriptionDisplay, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            layoutMain.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(509, 665);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblCarDetails
            // 
            lblCarDetails.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCarDetails, 2);
            lblCarDetails.Dock = DockStyle.Bottom;
            lblCarDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCarDetails.Location = new Point(3, 210);
            lblCarDetails.Margin = new Padding(3, 10, 3, 0);
            lblCarDetails.Name = "lblCarDetails";
            lblCarDetails.Size = new Size(503, 21);
            lblCarDetails.TabIndex = 7;
            lblCarDetails.Text = "Detaljer";
            lblCarDetails.TextAlign = ContentAlignment.BottomLeft;
            // 
            // picCar
            // 
            tableLayoutPanel1.SetColumnSpan(picCar, 3);
            picCar.Dock = DockStyle.Fill;
            picCar.Location = new Point(3, 3);
            picCar.Name = "picCar";
            picCar.Size = new Size(503, 194);
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // lblCarDescription
            // 
            lblCarDescription.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCarDescription, 2);
            lblCarDescription.Dock = DockStyle.Fill;
            lblCarDescription.Font = new Font("Segoe UI", 12F);
            lblCarDescription.Location = new Point(8, 412);
            lblCarDescription.Margin = new Padding(8);
            lblCarDescription.Name = "lblCarDescription";
            lblCarDescription.Size = new Size(493, 63);
            lblCarDescription.TabIndex = 3;
            lblCarDescription.Text = "CarDescription\r\nCarDescription\r\nCarDescription";
            lblCarDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoLeft
            // 
            lblCarInfoLeft.AutoSize = true;
            lblCarInfoLeft.Dock = DockStyle.Fill;
            lblCarInfoLeft.Font = new Font("Segoe UI", 12F);
            lblCarInfoLeft.Location = new Point(8, 239);
            lblCarInfoLeft.Margin = new Padding(8, 8, 50, 8);
            lblCarInfoLeft.Name = "lblCarInfoLeft";
            lblCarInfoLeft.Size = new Size(196, 126);
            lblCarInfoLeft.TabIndex = 1;
            lblCarInfoLeft.Text = "CarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft";
            lblCarInfoLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoRight
            // 
            lblCarInfoRight.AutoSize = true;
            lblCarInfoRight.Dock = DockStyle.Fill;
            lblCarInfoRight.Font = new Font("Segoe UI", 12F);
            lblCarInfoRight.Location = new Point(262, 239);
            lblCarInfoRight.Margin = new Padding(8);
            lblCarInfoRight.Name = "lblCarInfoRight";
            lblCarInfoRight.Size = new Size(239, 126);
            lblCarInfoRight.TabIndex = 2;
            lblCarInfoRight.Text = "CarInformationRight\r\nCarInformationRight\r\nCarInformationRight\r\nCarInformationRight\r\nCarInformationRight\r\nCarInformationRight";
            lblCarInfoRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarDescriptionDisplay
            // 
            lblCarDescriptionDisplay.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCarDescriptionDisplay, 2);
            lblCarDescriptionDisplay.Dock = DockStyle.Bottom;
            lblCarDescriptionDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCarDescriptionDisplay.Location = new Point(3, 383);
            lblCarDescriptionDisplay.Margin = new Padding(3, 10, 3, 0);
            lblCarDescriptionDisplay.Name = "lblCarDescriptionDisplay";
            lblCarDescriptionDisplay.Size = new Size(503, 21);
            lblCarDescriptionDisplay.TabIndex = 8;
            lblCarDescriptionDisplay.Text = "Beskrivelse";
            lblCarDescriptionDisplay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // CarViewDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 677);
            Controls.Add(layoutMain);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 600);
            Name = "CarViewDetails";
            Text = "Køreklar";
            Load += CarViewDetails_Load;
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            layoutTopBar.ResumeLayout(false);
            layoutTopBar.PerformLayout();
            topBarFlowButtons.ResumeLayout(false);
            PanelSelectPlan.ResumeLayout(false);
            PanelSelectPlan.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
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
        private FlowLayoutPanel PanelSelectPlan;
        private Label lblSelectPlan;
        private RadioButton btn1Month;
        private RadioButton btn3Months;
        private RadioButton btn6Months;
        private Button btnSubscribe;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picCar;
        private Label lblCarDescription;
        private Label lblCarInfoLeft;
        private Label lblCarInfoRight;
        private Label lblCarDetails;
        private Label lblCarDescriptionDisplay;
    }
}