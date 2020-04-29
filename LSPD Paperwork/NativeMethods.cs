using System;
using System.Runtime.InteropServices;

namespace LSPDPaperwork {
    internal static class NativeMethods {
        internal const UInt32 CB_TEXT = 1;
        internal const int WM_CLIPBOARDUPDATE = 0x031D;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AddClipboardFormatListener(IntPtr hwnd);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr GetClipboardData(UInt32 format);
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        internal static extern UIntPtr GlobalSize(IntPtr hMem);
    }
}
