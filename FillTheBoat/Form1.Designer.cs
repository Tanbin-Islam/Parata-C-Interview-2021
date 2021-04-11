
namespace FillTheBoat
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
            this.sldMC = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.sldT = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sldC = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.sldTC = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMCCount = new System.Windows.Forms.Label();
            this.lblTCount = new System.Windows.Forms.Label();
            this.lblCCount = new System.Windows.Forms.Label();
            this.lblTCCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sldMC
            // 
            this.sldMC.Location = new System.Drawing.Point(70, 251);
            this.sldMC.Name = "sldMC";
            this.sldMC.Size = new System.Drawing.Size(212, 17);
            this.sldMC.TabIndex = 0;
            this.sldMC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldMC_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor Cycle(3 units)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sldT
            // 
            this.sldT.Location = new System.Drawing.Point(452, 251);
            this.sldT.Name = "sldT";
            this.sldT.Size = new System.Drawing.Size(212, 17);
            this.sldT.TabIndex = 0;
            this.sldT.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldT_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(449, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trucks(11 units)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sldC
            // 
            this.sldC.Location = new System.Drawing.Point(67, 344);
            this.sldC.Name = "sldC";
            this.sldC.Size = new System.Drawing.Size(212, 17);
            this.sldC.TabIndex = 0;
            this.sldC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldC_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Car(5 units)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sldTC
            // 
            this.sldTC.Location = new System.Drawing.Point(452, 344);
            this.sldTC.Name = "sldTC";
            this.sldTC.Size = new System.Drawing.Size(212, 17);
            this.sldTC.TabIndex = 0;
            this.sldTC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldTC_Scroll);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(449, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Train Car(17 units)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMCCount
            // 
            this.lblMCCount.AutoSize = true;
            this.lblMCCount.Location = new System.Drawing.Point(67, 223);
            this.lblMCCount.Name = "lblMCCount";
            this.lblMCCount.Size = new System.Drawing.Size(13, 13);
            this.lblMCCount.TabIndex = 2;
            this.lblMCCount.Text = "0";
            // 
            // lblTCount
            // 
            this.lblTCount.AutoSize = true;
            this.lblTCount.Location = new System.Drawing.Point(449, 223);
            this.lblTCount.Name = "lblTCount";
            this.lblTCount.Size = new System.Drawing.Size(13, 13);
            this.lblTCount.TabIndex = 2;
            this.lblTCount.Text = "0";
            // 
            // lblCCount
            // 
            this.lblCCount.AutoSize = true;
            this.lblCCount.Location = new System.Drawing.Point(67, 321);
            this.lblCCount.Name = "lblCCount";
            this.lblCCount.Size = new System.Drawing.Size(13, 13);
            this.lblCCount.TabIndex = 2;
            this.lblCCount.Text = "0";
            // 
            // lblTCCount
            // 
            this.lblTCCount.AutoSize = true;
            this.lblTCCount.Location = new System.Drawing.Point(449, 321);
            this.lblTCCount.Name = "lblTCCount";
            this.lblTCCount.Size = new System.Drawing.Size(13, 13);
            this.lblTCCount.TabIndex = 2;
            this.lblTCCount.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 174);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(330, 35);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 52);
            this.progressBar1.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(330, 108);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(152, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Capacity : 239, current load : 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "New Boat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTCCount);
            this.Controls.Add(this.lblCCount);
            this.Controls.Add(this.lblTCount);
            this.Controls.Add(this.lblMCCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sldTC);
            this.Controls.Add(this.sldC);
            this.Controls.Add(this.sldT);
            this.Controls.Add(this.sldMC);
            this.Name = "Form1";
            this.Text = "Fill The boat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar sldMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar sldT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar sldC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar sldTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMCCount;
        private System.Windows.Forms.Label lblTCount;
        private System.Windows.Forms.Label lblCCount;
        private System.Windows.Forms.Label lblTCCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}

