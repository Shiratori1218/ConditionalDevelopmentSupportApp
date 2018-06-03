namespace CoDe_AssistApp {
    partial class SplashForm {
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
            this.tlpIndicator = new System.Windows.Forms.TableLayoutPanel();
            this.prbProcess = new System.Windows.Forms.ProgressBar();
            this.tlpPrgLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblIndicatorMessage = new System.Windows.Forms.Label();
            this.lblIndicatorParcentage = new System.Windows.Forms.Label();
            this.tlpLogoSkelton = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogoKanji = new System.Windows.Forms.Label();
            this.lblLogoRuby = new System.Windows.Forms.Label();
            this.timDisplay = new System.Windows.Forms.Timer(this.components);
            this.tlpWhole.SuspendLayout();
            this.tlpIndicator.SuspendLayout();
            this.tlpPrgLabels.SuspendLayout();
            this.tlpLogoSkelton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWhole
            // 
            this.tlpWhole.ColumnCount = 1;
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWhole.Controls.Add(this.tlpIndicator, 0, 1);
            this.tlpWhole.Controls.Add(this.tlpLogoSkelton, 0, 0);
            this.tlpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWhole.Location = new System.Drawing.Point(0, 0);
            this.tlpWhole.Name = "tlpWhole";
            this.tlpWhole.RowCount = 2;
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpWhole.Size = new System.Drawing.Size(350, 150);
            this.tlpWhole.TabIndex = 2;
            // 
            // tlpIndicator
            // 
            this.tlpIndicator.ColumnCount = 1;
            this.tlpIndicator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicator.Controls.Add(this.prbProcess, 0, 1);
            this.tlpIndicator.Controls.Add(this.tlpPrgLabels, 0, 0);
            this.tlpIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicator.Location = new System.Drawing.Point(3, 108);
            this.tlpIndicator.Name = "tlpIndicator";
            this.tlpIndicator.RowCount = 2;
            this.tlpIndicator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpIndicator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpIndicator.Size = new System.Drawing.Size(344, 39);
            this.tlpIndicator.TabIndex = 0;
            // 
            // prbProcess
            // 
            this.prbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbProcess.Location = new System.Drawing.Point(3, 26);
            this.prbProcess.Name = "prbProcess";
            this.prbProcess.Size = new System.Drawing.Size(338, 10);
            this.prbProcess.TabIndex = 0;
            // 
            // tlpPrgLabels
            // 
            this.tlpPrgLabels.ColumnCount = 2;
            this.tlpPrgLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpPrgLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrgLabels.Controls.Add(this.lblIndicatorMessage, 0, 0);
            this.tlpPrgLabels.Controls.Add(this.lblIndicatorParcentage, 1, 0);
            this.tlpPrgLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrgLabels.Location = new System.Drawing.Point(3, 3);
            this.tlpPrgLabels.Name = "tlpPrgLabels";
            this.tlpPrgLabels.RowCount = 1;
            this.tlpPrgLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrgLabels.Size = new System.Drawing.Size(338, 17);
            this.tlpPrgLabels.TabIndex = 1;
            // 
            // lblIndicatorMessage
            // 
            this.lblIndicatorMessage.AutoSize = true;
            this.lblIndicatorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndicatorMessage.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIndicatorMessage.Location = new System.Drawing.Point(3, 0);
            this.lblIndicatorMessage.Name = "lblIndicatorMessage";
            this.lblIndicatorMessage.Size = new System.Drawing.Size(264, 17);
            this.lblIndicatorMessage.TabIndex = 0;
            this.lblIndicatorMessage.Text = "Messages";
            this.lblIndicatorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIndicatorParcentage
            // 
            this.lblIndicatorParcentage.AutoSize = true;
            this.lblIndicatorParcentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndicatorParcentage.Location = new System.Drawing.Point(273, 0);
            this.lblIndicatorParcentage.Name = "lblIndicatorParcentage";
            this.lblIndicatorParcentage.Size = new System.Drawing.Size(62, 17);
            this.lblIndicatorParcentage.TabIndex = 1;
            this.lblIndicatorParcentage.Text = "0.00%";
            this.lblIndicatorParcentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpLogoSkelton
            // 
            this.tlpLogoSkelton.ColumnCount = 3;
            this.tlpLogoSkelton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLogoSkelton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpLogoSkelton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLogoSkelton.Controls.Add(this.lblLogoKanji, 1, 0);
            this.tlpLogoSkelton.Controls.Add(this.lblLogoRuby, 1, 1);
            this.tlpLogoSkelton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogoSkelton.Location = new System.Drawing.Point(3, 3);
            this.tlpLogoSkelton.Name = "tlpLogoSkelton";
            this.tlpLogoSkelton.RowCount = 2;
            this.tlpLogoSkelton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpLogoSkelton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLogoSkelton.Size = new System.Drawing.Size(344, 99);
            this.tlpLogoSkelton.TabIndex = 1;
            // 
            // lblLogoKanji
            // 
            this.lblLogoKanji.AutoSize = true;
            this.lblLogoKanji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoKanji.Font = new System.Drawing.Font("衡山毛筆フォント", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLogoKanji.Location = new System.Drawing.Point(106, 0);
            this.lblLogoKanji.Name = "lblLogoKanji";
            this.lblLogoKanji.Size = new System.Drawing.Size(131, 79);
            this.lblLogoKanji.TabIndex = 0;
            this.lblLogoKanji.Text = "鵠";
            this.lblLogoKanji.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblLogoRuby
            // 
            this.lblLogoRuby.AutoSize = true;
            this.lblLogoRuby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoRuby.Location = new System.Drawing.Point(106, 79);
            this.lblLogoRuby.Name = "lblLogoRuby";
            this.lblLogoRuby.Size = new System.Drawing.Size(131, 20);
            this.lblLogoRuby.TabIndex = 1;
            this.lblLogoRuby.Text = "-Kugui-";
            this.lblLogoRuby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timDisplay
            // 
            this.timDisplay.Enabled = true;
            this.timDisplay.Interval = 10;
            this.timDisplay.Tick += new System.EventHandler(this.timDisplay_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.ControlBox = false;
            this.Controls.Add(this.tlpWhole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.tlpWhole.ResumeLayout(false);
            this.tlpIndicator.ResumeLayout(false);
            this.tlpPrgLabels.ResumeLayout(false);
            this.tlpPrgLabels.PerformLayout();
            this.tlpLogoSkelton.ResumeLayout(false);
            this.tlpLogoSkelton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWhole;
        private System.Windows.Forms.TableLayoutPanel tlpIndicator;
        private System.Windows.Forms.ProgressBar prbProcess;
        private System.Windows.Forms.TableLayoutPanel tlpPrgLabels;
        private System.Windows.Forms.Label lblIndicatorMessage;
        private System.Windows.Forms.Label lblIndicatorParcentage;
        private System.Windows.Forms.TableLayoutPanel tlpLogoSkelton;
        private System.Windows.Forms.Label lblLogoKanji;
        private System.Windows.Forms.Label lblLogoRuby;
        private System.Windows.Forms.Timer timDisplay;
    }
}