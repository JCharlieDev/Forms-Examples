namespace Exercise1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTotal = new System.Windows.Forms.RadioButton();
            this.rbtnThirdP = new System.Windows.Forms.RadioButton();
            this.rbtnBasic = new System.Windows.Forms.RadioButton();
            this.lblAssurance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkAirCond = new System.Windows.Forms.CheckBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.txtPricing = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTotal);
            this.groupBox1.Controls.Add(this.rbtnThirdP);
            this.groupBox1.Controls.Add(this.rbtnBasic);
            this.groupBox1.Controls.Add(this.lblAssurance);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assurance To Select:";
            // 
            // rbtnTotal
            // 
            this.rbtnTotal.AutoSize = true;
            this.rbtnTotal.Location = new System.Drawing.Point(110, 88);
            this.rbtnTotal.Name = "rbtnTotal";
            this.rbtnTotal.Size = new System.Drawing.Size(61, 21);
            this.rbtnTotal.TabIndex = 3;
            this.rbtnTotal.TabStop = true;
            this.rbtnTotal.Text = "Total";
            this.rbtnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnTotal.UseVisualStyleBackColor = true;
            // 
            // rbtnThirdP
            // 
            this.rbtnThirdP.AutoSize = true;
            this.rbtnThirdP.Location = new System.Drawing.Point(110, 61);
            this.rbtnThirdP.Name = "rbtnThirdP";
            this.rbtnThirdP.Size = new System.Drawing.Size(99, 21);
            this.rbtnThirdP.TabIndex = 2;
            this.rbtnThirdP.TabStop = true;
            this.rbtnThirdP.Text = "Third Party";
            this.rbtnThirdP.UseVisualStyleBackColor = true;
            // 
            // rbtnBasic
            // 
            this.rbtnBasic.AutoSize = true;
            this.rbtnBasic.Checked = true;
            this.rbtnBasic.Location = new System.Drawing.Point(110, 34);
            this.rbtnBasic.Name = "rbtnBasic";
            this.rbtnBasic.Size = new System.Drawing.Size(63, 21);
            this.rbtnBasic.TabIndex = 1;
            this.rbtnBasic.TabStop = true;
            this.rbtnBasic.Text = "Basic";
            this.rbtnBasic.UseVisualStyleBackColor = true;
            // 
            // lblAssurance
            // 
            this.lblAssurance.AutoSize = true;
            this.lblAssurance.Location = new System.Drawing.Point(7, 34);
            this.lblAssurance.Name = "lblAssurance";
            this.lblAssurance.Size = new System.Drawing.Size(79, 17);
            this.lblAssurance.TabIndex = 0;
            this.lblAssurance.Text = "Assurance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAudio);
            this.groupBox2.Controls.Add(this.chkAirCond);
            this.groupBox2.Controls.Add(this.lblEquipment);
            this.groupBox2.Location = new System.Drawing.Point(289, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipement";
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(111, 61);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(66, 21);
            this.chkAudio.TabIndex = 3;
            this.chkAudio.Text = "Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkAirCond
            // 
            this.chkAirCond.AutoSize = true;
            this.chkAirCond.Location = new System.Drawing.Point(111, 34);
            this.chkAirCond.Name = "chkAirCond";
            this.chkAirCond.Size = new System.Drawing.Size(110, 21);
            this.chkAirCond.TabIndex = 2;
            this.chkAirCond.Text = "Air Condition";
            this.chkAirCond.UseVisualStyleBackColor = true;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(6, 34);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(79, 17);
            this.lblEquipment.TabIndex = 1;
            this.lblEquipment.Text = "Equipment:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(9, 264);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(56, 264);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 22);
            this.txtCost.TabIndex = 5;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Location = new System.Drawing.Point(289, 264);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(85, 30);
            this.btnGetPrice.TabIndex = 6;
            this.btnGetPrice.Text = "Calculate";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // txtPricing
            // 
            this.txtPricing.Location = new System.Drawing.Point(12, 326);
            this.txtPricing.Multiline = true;
            this.txtPricing.Name = "txtPricing";
            this.txtPricing.Size = new System.Drawing.Size(556, 173);
            this.txtPricing.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 511);
            this.Controls.Add(this.txtPricing);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Exercise 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTotal;
        private System.Windows.Forms.RadioButton rbtnThirdP;
        private System.Windows.Forms.RadioButton rbtnBasic;
        private System.Windows.Forms.Label lblAssurance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.CheckBox chkAirCond;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.TextBox txtPricing;
    }
}

