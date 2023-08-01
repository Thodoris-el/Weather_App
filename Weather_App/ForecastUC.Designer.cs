namespace Weather_App
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWIcon = new System.Windows.Forms.PictureBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbWCondition = new System.Windows.Forms.Label();
            this.lbWDescription = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWIcon
            // 
            this.picWIcon.Location = new System.Drawing.Point(15, 13);
            this.picWIcon.Name = "picWIcon";
            this.picWIcon.Size = new System.Drawing.Size(191, 153);
            this.picWIcon.TabIndex = 0;
            this.picWIcon.TabStop = false;
            this.picWIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.White;
            this.lbDay.Location = new System.Drawing.Point(235, 13);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(57, 35);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Day";
            this.lbDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbWCondition
            // 
            this.lbWCondition.AutoSize = true;
            this.lbWCondition.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWCondition.ForeColor = System.Drawing.Color.White;
            this.lbWCondition.Location = new System.Drawing.Point(235, 96);
            this.lbWCondition.Name = "lbWCondition";
            this.lbWCondition.Size = new System.Drawing.Size(127, 35);
            this.lbWCondition.TabIndex = 3;
            this.lbWCondition.Text = "Condition";
            // 
            // lbWDescription
            // 
            this.lbWDescription.AutoSize = true;
            this.lbWDescription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWDescription.ForeColor = System.Drawing.Color.White;
            this.lbWDescription.Location = new System.Drawing.Point(235, 131);
            this.lbWDescription.Name = "lbWDescription";
            this.lbWDescription.Size = new System.Drawing.Size(146, 35);
            this.lbWDescription.TabIndex = 4;
            this.lbWDescription.Text = "Description";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.White;
            this.lbTemp.Location = new System.Drawing.Point(235, 48);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(161, 35);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "Temparature";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbWDescription);
            this.Controls.Add(this.lbWCondition);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.picWIcon);
            this.DoubleBuffered = true;
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(573, 207);
            this.Load += new System.EventHandler(this.ForecastUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox picWIcon;
        public System.Windows.Forms.Label lbDay;
        public System.Windows.Forms.Label lbWCondition;
        public System.Windows.Forms.Label lbWDescription;
        public System.Windows.Forms.Label lbTemp;
    }
}
