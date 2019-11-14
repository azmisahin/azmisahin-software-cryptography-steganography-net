using System;

namespace CryptoSteganography.Extensions
{
    /// <summary>
    /// Global Extension Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ExtensionAttribute : Attribute
    {
    }
}
