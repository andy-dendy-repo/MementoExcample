namespace MementoExcample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btBackup = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.btHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMain.Location = new System.Drawing.Point(149, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(394, 234);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(330, 297);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(75, 23);
            this.btBackup.TabIndex = 1;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(249, 297);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(75, 23);
            this.btLeft.TabIndex = 3;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Controls.Add(this.rbSquare);
            this.groupBox1.Location = new System.Drawing.Point(539, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figures";
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(73, 28);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(55, 19);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Checked = true;
            this.rbSquare.Location = new System.Drawing.Point(6, 28);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(61, 19);
            this.rbSquare.TabIndex = 0;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // btHistory
            // 
            this.btHistory.Location = new System.Drawing.Point(21, 290);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(118, 55);
            this.btHistory.TabIndex = 5;
            this.btHistory.Text = "History";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 373);
            this.Controls.Add(this.btHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.pbMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbMain;
        private Button btBackup;
        private Button btLeft;
        private GroupBox groupBox1;
        private RadioButton rbCircle;
        private RadioButton rbSquare;
        private Button btHistory;
    }
}