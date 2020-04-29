using System.Windows.Forms;

using static LSPDPaperwork.NativeMethods;

namespace LSPDPaperwork {
    public static class ClipboardMonitor {
        private class Listener : Control {
            private static Listener INST;
            private Listener() {
                AddClipboardFormatListener(Handle);
            }

            public static void Initialize() {
                if (INST == null)
                    INST = new Listener();
            }

            protected override void WndProc(ref Message m) {
                base.WndProc(ref m);
                if (m.Msg == WM_CLIPBOARDUPDATE)
                    RaiseEvent();
            }
        }

        public delegate void ShortTextHandler(string data);
        public static event ShortTextHandler ShortTextEvent;

        static ClipboardMonitor() {
            Listener.Initialize();
        }

        private static void RaiseEvent() {
            if (Clipboard.ContainsText() && GlobalSize(GetClipboardData(CB_TEXT)).ToUInt64() <= 200)
                ShortTextEvent?.Invoke(Clipboard.GetText());
        }
    }
}
