namespace koreklarFORMS.GUI
{
    partial class CustomCarListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCar = new PictureBox();
            lblCarName = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // picCar
            // 
            picCar.Location = new Point(0, 0);
            picCar.Margin = new Padding(4, 5, 4, 5);
            picCar.Name = "picCar";
            picCar.Size = new Size(229, 267);
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            picCar.Click += PicCar_Click;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(0, 272);
            lblCarName.Margin = new Padding(4, 0, 4, 0);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(139, 32);
            lblCarName.TabIndex = 1;
            lblCarName.Text = "lblCarName";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(0, 307);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 32);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "lblPrice";
            // 
            // CustomCarListView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(lblCarName);
            Controls.Add(picCar);
            Margin = new Padding(7, 8, 7, 8);
            Name = "CustomCarListView";
            Size = new Size(229, 350);
            Load += CustomCarListView_Load;
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCar;
        private Label lblCarName;
        private Label lblPrice;
    }
}
