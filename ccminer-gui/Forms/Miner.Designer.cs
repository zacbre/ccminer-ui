namespace ccminer_gui
{
    partial class Miner
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.algorithmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poolUrlBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.intensityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpuStatsBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idleBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.totalHashrateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalSharesLabel = new System.Windows.Forms.Label();
            this.acceptedSharesLabel = new System.Windows.Forms.Label();
            this.staleSharesLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.blockLabel = new System.Windows.Forms.Label();
            this.stratumDifficultyLabel = new System.Windows.Forms.Label();
            this.blockDifficultyLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gpuStatsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // algorithmBox
            // 
            this.algorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmBox.FormattingEnabled = true;
            this.algorithmBox.Location = new System.Drawing.Point(12, 25);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(206, 21);
            this.algorithmBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 69);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(370, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(388, 69);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(145, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // poolUrlBox
            // 
            this.poolUrlBox.Location = new System.Drawing.Point(12, 113);
            this.poolUrlBox.Name = "poolUrlBox";
            this.poolUrlBox.Size = new System.Drawing.Size(521, 20);
            this.poolUrlBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pool URL:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(459, 144);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // intensityBox
            // 
            this.intensityBox.Location = new System.Drawing.Point(224, 25);
            this.intensityBox.Name = "intensityBox";
            this.intensityBox.Size = new System.Drawing.Size(158, 20);
            this.intensityBox.TabIndex = 9;
            this.intensityBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intensity: (Default 0 for Auto)";
            // 
            // gpuStatsBox
            // 
            this.gpuStatsBox.Location = new System.Drawing.Point(388, 25);
            this.gpuStatsBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.gpuStatsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gpuStatsBox.Name = "gpuStatsBox";
            this.gpuStatsBox.Size = new System.Drawing.Size(146, 20);
            this.gpuStatsBox.TabIndex = 11;
            this.gpuStatsBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GPU Stats: (in seconds)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(49, 149);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Stopped.";
            // 
            // idleBox
            // 
            this.idleBox.AutoSize = true;
            this.idleBox.Location = new System.Drawing.Point(315, 148);
            this.idleBox.Name = "idleBox";
            this.idleBox.Size = new System.Drawing.Size(138, 17);
            this.idleBox.TabIndex = 16;
            this.idleBox.Text = "Only run while PC is idle";
            this.idleBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 575);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 119);
            this.listBox1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Hashrate:";
            // 
            // totalHashrateLabel
            // 
            this.totalHashrateLabel.AutoSize = true;
            this.totalHashrateLabel.Location = new System.Drawing.Point(105, 173);
            this.totalHashrateLabel.Name = "totalHashrateLabel";
            this.totalHashrateLabel.Size = new System.Drawing.Size(41, 13);
            this.totalHashrateLabel.TabIndex = 19;
            this.totalHashrateLabel.Text = "0 KH/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Shares:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Accepted Shares:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Stale Shares:";
            // 
            // totalSharesLabel
            // 
            this.totalSharesLabel.AutoSize = true;
            this.totalSharesLabel.Location = new System.Drawing.Point(432, 173);
            this.totalSharesLabel.Name = "totalSharesLabel";
            this.totalSharesLabel.Size = new System.Drawing.Size(13, 13);
            this.totalSharesLabel.TabIndex = 23;
            this.totalSharesLabel.Text = "0";
            // 
            // acceptedSharesLabel
            // 
            this.acceptedSharesLabel.AutoSize = true;
            this.acceptedSharesLabel.Location = new System.Drawing.Point(432, 191);
            this.acceptedSharesLabel.Name = "acceptedSharesLabel";
            this.acceptedSharesLabel.Size = new System.Drawing.Size(13, 13);
            this.acceptedSharesLabel.TabIndex = 24;
            this.acceptedSharesLabel.Text = "0";
            // 
            // staleSharesLabel
            // 
            this.staleSharesLabel.AutoSize = true;
            this.staleSharesLabel.Location = new System.Drawing.Point(432, 209);
            this.staleSharesLabel.Name = "staleSharesLabel";
            this.staleSharesLabel.Size = new System.Drawing.Size(13, 13);
            this.staleSharesLabel.TabIndex = 25;
            this.staleSharesLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Stratum Difficulty:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Block Difficulty:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(105, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Block:";
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Location = new System.Drawing.Point(148, 149);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(13, 13);
            this.blockLabel.TabIndex = 29;
            this.blockLabel.Text = "0";
            // 
            // stratumDifficultyLabel
            // 
            this.stratumDifficultyLabel.AutoSize = true;
            this.stratumDifficultyLabel.Location = new System.Drawing.Point(105, 191);
            this.stratumDifficultyLabel.Name = "stratumDifficultyLabel";
            this.stratumDifficultyLabel.Size = new System.Drawing.Size(13, 13);
            this.stratumDifficultyLabel.TabIndex = 30;
            this.stratumDifficultyLabel.Text = "0";
            // 
            // blockDifficultyLabel
            // 
            this.blockDifficultyLabel.AutoSize = true;
            this.blockDifficultyLabel.Location = new System.Drawing.Point(105, 209);
            this.blockDifficultyLabel.Name = "blockDifficultyLabel";
            this.blockDifficultyLabel.Size = new System.Drawing.Size(13, 13);
            this.blockDifficultyLabel.TabIndex = 31;
            this.blockDifficultyLabel.Text = "0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BorderColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 225);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(546, 170);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // chartTimer
            // 
            this.chartTimer.Enabled = true;
            this.chartTimer.Interval = 60000;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BorderColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.SystemColors.Control;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(0, 401);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(546, 170);
            this.chart2.TabIndex = 33;
            this.chart2.Text = "chart2";
            // 
            // Miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 694);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.blockDifficultyLabel);
            this.Controls.Add(this.stratumDifficultyLabel);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.staleSharesLabel);
            this.Controls.Add(this.acceptedSharesLabel);
            this.Controls.Add(this.totalSharesLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalHashrateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idleBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpuStatsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.intensityBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.poolUrlBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algorithmBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Miner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCMiner GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Miner_FormClosing);
            this.Load += new System.EventHandler(this.Miner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpuStatsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poolUrlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox intensityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown gpuStatsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox idleBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalHashrateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalSharesLabel;
        private System.Windows.Forms.Label acceptedSharesLabel;
        private System.Windows.Forms.Label staleSharesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label stratumDifficultyLabel;
        private System.Windows.Forms.Label blockDifficultyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

