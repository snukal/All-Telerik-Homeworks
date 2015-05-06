namespace VersionAttribute
{
    using System;
    class CreateAttribute
    {
        static void Main()
        {
            Type type = typeof(TextLine);

            var attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }
    [Version(2.1)]
    public class TextLine
    {
        public int LineNumber { get; set; }
        public string Content { get; set; }
    }

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(double version)
        {
            this.Version = version;
        }

        public double Version { get; set; }
    }

}