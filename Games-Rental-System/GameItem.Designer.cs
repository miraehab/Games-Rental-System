namespace Games_Rental_System
{
    partial class GameItem
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.TPrice = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.Label();
            this.TAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = global::Games_Rental_System.Properties.Resources._2b589b43ba83e08f8c8f43433a9a6471;
            this.pbPhoto.Location = new System.Drawing.Point(0, 3);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(289, 178);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TPrice
            // 
            this.TPrice.AutoSize = true;
            this.TPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TPrice.ForeColor = System.Drawing.Color.White;
            this.TPrice.Location = new System.Drawing.Point(57, 208);
            this.TPrice.Name = "TPrice";
            this.TPrice.Size = new System.Drawing.Size(37, 21);
            this.TPrice.TabIndex = 2;
            this.TPrice.Text = "10$";
            // 
            // TName
            // 
            this.TName.AutoSize = true;
            this.TName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TName.ForeColor = System.Drawing.Color.White;
            this.TName.Location = new System.Drawing.Point(57, 183);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(135, 25);
            this.TName.TabIndex = 2;
            this.TName.Text = "God Of War";
            this.TName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TAmount
            // 
            this.TAmount.AutoSize = true;
            this.TAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TAmount.ForeColor = System.Drawing.Color.White;
            this.TAmount.Location = new System.Drawing.Point(190, 208);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(60, 21);
            this.TAmount.TabIndex = 2;
            this.TAmount.Text = "10 CDs";
            // 
            // GameItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TName);
            this.Controls.Add(this.TAmount);
            this.Controls.Add(this.TPrice);
            this.Controls.Add(this.pbPhoto);
            this.Name = "GameItem";
            this.Size = new System.Drawing.Size(289, 238);
            this.Click += new System.EventHandler(this.GameItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPhoto;
        private Label TPrice;
        private Button button1;
        private Button button2;
        private Label TName;
        private Label TAmount;
    }
}
