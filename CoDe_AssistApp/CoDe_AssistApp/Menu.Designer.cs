namespace CoDe_AssistApp {
    partial class Menu {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tlpWhole = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.btnMeasureTime = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tlpWhole.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWhole
            // 
            this.tlpWhole.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpWhole.ColumnCount = 1;
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpWhole.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWhole.Location = new System.Drawing.Point(0, 0);
            this.tlpWhole.Name = "tlpWhole";
            this.tlpWhole.RowCount = 2;
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpWhole.Size = new System.Drawing.Size(184, 312);
            this.tlpWhole.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnSettings, 0, 2);
            this.tlpButtons.Controls.Add(this.btnViewRecord, 0, 1);
            this.tlpButtons.Controls.Add(this.btnMeasureTime, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(4, 66);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 5;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.Size = new System.Drawing.Size(176, 242);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(3, 99);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 42);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "設定";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSharedLeaveEvent);
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewRecord.Location = new System.Drawing.Point(3, 51);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(170, 42);
            this.btnViewRecord.TabIndex = 1;
            this.btnViewRecord.Text = "記録を参照";
            this.btnViewRecord.UseVisualStyleBackColor = true;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            this.btnViewRecord.MouseEnter += new System.EventHandler(this.btnViewRecord_MouseEnter);
            this.btnViewRecord.MouseLeave += new System.EventHandler(this.btnSharedLeaveEvent);
            // 
            // btnMeasureTime
            // 
            this.btnMeasureTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMeasureTime.Location = new System.Drawing.Point(3, 3);
            this.btnMeasureTime.Name = "btnMeasureTime";
            this.btnMeasureTime.Size = new System.Drawing.Size(170, 42);
            this.btnMeasureTime.TabIndex = 0;
            this.btnMeasureTime.Text = "記録を開始";
            this.btnMeasureTime.UseVisualStyleBackColor = true;
            this.btnMeasureTime.Click += new System.EventHandler(this.btnMeasureTime_Click);
            this.btnMeasureTime.MouseEnter += new System.EventHandler(this.btnMeasureTime_MouseEnter);
            this.btnMeasureTime.MouseLeave += new System.EventHandler(this.btnSharedLeaveEvent);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMessage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(5, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 14);
            this.lblTitle.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(5, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(166, 35);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 312);
            this.Controls.Add(this.tlpWhole);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainMenu";
            this.tlpWhole.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWhole;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnViewRecord;
        private System.Windows.Forms.Button btnMeasureTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
    }
}

