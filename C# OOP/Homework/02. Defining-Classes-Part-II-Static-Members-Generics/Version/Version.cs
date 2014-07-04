namespace VersionTask
{
    using System;
    using System.Runtime.InteropServices;

    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface |
      AttributeTargets.Enum | AttributeTargets.Method,
      AllowMultiple = true)]

    public class Version : System.Attribute
    {
        public Version(string major, string minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public string Major { get; private set; }

        public string Minor { get; private set; }
    }
}