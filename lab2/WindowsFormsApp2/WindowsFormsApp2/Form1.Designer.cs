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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sunny = new System.Windows.Forms.RadioButton();
            this.snowy = new System.Windows.Forms.RadioButton();
            this.rainy = new System.Windows.Forms.RadioButton();
            this.cloudy = new System.Windows.Forms.RadioButton();
            this.TN = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.piccloudy = new System.Windows.Forms.PictureBox();
            this.picrainy = new System.Windows.Forms.PictureBox();
            this.picsunny = new System.Windows.Forms.PictureBox();
            this.picsnowy = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsnowy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sunny);
            this.groupBox1.Controls.Add(this.snowy);
            this.groupBox1.Controls.Add(this.rainy);
            this.groupBox1.Controls.Add(this.cloudy);
            this.groupBox1.Location = new System.Drawing.Point(61, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose";
            // 
            // sunny
            // 
            this.sunny.AutoSize = true;
            this.sunny.Location = new System.Drawing.Point(18, 100);
            this.sunny.Name = "sunny";
            this.sunny.Size = new System.Drawing.Size(51, 16);
            this.sunny.TabIndex = 3;
            this.sunny.TabStop = true;
            this.sunny.Text = "sunny";
            this.sunny.UseVisualStyleBackColor = true;
            this.sunny.CheckedChanged += new System.EventHandler(this.sunny_CheckedChanged);
            // 
            // snowy
            // 
            this.snowy.AutoSize = true;
            this.snowy.Location = new System.Drawing.Point(18, 78);
            this.snowy.Name = "snowy";
            this.snowy.Size = new System.Drawing.Size(53, 16);
            this.snowy.TabIndex = 2;
            this.snowy.TabStop = true;
            this.snowy.Text = "snowy";
            this.snowy.UseVisualStyleBackColor = true;
            this.snowy.CheckedChanged += new System.EventHandler(this.snowy_CheckedChanged);
            // 
            // rainy
            // 
            this.rainy.AutoSize = true;
            this.rainy.Location = new System.Drawing.Point(18, 56);
            this.rainy.Name = "rainy";
            this.rainy.Size = new System.Drawing.Size(47, 16);
            this.rainy.TabIndex = 1;
            this.rainy.TabStop = true;
            this.rainy.Text = "rainy";
            this.rainy.UseVisualStyleBackColor = true;
            this.rainy.CheckedChanged += new System.EventHandler(this.rainy_CheckedChanged);
            // 
            // cloudy
            // 
            this.cloudy.AutoSize = true;
            this.cloudy.Location = new System.Drawing.Point(18, 34);
            this.cloudy.Name = "cloudy";
            this.cloudy.Size = new System.Drawing.Size(55, 16);
            this.cloudy.TabIndex = 0;
            this.cloudy.TabStop = true;
            this.cloudy.Text = "cloudy";
            this.cloudy.UseVisualStyleBackColor = true;
            this.cloudy.CheckedChanged += new System.EventHandler(this.cloudy_CheckedChanged);
            // 
            // TN
            // 
            this.TN.Location = new System.Drawing.Point(180, 53);
            this.TN.Name = "TN";
            this.TN.Size = new System.Drawing.Size(201, 22);
            this.TN.TabIndex = 3;
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Message.Location = new System.Drawing.Point(61, 318);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(375, 50);
            this.Message.TabIndex = 4;
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // piccloudy
            // 
            this.piccloudy.Image = global::WindowsFormsApp2.Properties.Resources.cloud316;
            this.piccloudy.Location = new System.Drawing.Point(283, 138);
            this.piccloudy.Name = "piccloudy";
            this.piccloudy.Size = new System.Drawing.Size(64, 64);
            this.piccloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.piccloudy.TabIndex = 5;
            this.piccloudy.TabStop = false;
            this.piccloudy.Visible = false;
            // 
            // picrainy
            // 
            this.picrainy.Image = global::WindowsFormsApp2.Properties.Resources.raindrops2;
            this.picrainy.Location = new System.Drawing.Point(353, 138);
            this.picrainy.Name = "picrainy";
            this.picrainy.Size = new System.Drawing.Size(64, 64);
            this.picrainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picrainy.TabIndex = 6;
            this.picrainy.TabStop = false;
            this.picrainy.Visible = false;
            this.picrainy.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picsunny
            // 
            this.picsunny.Image = global::WindowsFormsApp2.Properties.Resources.sky;
            this.picsunny.Location = new System.Drawing.Point(353, 208);
            this.picsunny.Name = "picsunny";
            this.picsunny.Size = new System.Drawing.Size(64, 64);
            this.picsunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picsunny.TabIndex = 7;
            this.picsunny.TabStop = false;
            this.picsunny.Visible = false;
            // 
            // picsnowy
            // 
            this.picsnowy.Image = global::WindowsFormsApp2.Properties.Resources.snow263;
            this.picsnowy.Location = new System.Drawing.Point(283, 208);
            this.picsnowy.Name = "picsnowy";
            this.picsnowy.Size = new System.Drawing.Size(64, 64);
            this.picsnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picsnowy.TabIndex = 8;
            this.picsnowy.TabStop = false;
            this.picsnowy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 430);
            this.Controls.Add(this.picsnowy);
            this.Controls.Add(this.picsunny);
            this.Controls.Add(this.picrainy);
            this.Controls.Add(this.piccloudy);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.TN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsnowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sunny;
        private System.Windows.Forms.RadioButton snowy;
        private System.Windows.Forms.RadioButton rainy;
        private System.Windows.Forms.RadioButton cloudy;
        private System.Windows.Forms.TextBox TN;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.PictureBox piccloudy;
        private System.Windows.Forms.PictureBox picrainy;
        private System.Windows.Forms.PictureBox picsunny;
        private System.Windows.Forms.PictureBox picsnowy;
    }
}

