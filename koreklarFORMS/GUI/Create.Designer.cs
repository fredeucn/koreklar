namespace koreklarFORMS.GUI
{
    partial class Create
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
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtType = new TextBox();
            txtColor = new TextBox();
            txtOdometer = new TextBox();
            txtVin = new TextBox();
            txtCondition = new TextBox();
            txtYear = new TextBox();
            txtFuelType = new TextBox();
            txtTopSpeed = new TextBox();
            txtPrice = new TextBox();
            lblBrand = new Label();
            lblModel = new Label();
            lblType = new Label();
            lblColor = new Label();
            lblOdometer = new Label();
            lblVin = new Label();
            lblCondition = new Label();
            lblYear = new Label();
            lblFuelType = new Label();
            lblTopSpeed = new Label();
            lblImage = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnConfirm = new Button();
            btnUploadImage = new Button();
            SuspendLayout();
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(165, 28);
            txtBrand.Margin = new Padding(3, 2, 3, 2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(110, 23);
            txtBrand.TabIndex = 0;
            txtBrand.Text = "Monster";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(165, 72);
            txtModel.Margin = new Padding(3, 2, 3, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(110, 23);
            txtModel.TabIndex = 1;
            txtModel.Text = "Ultra";
            // 
            // txtType
            // 
            txtType.Location = new Point(165, 116);
            txtType.Margin = new Padding(3, 2, 3, 2);
            txtType.Name = "txtType";
            txtType.Size = new Size(110, 23);
            txtType.TabIndex = 2;
            txtType.Text = "Gamer";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(165, 163);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(110, 23);
            txtColor.TabIndex = 3;
            txtColor.Text = "Hvid";
            // 
            // txtOdometer
            // 
            txtOdometer.Location = new Point(165, 211);
            txtOdometer.Margin = new Padding(3, 2, 3, 2);
            txtOdometer.Name = "txtOdometer";
            txtOdometer.Size = new Size(110, 23);
            txtOdometer.TabIndex = 4;
            txtOdometer.Text = "1500";
            // 
            // txtVin
            // 
            txtVin.Location = new Point(165, 261);
            txtVin.Margin = new Padding(3, 2, 3, 2);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(110, 23);
            txtVin.TabIndex = 6;
            txtVin.Text = "Rose";
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(472, 25);
            txtCondition.Margin = new Padding(3, 2, 3, 2);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(110, 23);
            txtCondition.TabIndex = 7;
            txtCondition.Text = "Bad";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(470, 72);
            txtYear.Margin = new Padding(3, 2, 3, 2);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(110, 23);
            txtYear.TabIndex = 8;
            txtYear.Text = "2001";
            txtYear.KeyDown += txt_Year_KeyDown;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(470, 116);
            txtFuelType.Margin = new Padding(3, 2, 3, 2);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(110, 23);
            txtFuelType.TabIndex = 9;
            txtFuelType.Text = "Diesel";
            // 
            // txtTopSpeed
            // 
            txtTopSpeed.Location = new Point(470, 163);
            txtTopSpeed.Margin = new Padding(3, 2, 3, 2);
            txtTopSpeed.Name = "txtTopSpeed";
            txtTopSpeed.Size = new Size(110, 23);
            txtTopSpeed.TabIndex = 10;
            txtTopSpeed.Text = "200";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(472, 217);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 12;
            txtPrice.Text = "5000";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(78, 28);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 13;
            lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(78, 72);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 14;
            lblModel.Text = "Model";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(73, 116);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 15;
            lblType.Text = "Type";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(73, 163);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color";
            // 
            // lblOdometer
            // 
            lblOdometer.AutoSize = true;
            lblOdometer.Location = new Point(73, 211);
            lblOdometer.Name = "lblOdometer";
            lblOdometer.Size = new Size(61, 15);
            lblOdometer.TabIndex = 17;
            lblOdometer.Text = "Odometer";
            // 
            // lblVin
            // 
            lblVin.AutoSize = true;
            lblVin.Location = new Point(73, 263);
            lblVin.Name = "lblVin";
            lblVin.Size = new Size(24, 15);
            lblVin.TabIndex = 19;
            lblVin.Text = "Vin";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(403, 30);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(60, 15);
            lblCondition.TabIndex = 20;
            lblCondition.Text = "Condition";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(403, 72);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 21;
            lblYear.Text = "Year";
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(399, 116);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(53, 15);
            lblFuelType.TabIndex = 22;
            lblFuelType.Text = "FuelType";
            // 
            // lblTopSpeed
            // 
            lblTopSpeed.AutoSize = true;
            lblTopSpeed.Location = new Point(399, 166);
            lblTopSpeed.Name = "lblTopSpeed";
            lblTopSpeed.Size = new Size(58, 15);
            lblTopSpeed.TabIndex = 23;
            lblTopSpeed.Text = "TopSpeed";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(413, 313);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(40, 15);
            lblImage.TabIndex = 24;
            lblImage.Text = "Image";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(421, 217);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 25;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(391, 263);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(472, 259);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 27;
            txtDescription.Text = "This is just a test!";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(500, 388);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(83, 22);
            btnConfirm.TabIndex = 28;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btn_Confirm_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(498, 310);
            btnUploadImage.Margin = new Padding(3, 2, 3, 2);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(83, 22);
            btnUploadImage.TabIndex = 29;
            btnUploadImage.Text = "Choose Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btn_UploadImage_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 685);
            Controls.Add(btnUploadImage);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblImage);
            Controls.Add(lblTopSpeed);
            Controls.Add(lblFuelType);
            Controls.Add(lblYear);
            Controls.Add(lblCondition);
            Controls.Add(lblVin);
            Controls.Add(lblOdometer);
            Controls.Add(lblColor);
            Controls.Add(lblType);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(txtPrice);
            Controls.Add(txtTopSpeed);
            Controls.Add(txtFuelType);
            Controls.Add(txtYear);
            Controls.Add(txtCondition);
            Controls.Add(txtVin);
            Controls.Add(txtOdometer);
            Controls.Add(txtColor);
            Controls.Add(txtType);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Create";
            Text = "Køreklar";
            Load += Create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtType;
        private TextBox txtColor;
        private TextBox txtOdometer;
        private TextBox txtVin;
        private TextBox txtCondition;
        private TextBox txtYear;
        private TextBox txtFuelType;
        private TextBox txtTopSpeed;
        private TextBox txtPrice;
        private Label lblBrand;
        private Label lblModel;
        private Label lblType;
        private Label lblColor;
        private Label lblOdometer;
        private Label lblVin;
        private Label lblCondition;
        private Label lblYear;
        private Label lblFuelType;
        private Label lblTopSpeed;
        private Label lblImage;
        private Label lblPrice;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnConfirm;
        private Button btnUploadImage;
    }
}