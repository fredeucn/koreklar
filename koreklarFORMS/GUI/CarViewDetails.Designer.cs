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
            lblPriceText = new Label();
            lblSelectPlan = new Label();
            btnSubscribe = new Button();
            panelTopBar = new Panel();
            layoutTopBar = new TableLayoutPanel();
            topBarFlowButtons = new FlowLayoutPanel();
            btnProfile = new Button();
            btnBiler = new Button();
            btnContact = new Button();
            btnBack = new Button();
            lblCarName = new Label();
            PanelSelectPlan = new FlowLayoutPanel();
            btnSubscription1 = new RadioButton();
            btnSubscription2 = new RadioButton();
            btnSubscription3 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCarDetails = new Label();
            picCar = new PictureBox();
            lblCarDescription = new Label();
            lblCarInfoLeft = new Label();
            lblCarInfoRight = new Label();
            lblCarDescriptionDisplay = new Label();
            lblPriceNumber = new Label();
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
            layoutMain.ColumnCount = 3;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMain.Controls.Add(lblPriceText, 1, 3);
            layoutMain.Controls.Add(lblSelectPlan, 1, 1);
            layoutMain.Controls.Add(btnSubscribe, 1, 4);
            layoutMain.Controls.Add(panelTopBar, 0, 0);
            layoutMain.Controls.Add(lblCarName, 0, 1);
            layoutMain.Controls.Add(PanelSelectPlan, 1, 2);
            layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
            layoutMain.Controls.Add(lblPriceNumber, 2, 3);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(20);
            layoutMain.RowCount = 5;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(784, 661);
            layoutMain.TabIndex = 3;
            // 
            // lblPriceText
            // 
            lblPriceText.AutoSize = true;
            lblPriceText.BorderStyle = BorderStyle.FixedSingle;
            lblPriceText.Dock = DockStyle.Fill;
            lblPriceText.Font = new Font("Segoe UI", 12F);
            lblPriceText.Location = new Point(469, 278);
            lblPriceText.Margin = new Padding(3);
            lblPriceText.Name = "lblPriceText";
            lblPriceText.Size = new Size(142, 65);
            lblPriceText.TabIndex = 5;
            lblPriceText.Text = "PriceDescription\r\nPriceDescription\r\nPriceDescription";
            lblPriceText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectPlan
            // 
            lblSelectPlan.AutoSize = true;
            layoutMain.SetColumnSpan(lblSelectPlan, 2);
            lblSelectPlan.Dock = DockStyle.Bottom;
            lblSelectPlan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectPlan.Location = new Point(469, 95);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new Size(292, 25);
            lblSelectPlan.TabIndex = 10;
            lblSelectPlan.Text = "Vælg abonnement";
            lblSelectPlan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnSubscribe
            // 
            layoutMain.SetColumnSpan(btnSubscribe, 2);
            btnSubscribe.Dock = DockStyle.Top;
            btnSubscribe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscribe.Location = new Point(469, 349);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(292, 40);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Opret Abonnement";
            btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // panelTopBar
            // 
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(panelTopBar, 3);
            panelTopBar.Controls.Add(layoutTopBar);
            panelTopBar.Dock = DockStyle.Fill;
            panelTopBar.Location = new Point(23, 23);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(738, 44);
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
            layoutTopBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutTopBar.Size = new Size(736, 42);
            layoutTopBar.TabIndex = 5;
            // 
            // topBarFlowButtons
            // 
            topBarFlowButtons.AutoSize = true;
            topBarFlowButtons.Controls.Add(btnProfile);
            topBarFlowButtons.Controls.Add(btnBiler);
            topBarFlowButtons.Controls.Add(btnContact);
            topBarFlowButtons.Dock = DockStyle.Fill;
            topBarFlowButtons.FlowDirection = FlowDirection.RightToLeft;
            topBarFlowButtons.Location = new Point(52, 3);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(681, 37);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(580, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(98, 30);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Min Side";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(499, 3);
            btnBiler.Name = "btnBiler";
            btnBiler.Size = new Size(75, 30);
            btnBiler.TabIndex = 1;
            btnBiler.Text = "Biler";
            btnBiler.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 12F);
            btnContact.Location = new Point(418, 3);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(75, 30);
            btnContact.TabIndex = 3;
            btnContact.Text = "Kontakt";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(43, 37);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Dock = DockStyle.Bottom;
            lblCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(23, 95);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(440, 25);
            lblCarName.TabIndex = 6;
            lblCarName.Text = "Bil navn";
            lblCarName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PanelSelectPlan
            // 
            PanelSelectPlan.AutoSize = true;
            PanelSelectPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSelectPlan.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(PanelSelectPlan, 2);
            PanelSelectPlan.Controls.Add(btnSubscription1);
            PanelSelectPlan.Controls.Add(btnSubscription2);
            PanelSelectPlan.Controls.Add(btnSubscription3);
            PanelSelectPlan.Dock = DockStyle.Fill;
            PanelSelectPlan.FlowDirection = FlowDirection.TopDown;
            PanelSelectPlan.Location = new Point(469, 123);
            PanelSelectPlan.Name = "PanelSelectPlan";
            PanelSelectPlan.Size = new Size(292, 149);
            PanelSelectPlan.TabIndex = 9;
            // 
            // btnSubscription1
            // 
            btnSubscription1.AutoSize = true;
            btnSubscription1.Font = new Font("Segoe UI", 12F);
            btnSubscription1.Location = new Point(14, 12);
            btnSubscription1.Margin = new Padding(14, 12, 14, 12);
            btnSubscription1.Name = "btnSubscription1";
            btnSubscription1.Size = new Size(131, 25);
            btnSubscription1.TabIndex = 0;
            btnSubscription1.TabStop = true;
            btnSubscription1.Text = "1. Subscription";
            btnSubscription1.UseVisualStyleBackColor = true;
            btnSubscription1.Click += btnSubscription1_Clicked;
            // 
            // btnSubscription2
            // 
            btnSubscription2.AutoSize = true;
            btnSubscription2.Font = new Font("Segoe UI", 12F);
            btnSubscription2.Location = new Point(14, 61);
            btnSubscription2.Margin = new Padding(14, 12, 14, 12);
            btnSubscription2.Name = "btnSubscription2";
            btnSubscription2.Size = new Size(131, 25);
            btnSubscription2.TabIndex = 1;
            btnSubscription2.TabStop = true;
            btnSubscription2.Text = "2. Subscription";
            btnSubscription2.UseVisualStyleBackColor = true;
            btnSubscription2.Click += btnSubscription2_Clicked;
            // 
            // btnSubscription3
            // 
            btnSubscription3.AutoSize = true;
            btnSubscription3.Font = new Font("Segoe UI", 12F);
            btnSubscription3.Location = new Point(14, 110);
            btnSubscription3.Margin = new Padding(14, 12, 14, 12);
            btnSubscription3.Name = "btnSubscription3";
            btnSubscription3.Size = new Size(131, 25);
            btnSubscription3.TabIndex = 2;
            btnSubscription3.TabStop = true;
            btnSubscription3.Text = "3. Subscription";
            btnSubscription3.UseVisualStyleBackColor = true;
            btnSubscription3.Click += btnSubscription3_Clicked;
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
            tableLayoutPanel1.Location = new Point(23, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            layoutMain.SetRowSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(440, 665);
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
            lblCarDetails.Size = new Size(434, 21);
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
            picCar.Size = new Size(434, 194);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
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
            lblCarDescription.Size = new Size(424, 63);
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
            lblCarInfoLeft.Size = new Size(162, 126);
            lblCarInfoLeft.TabIndex = 1;
            lblCarInfoLeft.Text = "CarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft";
            lblCarInfoLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoRight
            // 
            lblCarInfoRight.AutoSize = true;
            lblCarInfoRight.Dock = DockStyle.Fill;
            lblCarInfoRight.Font = new Font("Segoe UI", 12F);
            lblCarInfoRight.Location = new Point(228, 239);
            lblCarInfoRight.Margin = new Padding(8);
            lblCarInfoRight.Name = "lblCarInfoRight";
            lblCarInfoRight.Size = new Size(204, 126);
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
            lblCarDescriptionDisplay.Size = new Size(434, 21);
            lblCarDescriptionDisplay.TabIndex = 8;
            lblCarDescriptionDisplay.Text = "Beskrivelse";
            lblCarDescriptionDisplay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPriceNumber
            // 
            lblPriceNumber.AutoSize = true;
            lblPriceNumber.BorderStyle = BorderStyle.FixedSingle;
            lblPriceNumber.Dock = DockStyle.Fill;
            lblPriceNumber.Font = new Font("Segoe UI", 12F);
            lblPriceNumber.Location = new Point(617, 278);
            lblPriceNumber.Margin = new Padding(3);
            lblPriceNumber.Name = "lblPriceNumber";
            lblPriceNumber.Size = new Size(144, 65);
            lblPriceNumber.TabIndex = 12;
            lblPriceNumber.Text = "PriceDescription\r\nPriceDescription\r\nPriceDescription";
            lblPriceNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CarViewDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(layoutMain);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 700);
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
        private Button btnProfile;
        private Button btnBiler;
        private Button btnContact;
        private Button btnBack;
        private Label lblCarName;
        private FlowLayoutPanel PanelSelectPlan;
        private Label lblSelectPlan;
        private RadioButton btnSubscription1;
        private RadioButton btnSubscription2;
        private RadioButton btnSubscription3;
        private Button btnSubscribe;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picCar;
        private Label lblCarDescription;
        private Label lblCarInfoLeft;
        private Label lblCarInfoRight;
        private Label lblCarDetails;
        private Label lblCarDescriptionDisplay;
        private Label lblPriceText;
        private Label lblPriceNumber;
    }
}