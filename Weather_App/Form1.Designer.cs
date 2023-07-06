namespace Weather_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.lbSunrise = new System.Windows.Forms.Label();
            this.lbSunset = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.picWeather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(332, 252);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(509, 42);
            this.txtCity.TabIndex = 1;
            this.txtCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(888, 249);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.BackColor = System.Drawing.Color.Transparent;
            this.lbCondition.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCondition.ForeColor = System.Drawing.Color.White;
            this.lbCondition.Location = new System.Drawing.Point(214, 507);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(127, 35);
            this.lbCondition.TabIndex = 3;
            this.lbCondition.Text = "Condition";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbDetails.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.Color.White;
            this.lbDetails.Location = new System.Drawing.Point(214, 600);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(91, 35);
            this.lbDetails.TabIndex = 4;
            this.lbDetails.Text = "Details";
            // 
            // lbSunrise
            // 
            this.lbSunrise.AutoSize = true;
            this.lbSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lbSunrise.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunrise.ForeColor = System.Drawing.Color.White;
            this.lbSunrise.Location = new System.Drawing.Point(214, 691);
            this.lbSunrise.Name = "lbSunrise";
            this.lbSunrise.Size = new System.Drawing.Size(157, 35);
            this.lbSunrise.TabIndex = 5;
            this.lbSunrise.Text = "Sunrise: N/A";
            this.lbSunrise.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSunset
            // 
            this.lbSunset.AutoSize = true;
            this.lbSunset.BackColor = System.Drawing.Color.Transparent;
            this.lbSunset.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunset.ForeColor = System.Drawing.Color.White;
            this.lbSunset.Location = new System.Drawing.Point(214, 779);
            this.lbSunset.Name = "lbSunset";
            this.lbSunset.Size = new System.Drawing.Size(150, 35);
            this.lbSunset.TabIndex = 6;
            this.lbSunset.Text = "Sunset: N/A";
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.BackColor = System.Drawing.Color.Transparent;
            this.lbWind.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWind.ForeColor = System.Drawing.Color.White;
            this.lbWind.Location = new System.Drawing.Point(958, 507);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(211, 35);
            this.lbWind.TabIndex = 7;
            this.lbWind.Text = "Wind Speed: N/A";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.BackColor = System.Drawing.Color.Transparent;
            this.lbPressure.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPressure.ForeColor = System.Drawing.Color.White;
            this.lbPressure.Location = new System.Drawing.Point(958, 600);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(172, 35);
            this.lbPressure.TabIndex = 8;
            this.lbPressure.Text = "Pressure: N/A";
            // 
            // picWeather
            // 
            this.picWeather.BackColor = System.Drawing.Color.Transparent;
            this.picWeather.Location = new System.Drawing.Point(226, 353);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(202, 141);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeather.TabIndex = 9;
            this.picWeather.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1222);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.lbSunset);
            this.Controls.Add(this.lbSunrise);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Label lbSunrise;
        private System.Windows.Forms.Label lbSunset;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.PictureBox picWeather;
    }
}

