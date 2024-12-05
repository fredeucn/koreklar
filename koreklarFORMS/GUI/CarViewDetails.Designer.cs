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
            layoutMain.Margin = new Padding(4, 5, 4, 5);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(29, 33, 29, 33);
            layoutMain.RowCount = 5;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(1120, 1102);
            layoutMain.TabIndex = 3;
            // 
            // lblPriceText
            // 
            lblPriceText.AutoSize = true;
            lblPriceText.Dock = DockStyle.Fill;
            lblPriceText.Font = new Font("Segoe UI", 12F);
            lblPriceText.Location = new Point(670, 444);
            lblPriceText.Margin = new Padding(4, 5, 4, 5);
            lblPriceText.Name = "lblPriceText";
            lblPriceText.Size = new Size(204, 96);
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
            lblSelectPlan.Location = new Point(670, 159);
            lblSelectPlan.Margin = new Padding(4, 0, 4, 0);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new Size(417, 40);
            lblSelectPlan.TabIndex = 10;
            lblSelectPlan.Text = "Vælg abonnement";
            lblSelectPlan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnSubscribe
            // 
            layoutMain.SetColumnSpan(btnSubscribe, 2);
            btnSubscribe.Dock = DockStyle.Top;
            btnSubscribe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscribe.Location = new Point(670, 550);
            btnSubscribe.Margin = new Padding(4, 5, 4, 5);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(417, 67);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Opret Abonnement";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // panelTopBar
            // 
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(panelTopBar, 3);
            panelTopBar.Controls.Add(layoutTopBar);
            panelTopBar.Dock = DockStyle.Fill;
            panelTopBar.Location = new Point(33, 38);
            panelTopBar.Margin = new Padding(4, 5, 4, 5);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1054, 73);
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
            layoutTopBar.Margin = new Padding(4, 5, 4, 5);
            layoutTopBar.Name = "layoutTopBar";
            layoutTopBar.RowCount = 1;
            layoutTopBar.RowStyles.Add(new RowStyle());
            layoutTopBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            layoutTopBar.Size = new Size(1052, 71);
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
            topBarFlowButtons.Location = new Point(73, 5);
            topBarFlowButtons.Margin = new Padding(4, 5, 4, 5);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(975, 62);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(831, 5);
            btnProfile.Margin = new Padding(4, 5, 4, 5);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(140, 50);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Min Side";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(716, 5);
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
            btnContact.Location = new Point(601, 5);
            btnContact.Margin = new Padding(4, 5, 4, 5);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(107, 50);
            btnContact.TabIndex = 3;
            btnContact.Text = "Kontakt";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(4, 5);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 62);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Dock = DockStyle.Bottom;
            lblCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(33, 159);
            lblCarName.Margin = new Padding(4, 0, 4, 0);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(629, 40);
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
            PanelSelectPlan.Location = new Point(670, 204);
            PanelSelectPlan.Margin = new Padding(4, 5, 4, 5);
            PanelSelectPlan.Name = "PanelSelectPlan";
            PanelSelectPlan.Size = new Size(417, 230);
            PanelSelectPlan.TabIndex = 9;
            // 
            // btnSubscription1
            // 
            btnSubscription1.AutoSize = true;
            btnSubscription1.Font = new Font("Segoe UI", 12F);
            btnSubscription1.Location = new Point(20, 20);
            btnSubscription1.Margin = new Padding(20);
            btnSubscription1.Name = "btnSubscription1";
            btnSubscription1.Size = new Size(196, 36);
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
            btnSubscription2.Location = new Point(20, 96);
            btnSubscription2.Margin = new Padding(20);
            btnSubscription2.Name = "btnSubscription2";
            btnSubscription2.Size = new Size(196, 36);
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
            btnSubscription3.Location = new Point(20, 172);
            btnSubscription3.Margin = new Padding(20);
            btnSubscription3.Name = "btnSubscription3";
            btnSubscription3.Size = new Size(196, 36);
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
            tableLayoutPanel1.Location = new Point(33, 204);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            layoutMain.SetRowSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(629, 1108);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblCarDetails
            // 
            lblCarDetails.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCarDetails, 2);
            lblCarDetails.Dock = DockStyle.Bottom;
            lblCarDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCarDetails.Location = new Point(4, 350);
            lblCarDetails.Margin = new Padding(4, 17, 4, 0);
            lblCarDetails.Name = "lblCarDetails";
            lblCarDetails.Size = new Size(621, 32);
            lblCarDetails.TabIndex = 7;
            lblCarDetails.Text = "Detaljer";
            lblCarDetails.TextAlign = ContentAlignment.BottomLeft;
            // 
            // picCar
            // 
            tableLayoutPanel1.SetColumnSpan(picCar, 3);
            picCar.Dock = DockStyle.Fill;
            picCar.Location = new Point(4, 5);
            picCar.Margin = new Padding(4, 5, 4, 5);
            picCar.Name = "picCar";
            picCar.Size = new Size(621, 323);
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
            lblCarDescription.Location = new Point(11, 662);
            lblCarDescription.Margin = new Padding(11, 13, 11, 13);
            lblCarDescription.Name = "lblCarDescription";
            lblCarDescription.Size = new Size(607, 96);
            lblCarDescription.TabIndex = 3;
            lblCarDescription.Text = "CarDescription\r\nCarDescription\r\nCarDescription";
            lblCarDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoLeft
            // 
            lblCarInfoLeft.AutoSize = true;
            lblCarInfoLeft.Dock = DockStyle.Fill;
            lblCarInfoLeft.Font = new Font("Segoe UI", 12F);
            lblCarInfoLeft.Location = new Point(11, 395);
            lblCarInfoLeft.Margin = new Padding(11, 13, 71, 13);
            lblCarInfoLeft.Name = "lblCarInfoLeft";
            lblCarInfoLeft.Size = new Size(232, 192);
            lblCarInfoLeft.TabIndex = 1;
            lblCarInfoLeft.Text = "CarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft";
            lblCarInfoLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoRight
            // 
            lblCarInfoRight.AutoSize = true;
            lblCarInfoRight.Dock = DockStyle.Fill;
            lblCarInfoRight.Font = new Font("Segoe UI", 12F);
            lblCarInfoRight.Location = new Point(325, 395);
            lblCarInfoRight.Margin = new Padding(11, 13, 11, 13);
            lblCarInfoRight.Name = "lblCarInfoRight";
            lblCarInfoRight.Size = new Size(293, 192);
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
            lblCarDescriptionDisplay.Location = new Point(4, 617);
            lblCarDescriptionDisplay.Margin = new Padding(4, 17, 4, 0);
            lblCarDescriptionDisplay.Name = "lblCarDescriptionDisplay";
            lblCarDescriptionDisplay.Size = new Size(621, 32);
            lblCarDescriptionDisplay.TabIndex = 8;
            lblCarDescriptionDisplay.Text = "Beskrivelse";
            lblCarDescriptionDisplay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPriceNumber
            // 
            lblPriceNumber.AutoSize = true;
            lblPriceNumber.Dock = DockStyle.Fill;
            lblPriceNumber.Font = new Font("Segoe UI", 12F);
            lblPriceNumber.Location = new Point(882, 444);
            lblPriceNumber.Margin = new Padding(4, 5, 4, 5);
            lblPriceNumber.Name = "lblPriceNumber";
            lblPriceNumber.Size = new Size(205, 96);
            lblPriceNumber.TabIndex = 12;
            lblPriceNumber.Text = "PriceDescription\r\nPriceDescription\r\nPriceDescription";
            lblPriceNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CarViewDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 1102);
            Controls.Add(layoutMain);
            MinimumSize = new Size(1133, 1129);
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