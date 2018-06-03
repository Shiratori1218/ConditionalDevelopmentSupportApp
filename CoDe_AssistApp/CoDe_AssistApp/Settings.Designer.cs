namespace CoDe_AssistApp {
    partial class Settings {
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
            this.tlpWhole = new System.Windows.Forms.TableLayoutPanel();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.pnlMaxTimeTexts = new System.Windows.Forms.Panel();
            this.lblTimeFlavor = new System.Windows.Forms.Label();
            this.nudTimeMin = new System.Windows.Forms.NumericUpDown();
            this.lblTimeHour = new System.Windows.Forms.Label();
            this.nudTimeHour = new System.Windows.Forms.NumericUpDown();
            this.lblTimeMin = new System.Windows.Forms.Label();
            this.trbTimeIndicator = new System.Windows.Forms.TrackBar();
            this.grbAlert = new System.Windows.Forms.GroupBox();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.grbPath = new System.Windows.Forms.GroupBox();
            this.btnPathExplorer = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grbDeatil = new System.Windows.Forms.GroupBox();
            this.lblDetailNote = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlpWhole.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.pnlMaxTimeTexts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTimeIndicator)).BeginInit();
            this.grbAlert.SuspendLayout();
            this.grbPath.SuspendLayout();
            this.grbDeatil.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWhole
            // 
            this.tlpWhole.ColumnCount = 1;
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.Controls.Add(this.grbTime, 0, 2);
            this.tlpWhole.Controls.Add(this.grbAlert, 0, 1);
            this.tlpWhole.Controls.Add(this.grbPath, 0, 0);
            this.tlpWhole.Controls.Add(this.grbDeatil, 0, 3);
            this.tlpWhole.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tlpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWhole.Location = new System.Drawing.Point(0, 0);
            this.tlpWhole.Name = "tlpWhole";
            this.tlpWhole.RowCount = 5;
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpWhole.Size = new System.Drawing.Size(284, 412);
            this.tlpWhole.TabIndex = 0;
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.pnlMaxTimeTexts);
            this.grbTime.Controls.Add(this.trbTimeIndicator);
            this.grbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTime.Location = new System.Drawing.Point(3, 167);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(278, 117);
            this.grbTime.TabIndex = 2;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "時間設定";
            // 
            // pnlMaxTimeTexts
            // 
            this.pnlMaxTimeTexts.Controls.Add(this.lblTimeFlavor);
            this.pnlMaxTimeTexts.Controls.Add(this.nudTimeMin);
            this.pnlMaxTimeTexts.Controls.Add(this.lblTimeHour);
            this.pnlMaxTimeTexts.Controls.Add(this.nudTimeHour);
            this.pnlMaxTimeTexts.Controls.Add(this.lblTimeMin);
            this.pnlMaxTimeTexts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMaxTimeTexts.Location = new System.Drawing.Point(3, 77);
            this.pnlMaxTimeTexts.Name = "pnlMaxTimeTexts";
            this.pnlMaxTimeTexts.Size = new System.Drawing.Size(272, 37);
            this.pnlMaxTimeTexts.TabIndex = 8;
            this.pnlMaxTimeTexts.MouseEnter += new System.EventHandler(this.trbTimeIndicator_MouseEnter);
            this.pnlMaxTimeTexts.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // lblTimeFlavor
            // 
            this.lblTimeFlavor.AutoSize = true;
            this.lblTimeFlavor.Location = new System.Drawing.Point(6, 12);
            this.lblTimeFlavor.Name = "lblTimeFlavor";
            this.lblTimeFlavor.Size = new System.Drawing.Size(122, 12);
            this.lblTimeFlavor.TabIndex = 5;
            this.lblTimeFlavor.Text = "一日に使える最長時間：";
            // 
            // nudTimeMin
            // 
            this.nudTimeMin.Location = new System.Drawing.Point(203, 7);
            this.nudTimeMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudTimeMin.Name = "nudTimeMin";
            this.nudTimeMin.Size = new System.Drawing.Size(40, 19);
            this.nudTimeMin.TabIndex = 7;
            this.nudTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeMin.ValueChanged += new System.EventHandler(this.nudTimeMin_ValueChanged);
            // 
            // lblTimeHour
            // 
            this.lblTimeHour.AutoSize = true;
            this.lblTimeHour.Location = new System.Drawing.Point(168, 14);
            this.lblTimeHour.Name = "lblTimeHour";
            this.lblTimeHour.Size = new System.Drawing.Size(29, 12);
            this.lblTimeHour.TabIndex = 2;
            this.lblTimeHour.Text = "時間";
            this.lblTimeHour.Enter += new System.EventHandler(this.trbTimeIndicator_MouseEnter);
            // 
            // nudTimeHour
            // 
            this.nudTimeHour.Location = new System.Drawing.Point(134, 7);
            this.nudTimeHour.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudTimeHour.Name = "nudTimeHour";
            this.nudTimeHour.Size = new System.Drawing.Size(34, 19);
            this.nudTimeHour.TabIndex = 6;
            this.nudTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeHour.ValueChanged += new System.EventHandler(this.nudTimeHour_ValueChanged);
            // 
            // lblTimeMin
            // 
            this.lblTimeMin.AutoSize = true;
            this.lblTimeMin.Location = new System.Drawing.Point(242, 14);
            this.lblTimeMin.Name = "lblTimeMin";
            this.lblTimeMin.Size = new System.Drawing.Size(17, 12);
            this.lblTimeMin.TabIndex = 4;
            this.lblTimeMin.Text = "分";
            // 
            // trbTimeIndicator
            // 
            this.trbTimeIndicator.AutoSize = false;
            this.trbTimeIndicator.LargeChange = 30;
            this.trbTimeIndicator.Location = new System.Drawing.Point(10, 19);
            this.trbTimeIndicator.Maximum = 480;
            this.trbTimeIndicator.Name = "trbTimeIndicator";
            this.trbTimeIndicator.Size = new System.Drawing.Size(259, 52);
            this.trbTimeIndicator.TabIndex = 0;
            this.trbTimeIndicator.TickFrequency = 30;
            this.trbTimeIndicator.Value = 60;
            this.trbTimeIndicator.ValueChanged += new System.EventHandler(this.trbTimeIndicator_ValueChanged);
            this.trbTimeIndicator.MouseEnter += new System.EventHandler(this.trbTimeIndicator_MouseEnter);
            this.trbTimeIndicator.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // grbAlert
            // 
            this.grbAlert.Controls.Add(this.chkAlert);
            this.grbAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAlert.Location = new System.Drawing.Point(3, 85);
            this.grbAlert.Name = "grbAlert";
            this.grbAlert.Size = new System.Drawing.Size(278, 76);
            this.grbAlert.TabIndex = 0;
            this.grbAlert.TabStop = false;
            this.grbAlert.Text = "通知設定";
            // 
            // chkAlert
            // 
            this.chkAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAlert.Location = new System.Drawing.Point(9, 18);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(263, 22);
            this.chkAlert.TabIndex = 0;
            this.chkAlert.Text = "chkAlert";
            this.chkAlert.UseVisualStyleBackColor = true;
            this.chkAlert.CheckedChanged += new System.EventHandler(this.chkAlert_CheckedChanged);
            this.chkAlert.MouseEnter += new System.EventHandler(this.chkAlert_MouseEnter);
            this.chkAlert.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // grbPath
            // 
            this.grbPath.Controls.Add(this.btnPathExplorer);
            this.grbPath.Controls.Add(this.txtPath);
            this.grbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPath.Location = new System.Drawing.Point(3, 3);
            this.grbPath.Name = "grbPath";
            this.grbPath.Size = new System.Drawing.Size(278, 76);
            this.grbPath.TabIndex = 1;
            this.grbPath.TabStop = false;
            this.grbPath.Text = "パス設定";
            // 
            // btnPathExplorer
            // 
            this.btnPathExplorer.Location = new System.Drawing.Point(247, 17);
            this.btnPathExplorer.Name = "btnPathExplorer";
            this.btnPathExplorer.Size = new System.Drawing.Size(25, 20);
            this.btnPathExplorer.TabIndex = 1;
            this.btnPathExplorer.Text = "...";
            this.btnPathExplorer.UseVisualStyleBackColor = true;
            this.btnPathExplorer.Click += new System.EventHandler(this.btnPathExplorer_Click);
            this.btnPathExplorer.MouseEnter += new System.EventHandler(this.txtPath_MouseEnter);
            this.btnPathExplorer.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(9, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(237, 19);
            this.txtPath.TabIndex = 0;
            this.txtPath.MouseEnter += new System.EventHandler(this.txtPath_MouseEnter);
            this.txtPath.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // grbDeatil
            // 
            this.grbDeatil.Controls.Add(this.lblDetailNote);
            this.grbDeatil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDeatil.Location = new System.Drawing.Point(3, 290);
            this.grbDeatil.Name = "grbDeatil";
            this.grbDeatil.Size = new System.Drawing.Size(278, 76);
            this.grbDeatil.TabIndex = 3;
            this.grbDeatil.TabStop = false;
            this.grbDeatil.Text = "説明";
            // 
            // lblDetailNote
            // 
            this.lblDetailNote.AutoSize = true;
            this.lblDetailNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailNote.Location = new System.Drawing.Point(3, 15);
            this.lblDetailNote.Name = "lblDetailNote";
            this.lblDetailNote.Size = new System.Drawing.Size(0, 12);
            this.lblDetailNote.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDefault, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 372);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 37);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDefault
            // 
            this.btnDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefault.Location = new System.Drawing.Point(3, 3);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(63, 31);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "初期化";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            this.btnDefault.MouseEnter += new System.EventHandler(this.btnDefault_MouseEnter);
            this.btnDefault.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(210, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(141, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 31);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.Shared_MouseLeave);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.tlpWhole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.tlpWhole.ResumeLayout(false);
            this.grbTime.ResumeLayout(false);
            this.pnlMaxTimeTexts.ResumeLayout(false);
            this.pnlMaxTimeTexts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTimeIndicator)).EndInit();
            this.grbAlert.ResumeLayout(false);
            this.grbPath.ResumeLayout(false);
            this.grbPath.PerformLayout();
            this.grbDeatil.ResumeLayout(false);
            this.grbDeatil.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWhole;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.Label lblTimeFlavor;
        private System.Windows.Forms.Label lblTimeMin;
        private System.Windows.Forms.Label lblTimeHour;
        private System.Windows.Forms.TrackBar trbTimeIndicator;
        private System.Windows.Forms.GroupBox grbAlert;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.GroupBox grbPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.NumericUpDown nudTimeMin;
        private System.Windows.Forms.NumericUpDown nudTimeHour;
        private System.Windows.Forms.Button btnPathExplorer;
        private System.Windows.Forms.GroupBox grbDeatil;
        private System.Windows.Forms.Label lblDetailNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlMaxTimeTexts;
    }
}