namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(57, 40);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 12);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(57, 76);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(63, 24);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate\r\n(Annual)";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(137, 37);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(137, 78);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 3;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(67, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(57, 164);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(74, 24);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value after 10 \r\nyears";
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(57, 214);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(74, 24);
            this.lblMillion.TabIndex = 6;
            this.lblMillion.Text = "Years to reach \r\n$1M";
            // 
            // lblValue2
            // 
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Location = new System.Drawing.Point(150, 169);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(100, 23);
            this.lblValue2.TabIndex = 7;
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(150, 214);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(100, 23);
            this.lblMillion2.TabIndex = 8;
            this.lblMillion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Compound Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMillion;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblMillion2;
    }
}

