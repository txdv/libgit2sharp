using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct GitProxyOptions
    {
        public int Version;
        public ProxyTypes Type;
        public IntPtr Url;
        public IntPtr credentials;
        public IntPtr certificate_check;
    }
}
