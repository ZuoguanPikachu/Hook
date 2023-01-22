using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Hook.Util
{
    internal class MouseHook
    {
        [StructLayout(LayoutKind.Sequential)]
        public class Point
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private class MouseLLHookStruct
        {
            public Point? pt;
            public int mouseData;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        public delegate void MouseEventHandler(Point pt);
        private event MouseEventHandler OnMouseActivity;
        private static Win32Api.HookProc? MouseHookProcedure;
        private int hMouseHook = 0;
        private const int WH_MOUSE_LL = 14;

        public MouseHook(MouseEventHandler mouseEventHandler)
        {
            OnMouseActivity += mouseEventHandler;
            MouseHookProcedure = new Win32Api.HookProc(MouseHookProc);
            hMouseHook = Win32Api.SetWindowsHookEx(WH_MOUSE_LL, MouseHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
        }

        ~MouseHook()
        {
            UnHook();
        }

        private int MouseHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (OnMouseActivity != null))
            {
                MouseLLHookStruct mouseHookStruct = (MouseLLHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseLLHookStruct))!;
                switch (wParam)
                {
                    case MouseMessage.MOUSEMOVE:
                        break;
                    default:
                        return Win32Api.CallNextHookEx(hMouseHook, nCode, wParam, lParam);
                }
                OnMouseActivity?.Invoke(mouseHookStruct.pt!);
            }

            return Win32Api.CallNextHookEx(hMouseHook, nCode, wParam, lParam);
        }

        public void UnHook()
        {
            if (hMouseHook != 0)
            {
                Win32Api.UnhookWindowsHookEx(hMouseHook);
            }
        }
    }
}
