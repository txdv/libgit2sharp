using System;

namespace LibGit2Sharp
{
    /// <summary>
    /// The type of proxy to use
    /// </summary>
    public enum ProxyTypes
    {
        /// <summary>
        /// Do not attempt to connect through a proxy.
        /// </summary>
        None,
        /// <summary>
        /// Try to auto-detect the proxy from the git configuration.
        /// </summary>
        Auto,
        /// <summary>
        /// Connect through a HTTP proxy.
        /// </summary>
        Http,
        /// <summary>
        /// Connect through a Socks4 proxy.
        /// </summary>
        Socks4,
        /// <summary>
        /// Connect through a Socks5 proxy.
        /// </summary>
        Socks5,
    }
}
