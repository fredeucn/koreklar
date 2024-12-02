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
            btnProfile = new Button();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTotalPrice = new Label();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            PanelSelectPlan.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            layoutMain.Controls.Add(lblSelectPlan, 1, 1);
            layoutMain.Controls.Add(panelTopBar, 0, 0);
            layoutMain.Controls.Add(lblCarName, 0, 1);
            layoutMain.Controls.Add(PanelSelectPlan, 1, 2);
            layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
            layoutMain.Controls.Add(flowLayoutPanel1, 1, 3);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 5, 4, 5);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(29, 33, 29, 33);
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(1284, 1128);
            layoutMain.TabIndex = 3;
            // 
            // lblSelectPlan
            // 
            lblSelectPlan.AutoSize = true;
            lblSelectPlan.Dock = DockStyle.Bottom;
            lblSelectPlan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectPlan.Location = new Point(768, 159);
            lblSelectPlan.Margin = new Padding(4, 0, 4, 0);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new Size(483, 40);
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
            panelTopBar.Size = new Size(1218, 73);
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
            layoutTopBar.Size = new Size(1216, 71);
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
            topBarFlowButtons.Size = new Size(1139, 61);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(995, 5);
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
            btnBiler.Location = new Point(880, 5);
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
            btnContact.Location = new Point(765, 5);
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
            btnBack.Size = new Size(61, 61);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Dock = DockStyle.Top;
            btnSubscribe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscribe.Location = new Point(3, 3);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(485, 67);
            btnSubscribe.TabIndex = 3;
            btnSubscribe.Text = "Opret Abonnement";
            btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Dock = DockStyle.Bottom;
            lblCarName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(33, 159);
            lblCarName.Margin = new Padding(4, 0, 4, 0);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(727, 40);
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
            PanelSelectPlan.Location = new Point(767, 202);
            PanelSelectPlan.Name = "PanelSelectPlan";
            PanelSelectPlan.Size = new Size(485, 230);
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
            layoutMain.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(727, 1108);
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
            lblCarDetails.Size = new Size(719, 32);
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
            picCar.Size = new Size(719, 323);
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
            lblCarDescription.Size = new Size(705, 96);
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
            lblCarInfoLeft.Size = new Size(281, 192);
            lblCarInfoLeft.TabIndex = 1;
            lblCarInfoLeft.Text = "CarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft\r\nCarInformationLeft";
            lblCarInfoLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarInfoRight
            // 
            lblCarInfoRight.AutoSize = true;
            lblCarInfoRight.Dock = DockStyle.Fill;
            lblCarInfoRight.Font = new Font("Segoe UI", 12F);
            lblCarInfoRight.Location = new Point(374, 395);
            lblCarInfoRight.Margin = new Padding(11, 13, 11, 13);
            lblCarInfoRight.Name = "lblCarInfoRight";
            lblCarInfoRight.Size = new Size(342, 192);
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
            lblCarDescriptionDisplay.Size = new Size(719, 32);
            lblCarDescriptionDisplay.TabIndex = 8;
            lblCarDescriptionDisplay.Text = "Beskrivelse";
            lblCarDescriptionDisplay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSubscribe);
            flowLayoutPanel1.Controls.Add(lblTotalPrice);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(767, 438);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(485, 876);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Dock = DockStyle.Top;
            lblTotalPrice.Font = new Font("Segoe UI", 12F);
            lblTotalPrice.Location = new Point(3, 73);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(142, 32);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Total: xxx kr.";
            // 
            // CarViewDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 1128);
            Controls.Add(layoutMain);
            MinimumSize = new Size(1133, 963);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTotalPrice;
    }
}