namespace Program05_08
{
    partial class ListViewForm
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
            this.lstvFood = new System.Windows.Forms.ListView();
            this.txtAddElement = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFruits = new System.Windows.Forms.RadioButton();
            this.rbtnMeats = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvFood
            // 
            this.lstvFood.HideSelection = false;
            this.lstvFood.Location = new System.Drawing.Point(13, 13);
            this.lstvFood.Name = "lstvFood";
            this.lstvFood.Size = new System.Drawing.Size(491, 216);
            this.lstvFood.TabIndex = 0;
            this.lstvFood.UseCompatibleStateImageBehavior = false;
            // 
            // txtAddElement
            // 
            this.txtAddElement.Location = new System.Drawing.Point(12, 349);
            this.txtAddElement.Name = "txtAddElement";
            this.txtAddElement.Size = new System.Drawing.Size(100, 22);
            this.txtAddElement.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMeats);
            this.groupBox1.Controls.Add(this.rbtnFruits);
            this.groupBox1.Location = new System.Drawing.Point(13, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groups";
            // 
            // rbtnFruits
            // 
            this.rbtnFruits.AutoSize = true;
            this.rbtnFruits.Checked = true;
            this.rbtnFruits.Location = new System.Drawing.Point(7, 22);
            this.rbtnFruits.Name = "rbtnFruits";
            this.rbtnFruits.Size = new System.Drawing.Size(64, 21);
            this.rbtnFruits.TabIndex = 0;
            this.rbtnFruits.TabStop = true;
            this.rbtnFruits.Text = "Fruits";
            this.rbtnFruits.UseVisualStyleBackColor = true;
            // 
            // rbtnMeats
            // 
            this.rbtnMeats.AutoSize = true;
            this.rbtnMeats.Checked = true;
            this.rbtnMeats.Location = new System.Drawing.Point(7, 49);
            this.rbtnMeats.Name = "rbtnMeats";
            this.rbtnMeats.Size = new System.Drawing.Size(67, 21);
            this.rbtnMeats.TabIndex = 1;
            this.rbtnMeats.TabStop = true;
            this.rbtnMeats.Text = "Meats";
            this.rbtnMeats.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddElement);
            this.Controls.Add(this.lstvFood);
            this.Name = "ListViewForm";
            this.Text = "ListView Form";
            this.Load += new System.EventHandler(this.ListViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvFood;
        private System.Windows.Forms.TextBox txtAddElement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMeats;
        private System.Windows.Forms.RadioButton rbtnFruits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

