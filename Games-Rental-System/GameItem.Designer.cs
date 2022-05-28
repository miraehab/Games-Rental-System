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
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
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
            // 
            // TPrice
            // 
            this.TPrice.AutoSize = true;
            this.TPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // 
            // TAmount
            // 
            this.TAmount.AutoSize = true;
            this.TAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TAmount.ForeColor = System.Drawing.Color.White;
            this.TAmount.Location = new System.Drawing.Point(185, 208);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(60, 21);
            this.TAmount.TabIndex = 2;
            this.TAmount.Text = "10 CDs";
            // 
            // btnRent
            // 
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(57, 242);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(83, 23);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(162, 242);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // GameItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.TAmount);
            this.Controls.Add(this.TPrice);
            this.Controls.Add(this.pbPhoto);
            this.Name = "GameItem";
            this.Size = new System.Drawing.Size(289, 272);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPhoto;
        private Label TPrice;
        private Label TName;
        private Label TAmount;
        private Button btnRent;
        private Button btnReturn;
    }
}
