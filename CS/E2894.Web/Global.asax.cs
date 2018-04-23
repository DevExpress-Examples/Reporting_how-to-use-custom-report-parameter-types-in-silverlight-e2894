using System;
using DevExpress.Xpf.Printing;

namespace E2894.Web {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            ServiceKnownTypeProvider.Register<GangOfFour>();
        }
    }
}
