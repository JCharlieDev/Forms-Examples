namespace Program01_04
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
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkKeyboard = new System.Windows.Forms.CheckBox();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.lblPriceTxt = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(43, 64);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(113, 21);
            this.chkMonitor.TabIndex = 0;
            this.chkMonitor.Text = "Monitor $250";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            this.chkMonitor.MouseLeave += new System.EventHandler(this.chkMonitor_MouseLeave);
            this.chkMonitor.MouseHover += new System.EventHandler(this.chkMonitor_MouseHover);
            // 
            // chkKeyboard
            // 
            this.chkKeyboard.AutoSize = true;
            this.chkKeyboard.Location = new System.Drawing.Point(43, 91);
            this.chkKeyboard.Name = "chkKeyboard";
            this.chkKeyboard.Size = new System.Drawing.Size(127, 21);
            this.chkKeyboard.TabIndex = 1;
            this.chkKeyboard.Text = "Keyboard $150";
            this.chkKeyboard.UseVisualStyleBackColor = true;
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.Location = new System.Drawing.Point(43, 118);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(108, 21);
            this.chkMouse.TabIndex = 2;
            this.chkMouse.Text = "Mouse $100";
            this.chkMouse.UseVisualStyleBackColor = true;
            // 
            // lblPriceTxt
            // 
            this.lblPriceTxt.AutoSize = true;
            this.lblPriceTxt.Location = new System.Drawing.Point(40, 230);
            this.lblPriceTxt.Name = "lblPriceTxt";
            this.lblPriceTxt.Size = new System.Drawing.Size(44, 17);
            this.lblPriceTxt.TabIndex = 3;
            this.lblPriceTxt.Text = "Price:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 31);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(91, 230);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 347);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPriceTxt);
            this.Controls.Add(this.chkMouse);
            this.Controls.Add(this.chkKeyboard);
            this.Controls.Add(this.chkMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkKeyboard;
        private System.Windows.Forms.CheckBox chkMouse;
        private System.Windows.Forms.Label lblPriceTxt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPrice;
    }
}

