namespace AdvertApplication
{
    partial class AdvertAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertAdd));
            this.RDSale = new System.Windows.Forms.RadioButton();
            this.RDRent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDRooms = new System.Windows.Forms.NumericUpDown();
            this.NUDFloor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDArea = new System.Windows.Forms.NumericUpDown();
            this.RBApartment = new System.Windows.Forms.RadioButton();
            this.RBGarden = new System.Windows.Forms.RadioButton();
            this.RBDublex = new System.Windows.Forms.RadioButton();
            this.RBSparate = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBRentPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBDeposit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBSalePrice = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.DPConstructionDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lblGuestPricee = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RDSale
            // 
            this.RDSale.AutoSize = true;
            this.RDSale.Location = new System.Drawing.Point(84, 30);
            this.RDSale.Name = "RDSale";
            this.RDSale.Size = new System.Drawing.Size(57, 21);
            this.RDSale.TabIndex = 0;
            this.RDSale.TabStop = true;
            this.RDSale.Text = "Sale";
            this.RDSale.UseVisualStyleBackColor = true;
            this.RDSale.CheckedChanged += new System.EventHandler(this.RDSale_CheckedChanged);
            // 
            // RDRent
            // 
            this.RDRent.AutoSize = true;
            this.RDRent.Location = new System.Drawing.Point(156, 30);
            this.RDRent.Name = "RDRent";
            this.RDRent.Size = new System.Drawing.Size(59, 21);
            this.RDRent.TabIndex = 1;
            this.RDRent.TabStop = true;
            this.RDRent.Text = "Rent";
            this.RDRent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rooms :";
            // 
            // NUDRooms
            // 
            this.NUDRooms.Location = new System.Drawing.Point(153, 69);
            this.NUDRooms.Name = "NUDRooms";
            this.NUDRooms.Size = new System.Drawing.Size(43, 22);
            this.NUDRooms.TabIndex = 4;
            this.NUDRooms.ValueChanged += new System.EventHandler(this.NUDRooms_ValueChanged);
            // 
            // NUDFloor
            // 
            this.NUDFloor.Location = new System.Drawing.Point(153, 119);
            this.NUDFloor.Name = "NUDFloor";
            this.NUDFloor.Size = new System.Drawing.Size(43, 22);
            this.NUDFloor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Floor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "City :";
            // 
            // CBCity
            // 
            this.CBCity.FormattingEnabled = true;
            this.CBCity.Location = new System.Drawing.Point(153, 163);
            this.CBCity.Name = "CBCity";
            this.CBCity.Size = new System.Drawing.Size(121, 24);
            this.CBCity.TabIndex = 8;
            this.CBCity.SelectedIndexChanged += new System.EventHandler(this.CBCity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "State :";
            // 
            // CBState
            // 
            this.CBState.FormattingEnabled = true;
            this.CBState.Location = new System.Drawing.Point(153, 213);
            this.CBState.Name = "CBState";
            this.CBState.Size = new System.Drawing.Size(121, 24);
            this.CBState.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Area :";
            // 
            // NUDArea
            // 
            this.NUDArea.Location = new System.Drawing.Point(156, 270);
            this.NUDArea.Name = "NUDArea";
            this.NUDArea.Size = new System.Drawing.Size(43, 22);
            this.NUDArea.TabIndex = 12;
            // 
            // RBApartment
            // 
            this.RBApartment.AutoSize = true;
            this.RBApartment.Location = new System.Drawing.Point(0, 0);
            this.RBApartment.Name = "RBApartment";
            this.RBApartment.Size = new System.Drawing.Size(94, 21);
            this.RBApartment.TabIndex = 13;
            this.RBApartment.TabStop = true;
            this.RBApartment.Text = "Apartment";
            this.RBApartment.UseVisualStyleBackColor = true;
            // 
            // RBGarden
            // 
            this.RBGarden.AutoSize = true;
            this.RBGarden.Location = new System.Drawing.Point(135, 0);
            this.RBGarden.Name = "RBGarden";
            this.RBGarden.Size = new System.Drawing.Size(109, 21);
            this.RBGarden.TabIndex = 14;
            this.RBGarden.TabStop = true;
            this.RBGarden.Text = "With Garden";
            this.RBGarden.UseVisualStyleBackColor = true;
            // 
            // RBDublex
            // 
            this.RBDublex.AutoSize = true;
            this.RBDublex.Location = new System.Drawing.Point(0, 27);
            this.RBDublex.Name = "RBDublex";
            this.RBDublex.Size = new System.Drawing.Size(72, 21);
            this.RBDublex.TabIndex = 15;
            this.RBDublex.TabStop = true;
            this.RBDublex.Text = "Dublex";
            this.RBDublex.UseVisualStyleBackColor = true;
            // 
            // RBSparate
            // 
            this.RBSparate.AutoSize = true;
            this.RBSparate.Location = new System.Drawing.Point(135, 27);
            this.RBSparate.Name = "RBSparate";
            this.RBSparate.Size = new System.Drawing.Size(79, 21);
            this.RBSparate.TabIndex = 16;
            this.RBSparate.TabStop = true;
            this.RBSparate.Text = "Sparate";
            this.RBSparate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "House Type :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBApartment);
            this.panel1.Controls.Add(this.RBDublex);
            this.panel1.Controls.Add(this.RBSparate);
            this.panel1.Controls.Add(this.RBGarden);
            this.panel1.Location = new System.Drawing.Point(156, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 54);
            this.panel1.TabIndex = 18;
            // 
            // CBActive
            // 
            this.CBActive.AutoSize = true;
            this.CBActive.Location = new System.Drawing.Point(156, 484);
            this.CBActive.Name = "CBActive";
            this.CBActive.Size = new System.Drawing.Size(68, 21);
            this.CBActive.TabIndex = 19;
            this.CBActive.Text = "Active";
            this.CBActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Rent Price :";
            // 
            // TBRentPrice
            // 
            this.TBRentPrice.Location = new System.Drawing.Point(156, 595);
            this.TBRentPrice.Name = "TBRentPrice";
            this.TBRentPrice.Size = new System.Drawing.Size(124, 22);
            this.TBRentPrice.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Deposit :";
            // 
            // TBDeposit
            // 
            this.TBDeposit.Location = new System.Drawing.Point(156, 540);
            this.TBDeposit.Name = "TBDeposit";
            this.TBDeposit.Size = new System.Drawing.Size(124, 22);
            this.TBDeposit.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sale Price :";
            // 
            // TBSalePrice
            // 
            this.TBSalePrice.Location = new System.Drawing.Point(156, 540);
            this.TBSalePrice.Name = "TBSalePrice";
            this.TBSalePrice.Size = new System.Drawing.Size(124, 22);
            this.TBSalePrice.TabIndex = 26;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.Location = new System.Drawing.Point(29, 708);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(371, 81);
            this.ButtonAdd.TabIndex = 27;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DPConstructionDate
            // 
            this.DPConstructionDate.Location = new System.Drawing.Point(156, 423);
            this.DPConstructionDate.Name = "DPConstructionDate";
            this.DPConstructionDate.Size = new System.Drawing.Size(200, 22);
            this.DPConstructionDate.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Construction Date :";
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.Location = new System.Drawing.Point(290, 708);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(110, 81);
            this.btnArchive.TabIndex = 30;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Visible = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lblGuestPricee
            // 
            this.lblGuestPricee.AutoSize = true;
            this.lblGuestPricee.Location = new System.Drawing.Point(12, 653);
            this.lblGuestPricee.Name = "lblGuestPricee";
            this.lblGuestPricee.Size = new System.Drawing.Size(95, 17);
            this.lblGuestPricee.TabIndex = 31;
            this.lblGuestPricee.Text = "Tahmini Kira: ";
            this.lblGuestPricee.Visible = false;
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Location = new System.Drawing.Point(153, 653);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(0, 17);
            this.lblPriceCost.TabIndex = 32;
            // 
            // AdvertAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 801);
            this.Controls.Add(this.lblPriceCost);
            this.Controls.Add(this.lblGuestPricee);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DPConstructionDate);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TBSalePrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBDeposit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBRentPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBActive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NUDArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDFloor);
            this.Controls.Add(this.NUDRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RDRent);
            this.Controls.Add(this.RDSale);
            this.Name = "AdvertAdd";
            this.Text = "AdvertAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvertAdd_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdvertAdd_FormClosed);
            this.Load += new System.EventHandler(this.AdvertAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RDSale;
        private System.Windows.Forms.RadioButton RDRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDRooms;
        private System.Windows.Forms.NumericUpDown NUDFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDArea;
        private System.Windows.Forms.RadioButton RBApartment;
        private System.Windows.Forms.RadioButton RBGarden;
        private System.Windows.Forms.RadioButton RBDublex;
        private System.Windows.Forms.RadioButton RBSparate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBRentPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBDeposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBSalePrice;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DateTimePicker DPConstructionDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lblGuestPricee;
        private System.Windows.Forms.Label lblPriceCost;
    }
}