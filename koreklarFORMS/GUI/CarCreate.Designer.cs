namespace koreklarFORMS.GUI
{
    partial class CarCreate
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
            panelTopBar = new Panel();
            layoutTopBar = new TableLayoutPanel();
            topBarFlowButtons = new FlowLayoutPanel();
            btnProfile = new Button();
            btnBiler = new Button();
            btnContact = new Button();
            btnBack = new Button();
            lblCreateCar = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtLicensePlate = new TextBox();
            lblDisplayLicensePlate = new Label();
            txtTopSpeed = new NumericUpDown();
            txtDistance = new NumericUpDown();
            txtPrice = new NumericUpDown();
            lblDisplayDescription = new Label();
            lblDisplayCondition = new Label();
            lblDisplayVin = new Label();
            lblDisplayColor = new Label();
            lblDisplayType = new Label();
            txtVin = new TextBox();
            txtColor = new TextBox();
            txtType = new TextBox();
            lblDisplayPrice = new Label();
            lblDisplayTopSpeed = new Label();
            lblDisplayModel = new Label();
            lblDisplayFuelType = new Label();
            lblDisplayDistance = new Label();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            lblDisplayYear = new Label();
            lblDisplayBrand = new Label();
            txtDescription = new TextBox();
            txtYear = new NumericUpDown();
            txtFuelType = new ComboBox();
            txtCondition = new ComboBox();
            imgUpload = new PictureBox();
            btnConfirm = new Button();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTopSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUpload).BeginInit();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            layoutMain.Controls.Add(panelTopBar, 0, 0);
            layoutMain.Controls.Add(lblCreateCar, 0, 1);
            layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
            layoutMain.Controls.Add(imgUpload, 1, 2);
            layoutMain.Controls.Add(btnConfirm, 1, 3);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(20);
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutMain.Size = new Size(839, 672);
            layoutMain.TabIndex = 4;
            // 
            // panelTopBar
            // 
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(panelTopBar, 2);
            panelTopBar.Controls.Add(layoutTopBar);
            panelTopBar.Dock = DockStyle.Fill;
            panelTopBar.Location = new Point(23, 23);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(793, 44);
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
            layoutTopBar.Size = new Size(791, 42);
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
            topBarFlowButtons.Size = new Size(736, 37);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.Location = new Point(635, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(98, 30);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Min Side";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(554, 3);
            btnBiler.Name = "btnBiler";
            btnBiler.Size = new Size(75, 30);
            btnBiler.TabIndex = 1;
            btnBiler.Text = "Biler";
            btnBiler.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 12F);
            btnContact.Location = new Point(473, 3);
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
            // lblCreateCar
            // 
            lblCreateCar.AutoSize = true;
            lblCreateCar.Dock = DockStyle.Bottom;
            lblCreateCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateCar.Location = new Point(23, 95);
            lblCreateCar.Name = "lblCreateCar";
            lblCreateCar.Size = new Size(553, 25);
            lblCreateCar.TabIndex = 6;
            lblCreateCar.Text = "Opret Bil";
            lblCreateCar.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtLicensePlate, 3, 5);
            tableLayoutPanel1.Controls.Add(lblDisplayLicensePlate, 2, 5);
            tableLayoutPanel1.Controls.Add(txtTopSpeed, 3, 2);
            tableLayoutPanel1.Controls.Add(txtDistance, 3, 0);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(lblDisplayDescription, 0, 6);
            tableLayoutPanel1.Controls.Add(lblDisplayCondition, 2, 4);
            tableLayoutPanel1.Controls.Add(lblDisplayVin, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDisplayColor, 2, 3);
            tableLayoutPanel1.Controls.Add(lblDisplayType, 0, 3);
            tableLayoutPanel1.Controls.Add(txtVin, 1, 4);
            tableLayoutPanel1.Controls.Add(txtColor, 3, 3);
            tableLayoutPanel1.Controls.Add(txtType, 1, 3);
            tableLayoutPanel1.Controls.Add(lblDisplayPrice, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDisplayTopSpeed, 2, 2);
            tableLayoutPanel1.Controls.Add(lblDisplayModel, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDisplayFuelType, 2, 1);
            tableLayoutPanel1.Controls.Add(lblDisplayDistance, 2, 0);
            tableLayoutPanel1.Controls.Add(txtModel, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBrand, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDisplayYear, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDisplayBrand, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 7);
            tableLayoutPanel1.Controls.Add(txtYear, 1, 0);
            tableLayoutPanel1.Controls.Add(txtFuelType, 3, 1);
            tableLayoutPanel1.Controls.Add(txtCondition, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            layoutMain.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(553, 528);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Dock = DockStyle.Fill;
            txtLicensePlate.Location = new Point(366, 153);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(184, 23);
            txtLicensePlate.TabIndex = 45;
            // 
            // lblDisplayLicensePlate
            // 
            lblDisplayLicensePlate.AutoSize = true;
            lblDisplayLicensePlate.Dock = DockStyle.Fill;
            lblDisplayLicensePlate.Location = new Point(273, 153);
            lblDisplayLicensePlate.Margin = new Padding(3);
            lblDisplayLicensePlate.Name = "lblDisplayLicensePlate";
            lblDisplayLicensePlate.Size = new Size(87, 24);
            lblDisplayLicensePlate.TabIndex = 44;
            lblDisplayLicensePlate.Text = "Nummerplade:";
            lblDisplayLicensePlate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTopSpeed
            // 
            txtTopSpeed.Dock = DockStyle.Fill;
            txtTopSpeed.Location = new Point(366, 63);
            txtTopSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtTopSpeed.Name = "txtTopSpeed";
            txtTopSpeed.Size = new Size(184, 23);
            txtTopSpeed.TabIndex = 41;
            txtTopSpeed.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // txtDistance
            // 
            txtDistance.Dock = DockStyle.Fill;
            txtDistance.Location = new Point(366, 3);
            txtDistance.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(184, 23);
            txtDistance.TabIndex = 40;
            txtDistance.ThousandsSeparator = true;
            // 
            // txtPrice
            // 
            txtPrice.DecimalPlaces = 2;
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            txtPrice.Location = new Point(84, 153);
            txtPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 23);
            txtPrice.TabIndex = 39;
            txtPrice.ThousandsSeparator = true;
            txtPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblDisplayDescription
            // 
            lblDisplayDescription.AutoSize = true;
            lblDisplayDescription.Dock = DockStyle.Fill;
            lblDisplayDescription.Location = new Point(3, 183);
            lblDisplayDescription.Margin = new Padding(3);
            lblDisplayDescription.Name = "lblDisplayDescription";
            lblDisplayDescription.Size = new Size(75, 24);
            lblDisplayDescription.TabIndex = 36;
            lblDisplayDescription.Text = "Beskrivelse:";
            lblDisplayDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayCondition
            // 
            lblDisplayCondition.AutoSize = true;
            lblDisplayCondition.Dock = DockStyle.Fill;
            lblDisplayCondition.Location = new Point(273, 123);
            lblDisplayCondition.Margin = new Padding(3);
            lblDisplayCondition.Name = "lblDisplayCondition";
            lblDisplayCondition.Size = new Size(87, 24);
            lblDisplayCondition.TabIndex = 33;
            lblDisplayCondition.Text = "Stand:";
            lblDisplayCondition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayVin
            // 
            lblDisplayVin.AutoSize = true;
            lblDisplayVin.Dock = DockStyle.Fill;
            lblDisplayVin.Location = new Point(3, 123);
            lblDisplayVin.Margin = new Padding(3);
            lblDisplayVin.Name = "lblDisplayVin";
            lblDisplayVin.Size = new Size(75, 24);
            lblDisplayVin.TabIndex = 32;
            lblDisplayVin.Text = "Stelnummer:";
            lblDisplayVin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayColor
            // 
            lblDisplayColor.AutoSize = true;
            lblDisplayColor.Dock = DockStyle.Fill;
            lblDisplayColor.Location = new Point(273, 93);
            lblDisplayColor.Margin = new Padding(3);
            lblDisplayColor.Name = "lblDisplayColor";
            lblDisplayColor.Size = new Size(87, 24);
            lblDisplayColor.TabIndex = 31;
            lblDisplayColor.Text = "Farve:";
            lblDisplayColor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayType
            // 
            lblDisplayType.AutoSize = true;
            lblDisplayType.Dock = DockStyle.Fill;
            lblDisplayType.Location = new Point(3, 93);
            lblDisplayType.Margin = new Padding(3);
            lblDisplayType.Name = "lblDisplayType";
            lblDisplayType.Size = new Size(75, 24);
            lblDisplayType.TabIndex = 30;
            lblDisplayType.Text = "Type:";
            lblDisplayType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVin
            // 
            txtVin.Dock = DockStyle.Fill;
            txtVin.Location = new Point(84, 123);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(183, 23);
            txtVin.TabIndex = 27;
            // 
            // txtColor
            // 
            txtColor.Dock = DockStyle.Fill;
            txtColor.Location = new Point(366, 93);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(184, 23);
            txtColor.TabIndex = 25;
            // 
            // txtType
            // 
            txtType.Dock = DockStyle.Fill;
            txtType.Location = new Point(84, 93);
            txtType.Name = "txtType";
            txtType.Size = new Size(183, 23);
            txtType.TabIndex = 23;
            // 
            // lblDisplayPrice
            // 
            lblDisplayPrice.AutoSize = true;
            lblDisplayPrice.Dock = DockStyle.Fill;
            lblDisplayPrice.Location = new Point(3, 153);
            lblDisplayPrice.Margin = new Padding(3);
            lblDisplayPrice.Name = "lblDisplayPrice";
            lblDisplayPrice.Size = new Size(75, 24);
            lblDisplayPrice.TabIndex = 20;
            lblDisplayPrice.Text = "Pris:";
            lblDisplayPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayTopSpeed
            // 
            lblDisplayTopSpeed.AutoSize = true;
            lblDisplayTopSpeed.Dock = DockStyle.Fill;
            lblDisplayTopSpeed.Location = new Point(273, 63);
            lblDisplayTopSpeed.Margin = new Padding(3);
            lblDisplayTopSpeed.Name = "lblDisplayTopSpeed";
            lblDisplayTopSpeed.Size = new Size(87, 24);
            lblDisplayTopSpeed.TabIndex = 19;
            lblDisplayTopSpeed.Text = "Tophastighed:";
            lblDisplayTopSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayModel
            // 
            lblDisplayModel.AutoSize = true;
            lblDisplayModel.Dock = DockStyle.Fill;
            lblDisplayModel.Location = new Point(3, 63);
            lblDisplayModel.Margin = new Padding(3);
            lblDisplayModel.Name = "lblDisplayModel";
            lblDisplayModel.Size = new Size(75, 24);
            lblDisplayModel.TabIndex = 18;
            lblDisplayModel.Text = "Model:";
            lblDisplayModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayFuelType
            // 
            lblDisplayFuelType.AutoSize = true;
            lblDisplayFuelType.Dock = DockStyle.Fill;
            lblDisplayFuelType.Location = new Point(273, 33);
            lblDisplayFuelType.Margin = new Padding(3);
            lblDisplayFuelType.Name = "lblDisplayFuelType";
            lblDisplayFuelType.Size = new Size(87, 24);
            lblDisplayFuelType.TabIndex = 17;
            lblDisplayFuelType.Text = "Drivmiddel:";
            lblDisplayFuelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayDistance
            // 
            lblDisplayDistance.AutoSize = true;
            lblDisplayDistance.Dock = DockStyle.Fill;
            lblDisplayDistance.Location = new Point(273, 3);
            lblDisplayDistance.Margin = new Padding(3);
            lblDisplayDistance.Name = "lblDisplayDistance";
            lblDisplayDistance.Size = new Size(87, 24);
            lblDisplayDistance.TabIndex = 16;
            lblDisplayDistance.Text = "Kilometertal:";
            lblDisplayDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            txtModel.Dock = DockStyle.Fill;
            txtModel.Location = new Point(84, 63);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(183, 23);
            txtModel.TabIndex = 9;
            // 
            // txtBrand
            // 
            txtBrand.Dock = DockStyle.Fill;
            txtBrand.Location = new Point(84, 33);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(183, 23);
            txtBrand.TabIndex = 5;
            // 
            // lblDisplayYear
            // 
            lblDisplayYear.AutoSize = true;
            lblDisplayYear.Dock = DockStyle.Fill;
            lblDisplayYear.Location = new Point(3, 3);
            lblDisplayYear.Margin = new Padding(3);
            lblDisplayYear.Name = "lblDisplayYear";
            lblDisplayYear.Size = new Size(75, 24);
            lblDisplayYear.TabIndex = 0;
            lblDisplayYear.Text = "Modelår:";
            lblDisplayYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDisplayBrand
            // 
            lblDisplayBrand.AutoSize = true;
            lblDisplayBrand.Dock = DockStyle.Fill;
            lblDisplayBrand.Location = new Point(3, 33);
            lblDisplayBrand.Margin = new Padding(3);
            lblDisplayBrand.Name = "lblDisplayBrand";
            lblDisplayBrand.Size = new Size(75, 24);
            lblDisplayBrand.TabIndex = 2;
            lblDisplayBrand.Text = "Mærke:";
            lblDisplayBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            tableLayoutPanel1.SetColumnSpan(txtDescription, 4);
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(3, 213);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(547, 312);
            txtDescription.TabIndex = 37;
            // 
            // txtYear
            // 
            txtYear.Dock = DockStyle.Fill;
            txtYear.Location = new Point(84, 3);
            txtYear.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            txtYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(183, 23);
            txtYear.TabIndex = 38;
            txtYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // txtFuelType
            // 
            txtFuelType.Dock = DockStyle.Fill;
            txtFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFuelType.FormattingEnabled = true;
            txtFuelType.Items.AddRange(new object[] { "El", "Benzin", "Diesel", "Hybrid - Benzin", "Hybrid - Diesel", "Plug-in - Benzin", "Plug-in Diesel" });
            txtFuelType.Location = new Point(366, 33);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(184, 23);
            txtFuelType.TabIndex = 42;
            // 
            // txtCondition
            // 
            txtCondition.Dock = DockStyle.Fill;
            txtCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCondition.FormattingEnabled = true;
            txtCondition.Items.AddRange(new object[] { "Perfekt", "God", "Dårlig" });
            txtCondition.Location = new Point(366, 123);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(184, 23);
            txtCondition.TabIndex = 43;
            // 
            // imgUpload
            // 
            imgUpload.Dock = DockStyle.Fill;
            imgUpload.Image = Properties.Resources.vælg_billede;
            imgUpload.Location = new Point(582, 123);
            imgUpload.Name = "imgUpload";
            imgUpload.Size = new Size(234, 194);
            imgUpload.SizeMode = PictureBoxSizeMode.Zoom;
            imgUpload.TabIndex = 12;
            imgUpload.TabStop = false;
            imgUpload.Click += imgUpload_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Bottom;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirm.Location = new Point(581, 612);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(236, 40);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Opret Bil";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // CarCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 672);
            Controls.Add(layoutMain);
            MinimumSize = new Size(648, 443);
            Name = "CarCreate";
            Text = "Køreklar";
            Load += CarCreate_Load;
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            layoutTopBar.ResumeLayout(false);
            layoutTopBar.PerformLayout();
            topBarFlowButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTopSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUpload).EndInit();
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
        private Label lblCreateCar;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox imgUpload;
        private Button btnConfirm;
        private Label lblDisplayYear;
        private TextBox txtModel;
        private TextBox txtBrand;
        private Label lblDisplayBrand;
        private Label lblDisplayPrice;
        private Label lblDisplayTopSpeed;
        private Label lblDisplayModel;
        private Label lblDisplayFuelType;
        private Label lblDisplayDistance;
        private Label lblDisplayCondition;
        private Label lblDisplayVin;
        private Label lblDisplayColor;
        private Label lblDisplayType;
        private TextBox txtVin;
        private TextBox txtColor;
        private TextBox txtType;
        private Label lblDisplayDescription;
        private TextBox txtDescription;
        private NumericUpDown txtYear;
        private NumericUpDown txtTopSpeed;
        private NumericUpDown txtDistance;
        private NumericUpDown txtPrice;
        private ComboBox txtFuelType;
        private ComboBox txtCondition;
        private Label lblDisplayLicensePlate;
        private TextBox txtLicensePlate;
    }
}