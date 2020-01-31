namespace Program03_01
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVariableA = new System.Windows.Forms.TextBox();
            this.cmnuTxtVarA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randNumbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVariableB = new System.Windows.Forms.TextBox();
            this.cmnuTxtVarB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cleanStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.randNumbStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tstOperations = new System.Windows.Forms.ToolStrip();
            this.tstBtnSum = new System.Windows.Forms.ToolStripButton();
            this.tstBtnSub = new System.Windows.Forms.ToolStripButton();
            this.tstBtnMult = new System.Windows.Forms.ToolStripButton();
            this.tstBtnDiv = new System.Windows.Forms.ToolStripButton();
            this.stsInformation = new System.Windows.Forms.StatusStrip();
            this.slblValues = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.cmnuTxtVarA.SuspendLayout();
            this.cmnuTxtVarB.SuspendLayout();
            this.tstOperations.SuspendLayout();
            this.stsInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the application.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumToolStripMenuItem,
            this.substractionToolStripMenuItem,
            this.multiplicationToolStripMenuItem,
            this.divitionToolStripMenuItem,
            this.toolStripSeparator1,
            this.enableToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.AutoToolTip = true;
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.sumToolStripMenuItem.Text = "Sum";
            this.sumToolStripMenuItem.ToolTipText = "Enables Sum between variables.";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // substractionToolStripMenuItem
            // 
            this.substractionToolStripMenuItem.Name = "substractionToolStripMenuItem";
            this.substractionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.substractionToolStripMenuItem.Text = "Substraction";
            this.substractionToolStripMenuItem.Click += new System.EventHandler(this.substractionToolStripMenuItem_Click);
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.multiplicationToolStripMenuItem.Text = "Multiplication";
            this.multiplicationToolStripMenuItem.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // divitionToolStripMenuItem
            // 
            this.divitionToolStripMenuItem.Name = "divitionToolStripMenuItem";
            this.divitionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.divitionToolStripMenuItem.Text = "Divition";
            this.divitionToolStripMenuItem.Click += new System.EventHandler(this.divitionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Checked = true;
            this.enableToolStripMenuItem.CheckOnClick = true;
            this.enableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtVariableA
            // 
            this.txtVariableA.ContextMenuStrip = this.cmnuTxtVarA;
            this.txtVariableA.Location = new System.Drawing.Point(40, 70);
            this.txtVariableA.Name = "txtVariableA";
            this.txtVariableA.Size = new System.Drawing.Size(100, 22);
            this.txtVariableA.TabIndex = 1;
            this.txtVariableA.Text = "0";
            this.txtVariableA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmnuTxtVarA
            // 
            this.cmnuTxtVarA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuTxtVarA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanToolStripMenuItem,
            this.randNumbToolStripMenuItem});
            this.cmnuTxtVarA.Name = "cmnuTxtVarA";
            this.cmnuTxtVarA.Size = new System.Drawing.Size(158, 52);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // randNumbToolStripMenuItem
            // 
            this.randNumbToolStripMenuItem.Name = "randNumbToolStripMenuItem";
            this.randNumbToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.randNumbToolStripMenuItem.Text = "Rand Numb";
            this.randNumbToolStripMenuItem.Click += new System.EventHandler(this.randNumbToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // txtVariableB
            // 
            this.txtVariableB.ContextMenuStrip = this.cmnuTxtVarB;
            this.txtVariableB.Location = new System.Drawing.Point(40, 98);
            this.txtVariableB.Name = "txtVariableB";
            this.txtVariableB.Size = new System.Drawing.Size(100, 22);
            this.txtVariableB.TabIndex = 3;
            this.txtVariableB.Text = "0";
            this.txtVariableB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmnuTxtVarB
            // 
            this.cmnuTxtVarB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuTxtVarB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanStripMenuItem1,
            this.randNumbStripMenuItem2});
            this.cmnuTxtVarB.Name = "cmnuTxtVarA";
            this.cmnuTxtVarB.Size = new System.Drawing.Size(158, 52);
            // 
            // cleanStripMenuItem1
            // 
            this.cleanStripMenuItem1.Name = "cleanStripMenuItem1";
            this.cleanStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.cleanStripMenuItem1.Text = "Clean";
            this.cleanStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // randNumbStripMenuItem2
            // 
            this.randNumbStripMenuItem2.Name = "randNumbStripMenuItem2";
            this.randNumbStripMenuItem2.Size = new System.Drawing.Size(157, 24);
            this.randNumbStripMenuItem2.Text = "Rand Numb";
            this.randNumbStripMenuItem2.Click += new System.EventHandler(this.randNumbStripMenuItem2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(71, 168);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tstOperations
            // 
            this.tstOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstBtnSum,
            this.tstBtnSub,
            this.tstBtnMult,
            this.tstBtnDiv});
            this.tstOperations.Location = new System.Drawing.Point(0, 28);
            this.tstOperations.Name = "tstOperations";
            this.tstOperations.Size = new System.Drawing.Size(487, 27);
            this.tstOperations.TabIndex = 8;
            this.tstOperations.Text = "toolStrip1";
            // 
            // tstBtnSum
            // 
            this.tstBtnSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstBtnSum.Image = ((System.Drawing.Image)(resources.GetObject("tstBtnSum.Image")));
            this.tstBtnSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBtnSum.Name = "tstBtnSum";
            this.tstBtnSum.Size = new System.Drawing.Size(29, 24);
            this.tstBtnSum.Text = "Sum";
            this.tstBtnSum.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // tstBtnSub
            // 
            this.tstBtnSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstBtnSub.Image = ((System.Drawing.Image)(resources.GetObject("tstBtnSub.Image")));
            this.tstBtnSub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBtnSub.Name = "tstBtnSub";
            this.tstBtnSub.Size = new System.Drawing.Size(29, 24);
            this.tstBtnSub.Text = "Substraction";
            this.tstBtnSub.Click += new System.EventHandler(this.substractionToolStripMenuItem_Click);
            // 
            // tstBtnMult
            // 
            this.tstBtnMult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstBtnMult.Image = ((System.Drawing.Image)(resources.GetObject("tstBtnMult.Image")));
            this.tstBtnMult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBtnMult.Name = "tstBtnMult";
            this.tstBtnMult.Size = new System.Drawing.Size(29, 24);
            this.tstBtnMult.Text = "Multiplication";
            this.tstBtnMult.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // tstBtnDiv
            // 
            this.tstBtnDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstBtnDiv.Image = ((System.Drawing.Image)(resources.GetObject("tstBtnDiv.Image")));
            this.tstBtnDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBtnDiv.Name = "tstBtnDiv";
            this.tstBtnDiv.Size = new System.Drawing.Size(29, 24);
            this.tstBtnDiv.Text = "Divition";
            this.tstBtnDiv.Click += new System.EventHandler(this.divitionToolStripMenuItem_Click);
            // 
            // stsInformation
            // 
            this.stsInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblValues,
            this.slblOperation,
            this.slblResult});
            this.stsInformation.Location = new System.Drawing.Point(0, 248);
            this.stsInformation.Name = "stsInformation";
            this.stsInformation.Size = new System.Drawing.Size(487, 30);
            this.stsInformation.TabIndex = 9;
            this.stsInformation.Text = "statusStrip1";
            // 
            // slblValues
            // 
            this.slblValues.AutoSize = false;
            this.slblValues.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblValues.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblValues.Name = "slblValues";
            this.slblValues.Size = new System.Drawing.Size(120, 24);
            this.slblValues.Text = "A = 0, B = 0";
            // 
            // slblOperation
            // 
            this.slblOperation.AutoSize = false;
            this.slblOperation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblOperation.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblOperation.Name = "slblOperation";
            this.slblOperation.Size = new System.Drawing.Size(150, 24);
            this.slblOperation.Text = "Operation: ";
            // 
            // slblResult
            // 
            this.slblResult.AutoSize = false;
            this.slblResult.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblResult.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblResult.Name = "slblResult";
            this.slblResult.Size = new System.Drawing.Size(100, 24);
            this.slblResult.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status Information";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 278);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stsInformation);
            this.Controls.Add(this.tstOperations);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVariableB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariableA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Menu Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmnuTxtVarA.ResumeLayout(false);
            this.cmnuTxtVarB.ResumeLayout(false);
            this.tstOperations.ResumeLayout(false);
            this.tstOperations.PerformLayout();
            this.stsInformation.ResumeLayout(false);
            this.stsInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtVariableA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVariableB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnuTxtVarA;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randNumbToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tstOperations;
        private System.Windows.Forms.ToolStripButton tstBtnSum;
        private System.Windows.Forms.ToolStripButton tstBtnSub;
        private System.Windows.Forms.ToolStripButton tstBtnMult;
        private System.Windows.Forms.ToolStripButton tstBtnDiv;
        private System.Windows.Forms.ContextMenuStrip cmnuTxtVarB;
        private System.Windows.Forms.ToolStripMenuItem cleanStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randNumbStripMenuItem2;
        private System.Windows.Forms.StatusStrip stsInformation;
        private System.Windows.Forms.ToolStripStatusLabel slblValues;
        private System.Windows.Forms.ToolStripStatusLabel slblOperation;
        private System.Windows.Forms.ToolStripStatusLabel slblResult;
        private System.Windows.Forms.Label label4;
    }
}

