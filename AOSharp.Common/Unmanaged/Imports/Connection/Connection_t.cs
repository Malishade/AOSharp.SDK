using System;
using System.Runtime.InteropServices;
using Reloaded.Hooks.Definitions.X86;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class Connection_t
    {
        [DllImport("Connection.dll", EntryPoint = "?Send@Connection_t@@QAEHIIPBX@Z", CallingConvention = CallingConvention.ThisCall)]
        public static extern int Send(IntPtr pConnection, uint unk, int len, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] buf);
        // The hook takes the client's own buffer as a pointer and hands it back unchanged, as DDataBlockToMessage
        // does; a marshalled byte[] would give the client a temporary copy to send from.
        [Function(CallingConventions.MicrosoftThiscall)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public delegate int DSend(IntPtr pConnection, uint unk, int len, IntPtr buf);
    }
}
