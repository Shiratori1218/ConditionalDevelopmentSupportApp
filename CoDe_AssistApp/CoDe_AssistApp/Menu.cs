using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoDe_AssistApp {
    public partial class Menu : Form {

        #region Fields

        private struct messages {
            public string Title;
            public string Message;
        }

        #region Members
        private readonly messages DEFAULT = new messages { Title = "ここにボタンの名称が表示されるよ", Message = "ここに詳細が表示されるよ" };
        private readonly messages MEASURE = new messages { Title = "計測開始ボタン", Message = "作業時間の計測を開始します。\r\n時間を超過すると怒られるよ！" };
        private readonly messages VRECORD = new messages { Title = "記録参照ボタン", Message = "作業時間の記録を参照します。\r\n時間を有効に使えたかな？" };
        private readonly messages SETTING = new messages { Title = "設定ボタン", Message = "時間の計測方法を設定します。\r\n何時間くらい働く？" };


        #endregion // Members
        #region Properties
        private messages mWindow {
            get {
                return new messages { Title = lblTitle.Text, Message = lblMessage.Text };
            }

            set {
                lblTitle.Text = value.Title;
                lblMessage.Text = value.Message;
                return;
            }

        }


        #endregion // Properties
        #endregion // Fields

        #region Methods

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Menu() {
            InitializeComponent();

            InitializeMessage();
        }

        /// <summary>
        /// メッセージウィンドウ初期化処理
        /// </summary>
        private void InitializeMessage() {
            mWindow = DEFAULT;
            return;
        }

        #region EventHandlers

        private void InitializeMember() {

            return;
        }


        /// <summary>
        /// 【共用】ボタン群のマウスリーブイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSharedLeaveEvent(object sender, EventArgs e) {
            InitializeMessage();
            return;
        }

        /// <summary>
        /// 「記録を開始」ボタン　マウスエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMeasureTime_MouseEnter(object sender, EventArgs e) {
            mWindow = MEASURE;
            return;
        }

        /// <summary>
        /// 「記録を参照」ボタン　マウスエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewRecord_MouseEnter(object sender, EventArgs e) {
            mWindow = VRECORD;
            return;
        }

        /// <summary>
        /// 「設定」ボタン　マウスエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_MouseEnter(object sender, EventArgs e) {
            mWindow = SETTING;
            return;
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            new Settings().ShowDialog();

            return;
        }

        private void btnViewRecord_Click(object sender, EventArgs e) {
            return;
        }

        private void btnMeasureTime_Click(object sender, EventArgs e) {

            /* TODO : MeasureTimeウィンドウは常にひとつしか表示させないようにする。 */
            MeasureTime frmMT = new MeasureTime();
            frmMT.Show();
            return;
        }

        #endregion // EventHandler

        #endregion // Methods

    }
}
