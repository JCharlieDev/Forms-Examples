namespace Program05_04
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
            this.dupFruits = new System.Windows.Forms.DomainUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddFruit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedFruit = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dupFruits
            // 
            this.dupFruits.Location = new System.Drawing.Point(13, 13);
            this.dupFruits.Name = "dupFruits";
            this.dupFruits.Size = new System.Drawing.Size(120, 22);
            this.dupFruits.TabIndex = 0;
            this.dupFruits.Text = "Fruits";
            this.dupFruits.SelectedItemChanged += new System.EventHandler(this.dupFruits_SelectedItemChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Fruit";
            // 
            // txtAddFruit
            // 
            this.txtAddFruit.Location = new System.Drawing.Point(13, 94);
            this.txtAddFruit.Name = "txtAddFruit";
            this.txtAddFruit.Size = new System.Drawing.Size(100, 22);
            this.txtAddFruit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fruit selected:";
            // 
            // lblSelectedFruit
            // 
            this.lblSelectedFruit.AutoSize = true;
            this.lblSelectedFruit.Location = new System.Drawing.Point(113, 173);
            this.lblSelectedFruit.Name = "lblSelectedFruit";
            this.lblSelectedFruit.Size = new System.Drawing.Size(110, 17);
            this.lblSelectedFruit.TabIndex = 5;
            this.lblSelectedFruit.Text = "FruitSelectedPH";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(235, 242);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 306);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSelectedFruit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddFruit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dupFruits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dupFruits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddFruit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedFruit;
        private System.Windows.Forms.Button btnRemove;
    }
}

