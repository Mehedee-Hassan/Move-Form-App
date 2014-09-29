using System;
using System.Runtime.InteropServices;

namespace formAnimation
{
	/// <summary>
	/// Win32 implementation to show / hide a window with animation.
	/// </summary>

	public class WinAPI
	{
		
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static  extern int AnimateWindow (IntPtr hwand , int dwTime , int dwFlags) ;		
	} 
}
