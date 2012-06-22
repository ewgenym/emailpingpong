using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmailPingPong.UI.Word.Utils
{
	public class InterceptKeys
	{
		public delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private static readonly LowLevelKeyboardProc _keyboardProc = HookCallback;

		private static IntPtr _hookHandle = IntPtr.Zero;

		private const int WH_KEYBOARD = 2;

		private const int HC_ACTION = 0;

		public static void SetHook()
		{
			_hookHandle = SetWindowsHookEx(WH_KEYBOARD, _keyboardProc, IntPtr.Zero, (uint)AppDomain.GetCurrentThreadId());
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
			else
			{
				if (nCode == HC_ACTION)
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