namespace Program05_01
{
    partial class CheckedListForm
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
            this.chlbFood = new System.Windows.Forms.CheckedListBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIndexName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chlbFood
            // 
            this.chlbFood.CheckOnClick = true;
            this.chlbFood.Items.AddRange(new object[] {
            "Beans",
            "Tomatoes"});
            this.chlbFood.Location = new System.Drawing.Point(12, 12);
            this.chlbFood.Name = "chlbFood";
            this.chlbFood.Size = new System.Drawing.Size(436, 157);
            this.chlbFood.TabIndex = 0;
            this.chlbFood.SelectedIndexChanged += new System.EventHandler(this.chlbFood_SelectedIndexChanged);
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(12, 234);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(100, 22);
            this.txtFood.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index Selected:";
            // 
            // lblIndexName
            // 
            this.lblIndexName.AutoSize = true;
            this.lblIndexName.Location = new System.Drawing.Point(127, 281);
            this.lblIndexName.Name = "lblIndexName";
            this.lblIndexName.Size = new System.Drawing.Size(122, 17);
            this.lblIndexName.TabIndex = 5;
            this.lblIndexName.Text = "Index PlaceHolder";
            // 
            // CheckedListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 433);
            this.Controls.Add(this.lblIndexName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.chlbFood);
            this.Name = "CheckedListForm";
            this.Text = "Checked List Form";
            this.Load += new System.EventHandler(this.CheckedListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbFood;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIndexName;
    }
}

