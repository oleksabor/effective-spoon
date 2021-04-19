using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcOverriden
{
	class Program
	{
		static IntPtr GetHandle()
		{
			return IntPtr.Zero;
		}

		static void Main(string[] args)
		{
			WithParentActivityOrWindow(GetHandle);
		}
		static void WithParentActivityOrWindow(Func<object> parentActivityOrWindowFunc) { }
		static void WithParentActivityOrWindow(Func<IWin32Window> windowFunc) { }
		static void WithParentActivityOrWindow(Func<IntPtr> windowFunc) { }
	}
}
