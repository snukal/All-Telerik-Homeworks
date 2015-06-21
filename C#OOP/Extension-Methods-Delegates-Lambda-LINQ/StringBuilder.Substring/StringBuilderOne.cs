namespace StringBuilderSubstring
{
    using System.Text;
    public static class StringBuilderHW
    {
        public static StringBuilder Substring(this StringBuilder opa,int input,int length)
        {
            //StringBuilder nov = new StringBuilder(opa.ToString(),opa.Substring(input,length));
            StringBuilder nov = new StringBuilder();
            for (int i = input; i <= length; i++)
            {
                nov.Append(opa[i]);
            }
            return nov;
        }
    }
}
