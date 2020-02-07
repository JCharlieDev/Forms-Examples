namespace Program05_07
{
    partial class ImageListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageListForm));
            this.imglPictures = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.picbPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imglPictures
            // 
            this.imglPictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglPictures.ImageStream")));
            this.imglPictures.TransparentColor = System.Drawing.Color.Transparent;
            this.imglPictures.Images.SetKeyName(0, "Car100x100.png");
            this.imglPictures.Images.SetKeyName(1, "IPhone100x100.png");
            this.imglPictures.Images.SetKeyName(2, "Laptop100x100.png");
            this.imglPictures.Images.SetKeyName(3, "Me100x100.png");
            this.imglPictures.Images.SetKeyName(4, "SNES100x100.png");
            this.imglPictures.Images.SetKeyName(5, "Bitmap1.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picture:";
            // 
            // lblPicture
            // 
            this.lblPicture.ImageIndex = 0;
            this.lblPicture.ImageList = this.imglPictures;
            this.lblPicture.Location = new System.Drawing.Point(74, 9);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(125, 125);
            this.lblPicture.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(97, 229);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 37);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change Image";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(16, 229);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 37);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // picbPicture
            // 
            this.picbPicture.Location = new System.Drawing.Point(426, 9);
            this.picbPicture.Name = "picbPicture";
            this.picbPicture.Size = new System.Drawing.Size(125, 125);
            this.picbPicture.TabIndex = 5;
            this.picbPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Picture box:";
            // 
            // ImageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbPicture);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.label1);
            this.Name = "ImageListForm";
            this.Text = "ImageList Form";
            this.Load += new System.EventHandler(this.ImageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglPictures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox picbPicture;
        private System.Windows.Forms.Label label3;
    }
}

