using System;
using System.Runtime.InteropServices;
using Reloaded.Hooks.Definitions.X86;

namespace AOSharp.Common.Unmanaged.Imports
{
    public class MessageProtocol
    {
        [DllImport("MessageProtocol.dll", EntryPoint = "?DataBlockToMessage@@YAPAVMessage_t@@IPAX@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr DataBlockToMessage(uint size, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] dataBlock);
        // The hook takes the client's own buffer as a pointer and hands it back unchanged. Marshalling it
        // as a byte[] gave the client a temporary copy, which the message it builds can keep pointing into
        // after the call, when that memory is already released or moved by the garbage collector.
        [Function(CallingConventions.Cdecl)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode, SetLastError = true)]
        public delegate IntPtr DDataBlockToMessage(uint size, IntPtr dataBlock);
    }
}
