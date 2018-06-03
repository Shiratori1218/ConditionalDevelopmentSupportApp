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

    delegate void tickPostProcess();

    public partial class SplashForm : Form {

        #region Fields
        #region Members

        private int _progVal;
        private int increseVal;
        private readonly string[] progMessages = new string[5]{
            test.PROGRESS_FIRST_QUARTER,
            test.PROGRESS_SECOND_QUARTER,
            test.PROGRESS_THIRD_QUARTER,
            test.PROGRESS_FOURTH_QUARTER,
            test.PROGRESS_COMPLETE
        };
        private static SplashForm _form = null;
        private tickPostProcess[] _tPP;

        #endregion // Members

        #region Properties

        private int progressVal {
            get { return _progVal; }
            set {
                _progVal = value;
                lblIndicatorParcentage.Text = value.ToString("0'.'0'%'");
                prbProcess.Value = value / 10;

            }
        }
        public static SplashForm Form {
            get { return _form; }
        }

        #endregion // Properties
        #endregion // Fields

        #region Methods

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SplashForm() {
            InitializeComponent();
            InitializeMembers();
            InitializePostProcess();

            timDisplay.Start();

            return;
        }


        private void InitializeMembers() {
            lblIndicatorMessage.Text = test.PROGRESS_INITIATION;
            progressVal = 0;
            increseVal = 1;

            return;
        }

        private void InitializePostProcess() {
            _tPP = new tickPostProcess[5] {
                DummyPostProcess,
                AccelaratePostProcess,
                DummyPostProcess,
                DefaultSpeedPodtProcess,
                CompletePostProcess
            };

            return;
        }

        #region PostProcessDelegates

        public void DummyPostProcess() {
            return;
        }

        public void AccelaratePostProcess() {
            increseVal = 2;
        }

        public void DefaultSpeedPodtProcess() {
            increseVal = 1;
        }

        public async void CompletePostProcess() {
            timDisplay.Stop();
            await Task.Delay(1000);
            this.Close();
            return;
        }

        #endregion

        #region EventHandlers

        private void timDisplay_Tick(object sender, EventArgs e) {
            int lPrgLv = 0;

            progressVal += increseVal;
            lPrgLv = (progressVal / 250) % 5;

            lblIndicatorMessage.Text = progMessages[ lPrgLv ];
            _tPP[ lPrgLv ]();

            return;
        }

        #endregion //EventHandler

        #endregion // Methods
    }
}
