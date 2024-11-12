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
            flowLayoutPanel1 = new FlowLayoutPanel();
            customCarListView1 = new GUI.CustomCarListView();
            customCarListView2 = new GUI.CustomCarListView();
            customCarListView3 = new GUI.CustomCarListView();
            customCarListView4 = new GUI.CustomCarListView();
            customCarListView5 = new GUI.CustomCarListView();
            customCarListView6 = new GUI.CustomCarListView();
            customCarListView7 = new GUI.CustomCarListView();
            customCarListView8 = new GUI.CustomCarListView();
            layoutMain.SuspendLayout();
            panelTopBar.SuspendLayout();
            layoutTopBar.SuspendLayout();
            topBarFlowButtons.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            layoutMain.Controls.Add(flowLayoutPanel1, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(20);
            layoutMain.RowCount = 3;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layoutMain.RowStyles.Add(new RowStyle());
            layoutMain.Size = new Size(776, 766);
            layoutMain.TabIndex = 2;
            // 
            // panelTopBar
            // 
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(panelTopBar, 2);
            panelTopBar.Controls.Add(layoutTopBar);
            panelTopBar.Dock = DockStyle.Fill;
            panelTopBar.Location = new Point(23, 23);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(730, 44);
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
            layoutTopBar.Name = "layoutTopBar";
            layoutTopBar.RowCount = 1;
            layoutTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTopBar.Size = new Size(728, 42);
            layoutTopBar.TabIndex = 5;
            // 
            // topBarFlowButtons
            // 
            topBarFlowButtons.Controls.Add(btnLogin);
            topBarFlowButtons.Controls.Add(btnBiler);
            topBarFlowButtons.Controls.Add(btnContact);
            topBarFlowButtons.Dock = DockStyle.Fill;
            topBarFlowButtons.FlowDirection = FlowDirection.RightToLeft;
            topBarFlowButtons.Location = new Point(39, 3);
            topBarFlowButtons.Name = "topBarFlowButtons";
            topBarFlowButtons.Size = new Size(686, 36);
            topBarFlowButtons.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(608, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnBiler
            // 
            btnBiler.Font = new Font("Segoe UI", 12F);
            btnBiler.Location = new Point(527, 3);
            btnBiler.Name = "btnBiler";
            btnBiler.Size = new Size(75, 30);
            btnBiler.TabIndex = 1;
            btnBiler.Text = "Biler";
            btnBiler.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 12F);
            btnContact.Location = new Point(446, 3);
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
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblSelectCar
            // 
            lblSelectCar.AutoSize = true;
            lblSelectCar.Dock = DockStyle.Bottom;
            lblSelectCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectCar.Location = new Point(23, 95);
            lblSelectCar.Name = "lblSelectCar";
            lblSelectCar.Size = new Size(435, 25);
            lblSelectCar.TabIndex = 6;
            lblSelectCar.Text = "Vælg Bil";
            lblSelectCar.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(464, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Søg efter bil...";
            txtSearch.Size = new Size(289, 29);
            txtSearch.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            layoutMain.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(customCarListView1);
            flowLayoutPanel1.Controls.Add(customCarListView2);
            flowLayoutPanel1.Controls.Add(customCarListView3);
            flowLayoutPanel1.Controls.Add(customCarListView4);
            flowLayoutPanel1.Controls.Add(customCarListView5);
            flowLayoutPanel1.Controls.Add(customCarListView6);
            flowLayoutPanel1.Controls.Add(customCarListView7);
            flowLayoutPanel1.Controls.Add(customCarListView8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(23, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(730, 620);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // customCarListView1
            // 
            customCarListView1.Location = new Point(5, 5);
            customCarListView1.Margin = new Padding(5);
            customCarListView1.Name = "customCarListView1";
            customCarListView1.Size = new Size(160, 210);
            customCarListView1.TabIndex = 0;
            // 
            // customCarListView2
            // 
            customCarListView2.Location = new Point(175, 5);
            customCarListView2.Margin = new Padding(5);
            customCarListView2.Name = "customCarListView2";
            customCarListView2.Size = new Size(160, 210);
            customCarListView2.TabIndex = 1;
            // 
            // customCarListView3
            // 
            customCarListView3.Location = new Point(345, 5);
            customCarListView3.Margin = new Padding(5);
            customCarListView3.Name = "customCarListView3";
            customCarListView3.Size = new Size(160, 210);
            customCarListView3.TabIndex = 2;
            // 
            // customCarListView4
            // 
            customCarListView4.Location = new Point(515, 5);
            customCarListView4.Margin = new Padding(5);
            customCarListView4.Name = "customCarListView4";
            customCarListView4.Size = new Size(160, 210);
            customCarListView4.TabIndex = 3;
            // 
            // customCarListView5
            // 
            customCarListView5.Location = new Point(5, 225);
            customCarListView5.Margin = new Padding(5);
            customCarListView5.Name = "customCarListView5";
            customCarListView5.Size = new Size(160, 210);
            customCarListView5.TabIndex = 4;
            // 
            // customCarListView6
            // 
            customCarListView6.Location = new Point(175, 225);
            customCarListView6.Margin = new Padding(5);
            customCarListView6.Name = "customCarListView6";
            customCarListView6.Size = new Size(160, 210);
            customCarListView6.TabIndex = 5;
            // 
            // customCarListView7
            // 
            customCarListView7.Location = new Point(345, 225);
            customCarListView7.Margin = new Padding(5);
            customCarListView7.Name = "customCarListView7";
            customCarListView7.Size = new Size(160, 210);
            customCarListView7.TabIndex = 6;
            // 
            // customCarListView8
            // 
            customCarListView8.Location = new Point(515, 225);
            customCarListView8.Margin = new Padding(5);
            customCarListView8.Name = "customCarListView8";
            customCarListView8.Size = new Size(160, 210);
            customCarListView8.TabIndex = 7;
            // 
            // CarsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 766);
            Controls.Add(layoutMain);
            MinimumSize = new Size(600, 400);
            Name = "CarsView";
            Text = "Form1";
            Load += Form1_Load;
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            panelTopBar.ResumeLayout(false);
            layoutTopBar.ResumeLayout(false);
            topBarFlowButtons.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private GUI.CustomCarListView customCarListView1;
        private GUI.CustomCarListView customCarListView2;
        private GUI.CustomCarListView customCarListView3;
        private GUI.CustomCarListView customCarListView4;
        private GUI.CustomCarListView customCarListView5;
        private GUI.CustomCarListView customCarListView6;
        private GUI.CustomCarListView customCarListView7;
        private GUI.CustomCarListView customCarListView8;
    }
}
