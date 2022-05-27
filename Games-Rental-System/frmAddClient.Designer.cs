namespace Games_Rental_System
{
    partial class frmAddClient
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
            this.inpClientPhone = new System.Windows.Forms.TextBox();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inpClientFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inpClientSecondName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_name.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpClientPhone
            // 
            this.inpClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientPhone.Location = new System.Drawing.Point(4, 4);
            this.inpClientPhone.Name = "inpClientPhone";
            this.inpClientPhone.Size = new System.Drawing.Size(277, 23);
            this.inpClientPhone.TabIndex = 15;
            this.inpClientPhone.Text = "Enter Client Phone Number";
            this.inpClientPhone.Click += new System.EventHandler(this.inpClientPhone_Click);
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.inpClientPhone);
            this.pnl_name.Controls.Add(this.panel2);
            this.pnl_name.Location = new System.Drawing.Point(371, 98);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(283, 46);
            this.pnl_name.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(4, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 1);
            this.panel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(217)))), ((int)(((byte)(205)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(315, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Phone";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inpClientFirstName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(371, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 46);
            this.panel1.TabIndex = 1;
            // 
            // inpClientFirstName
            // 
            this.inpClientFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientFirstName.Location = new System.Drawing.Point(4, 4);
            this.inpClientFirstName.Name = "inpClientFirstName";
            this.inpClientFirstName.Size = new System.Drawing.Size(277, 23);
            this.inpClientFirstName.TabIndex = 18;
            this.inpClientFirstName.Text = "Enter Client First Name";
            this.inpClientFirstName.Click += new System.EventHandler(this.inpClientFirstName_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 1);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client First Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inpClientSecondName);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(371, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 46);
            this.panel4.TabIndex = 2;
            // 
            // inpClientSecondName
            // 
            this.inpClientSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientSecondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientSecondName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientSecondName.Location = new System.Drawing.Point(4, 4);
            this.inpClientSecondName.Name = "inpClientSecondName";
            this.inpClientSecondName.Size = new System.Drawing.Size(277, 23);
            this.inpClientSecondName.TabIndex = 19;
            this.inpClientSecondName.Text = "Enter Client Second Name";
            this.inpClientSecondName.Click += new System.EventHandler(this.inpClientSecondName_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(4, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 1);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Second Name";
            // 
            // frmAddClient
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(920, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddClient";
            this.Text = "frmContactUs";
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inpClientPhone;
        private Panel pnl_name;
        private Panel panel2;
        private Button btnAdd;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private TextBox inpClientFirstName;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private TextBox inpClientSecondName;
        private Label label3;
    }
}