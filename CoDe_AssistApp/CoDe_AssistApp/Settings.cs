using System;
using System.IO;
using System.Windows.Forms;

namespace CoDe_AssistApp {
    public partial class Settings : Form {
        #region Members
        private int _MaxTime;

        #region Constants
        private const int DEFAULT_TIME = 480;
        private const string DEFAULT_PATH = @".\Record\";
        private const string ALERT_ON = "現在1時間前通知は有効です。";
        private const string ALERT_OFF = "現在1時間前通知は無効です。";
        private const string PATH_FBD_DESCRIPTION = "計測記録を保存するディレクトリを選択してください。";
        private const string DETAIL_DEFAULT = "ここにポインタを合わせた項目の詳細が表示されます。";
        private const string DETAIL_PATH = "計測記録を保存するパスを設定します。";
        private const string DETAIL_ALERT = "計測最長時間一時間前に通知をするか設定します。";
        private const string DETAIL_TIME = "一日に最大何時間作業を行うか設定します。\r\n最大で8時間まで設定可能です。\r\nそれ以上？効率下がるからダメです。";
        private const string DETAIL_BTN_DEF = "工場出荷時の状態に戻します。\r\n工場･･･？工場ってどこだ･･･？";
        private const string DETAIL_BTN_RES = "設定画面を開いた時の状態に戻します。";
        private const string DETAIL_BTN_SAV = "設定を保存します。";
        private const string CONFIRM_DEF_TITLE = "設定を初期化しますか？";
        private const string CONFIRM_DEF_DETAIL = @"設定を以下の内容に変更します。\r\nよろしいですか？\r\n\t・Path\t:.\Record\\r\n\t・Alert\t:有効\r\n\t・MaxTime\t:8時間";
        private const string CONFIRM_RES_TITLE = "変更した内容を破棄しますか？";
        private const string CONFIRM_RES_DETAIL = "入力内容を破棄します。\r\nよろしいですか？";
        private const string CONFIRM_SAVE_TITLE = "設定を保存しますか？";
        private const string CONFIRM_SAVE_DETAIL = "現在の内容を保存します。\r\nよろしいですか？";

        #endregion // Contants

        #region Properties
        private int MaxTime {
            get { return _MaxTime; }
            set {

                _MaxTime = value;

                /* 時間設定トラックバーへの反映 */
                trbTimeIndicator.Value = value;

                /* 時間設定ニューメリックアップダウンへの反映 */
                nudTimeHour.Value = value / 60;
                nudTimeMin.Value = value % 60;

                return;
            }
        }



        #endregion // Properties
        #endregion // Members

        #region Methods


        public Settings() {
            InitializeComponent();
            InitializeMember();

            return;
        }


        private void InitializeMember() {

            /* パス設定部　初期化処理 */
            txtPath.Text = Properties.Settings.Default.BasePath;

            /* 通知設定部　初期化処理 */
            chkAlert.Checked = Properties.Settings.Default.AlertAvailable;

            /* 時間設定部　初期化処理 */
            MaxTime = Properties.Settings.Default.MaxTime;

            /* 詳細表示部　初期化処理 */
            lblDetailNote.Text = DETAIL_DEFAULT;

            return;
        }

        private void TimeNudSharedValueChangedEvent() {

            decimal lTime = 0;

            lTime = nudTimeHour.Value * 60 + nudTimeMin.Value;

            if (lTime <= DEFAULT_TIME) {

                MaxTime = (int)lTime;

            } else {

                MaxTime = DEFAULT_TIME;

            }

            return;
        }

        private void trbTimeIndicator_ValueChanged(object sender, EventArgs e) {

            MaxTime = trbTimeIndicator.Value;
            return;
        }

        private void nudTimeHour_ValueChanged(object sender, EventArgs e) {

            TimeNudSharedValueChangedEvent();
            return;
        }

        private void nudTimeMin_ValueChanged(object sender, EventArgs e) {

            TimeNudSharedValueChangedEvent();
            return;
        }

        private void btnDefault_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this, CONFIRM_RES_DETAIL, CONFIRM_RES_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) {

                txtPath.Text = DEFAULT_PATH;
                chkAlert.Checked = true;
                MaxTime = DEFAULT_TIME;

            } else {

                /* no operation */

            }

            return;
        }

        private void chkAlert_CheckedChanged(object sender, EventArgs e) {

            if (chkAlert.Checked == true) {

                chkAlert.Text = ALERT_ON;

            } else {

                chkAlert.Text = ALERT_OFF;

            }

            return;
        }

        private void btnPathExplorer_Click(object sender, EventArgs e) {

            FolderBrowserDialog fbd = new FolderBrowserDialog();


            /* フォルダブラウザダイアログ設定 */
            fbd.Description = PATH_FBD_DESCRIPTION;
            if (Directory.Exists(txtPath.Text) == true) {

                fbd.SelectedPath = txtPath.Text;

            } else {

                fbd.SelectedPath = @".\";

            }

            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog(this) == DialogResult.OK) {

                txtPath.Text = fbd.SelectedPath;

            } else {

                /* no operation */

            }

            return;
        }

        private void InitializeDetailLabel() {

            lblDetailNote.Text = DETAIL_DEFAULT;
            return;
        }

        private void txtPath_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_PATH;
            return;

        }

        private void chkAlert_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_ALERT;
            return;
        }

        private void trbTimeIndicator_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_TIME;
            return;
        }

        private void btnDefault_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_BTN_DEF;
            return;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_BTN_RES;
            return;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e) {

            lblDetailNote.Text = DETAIL_BTN_SAV;
            return;
        }

        private void Shared_MouseLeave(object sender, EventArgs e) {

            InitializeDetailLabel();
            return;
        }

        private void btnReset_Click(object sender, EventArgs e) {

            InitializeMember();
            return;
        }

        private void btnSave_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this, CONFIRM_SAVE_DETAIL, CONFIRM_SAVE_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) {

                Properties.Settings.Default.BasePath = txtPath.Text;
                Properties.Settings.Default.AlertAvailable = chkAlert.Checked;
                Properties.Settings.Default.MaxTime = MaxTime;

                Properties.Settings.Default.Save();

                Close();

            }else {

                /* no operations */

            }

            return;
        }
    }
    #endregion
}
