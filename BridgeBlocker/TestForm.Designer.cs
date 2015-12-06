﻿namespace BridgeDistribution
{
	partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pLeftPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAggressive = new System.Windows.Forms.RadioButton();
            this.rbStochastic = new System.Windows.Forms.RadioButton();
            this.lStochastic = new System.Windows.Forms.Label();
            this.rbPrudent = new System.Windows.Forms.RadioButton();
            this.tbStochastic = new System.Windows.Forms.TrackBar();
            this.llPlotSettings = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lBadCount = new System.Windows.Forms.Label();
            this.tbBadCount = new System.Windows.Forms.TrackBar();
            this.lUserCount = new System.Windows.Forms.Label();
            this.tbUserCount = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBnb = new System.Windows.Forms.RadioButton();
            this.rbMatrix = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lc = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbGridView = new System.Windows.Forms.RadioButton();
            this.rbPlot = new System.Windows.Forms.RadioButton();
            this.splitterLeft = new System.Windows.Forms.Splitter();
            this.splitterRight = new System.Windows.Forms.Splitter();
            this.pRightPanel = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbLogY = new System.Windows.Forms.CheckBox();
            this.cbLogX = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGridY = new System.Windows.Forms.CheckBox();
            this.cboGridX = new System.Windows.Forms.CheckBox();
            this.lMarkerStep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBadCountMax = new System.Windows.Forms.Label();
            this.tbMarkerStep = new System.Windows.Forms.TrackBar();
            this.tbBadCountMax = new System.Windows.Forms.TrackBar();
            this.cbmm = new System.Windows.Forms.CheckBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbN = new System.Windows.Forms.CheckBox();
            this.cbb = new System.Windows.Forms.CheckBox();
            this.cbThirsty = new System.Windows.Forms.CheckBox();
            this.cbm = new System.Windows.Forms.CheckBox();
            this.rbMultipleRuns = new System.Windows.Forms.RadioButton();
            this.rbSingleRun = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.pOutputPanel = new System.Windows.Forms.Panel();
            this.chPlots = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.col_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mclogn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_bigN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCollapseButtonRight = new System.Windows.Forms.Panel();
            this.btnCollapseRight = new System.Windows.Forms.Button();
            this.pCollapseButtonLeft = new System.Windows.Forms.Panel();
            this.btnCollapseLeft = new System.Windows.Forms.Button();
            this.pLeftPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStochastic)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pRightPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkerStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBadCountMax)).BeginInit();
            this.pOutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chPlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.pCollapseButtonRight.SuspendLayout();
            this.pCollapseButtonLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeftPanel
            // 
            this.pLeftPanel.Controls.Add(this.groupBox1);
            this.pLeftPanel.Controls.Add(this.llPlotSettings);
            this.pLeftPanel.Controls.Add(this.groupBox3);
            this.pLeftPanel.Controls.Add(this.groupBox2);
            this.pLeftPanel.Controls.Add(this.btnStart);
            this.pLeftPanel.Controls.Add(this.groupBox5);
            this.pLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.pLeftPanel.MinimumSize = new System.Drawing.Size(270, 500);
            this.pLeftPanel.Name = "pLeftPanel";
            this.pLeftPanel.Size = new System.Drawing.Size(298, 638);
            this.pLeftPanel.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbAggressive);
            this.groupBox1.Controls.Add(this.rbStochastic);
            this.groupBox1.Controls.Add(this.lStochastic);
            this.groupBox1.Controls.Add(this.rbPrudent);
            this.groupBox1.Controls.Add(this.tbStochastic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Censor Strategy";
            // 
            // rbAggressive
            // 
            this.rbAggressive.AutoSize = true;
            this.rbAggressive.Checked = true;
            this.rbAggressive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAggressive.Location = new System.Drawing.Point(12, 29);
            this.rbAggressive.Name = "rbAggressive";
            this.rbAggressive.Size = new System.Drawing.Size(98, 22);
            this.rbAggressive.TabIndex = 2;
            this.rbAggressive.TabStop = true;
            this.rbAggressive.Text = "Aggressive";
            this.rbAggressive.UseVisualStyleBackColor = true;
            // 
            // rbStochastic
            // 
            this.rbStochastic.AutoSize = true;
            this.rbStochastic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStochastic.Location = new System.Drawing.Point(12, 59);
            this.rbStochastic.Name = "rbStochastic";
            this.rbStochastic.Size = new System.Drawing.Size(100, 22);
            this.rbStochastic.TabIndex = 3;
            this.rbStochastic.Text = "Stochastic:";
            this.rbStochastic.UseVisualStyleBackColor = true;
            this.rbStochastic.CheckedChanged += new System.EventHandler(this.rbStochastic_CheckedChanged);
            // 
            // lStochastic
            // 
            this.lStochastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStochastic.AutoSize = true;
            this.lStochastic.Enabled = false;
            this.lStochastic.Location = new System.Drawing.Point(117, 81);
            this.lStochastic.Name = "lStochastic";
            this.lStochastic.Size = new System.Drawing.Size(69, 18);
            this.lStochastic.TabIndex = 6;
            this.lStochastic.Text = "p = 0.800";
            // 
            // rbPrudent
            // 
            this.rbPrudent.AutoSize = true;
            this.rbPrudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrudent.Location = new System.Drawing.Point(155, 29);
            this.rbPrudent.Name = "rbPrudent";
            this.rbPrudent.Size = new System.Drawing.Size(77, 22);
            this.rbPrudent.TabIndex = 3;
            this.rbPrudent.Text = "Prudent";
            this.rbPrudent.UseVisualStyleBackColor = true;
            // 
            // tbStochastic
            // 
            this.tbStochastic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStochastic.Enabled = false;
            this.tbStochastic.LargeChange = 2;
            this.tbStochastic.Location = new System.Drawing.Point(6, 102);
            this.tbStochastic.Maximum = 40;
            this.tbStochastic.Minimum = 16;
            this.tbStochastic.Name = "tbStochastic";
            this.tbStochastic.Size = new System.Drawing.Size(273, 45);
            this.tbStochastic.TabIndex = 5;
            this.tbStochastic.Value = 32;
            this.tbStochastic.ValueChanged += new System.EventHandler(this.tbStochastic_ValueChanged);
            // 
            // llPlotSettings
            // 
            this.llPlotSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llPlotSettings.AutoSize = true;
            this.llPlotSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPlotSettings.Location = new System.Drawing.Point(177, 518);
            this.llPlotSettings.Name = "llPlotSettings";
            this.llPlotSettings.Size = new System.Drawing.Size(129, 18);
            this.llPlotSettings.TabIndex = 7;
            this.llPlotSettings.TabStop = true;
            this.llPlotSettings.Text = "Show plot settings";
            this.llPlotSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPlotSettings_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lBadCount);
            this.groupBox3.Controls.Add(this.tbBadCount);
            this.groupBox3.Controls.Add(this.lUserCount);
            this.groupBox3.Controls.Add(this.tbUserCount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 153);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Size";
            // 
            // lBadCount
            // 
            this.lBadCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBadCount.AutoSize = true;
            this.lBadCount.Location = new System.Drawing.Point(118, 82);
            this.lBadCount.Name = "lBadCount";
            this.lBadCount.Size = new System.Drawing.Size(45, 18);
            this.lBadCount.TabIndex = 6;
            this.lBadCount.Text = "t = 32";
            // 
            // tbBadCount
            // 
            this.tbBadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadCount.LargeChange = 2;
            this.tbBadCount.Location = new System.Drawing.Point(6, 104);
            this.tbBadCount.Maximum = 63;
            this.tbBadCount.Minimum = 1;
            this.tbBadCount.Name = "tbBadCount";
            this.tbBadCount.Size = new System.Drawing.Size(273, 45);
            this.tbBadCount.TabIndex = 5;
            this.tbBadCount.Value = 32;
            this.tbBadCount.ValueChanged += new System.EventHandler(this.tbT_ValueChanged);
            // 
            // lUserCount
            // 
            this.lUserCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lUserCount.AutoSize = true;
            this.lUserCount.Location = new System.Drawing.Point(118, 22);
            this.lUserCount.Name = "lUserCount";
            this.lUserCount.Size = new System.Drawing.Size(49, 18);
            this.lUserCount.TabIndex = 6;
            this.lUserCount.Text = "n = 64";
            // 
            // tbUserCount
            // 
            this.tbUserCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserCount.LargeChange = 2;
            this.tbUserCount.Location = new System.Drawing.Point(6, 42);
            this.tbUserCount.Maximum = 20;
            this.tbUserCount.Minimum = 3;
            this.tbUserCount.Name = "tbUserCount";
            this.tbUserCount.Size = new System.Drawing.Size(273, 45);
            this.tbUserCount.TabIndex = 5;
            this.tbUserCount.Value = 6;
            this.tbUserCount.ValueChanged += new System.EventHandler(this.tbN_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbBnb);
            this.groupBox2.Controls.Add(this.rbMatrix);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distributor Algorithm";
            // 
            // rbBnb
            // 
            this.rbBnb.AutoSize = true;
            this.rbBnb.Checked = true;
            this.rbBnb.Location = new System.Drawing.Point(12, 37);
            this.rbBnb.Name = "rbBnb";
            this.rbBnb.Size = new System.Drawing.Size(119, 22);
            this.rbBnb.TabIndex = 2;
            this.rbBnb.TabStop = true;
            this.rbBnb.Text = "Balls and Bins";
            this.rbBnb.UseVisualStyleBackColor = true;
            // 
            // rbMatrix
            // 
            this.rbMatrix.AutoSize = true;
            this.rbMatrix.Location = new System.Drawing.Point(157, 37);
            this.rbMatrix.Name = "rbMatrix";
            this.rbMatrix.Size = new System.Drawing.Size(66, 22);
            this.rbMatrix.TabIndex = 3;
            this.rbMatrix.Text = "Matrix";
            this.rbMatrix.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(27, 593);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(245, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lc);
            this.groupBox5.Controls.Add(this.tbC);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Repeats";
            // 
            // lc
            // 
            this.lc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lc.AutoSize = true;
            this.lc.Location = new System.Drawing.Point(118, 20);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(41, 18);
            this.lc.TabIndex = 20;
            this.lc.Text = "c = 1";
            // 
            // tbC
            // 
            this.tbC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbC.LargeChange = 2;
            this.tbC.Location = new System.Drawing.Point(6, 41);
            this.tbC.Maximum = 20;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(273, 45);
            this.tbC.TabIndex = 7;
            this.tbC.Value = 1;
            this.tbC.ValueChanged += new System.EventHandler(this.tbC_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rbGridView);
            this.groupBox4.Controls.Add(this.rbPlot);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 72);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // rbGridView
            // 
            this.rbGridView.AutoSize = true;
            this.rbGridView.Location = new System.Drawing.Point(152, 31);
            this.rbGridView.Name = "rbGridView";
            this.rbGridView.Size = new System.Drawing.Size(89, 22);
            this.rbGridView.TabIndex = 2;
            this.rbGridView.Text = "Grid View";
            this.rbGridView.UseVisualStyleBackColor = true;
            // 
            // rbPlot
            // 
            this.rbPlot.AutoSize = true;
            this.rbPlot.Location = new System.Drawing.Point(20, 31);
            this.rbPlot.Name = "rbPlot";
            this.rbPlot.Size = new System.Drawing.Size(52, 22);
            this.rbPlot.TabIndex = 3;
            this.rbPlot.Text = "Plot";
            this.rbPlot.UseVisualStyleBackColor = true;
            this.rbPlot.CheckedChanged += new System.EventHandler(this.rbPlot_CheckedChanged);
            // 
            // splitterLeft
            // 
            this.splitterLeft.Location = new System.Drawing.Point(298, 0);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(3, 638);
            this.splitterLeft.TabIndex = 0;
            this.splitterLeft.TabStop = false;
            // 
            // splitterRight
            // 
            this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight.Location = new System.Drawing.Point(1046, 0);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(3, 638);
            this.splitterRight.TabIndex = 16;
            this.splitterRight.TabStop = false;
            // 
            // pRightPanel
            // 
            this.pRightPanel.Controls.Add(this.groupBox6);
            this.pRightPanel.Controls.Add(this.btnSave);
            this.pRightPanel.Controls.Add(this.groupBox4);
            this.pRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRightPanel.Location = new System.Drawing.Point(1049, 0);
            this.pRightPanel.Name = "pRightPanel";
            this.pRightPanel.Size = new System.Drawing.Size(280, 638);
            this.pRightPanel.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.cbLogY);
            this.groupBox6.Controls.Add(this.cbLogX);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cboGridY);
            this.groupBox6.Controls.Add(this.cboGridX);
            this.groupBox6.Controls.Add(this.lMarkerStep);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.lBadCountMax);
            this.groupBox6.Controls.Add(this.tbMarkerStep);
            this.groupBox6.Controls.Add(this.tbBadCountMax);
            this.groupBox6.Controls.Add(this.cbmm);
            this.groupBox6.Controls.Add(this.cbTime);
            this.groupBox6.Controls.Add(this.cbN);
            this.groupBox6.Controls.Add(this.cbb);
            this.groupBox6.Controls.Add(this.cbThirsty);
            this.groupBox6.Controls.Add(this.cbm);
            this.groupBox6.Controls.Add(this.rbMultipleRuns);
            this.groupBox6.Controls.Add(this.rbSingleRun);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 496);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Plot Settings";
            // 
            // cbLogY
            // 
            this.cbLogY.AutoSize = true;
            this.cbLogY.Location = new System.Drawing.Point(176, 458);
            this.cbLogY.Name = "cbLogY";
            this.cbLogY.Size = new System.Drawing.Size(36, 22);
            this.cbLogY.TabIndex = 23;
            this.cbLogY.Text = "Y";
            this.cbLogY.UseVisualStyleBackColor = true;
            this.cbLogY.CheckedChanged += new System.EventHandler(this.cbLogY_CheckedChanged);
            // 
            // cbLogX
            // 
            this.cbLogX.AutoSize = true;
            this.cbLogX.Location = new System.Drawing.Point(82, 458);
            this.cbLogX.Name = "cbLogX";
            this.cbLogX.Size = new System.Drawing.Size(37, 22);
            this.cbLogX.TabIndex = 22;
            this.cbLogX.Text = "X";
            this.cbLogX.UseVisualStyleBackColor = true;
            this.cbLogX.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Log axis:";
            // 
            // cboGridY
            // 
            this.cboGridY.AutoSize = true;
            this.cboGridY.Location = new System.Drawing.Point(82, 430);
            this.cboGridY.Name = "cboGridY";
            this.cboGridY.Size = new System.Drawing.Size(95, 22);
            this.cboGridY.TabIndex = 20;
            this.cboGridY.Text = "Horizontal";
            this.cboGridY.UseVisualStyleBackColor = true;
            this.cboGridY.CheckedChanged += new System.EventHandler(this.cboGridY_CheckedChanged);
            // 
            // cboGridX
            // 
            this.cboGridX.AutoSize = true;
            this.cboGridX.Location = new System.Drawing.Point(176, 430);
            this.cboGridX.Name = "cboGridX";
            this.cboGridX.Size = new System.Drawing.Size(75, 22);
            this.cboGridX.TabIndex = 20;
            this.cboGridX.Text = "Vertical";
            this.cboGridX.UseVisualStyleBackColor = true;
            this.cboGridX.CheckedChanged += new System.EventHandler(this.cboGridX_CheckedChanged);
            // 
            // lMarkerStep
            // 
            this.lMarkerStep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMarkerStep.AutoSize = true;
            this.lMarkerStep.Location = new System.Drawing.Point(80, 355);
            this.lMarkerStep.Name = "lMarkerStep";
            this.lMarkerStep.Size = new System.Drawing.Size(142, 18);
            this.lMarkerStep.TabIndex = 19;
            this.lMarkerStep.Text = "Plot marker step = 1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Grid:";
            // 
            // lBadCountMax
            // 
            this.lBadCountMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lBadCountMax.AutoSize = true;
            this.lBadCountMax.Enabled = false;
            this.lBadCountMax.Location = new System.Drawing.Point(94, 290);
            this.lBadCountMax.Name = "lBadCountMax";
            this.lBadCountMax.Size = new System.Drawing.Size(81, 18);
            this.lBadCountMax.TabIndex = 19;
            this.lBadCountMax.Text = "t_max = 32";
            // 
            // tbMarkerStep
            // 
            this.tbMarkerStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarkerStep.LargeChange = 2;
            this.tbMarkerStep.Location = new System.Drawing.Point(25, 380);
            this.tbMarkerStep.Maximum = 20;
            this.tbMarkerStep.Name = "tbMarkerStep";
            this.tbMarkerStep.Size = new System.Drawing.Size(221, 45);
            this.tbMarkerStep.TabIndex = 18;
            this.tbMarkerStep.Value = 1;
            this.tbMarkerStep.ValueChanged += new System.EventHandler(this.tbMarkerStep_ValueChanged);
            // 
            // tbBadCountMax
            // 
            this.tbBadCountMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBadCountMax.Enabled = false;
            this.tbBadCountMax.LargeChange = 2;
            this.tbBadCountMax.Location = new System.Drawing.Point(25, 315);
            this.tbBadCountMax.Maximum = 63;
            this.tbBadCountMax.Minimum = 1;
            this.tbBadCountMax.Name = "tbBadCountMax";
            this.tbBadCountMax.Size = new System.Drawing.Size(221, 45);
            this.tbBadCountMax.TabIndex = 18;
            this.tbBadCountMax.Value = 32;
            this.tbBadCountMax.ValueChanged += new System.EventHandler(this.tbBadCountMax_ValueChanged);
            // 
            // cbmm
            // 
            this.cbmm.AutoSize = true;
            this.cbmm.Checked = true;
            this.cbmm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmm.Location = new System.Drawing.Point(32, 258);
            this.cbmm.Name = "cbmm";
            this.cbmm.Size = new System.Drawing.Size(148, 22);
            this.cbmm.TabIndex = 12;
            this.cbmm.Text = "Total bridges used";
            this.cbmm.UseVisualStyleBackColor = true;
            this.cbmm.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Checked = true;
            this.cbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.Location = new System.Drawing.Point(32, 228);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(113, 22);
            this.cbTime.TabIndex = 13;
            this.cbTime.Text = "Running time";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbN
            // 
            this.cbN.AutoSize = true;
            this.cbN.Checked = true;
            this.cbN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbN.Location = new System.Drawing.Point(32, 159);
            this.cbN.Name = "cbN";
            this.cbN.Size = new System.Drawing.Size(113, 22);
            this.cbN.TabIndex = 14;
            this.cbN.Text = "Bridges used";
            this.cbN.UseVisualStyleBackColor = true;
            this.cbN.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbb
            // 
            this.cbb.AutoSize = true;
            this.cbb.Checked = true;
            this.cbb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb.Location = new System.Drawing.Point(32, 129);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(133, 22);
            this.cbb.TabIndex = 15;
            this.cbb.Text = "Blocked bridges";
            this.cbb.UseVisualStyleBackColor = true;
            this.cbb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbThirsty
            // 
            this.cbThirsty.AutoSize = true;
            this.cbThirsty.Checked = true;
            this.cbThirsty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThirsty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThirsty.Location = new System.Drawing.Point(32, 69);
            this.cbThirsty.Name = "cbThirsty";
            this.cbThirsty.Size = new System.Drawing.Size(112, 22);
            this.cbThirsty.TabIndex = 16;
            this.cbThirsty.Text = "Thirsty users";
            this.cbThirsty.UseVisualStyleBackColor = true;
            this.cbThirsty.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbm
            // 
            this.cbm.AutoSize = true;
            this.cbm.Checked = true;
            this.cbm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm.Location = new System.Drawing.Point(32, 99);
            this.cbm.Name = "cbm";
            this.cbm.Size = new System.Drawing.Size(148, 22);
            this.cbm.TabIndex = 17;
            this.cbm.Text = "Bridges distributed";
            this.cbm.UseVisualStyleBackColor = true;
            this.cbm.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // rbMultipleRuns
            // 
            this.rbMultipleRuns.AutoSize = true;
            this.rbMultipleRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultipleRuns.Location = new System.Drawing.Point(11, 196);
            this.rbMultipleRuns.Name = "rbMultipleRuns";
            this.rbMultipleRuns.Size = new System.Drawing.Size(269, 22);
            this.rbMultipleRuns.TabIndex = 10;
            this.rbMultipleRuns.Text = "Multiple run (variable # corrupt users)";
            this.rbMultipleRuns.UseVisualStyleBackColor = true;
            this.rbMultipleRuns.CheckedChanged += new System.EventHandler(this.rbMultipleRuns_CheckedChanged);
            // 
            // rbSingleRun
            // 
            this.rbSingleRun.AutoSize = true;
            this.rbSingleRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingleRun.Location = new System.Drawing.Point(11, 37);
            this.rbSingleRun.Name = "rbSingleRun";
            this.rbSingleRun.Size = new System.Drawing.Size(239, 22);
            this.rbSingleRun.TabIndex = 11;
            this.rbSingleRun.Text = "Single run (fixed # corrupt users)";
            this.rbSingleRun.UseVisualStyleBackColor = true;
            this.rbSingleRun.CheckedChanged += new System.EventHandler(this.rbSingleRun_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(27, 593);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Plot";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pOutputPanel
            // 
            this.pOutputPanel.Controls.Add(this.chPlots);
            this.pOutputPanel.Controls.Add(this.dgvStats);
            this.pOutputPanel.Controls.Add(this.pCollapseButtonRight);
            this.pOutputPanel.Controls.Add(this.pCollapseButtonLeft);
            this.pOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOutputPanel.Location = new System.Drawing.Point(301, 0);
            this.pOutputPanel.Name = "pOutputPanel";
            this.pOutputPanel.Size = new System.Drawing.Size(745, 638);
            this.pOutputPanel.TabIndex = 17;
            // 
            // chPlots
            // 
            this.chPlots.BorderlineColor = System.Drawing.Color.Black;
            this.chPlots.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chPlots.ChartAreas.Add(chartArea1);
            this.chPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chPlots.Legends.Add(legend1);
            this.chPlots.Location = new System.Drawing.Point(15, 0);
            this.chPlots.Name = "chPlots";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chPlots.Series.Add(series1);
            this.chPlots.Size = new System.Drawing.Size(715, 638);
            this.chPlots.TabIndex = 18;
            this.chPlots.Text = "chart1";
            this.chPlots.Visible = false;
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AllowUserToResizeRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_i,
            this.col_n,
            this.col_t,
            this.col_m,
            this.col_mclogn,
            this.col_b,
            this.col_bigN,
            this.col_th});
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.EnableHeadersVisualStyles = false;
            this.dgvStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStats.Location = new System.Drawing.Point(15, 0);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStats.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStats.RowTemplate.Height = 25;
            this.dgvStats.RowTemplate.ReadOnly = true;
            this.dgvStats.Size = new System.Drawing.Size(715, 638);
            this.dgvStats.TabIndex = 17;
            // 
            // col_i
            // 
            this.col_i.FillWeight = 67.87527F;
            this.col_i.HeaderText = "Round";
            this.col_i.Name = "col_i";
            this.col_i.ReadOnly = true;
            this.col_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_n
            // 
            this.col_n.FillWeight = 67.87527F;
            this.col_n.HeaderText = "n";
            this.col_n.Name = "col_n";
            this.col_n.ReadOnly = true;
            this.col_n.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_t
            // 
            this.col_t.FillWeight = 67.87527F;
            this.col_t.HeaderText = "t";
            this.col_t.Name = "col_t";
            this.col_t.ReadOnly = true;
            this.col_t.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_m
            // 
            this.col_m.FillWeight = 67.87527F;
            this.col_m.HeaderText = "m";
            this.col_m.Name = "col_m";
            this.col_m.ReadOnly = true;
            this.col_m.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_mclogn
            // 
            this.col_mclogn.FillWeight = 67.87527F;
            this.col_mclogn.HeaderText = "mclog(n)";
            this.col_mclogn.Name = "col_mclogn";
            this.col_mclogn.ReadOnly = true;
            this.col_mclogn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_b
            // 
            this.col_b.FillWeight = 67.87527F;
            this.col_b.HeaderText = "b";
            this.col_b.Name = "col_b";
            this.col_b.ReadOnly = true;
            this.col_b.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_bigN
            // 
            this.col_bigN.FillWeight = 67.87527F;
            this.col_bigN.HeaderText = "N";
            this.col_bigN.Name = "col_bigN";
            this.col_bigN.ReadOnly = true;
            this.col_bigN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_th
            // 
            this.col_th.FillWeight = 67.87527F;
            this.col_th.HeaderText = "Thirsty";
            this.col_th.Name = "col_th";
            this.col_th.ReadOnly = true;
            this.col_th.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pCollapseButtonRight
            // 
            this.pCollapseButtonRight.Controls.Add(this.btnCollapseRight);
            this.pCollapseButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCollapseButtonRight.Location = new System.Drawing.Point(730, 0);
            this.pCollapseButtonRight.Name = "pCollapseButtonRight";
            this.pCollapseButtonRight.Size = new System.Drawing.Size(15, 638);
            this.pCollapseButtonRight.TabIndex = 16;
            // 
            // btnCollapseRight
            // 
            this.btnCollapseRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapseRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseRight.Location = new System.Drawing.Point(0, 0);
            this.btnCollapseRight.Name = "btnCollapseRight";
            this.btnCollapseRight.Size = new System.Drawing.Size(15, 638);
            this.btnCollapseRight.TabIndex = 0;
            this.btnCollapseRight.TabStop = false;
            this.btnCollapseRight.Text = ">>>";
            this.btnCollapseRight.UseVisualStyleBackColor = true;
            this.btnCollapseRight.Click += new System.EventHandler(this.btnCollapseRight_Click);
            // 
            // pCollapseButtonLeft
            // 
            this.pCollapseButtonLeft.Controls.Add(this.btnCollapseLeft);
            this.pCollapseButtonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCollapseButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.pCollapseButtonLeft.Name = "pCollapseButtonLeft";
            this.pCollapseButtonLeft.Size = new System.Drawing.Size(15, 638);
            this.pCollapseButtonLeft.TabIndex = 13;
            // 
            // btnCollapseLeft
            // 
            this.btnCollapseLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapseLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseLeft.Location = new System.Drawing.Point(0, 0);
            this.btnCollapseLeft.Name = "btnCollapseLeft";
            this.btnCollapseLeft.Size = new System.Drawing.Size(15, 638);
            this.btnCollapseLeft.TabIndex = 0;
            this.btnCollapseLeft.TabStop = false;
            this.btnCollapseLeft.Text = "<<<";
            this.btnCollapseLeft.UseVisualStyleBackColor = true;
            this.btnCollapseLeft.Click += new System.EventHandler(this.btnCollapseLeft_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 638);
            this.Controls.Add(this.pOutputPanel);
            this.Controls.Add(this.splitterRight);
            this.Controls.Add(this.pRightPanel);
            this.Controls.Add(this.splitterLeft);
            this.Controls.Add(this.pLeftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tor Bridge Distribution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.pLeftPanel.ResumeLayout(false);
            this.pLeftPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStochastic)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pRightPanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkerStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBadCountMax)).EndInit();
            this.pOutputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chPlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.pCollapseButtonRight.ResumeLayout(false);
            this.pCollapseButtonLeft.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Panel pLeftPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lBadCount;
        private System.Windows.Forms.TrackBar tbBadCount;
        private System.Windows.Forms.Label lUserCount;
        private System.Windows.Forms.TrackBar tbUserCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAggressive;
        private System.Windows.Forms.RadioButton rbPrudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBnb;
        private System.Windows.Forms.RadioButton rbMatrix;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbGridView;
        private System.Windows.Forms.RadioButton rbPlot;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lc;
        private System.Windows.Forms.TrackBar tbC;
        private System.Windows.Forms.Splitter splitterLeft;
        private System.Windows.Forms.Splitter splitterRight;
        private System.Windows.Forms.Panel pRightPanel;
        private System.Windows.Forms.Panel pOutputPanel;
        private System.Windows.Forms.Panel pCollapseButtonLeft;
        private System.Windows.Forms.Button btnCollapseLeft;
        private System.Windows.Forms.Panel pCollapseButtonRight;
        private System.Windows.Forms.Button btnCollapseRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPlots;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mclogn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bigN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_th;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label lBadCountMax;
        public System.Windows.Forms.TrackBar tbBadCountMax;
        public System.Windows.Forms.CheckBox cbmm;
        public System.Windows.Forms.CheckBox cbTime;
        public System.Windows.Forms.CheckBox cbN;
        public System.Windows.Forms.CheckBox cbb;
        public System.Windows.Forms.CheckBox cbThirsty;
        public System.Windows.Forms.CheckBox cbm;
        public System.Windows.Forms.RadioButton rbMultipleRuns;
        public System.Windows.Forms.RadioButton rbSingleRun;
        public System.Windows.Forms.Label lMarkerStep;
        public System.Windows.Forms.TrackBar tbMarkerStep;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cboGridY;
        private System.Windows.Forms.CheckBox cboGridX;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llPlotSettings;
        private System.Windows.Forms.RadioButton rbStochastic;
        private System.Windows.Forms.TrackBar tbStochastic;
        private System.Windows.Forms.Label lStochastic;
        private System.Windows.Forms.CheckBox cbLogY;
        private System.Windows.Forms.CheckBox cbLogX;
        public System.Windows.Forms.Label label2;


    }
}