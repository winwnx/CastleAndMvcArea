using System.Collections.Generic;

namespace MvcAreasSingleProject.Helper
{
    public class AppHelper
    {
        public static IList<string> NameList()
        {
            return new List<string>
                       {
                           "Name_aa",
                           "Name_bb",
                           "Name_cc",
                           "Name_dd",
                       };
        }
    }
}