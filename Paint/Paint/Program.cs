/*
 * Created for OS project.
 * Author: Matei Cristina & Bratucu Ana Maria
 * Date: 21.05.2018
 *
 * 
 * 
 */
using System;
using System.Windows.Forms;

namespace Paint
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
