using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace E2894.Web {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport() {
            InitializeComponent();

            customParameter.Type = typeof(GangOfFour);
            customParameter.Value = GangOfFour.None;
        }
    }
}
