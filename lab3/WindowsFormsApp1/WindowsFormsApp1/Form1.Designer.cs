namespace WindowsFormsApp1
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
            this.lblCast = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(127, 85);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(156, 12);
            this.lblCast.TabIndex = 0;
            this.lblCast.Text = "My Choice of Best Movie Series";
            this.lblCast.Click += new System.EventHandler(this.lblCast_Click);
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "the godfather",
            "terminator",
            "back to the future",
            "matrix"});
            this.cboMovie.Location = new System.Drawing.Point(129, 112);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(121, 20);
            this.cboMovie.TabIndex = 1;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(129, 234);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(121, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast Your Vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.lblCast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Button btnCast;
    }
}

