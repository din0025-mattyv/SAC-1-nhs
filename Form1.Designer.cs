namespace SofDev_SAC_task_ONE
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
            this.updAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPriceLab = new System.Windows.Forms.Label();
            this.lblTotLab = new System.Windows.Forms.Label();
            this.lblCollectPrice = new System.Windows.Forms.Label();
            this.lblSingPrice = new System.Windows.Forms.Label();
            this.btnEndQuote = new System.Windows.Forms.Button();
            this.txtPaidVal = new System.Windows.Forms.TextBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblAgeErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updAge)).BeginInit();
            this.SuspendLayout();
            // 
            // updAge
            // 
            this.updAge.Location = new System.Drawing.Point(77, 78);
            this.updAge.Name = "updAge";
            this.updAge.Size = new System.Drawing.Size(120, 26);
            this.updAge.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(74, 55);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(182, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "How old is the textbook?";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(71, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(211, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "How much did you pay for it?";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(76, 222);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPriceLab
            // 
            this.lblPriceLab.AutoSize = true;
            this.lblPriceLab.Location = new System.Drawing.Point(535, 88);
            this.lblPriceLab.Name = "lblPriceLab";
            this.lblPriceLab.Size = new System.Drawing.Size(165, 20);
            this.lblPriceLab.TabIndex = 5;
            this.lblPriceLab.Text = "This textbook is worth:";
            // 
            // lblTotLab
            // 
            this.lblTotLab.AutoSize = true;
            this.lblTotLab.Location = new System.Drawing.Point(537, 142);
            this.lblTotLab.Name = "lblTotLab";
            this.lblTotLab.Size = new System.Drawing.Size(170, 20);
            this.lblTotLab.TabIndex = 6;
            this.lblTotLab.Text = "This collection is worth:";
            // 
            // lblCollectPrice
            // 
            this.lblCollectPrice.AutoSize = true;
            this.lblCollectPrice.Location = new System.Drawing.Point(539, 180);
            this.lblCollectPrice.Name = "lblCollectPrice";
            this.lblCollectPrice.Size = new System.Drawing.Size(24, 20);
            this.lblCollectPrice.TabIndex = 7;
            this.lblCollectPrice.Text = "---";
            // 
            // lblSingPrice
            // 
            this.lblSingPrice.AutoSize = true;
            this.lblSingPrice.Location = new System.Drawing.Point(539, 116);
            this.lblSingPrice.Name = "lblSingPrice";
            this.lblSingPrice.Size = new System.Drawing.Size(24, 20);
            this.lblSingPrice.TabIndex = 8;
            this.lblSingPrice.Text = "---";
            // 
            // btnEndQuote
            // 
            this.btnEndQuote.Location = new System.Drawing.Point(542, 204);
            this.btnEndQuote.Name = "btnEndQuote";
            this.btnEndQuote.Size = new System.Drawing.Size(108, 55);
            this.btnEndQuote.TabIndex = 9;
            this.btnEndQuote.Text = "End Quote";
            this.btnEndQuote.UseVisualStyleBackColor = true;
            this.btnEndQuote.Click += new System.EventHandler(this.btnEndQuote_Click);
            // 
            // txtPaidVal
            // 
            this.txtPaidVal.Location = new System.Drawing.Point(74, 160);
            this.txtPaidVal.Name = "txtPaidVal";
            this.txtPaidVal.Size = new System.Drawing.Size(120, 26);
            this.txtPaidVal.TabIndex = 10;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(72, 192);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(24, 20);
            this.lblErr.TabIndex = 11;
            this.lblErr.Text = "---";
            // 
            // lblAgeErr
            // 
            this.lblAgeErr.AutoSize = true;
            this.lblAgeErr.Location = new System.Drawing.Point(75, 112);
            this.lblAgeErr.Name = "lblAgeErr";
            this.lblAgeErr.Size = new System.Drawing.Size(24, 20);
            this.lblAgeErr.TabIndex = 12;
            this.lblAgeErr.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAgeErr);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.txtPaidVal);
            this.Controls.Add(this.btnEndQuote);
            this.Controls.Add(this.lblSingPrice);
            this.Controls.Add(this.lblCollectPrice);
            this.Controls.Add(this.lblTotLab);
            this.Controls.Add(this.lblPriceLab);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.updAge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.updAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPriceLab;
        private System.Windows.Forms.Label lblTotLab;
        private System.Windows.Forms.Label lblCollectPrice;
        private System.Windows.Forms.Label lblSingPrice;
        private System.Windows.Forms.Button btnEndQuote;
        private System.Windows.Forms.TextBox txtPaidVal;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Label lblAgeErr;
    }
}

