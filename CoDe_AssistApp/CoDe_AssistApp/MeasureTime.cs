using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CoDe_AssistApp {
    public partial class MeasureTime : Form {

        #region Members
        #region Constants
        private const bool STATE_WORK = true;
        private const bool STATE_REST = false;
        private const string ALERT_TITLE = "残り1時間！";
        private const string ALERT_MESSAGE = "ラストスパートかけとく？";
        private const string CONF_FIN_TITILE = "終了確認";
        private const string CONF_FIN_MESSAGE = "記録を保存し、計測を完了します。\r\nよろしいですか？";
        private const string DIAG_TIME_UP_TITILE = "時間切れ！";
        private const string DIAG_TIME_UP_MESSAGE = "今日はよく働いた？\r\nそれとも物足りない？\r\nどっちにしても明日にしよう";
        #endregion // Constants
        #region Variants

        /* 時間を格納する変数群。単位は秒。 */
        private int _workLeft;
        private int _workPassed;
        private int _restTime;
        private int MaxTime;
        private string _recPath;

        /* 状態フラグ */
        private bool currentState;

        /* file保存用 */
        private DateTime startAt;

        #endregion // Variants
        #region Properties

        private int workTime {
            get { return _workPassed; }
            set {

                /* 経過時間の設定 */
                _workPassed = value;
                lblWTPassedTime.Text = ConvertSecToHmS(value);

                /* 残り時間の設定 */
                _workLeft = MaxTime - value;
                lblWTLeftTime.Text = ConvertSecToHmS(_workLeft);
                prbWT.Value = ( ( _workLeft * 100) / MaxTime );

                if( _workLeft == 0) {
                    secTimer.Stop();

                    MessageBox.Show(this, DIAG_TIME_UP_MESSAGE, DIAG_TIME_UP_TITILE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    /* TODO : 保存処理に移行する。 */ 

                }

                return;
            }
        }
        private int restTime {
            get { return _restTime; }
            set {

                _restTime = value;
                lblRTPassedTime.Text = ConvertSecToHmS(value);
                prbRT.Value = (int)(_restTime * 100 / MaxTime);
            }
        }
        /* ファイルパス */
        private string recPath {
            get { return _recPath; }
            set {
                _recPath = value;
                lblStoragePath.Text = value;
            }
        }

        #endregion // Properties

        #endregion // Members

        internal MeasureTime() {

            InitializeComponent();
            InitializeMembers();

            startAt = DateTime.Now;
            return;
        }

        private void InitializeMembers() {

            MaxTime = Properties.Settings.Default.MaxTime * 60;
            workTime = 0;
            restTime = 0;
            currentState = STATE_WORK;
            recPath = Properties.Settings.Default.BasePath;

            btnStart.Enabled = true;
            secTimer.Stop();
            return;
        }


        private string ConvertSecToHmS( int pSec) {

            int wtHour = 0;
            int wtMin = 0;
            int wtSec = 0;

            wtHour = pSec / 3600;
            wtMin = (pSec % 3600) / 60;
            wtSec = (pSec % 3600) % 60;

            return string.Format( "{0:0}:{1:00}:{2:00}", wtHour, wtMin, wtSec );
        }

        private void secTimer_Tick(object sender, EventArgs e) {

            if( currentState == STATE_WORK) {

                workTime++;

                if( (_workLeft == 3600) && ( Properties.Settings.Default.AlertAvailable == true ) ){

                    MessageBox.Show( this, ALERT_MESSAGE, ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning );

                }else{

                    /* no operation */

                }

            } else {

                restTime++;

            }

            return;
        }

        private void btnStart_Click(object sender, EventArgs e) {

            currentState = STATE_WORK;
            secTimer.Start();
            btnStart.Enabled = false;

            return;
        }

        private void btnRest_Click(object sender, EventArgs e) {

            currentState ^= true;
            return;
        }

        private void btnFinish_Click(object sender, EventArgs e) {

            if( MessageBox.Show( this, CONF_FIN_MESSAGE, CONF_FIN_TITILE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1 ) == DialogResult.OK) {

                /* Timerの停止 */
                secTimer.Stop();

                /* 保存先の選択 */
                OpenFileDialog lOfd = new OpenFileDialog();
                lOfd.AddExtension = true;
                lOfd.DefaultExt = ".log";
                lOfd.CheckFileExists = false;
                lOfd.Filter = "レコードファイル(*.log)|*.log|全てのファイル(*.*)|*,*";
                lOfd.FilterIndex = 1;
                lOfd.FileName = "Record.log";
                lOfd.Multiselect = false;
                lOfd.RestoreDirectory = false;
                lOfd.Title = "計測記録の保存先を選択してください。";

                if ( Directory.Exists( recPath ) == true) {

                    lOfd.InitialDirectory = recPath;

                }else {

                    /* no operation */

                }

                if( lOfd.ShowDialog() == DialogResult.OK) {

                    StreamWriter lSw;

                    try {

                        lSw = new StreamWriter( lOfd.FileName,
                                                true,
                                                Encoding.GetEncoding("utf-8")
                                                );

                        lSw.WriteLine( string.Format( "{0}, {1}, {2}", startAt.ToString(), lblWTPassedTime.Text, lblRTPassedTime.Text) );
                        lSw.Close();

                    } catch (Exception ex) {

                        Console.Write(ex.ToString());

                    }

                }else {

                    /* no operation */

                }


            } else {

                /* no operation */

            }

            return;
        }

        private void btnReset_Click(object sender, EventArgs e) {

            InitializeMembers();
            return;
        }
    }
}
