namespace CoDe_AssistApp {
    partial class MeasureTime {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tlpWhole = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRestTime = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRTIndicators = new System.Windows.Forms.TableLayoutPanel();
            this.prbRT = new System.Windows.Forms.ProgressBar();
            this.tlpRTLabels = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRTPassed = new System.Windows.Forms.Panel();
            this.lblRTPassedTitile = new System.Windows.Forms.Label();
            this.lblRTPassedTime = new System.Windows.Forms.Label();
            this.pnlRTLeft = new System.Windows.Forms.Panel();
            this.lblRTLeftTitle = new System.Windows.Forms.Label();
            this.lblRTLeftTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tlpWorkTime = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWTIndicators = new System.Windows.Forms.TableLayoutPanel();
            this.prbWT = new System.Windows.Forms.ProgressBar();
            this.tlpWTLabels = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWTPassed = new System.Windows.Forms.Panel();
            this.lblWTPassedTitle = new System.Windows.Forms.Label();
            this.lblWTPassedTime = new System.Windows.Forms.Label();
            this.pnlWTLeft = new System.Windows.Forms.Panel();
            this.lblWTLeftTitle = new System.Windows.Forms.Label();
            this.lblWTLeftTime = new System.Windows.Forms.Label();
            this.lblWTIndex = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlPath = new System.Windows.Forms.Panel();
            this.lblPathIndex = new System.Windows.Forms.Label();
            this.lblStoragePath = new System.Windows.Forms.Label();
            this.tlpWhole.SuspendLayout();
            this.tlpRestTime.SuspendLayout();
            this.tlpRTIndicators.SuspendLayout();
            this.tlpRTLabels.SuspendLayout();
            this.pnlRTPassed.SuspendLayout();
            this.pnlRTLeft.SuspendLayout();
            this.tlpWorkTime.SuspendLayout();
            this.tlpWTIndicators.SuspendLayout();
            this.tlpWTLabels.SuspendLayout();
            this.pnlWTPassed.SuspendLayout();
            this.pnlWTLeft.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnlPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWhole
            // 
            this.tlpWhole.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpWhole.ColumnCount = 1;
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.Controls.Add(this.tlpRestTime, 0, 1);
            this.tlpWhole.Controls.Add(this.tlpWorkTime, 0, 0);
            this.tlpWhole.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tlpWhole.Controls.Add(this.pnlPath, 0, 2);
            this.tlpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWhole.Location = new System.Drawing.Point(0, 0);
            this.tlpWhole.Name = "tlpWhole";
            this.tlpWhole.RowCount = 4;
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWhole.Size = new System.Drawing.Size(384, 197);
            this.tlpWhole.TabIndex = 0;
            // 
            // tlpRestTime
            // 
            this.tlpRestTime.ColumnCount = 2;
            this.tlpRestTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRestTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpRestTime.Controls.Add(this.tlpRTIndicators, 1, 0);
            this.tlpRestTime.Controls.Add(this.label10, 0, 0);
            this.tlpRestTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRestTime.Location = new System.Drawing.Point(4, 67);
            this.tlpRestTime.Name = "tlpRestTime";
            this.tlpRestTime.RowCount = 1;
            this.tlpRestTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRestTime.Size = new System.Drawing.Size(376, 56);
            this.tlpRestTime.TabIndex = 2;
            // 
            // tlpRTIndicators
            // 
            this.tlpRTIndicators.ColumnCount = 1;
            this.tlpRTIndicators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTIndicators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRTIndicators.Controls.Add(this.prbRT, 0, 1);
            this.tlpRTIndicators.Controls.Add(this.tlpRTLabels, 0, 0);
            this.tlpRTIndicators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRTIndicators.Location = new System.Drawing.Point(78, 3);
            this.tlpRTIndicators.Name = "tlpRTIndicators";
            this.tlpRTIndicators.RowCount = 2;
            this.tlpRTIndicators.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRTIndicators.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRTIndicators.Size = new System.Drawing.Size(295, 50);
            this.tlpRTIndicators.TabIndex = 0;
            // 
            // prbRT
            // 
            this.prbRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbRT.Location = new System.Drawing.Point(3, 38);
            this.prbRT.Name = "prbRT";
            this.prbRT.Size = new System.Drawing.Size(289, 9);
            this.prbRT.TabIndex = 0;
            // 
            // tlpRTLabels
            // 
            this.tlpRTLabels.ColumnCount = 2;
            this.tlpRTLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRTLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRTLabels.Controls.Add(this.pnlRTPassed, 1, 0);
            this.tlpRTLabels.Controls.Add(this.pnlRTLeft, 0, 0);
            this.tlpRTLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRTLabels.Location = new System.Drawing.Point(3, 3);
            this.tlpRTLabels.Name = "tlpRTLabels";
            this.tlpRTLabels.RowCount = 1;
            this.tlpRTLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpRTLabels.Size = new System.Drawing.Size(289, 29);
            this.tlpRTLabels.TabIndex = 1;
            // 
            // pnlRTPassed
            // 
            this.pnlRTPassed.Controls.Add(this.lblRTPassedTitile);
            this.pnlRTPassed.Controls.Add(this.lblRTPassedTime);
            this.pnlRTPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRTPassed.Location = new System.Drawing.Point(147, 3);
            this.pnlRTPassed.Name = "pnlRTPassed";
            this.pnlRTPassed.Size = new System.Drawing.Size(139, 23);
            this.pnlRTPassed.TabIndex = 1;
            // 
            // lblRTPassedTitile
            // 
            this.lblRTPassedTitile.AutoSize = true;
            this.lblRTPassedTitile.Location = new System.Drawing.Point(0, 0);
            this.lblRTPassedTitile.Name = "lblRTPassedTitile";
            this.lblRTPassedTitile.Size = new System.Drawing.Size(48, 12);
            this.lblRTPassedTitile.TabIndex = 0;
            this.lblRTPassedTitile.Text = "Passed...";
            // 
            // lblRTPassedTime
            // 
            this.lblRTPassedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRTPassedTime.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblRTPassedTime.Location = new System.Drawing.Point(0, 0);
            this.lblRTPassedTime.Name = "lblRTPassedTime";
            this.lblRTPassedTime.Size = new System.Drawing.Size(139, 23);
            this.lblRTPassedTime.TabIndex = 1;
            this.lblRTPassedTime.Text = "tlpRTPassedTime";
            this.lblRTPassedTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnlRTLeft
            // 
            this.pnlRTLeft.Controls.Add(this.lblRTLeftTitle);
            this.pnlRTLeft.Controls.Add(this.lblRTLeftTime);
            this.pnlRTLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRTLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlRTLeft.Name = "pnlRTLeft";
            this.pnlRTLeft.Size = new System.Drawing.Size(138, 23);
            this.pnlRTLeft.TabIndex = 0;
            // 
            // lblRTLeftTitle
            // 
            this.lblRTLeftTitle.AutoSize = true;
            this.lblRTLeftTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRTLeftTitle.Name = "lblRTLeftTitle";
            this.lblRTLeftTitle.Size = new System.Drawing.Size(31, 12);
            this.lblRTLeftTitle.TabIndex = 0;
            this.lblRTLeftTitle.Text = "Left...";
            // 
            // lblRTLeftTime
            // 
            this.lblRTLeftTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRTLeftTime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRTLeftTime.Location = new System.Drawing.Point(0, 0);
            this.lblRTLeftTime.Name = "lblRTLeftTime";
            this.lblRTLeftTime.Size = new System.Drawing.Size(138, 23);
            this.lblRTLeftTime.TabIndex = 1;
            this.lblRTLeftTime.Text = "--:--:--";
            this.lblRTLeftTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("衡山毛筆フォント", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 56);
            this.label10.TabIndex = 1;
            this.label10.Text = "RestTime";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpWorkTime
            // 
            this.tlpWorkTime.ColumnCount = 2;
            this.tlpWorkTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWorkTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpWorkTime.Controls.Add(this.tlpWTIndicators, 1, 0);
            this.tlpWorkTime.Controls.Add(this.lblWTIndex, 0, 0);
            this.tlpWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkTime.Location = new System.Drawing.Point(4, 4);
            this.tlpWorkTime.Name = "tlpWorkTime";
            this.tlpWorkTime.RowCount = 1;
            this.tlpWorkTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkTime.Size = new System.Drawing.Size(376, 56);
            this.tlpWorkTime.TabIndex = 0;
            // 
            // tlpWTIndicators
            // 
            this.tlpWTIndicators.ColumnCount = 1;
            this.tlpWTIndicators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWTIndicators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWTIndicators.Controls.Add(this.prbWT, 0, 1);
            this.tlpWTIndicators.Controls.Add(this.tlpWTLabels, 0, 0);
            this.tlpWTIndicators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWTIndicators.Location = new System.Drawing.Point(78, 3);
            this.tlpWTIndicators.Name = "tlpWTIndicators";
            this.tlpWTIndicators.RowCount = 2;
            this.tlpWTIndicators.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpWTIndicators.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpWTIndicators.Size = new System.Drawing.Size(295, 50);
            this.tlpWTIndicators.TabIndex = 0;
            // 
            // prbWT
            // 
            this.prbWT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbWT.Location = new System.Drawing.Point(3, 38);
            this.prbWT.Name = "prbWT";
            this.prbWT.Size = new System.Drawing.Size(289, 9);
            this.prbWT.TabIndex = 0;
            // 
            // tlpWTLabels
            // 
            this.tlpWTLabels.ColumnCount = 2;
            this.tlpWTLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWTLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWTLabels.Controls.Add(this.pnlWTPassed, 1, 0);
            this.tlpWTLabels.Controls.Add(this.pnlWTLeft, 0, 0);
            this.tlpWTLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWTLabels.Location = new System.Drawing.Point(3, 3);
            this.tlpWTLabels.Name = "tlpWTLabels";
            this.tlpWTLabels.RowCount = 1;
            this.tlpWTLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWTLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpWTLabels.Size = new System.Drawing.Size(289, 29);
            this.tlpWTLabels.TabIndex = 1;
            // 
            // pnlWTPassed
            // 
            this.pnlWTPassed.Controls.Add(this.lblWTPassedTitle);
            this.pnlWTPassed.Controls.Add(this.lblWTPassedTime);
            this.pnlWTPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWTPassed.Location = new System.Drawing.Point(147, 3);
            this.pnlWTPassed.Name = "pnlWTPassed";
            this.pnlWTPassed.Size = new System.Drawing.Size(139, 23);
            this.pnlWTPassed.TabIndex = 1;
            // 
            // lblWTPassedTitle
            // 
            this.lblWTPassedTitle.AutoSize = true;
            this.lblWTPassedTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWTPassedTitle.Name = "lblWTPassedTitle";
            this.lblWTPassedTitle.Size = new System.Drawing.Size(48, 12);
            this.lblWTPassedTitle.TabIndex = 0;
            this.lblWTPassedTitle.Text = "Passed...";
            // 
            // lblWTPassedTime
            // 
            this.lblWTPassedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWTPassedTime.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblWTPassedTime.Location = new System.Drawing.Point(0, 0);
            this.lblWTPassedTime.Name = "lblWTPassedTime";
            this.lblWTPassedTime.Size = new System.Drawing.Size(139, 23);
            this.lblWTPassedTime.TabIndex = 1;
            this.lblWTPassedTime.Text = "lblWTPassedTime";
            this.lblWTPassedTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnlWTLeft
            // 
            this.pnlWTLeft.Controls.Add(this.lblWTLeftTitle);
            this.pnlWTLeft.Controls.Add(this.lblWTLeftTime);
            this.pnlWTLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWTLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlWTLeft.Name = "pnlWTLeft";
            this.pnlWTLeft.Size = new System.Drawing.Size(138, 23);
            this.pnlWTLeft.TabIndex = 0;
            // 
            // lblWTLeftTitle
            // 
            this.lblWTLeftTitle.AutoSize = true;
            this.lblWTLeftTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWTLeftTitle.Name = "lblWTLeftTitle";
            this.lblWTLeftTitle.Size = new System.Drawing.Size(31, 12);
            this.lblWTLeftTitle.TabIndex = 0;
            this.lblWTLeftTitle.Text = "Left...";
            // 
            // lblWTLeftTime
            // 
            this.lblWTLeftTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWTLeftTime.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lblWTLeftTime.Location = new System.Drawing.Point(0, 0);
            this.lblWTLeftTime.Name = "lblWTLeftTime";
            this.lblWTLeftTime.Size = new System.Drawing.Size(138, 23);
            this.lblWTLeftTime.TabIndex = 1;
            this.lblWTLeftTime.Text = "lblWTLeftTime";
            this.lblWTLeftTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblWTIndex
            // 
            this.lblWTIndex.AutoSize = true;
            this.lblWTIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWTIndex.Font = new System.Drawing.Font("衡山毛筆フォント", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWTIndex.Location = new System.Drawing.Point(3, 0);
            this.lblWTIndex.Name = "lblWTIndex";
            this.lblWTIndex.Size = new System.Drawing.Size(69, 56);
            this.lblWTIndex.TabIndex = 1;
            this.lblWTIndex.Text = "WorkTime";
            this.lblWTIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Controls.Add(this.btnFinish, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnReset, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRest, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 166);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 27);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(189, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 21);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(313, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 21);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.Location = new System.Drawing.Point(127, 3);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(56, 21);
            this.btnRest.TabIndex = 1;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 21);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // secTimer
            // 
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // pnlPath
            // 
            this.pnlPath.Controls.Add(this.lblPathIndex);
            this.pnlPath.Controls.Add(this.lblStoragePath);
            this.pnlPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPath.Location = new System.Drawing.Point(4, 130);
            this.pnlPath.Name = "pnlPath";
            this.pnlPath.Size = new System.Drawing.Size(376, 29);
            this.pnlPath.TabIndex = 3;
            // 
            // lblPathIndex
            // 
            this.lblPathIndex.AutoSize = true;
            this.lblPathIndex.Location = new System.Drawing.Point(1, 0);
            this.lblPathIndex.Name = "lblPathIndex";
            this.lblPathIndex.Size = new System.Drawing.Size(69, 12);
            this.lblPathIndex.TabIndex = 0;
            this.lblPathIndex.Text = "StoragePath:";
            // 
            // lblStoragePath
            // 
            this.lblStoragePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStoragePath.Location = new System.Drawing.Point(0, 0);
            this.lblStoragePath.Name = "lblStoragePath";
            this.lblStoragePath.Size = new System.Drawing.Size(376, 29);
            this.lblStoragePath.TabIndex = 1;
            this.lblStoragePath.Text = "Path";
            this.lblStoragePath.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MeasureTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 197);
            this.Controls.Add(this.tlpWhole);
            this.Name = "MeasureTime";
            this.Text = "MeasureTime";
            this.tlpWhole.ResumeLayout(false);
            this.tlpRestTime.ResumeLayout(false);
            this.tlpRestTime.PerformLayout();
            this.tlpRTIndicators.ResumeLayout(false);
            this.tlpRTLabels.ResumeLayout(false);
            this.pnlRTPassed.ResumeLayout(false);
            this.pnlRTPassed.PerformLayout();
            this.pnlRTLeft.ResumeLayout(false);
            this.pnlRTLeft.PerformLayout();
            this.tlpWorkTime.ResumeLayout(false);
            this.tlpWorkTime.PerformLayout();
            this.tlpWTIndicators.ResumeLayout(false);
            this.tlpWTLabels.ResumeLayout(false);
            this.pnlWTPassed.ResumeLayout(false);
            this.pnlWTPassed.PerformLayout();
            this.pnlWTLeft.ResumeLayout(false);
            this.pnlWTLeft.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pnlPath.ResumeLayout(false);
            this.pnlPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWhole;
        private System.Windows.Forms.TableLayoutPanel tlpRestTime;
        private System.Windows.Forms.TableLayoutPanel tlpRTIndicators;
        private System.Windows.Forms.ProgressBar prbRT;
        private System.Windows.Forms.TableLayoutPanel tlpRTLabels;
        private System.Windows.Forms.Panel pnlRTPassed;
        private System.Windows.Forms.Label lblRTPassedTitile;
        private System.Windows.Forms.Label lblRTPassedTime;
        private System.Windows.Forms.Panel pnlRTLeft;
        private System.Windows.Forms.Label lblRTLeftTitle;
        private System.Windows.Forms.Label lblRTLeftTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpWorkTime;
        private System.Windows.Forms.TableLayoutPanel tlpWTIndicators;
        private System.Windows.Forms.ProgressBar prbWT;
        private System.Windows.Forms.TableLayoutPanel tlpWTLabels;
        private System.Windows.Forms.Panel pnlWTPassed;
        private System.Windows.Forms.Label lblWTPassedTitle;
        private System.Windows.Forms.Label lblWTPassedTime;
        private System.Windows.Forms.Panel pnlWTLeft;
        private System.Windows.Forms.Label lblWTLeftTitle;
        private System.Windows.Forms.Label lblWTLeftTime;
        private System.Windows.Forms.Label lblWTIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel pnlPath;
        private System.Windows.Forms.Label lblPathIndex;
        private System.Windows.Forms.Label lblStoragePath;
    }
}