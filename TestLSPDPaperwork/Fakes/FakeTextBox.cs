using System;
using System.Windows.Forms;

namespace TestLSPDPaperwork {
    internal class FakeTextBox : TextBox {
        public void SimulateKeyUp(KeyEventArgs e) {
            var m = new Message {
                Msg = 0x101, //WM_KEYUP
                WParam = new IntPtr(e.KeyValue)
            };
            ProcessKeyEventArgs(ref m);
        }
    }
}
