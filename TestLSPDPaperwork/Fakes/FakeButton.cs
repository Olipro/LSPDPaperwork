using System.Windows.Forms;

namespace TestLSPDPaperwork {
    internal class FakeButton : Button {
        public void SimulateMouseUp(MouseButtons e) {
            var m = new Message {
                Msg = e == MouseButtons.Left ? 514 : 517
            };
            WndProc(ref m);
        }
    }
}
