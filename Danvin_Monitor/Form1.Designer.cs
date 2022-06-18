namespace Danvin_Monitor
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
            this.components = new System.ComponentModel.Container();
            this.stockTempText = new System.Windows.Forms.RichTextBox();
            this.tempHumidity = new System.Windows.Forms.Label();
            this.outdoorTempText = new System.Windows.Forms.RichTextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.outdoorLabel = new System.Windows.Forms.Label();
            this.copenhagenText = new System.Windows.Forms.RichTextBox();
            this.londonText = new System.Windows.Forms.RichTextBox();
            this.singaporeText = new System.Windows.Forms.RichTextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.stockStatusText = new System.Windows.Forms.Label();
            this.minStockText = new System.Windows.Forms.RichTextBox();
            this.mostSoldText = new System.Windows.Forms.RichTextBox();
            this.maxStockText = new System.Windows.Forms.RichTextBox();
            this.copenhagenLabel = new System.Windows.Forms.Label();
            this.londonLabel = new System.Windows.Forms.Label();
            this.singaporeLabel = new System.Windows.Forms.Label();
            this.minStockLabel = new System.Windows.Forms.Label();
            this.maxStockLabel = new System.Windows.Forms.Label();
            this.mostSoldLabel = new System.Windows.Forms.Label();
            this.clockUpdate = new System.Windows.Forms.Timer(this.components);
            this.update5Min = new System.Windows.Forms.Timer(this.components);
            this.timePassed = new System.Windows.Forms.Timer(this.components);
            this.marqueeTick = new System.Windows.Forms.Timer(this.components);
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.newsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockTempText
            // 
            this.stockTempText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTempText.ForeColor = System.Drawing.Color.White;
            this.stockTempText.Location = new System.Drawing.Point(17, 153);
            this.stockTempText.Name = "stockTempText";
            this.stockTempText.ReadOnly = true;
            this.stockTempText.Size = new System.Drawing.Size(227, 52);
            this.stockTempText.TabIndex = 2;
            this.stockTempText.Text = "";
            // 
            // tempHumidity
            // 
            this.tempHumidity.AutoSize = true;
            this.tempHumidity.BackColor = System.Drawing.Color.Transparent;
            this.tempHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempHumidity.ForeColor = System.Drawing.Color.Red;
            this.tempHumidity.Location = new System.Drawing.Point(7, 9);
            this.tempHumidity.Name = "tempHumidity";
            this.tempHumidity.Size = new System.Drawing.Size(255, 25);
            this.tempHumidity.TabIndex = 3;
            this.tempHumidity.Text = "Temperatur og Fugtighed";
            // 
            // outdoorTempText
            // 
            this.outdoorTempText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outdoorTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorTempText.ForeColor = System.Drawing.Color.White;
            this.outdoorTempText.Location = new System.Drawing.Point(17, 260);
            this.outdoorTempText.Name = "outdoorTempText";
            this.outdoorTempText.ReadOnly = true;
            this.outdoorTempText.Size = new System.Drawing.Size(227, 52);
            this.outdoorTempText.TabIndex = 4;
            this.outdoorTempText.Text = "";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.BackColor = System.Drawing.Color.Transparent;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.ForeColor = System.Drawing.Color.Red;
            this.stockLabel.Location = new System.Drawing.Point(13, 130);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(60, 20);
            this.stockLabel.TabIndex = 5;
            this.stockLabel.Text = "Lager:";
            // 
            // outdoorLabel
            // 
            this.outdoorLabel.AutoSize = true;
            this.outdoorLabel.BackColor = System.Drawing.Color.Transparent;
            this.outdoorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorLabel.ForeColor = System.Drawing.Color.Red;
            this.outdoorLabel.Location = new System.Drawing.Point(13, 236);
            this.outdoorLabel.Name = "outdoorLabel";
            this.outdoorLabel.Size = new System.Drawing.Size(79, 20);
            this.outdoorLabel.TabIndex = 6;
            this.outdoorLabel.Text = "Udenfor:";
            // 
            // copenhagenText
            // 
            this.copenhagenText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copenhagenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copenhagenText.ForeColor = System.Drawing.Color.White;
            this.copenhagenText.Location = new System.Drawing.Point(319, 112);
            this.copenhagenText.Name = "copenhagenText";
            this.copenhagenText.ReadOnly = true;
            this.copenhagenText.Size = new System.Drawing.Size(278, 33);
            this.copenhagenText.TabIndex = 7;
            this.copenhagenText.Text = "";
            // 
            // londonText
            // 
            this.londonText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.londonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonText.ForeColor = System.Drawing.Color.White;
            this.londonText.Location = new System.Drawing.Point(319, 213);
            this.londonText.Name = "londonText";
            this.londonText.ReadOnly = true;
            this.londonText.Size = new System.Drawing.Size(278, 33);
            this.londonText.TabIndex = 8;
            this.londonText.Text = "";
            // 
            // singaporeText
            // 
            this.singaporeText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.singaporeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singaporeText.ForeColor = System.Drawing.Color.White;
            this.singaporeText.Location = new System.Drawing.Point(319, 318);
            this.singaporeText.Name = "singaporeText";
            this.singaporeText.ReadOnly = true;
            this.singaporeText.Size = new System.Drawing.Size(278, 33);
            this.singaporeText.TabIndex = 9;
            this.singaporeText.Text = "";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.Lime;
            this.dateTimeLabel.Location = new System.Drawing.Point(405, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(107, 25);
            this.dateTimeLabel.TabIndex = 10;
            this.dateTimeLabel.Text = "Dato / Tid";
            // 
            // stockStatusText
            // 
            this.stockStatusText.AutoSize = true;
            this.stockStatusText.BackColor = System.Drawing.Color.Transparent;
            this.stockStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockStatusText.ForeColor = System.Drawing.Color.Aqua;
            this.stockStatusText.Location = new System.Drawing.Point(725, 9);
            this.stockStatusText.Name = "stockStatusText";
            this.stockStatusText.Size = new System.Drawing.Size(125, 25);
            this.stockStatusText.TabIndex = 11;
            this.stockStatusText.Text = "Lagerstatus";
            // 
            // minStockText
            // 
            this.minStockText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minStockText.ForeColor = System.Drawing.Color.White;
            this.minStockText.Location = new System.Drawing.Point(657, 65);
            this.minStockText.Name = "minStockText";
            this.minStockText.ReadOnly = true;
            this.minStockText.Size = new System.Drawing.Size(256, 85);
            this.minStockText.TabIndex = 12;
            this.minStockText.Text = "";
            // 
            // mostSoldText
            // 
            this.mostSoldText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mostSoldText.ForeColor = System.Drawing.Color.White;
            this.mostSoldText.Location = new System.Drawing.Point(657, 292);
            this.mostSoldText.Name = "mostSoldText";
            this.mostSoldText.ReadOnly = true;
            this.mostSoldText.Size = new System.Drawing.Size(256, 98);
            this.mostSoldText.TabIndex = 13;
            this.mostSoldText.Text = "";
            // 
            // maxStockText
            // 
            this.maxStockText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maxStockText.ForeColor = System.Drawing.Color.White;
            this.maxStockText.Location = new System.Drawing.Point(657, 181);
            this.maxStockText.Name = "maxStockText";
            this.maxStockText.ReadOnly = true;
            this.maxStockText.Size = new System.Drawing.Size(256, 85);
            this.maxStockText.TabIndex = 14;
            this.maxStockText.Text = "";
            // 
            // copenhagenLabel
            // 
            this.copenhagenLabel.AutoSize = true;
            this.copenhagenLabel.BackColor = System.Drawing.Color.Transparent;
            this.copenhagenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copenhagenLabel.ForeColor = System.Drawing.Color.Lime;
            this.copenhagenLabel.Location = new System.Drawing.Point(315, 89);
            this.copenhagenLabel.Name = "copenhagenLabel";
            this.copenhagenLabel.Size = new System.Drawing.Size(103, 20);
            this.copenhagenLabel.TabIndex = 15;
            this.copenhagenLabel.Text = "København:";
            // 
            // londonLabel
            // 
            this.londonLabel.AutoSize = true;
            this.londonLabel.BackColor = System.Drawing.Color.Transparent;
            this.londonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonLabel.ForeColor = System.Drawing.Color.Lime;
            this.londonLabel.Location = new System.Drawing.Point(315, 190);
            this.londonLabel.Name = "londonLabel";
            this.londonLabel.Size = new System.Drawing.Size(74, 20);
            this.londonLabel.TabIndex = 16;
            this.londonLabel.Text = "London:";
            // 
            // singaporeLabel
            // 
            this.singaporeLabel.AutoSize = true;
            this.singaporeLabel.BackColor = System.Drawing.Color.Transparent;
            this.singaporeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singaporeLabel.ForeColor = System.Drawing.Color.Lime;
            this.singaporeLabel.Location = new System.Drawing.Point(316, 296);
            this.singaporeLabel.Name = "singaporeLabel";
            this.singaporeLabel.Size = new System.Drawing.Size(96, 20);
            this.singaporeLabel.TabIndex = 17;
            this.singaporeLabel.Text = "Singapore:";
            // 
            // minStockLabel
            // 
            this.minStockLabel.AutoSize = true;
            this.minStockLabel.BackColor = System.Drawing.Color.Transparent;
            this.minStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minStockLabel.ForeColor = System.Drawing.Color.Aqua;
            this.minStockLabel.Location = new System.Drawing.Point(653, 42);
            this.minStockLabel.Name = "minStockLabel";
            this.minStockLabel.Size = new System.Drawing.Size(184, 20);
            this.minStockLabel.TabIndex = 18;
            this.minStockLabel.Text = "Varer under minimum:";
            // 
            // maxStockLabel
            // 
            this.maxStockLabel.AutoSize = true;
            this.maxStockLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxStockLabel.ForeColor = System.Drawing.Color.Aqua;
            this.maxStockLabel.Location = new System.Drawing.Point(654, 158);
            this.maxStockLabel.Name = "maxStockLabel";
            this.maxStockLabel.Size = new System.Drawing.Size(181, 20);
            this.maxStockLabel.TabIndex = 19;
            this.maxStockLabel.Text = "Varer over maksimum";
            // 
            // mostSoldLabel
            // 
            this.mostSoldLabel.AutoSize = true;
            this.mostSoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.mostSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostSoldLabel.ForeColor = System.Drawing.Color.Aqua;
            this.mostSoldLabel.Location = new System.Drawing.Point(653, 270);
            this.mostSoldLabel.Name = "mostSoldLabel";
            this.mostSoldLabel.Size = new System.Drawing.Size(151, 20);
            this.mostSoldLabel.TabIndex = 20;
            this.mostSoldLabel.Text = "Mest solgte i dag:";
            // 
            // clockUpdate
            // 
            this.clockUpdate.Enabled = true;
            this.clockUpdate.Tick += new System.EventHandler(this.clockUpdate_Tick);
            // 
            // update5Min
            // 
            this.update5Min.Enabled = true;
            this.update5Min.Interval = 300000;
            this.update5Min.Tick += new System.EventHandler(this.update5Min_Tick);
            // 
            // timePassed
            // 
            this.timePassed.Enabled = true;
            this.timePassed.Interval = 1000;
            // 
            // marqueeTick
            // 
            this.marqueeTick.Enabled = true;
            this.marqueeTick.Interval = 50;
            this.marqueeTick.Tick += new System.EventHandler(this.marqueeTick_Tick);
            // 
            // newsPanel
            // 
            this.newsPanel.BackColor = System.Drawing.Color.Black;
            this.newsPanel.Controls.Add(this.newsLabel);
            this.newsPanel.Location = new System.Drawing.Point(12, 402);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(901, 30);
            this.newsPanel.TabIndex = 21;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.ForeColor = System.Drawing.Color.White;
            this.newsLabel.Location = new System.Drawing.Point(796, 4);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(105, 22);
            this.newsLabel.TabIndex = 0;
            this.newsLabel.Text = "Placeholder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(925, 444);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.mostSoldLabel);
            this.Controls.Add(this.maxStockLabel);
            this.Controls.Add(this.minStockLabel);
            this.Controls.Add(this.singaporeLabel);
            this.Controls.Add(this.londonLabel);
            this.Controls.Add(this.copenhagenLabel);
            this.Controls.Add(this.maxStockText);
            this.Controls.Add(this.mostSoldText);
            this.Controls.Add(this.minStockText);
            this.Controls.Add(this.stockStatusText);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.singaporeText);
            this.Controls.Add(this.londonText);
            this.Controls.Add(this.copenhagenText);
            this.Controls.Add(this.tempHumidity);
            this.Controls.Add(this.outdoorLabel);
            this.Controls.Add(this.stockTempText);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.outdoorTempText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DVI Monitorering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox stockTempText;
        private System.Windows.Forms.Label tempHumidity;
        private System.Windows.Forms.RichTextBox outdoorTempText;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label outdoorLabel;
        private System.Windows.Forms.RichTextBox copenhagenText;
        private System.Windows.Forms.RichTextBox londonText;
        private System.Windows.Forms.RichTextBox singaporeText;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label stockStatusText;
        private System.Windows.Forms.RichTextBox minStockText;
        private System.Windows.Forms.RichTextBox mostSoldText;
        private System.Windows.Forms.RichTextBox maxStockText;
        private System.Windows.Forms.Label copenhagenLabel;
        private System.Windows.Forms.Label londonLabel;
        private System.Windows.Forms.Label singaporeLabel;
        private System.Windows.Forms.Label minStockLabel;
        private System.Windows.Forms.Label maxStockLabel;
        private System.Windows.Forms.Label mostSoldLabel;
        private System.Windows.Forms.Timer clockUpdate;
        private System.Windows.Forms.Timer update5Min;
        private System.Windows.Forms.Timer timePassed;
        private System.Windows.Forms.Timer marqueeTick;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Label newsLabel;
    }
}

