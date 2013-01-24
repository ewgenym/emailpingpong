using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmailPingPong.Outlook.Common.Utils
{
	public class InterceptKeys
	{
		public delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private static readonly LowLevelKeyboardProc KeyboardProc = HookCallback;

		private static IntPtr _hookHandle = IntPtr.Zero;

		private const int WhKeyboard = 2;

		private const int HcAction = 0;

		public static void SetHook()
		{
			_hookHandle = SetWindowsHookEx(WhKeyboard, KeyboardProc, IntPtr.Zero, (uint)AppDomain.GetCurrentThreadId());
		}

		public static void ReleaseHook()
		{
			UnhookWindowsHookEx(_hookHandle);
		}
		
		public static event KeyEventHandler KeyDown;

		private static int HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode < 0)
			{
				return (int)CallNextHookEx(_hookHandle, nCode, wParam, lParam);
			}

			if (nCode == HcAction)
			{
				var keyDown = KeyDown;
				if (keyDown != null)
				{
					var keyEventArgs = new KeyEventArgs((Keys)wParam);
					keyDown(null, keyEventArgs);
					if (keyEventArgs.SuppressKeyPress)
					{
						return 1;
					}
				}
			}
			return (int) CallNextHookEx(_hookHandle, nCode, wParam, lParam);
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
		
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
	}

	public class Functions
	{
		public static bool IsKeyDown(Keys keys)
		{
			return (GetKeyState((int)keys) & 0x8000) == 0x8000;
		}

		[DllImport("user32.dll")]
		static extern short GetKeyState(int nVirtKey);
	}
}