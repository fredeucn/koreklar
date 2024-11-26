namespace koreklarFORMS
{
    partial class CarsView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutMain = new TableLayoutPanel();
            panelTopBar = new Panel();
            layoutTopBar = new TableLayoutPanel();
            topBarFlowButtons = new FlowLayoutPanel();
            btnLogin = new Button();
            btnBiler = new Button();
            btnContact = new Button();
            btnBack = new Button();
            lblSelectCar = new Label();
            txtSearch = new TextBox();
            PanelCarList = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreateCar = new Button();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            layoutMain.Controls.Add(panelTopBar, 0, 0);
            layoutMain.Controls.Add(lblSelectCar, 0, 1);
            layoutMain.Controls.Add(txtSearch, 1, 1);
            layoutMain.Controls.Add(PanelCarList, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 5, 4, 5);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(29, 33, 29, 33);
            layoutMain.RowCount = 3;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(1013, 1063);
            layoutMain.TabIndex = 2;
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
            panelTopBar.Size = new Size(947, 57);
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
            layoutTopBar.Size = new Size(945, 55);
            layoutTopBar.TabIndex = 5;
            // 
            // topBarFlowButtons
            // 
            topBarFlowButtons.Controls.Add(btnLogin);
            topBarFlowButtons.Controls.Add(btnBiler);
            topBarFlowButtons.Controls.Add(btnContact);
            topBarFlowButtons.Controls.Add(btnCreateCar);
            topBarFlowButtons.Dock = DockStyle.Fill;
            topBarFlowButtons.FlowDirection = FlowDirection.RightToLeft;
            topBarFlowButtons.Location = new Point(55, 5);
            topBarFlowButtons.Margin = new Padding(4, 5, 4, 5);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(886, 45);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(775, 5);
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
            btnBiler.Location = new Point(660, 5);
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
            btnContact.Location = new Point(530, 5);
            btnContact.Margin = new Padding(4, 5, 4, 5);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(122, 50);
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
            btnBack.Size = new Size(43, 43);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblSelectCar
            // 
            lblSelectCar.AutoSize = true;
            lblSelectCar.Dock = DockStyle.Bottom;
            lblSelectCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectCar.Location = new Point(33, 127);
            lblSelectCar.Margin = new Padding(4, 0, 4, 0);
            lblSelectCar.Name = "lblSelectCar";
            lblSelectCar.Size = new Size(565, 40);
            lblSelectCar.TabIndex = 6;
            lblSelectCar.Text = "Vælg Bil";
            lblSelectCar.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(606, 123);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Søg efter bil...";
            txtSearch.Size = new Size(374, 39);
            txtSearch.TabIndex = 7;
            // 
            // PanelCarList
            // 
            PanelCarList.AutoScroll = true;
            PanelCarList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelCarList.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(PanelCarList, 2);
            PanelCarList.Dock = DockStyle.Fill;
            PanelCarList.Location = new Point(33, 172);
            PanelCarList.Margin = new Padding(4, 5, 4, 5);
            PanelCarList.Name = "PanelCarList";
            PanelCarList.Size = new Size(947, 853);
            PanelCarList.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(26, 165);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(835, 825);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnCreateCar
            // 
            btnCreateCar.Font = new Font("Segoe UI", 12F);
            btnCreateCar.Location = new Point(373, 5);
            btnCreateCar.Margin = new Padding(4, 5, 4, 5);
            btnCreateCar.Name = "btnCreateCar";
            btnCreateCar.Size = new Size(149, 50);
            btnCreateCar.TabIndex = 5;
            btnCreateCar.Text = "Opret Bil";
            btnCreateCar.UseVisualStyleBackColor = true;
            btnCreateCar.Click += btnCreateCar_Click;
            // 
            // CarsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 1063);
            Controls.Add(layoutMain);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(845, 618);
            Name = "CarsView";
            Text = "Køreklar";
            Load += CarsView_Load;
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            layoutTopBar.ResumeLayout(false);
            topBarFlowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel layoutMain;
        private Button btnBack;
        private Button btnBiler;
        private Button btnContact;
        private Button btnLogin;
        private TableLayoutPanel layoutTopBar;
        private FlowLayoutPanel topBarFlowButtons;
        private Label lblSelectCar;
        private TextBox txtSearch;
        private Panel panelTopBar;
        private FlowLayoutPanel PanelCarList;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreateCar;
    }
}
