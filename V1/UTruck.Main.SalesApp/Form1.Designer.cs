namespace UTruck.Main.SalesApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTruckId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNewTruckMsrp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateGuid = new System.Windows.Forms.Button();
            this.txtNewTruckYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewTruckModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewTruckMake = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewTruckId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTruckId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSell);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(99, 81);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(233, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale Amount";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // txtTruckId
            // 
            this.txtTruckId.Location = new System.Drawing.Point(99, 29);
            this.txtTruckId.Name = "txtTruckId";
            this.txtTruckId.Size = new System.Drawing.Size(233, 20);
            this.txtTruckId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truck ID";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(442, 79);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewTruckMsrp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnGenerateGuid);
            this.groupBox3.Controls.Add(this.txtNewTruckYear);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNewTruckModel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNewTruckMake);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNewTruckId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAddInventory);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 165);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory";
            // 
            // txtNewTruckMsrp
            // 
            this.txtNewTruckMsrp.Location = new System.Drawing.Point(99, 133);
            this.txtNewTruckMsrp.Name = "txtNewTruckMsrp";
            this.txtNewTruckMsrp.Size = new System.Drawing.Size(233, 20);
            this.txtNewTruckMsrp.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "MSRP";
            // 
            // btnGenerateGuid
            // 
            this.btnGenerateGuid.Location = new System.Drawing.Point(338, 27);
            this.btnGenerateGuid.Name = "btnGenerateGuid";
            this.btnGenerateGuid.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateGuid.TabIndex = 9;
            this.btnGenerateGuid.Text = "Generate";
            this.btnGenerateGuid.UseVisualStyleBackColor = true;
            this.btnGenerateGuid.Click += new System.EventHandler(this.btnGenerateGuid_Click);
            // 
            // txtNewTruckYear
            // 
            this.txtNewTruckYear.Location = new System.Drawing.Point(99, 107);
            this.txtNewTruckYear.Name = "txtNewTruckYear";
            this.txtNewTruckYear.Size = new System.Drawing.Size(233, 20);
            this.txtNewTruckYear.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Year";
            // 
            // txtNewTruckModel
            // 
            this.txtNewTruckModel.Location = new System.Drawing.Point(99, 81);
            this.txtNewTruckModel.Name = "txtNewTruckModel";
            this.txtNewTruckModel.Size = new System.Drawing.Size(233, 20);
            this.txtNewTruckModel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model";
            // 
            // txtNewTruckMake
            // 
            this.txtNewTruckMake.Location = new System.Drawing.Point(99, 55);
            this.txtNewTruckMake.Name = "txtNewTruckMake";
            this.txtNewTruckMake.Size = new System.Drawing.Size(233, 20);
            this.txtNewTruckMake.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Make";
            // 
            // txtNewTruckId
            // 
            this.txtNewTruckId.Location = new System.Drawing.Point(99, 29);
            this.txtNewTruckId.Name = "txtNewTruckId";
            this.txtNewTruckId.Size = new System.Drawing.Size(233, 20);
            this.txtNewTruckId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Truck ID";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(442, 131);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 0;
            this.btnAddInventory.Text = "Add";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTruckId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerateGuid;
        private System.Windows.Forms.TextBox txtNewTruckYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewTruckModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewTruckMake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewTruckId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.TextBox txtNewTruckMsrp;
        private System.Windows.Forms.Label label8;
    }
}

