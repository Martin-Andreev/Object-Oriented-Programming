namespace GenericList
{
    using System;

    [AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method)]
    public class Version : Attribute
    {
        private int minor;
        private int major;

        public Version(int major, int minor)
        {
            this.Minor = minor;
            this.Major = major;
        }

        public int Minor { get; set; }
        public int Major { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor);
        }
    }
}
