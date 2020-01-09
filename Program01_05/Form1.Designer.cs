namespace Program01_05
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.gboxOperations = new System.Windows.Forms.GroupBox();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.lblTxtResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gboxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(45, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(45, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(212, 37);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 40);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 17);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 69);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 17);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B:";
            // 
            // gboxOperations
            // 
            this.gboxOperations.Controls.Add(this.rbDiv);
            this.gboxOperations.Controls.Add(this.rbMult);
            this.gboxOperations.Controls.Add(this.rbSub);
            this.gboxOperations.Controls.Add(this.rbSum);
            this.gboxOperations.Location = new System.Drawing.Point(15, 121);
            this.gboxOperations.Name = "gboxOperations";
            this.gboxOperations.Size = new System.Drawing.Size(200, 150);
            this.gboxOperations.TabIndex = 5;
            this.gboxOperations.TabStop = false;
            this.gboxOperations.Text = "Operations";
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(7, 103);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(75, 21);
            this.rbDiv.TabIndex = 3;
            this.rbDiv.Text = "Divition";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.Location = new System.Drawing.Point(6, 76);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(110, 21);
            this.rbMult.TabIndex = 2;
            this.rbMult.Text = "Multiplication";
            this.rbMult.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Location = new System.Drawing.Point(7, 49);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(54, 21);
            this.rbSub.TabIndex = 1;
            this.rbSub.Text = "Sub";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Checked = true;
            this.rbSum.Location = new System.Drawing.Point(7, 22);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(57, 21);
            this.rbSum.TabIndex = 0;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Sum";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // lblTxtResult
            // 
            this.lblTxtResult.AutoSize = true;
            this.lblTxtResult.Location = new System.Drawing.Point(12, 293);
            this.lblTxtResult.Name = "lblTxtResult";
            this.lblTxtResult.Size = new System.Drawing.Size(52, 17);
            this.lblTxtResult.TabIndex = 6;
            this.lblTxtResult.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(70, 293);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 337);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTxtResult);
            this.Controls.Add(this.gboxOperations);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "RadioButton & GroupBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxOperations.ResumeLayout(false);
            this.gboxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.GroupBox gboxOperations;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.Label lblTxtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

