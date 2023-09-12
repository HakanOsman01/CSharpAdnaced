using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class  DateModifier
    {
       public static int DateDiffrence(string startDateAsSrting,string endDateAsString)
       {
            DateTime startDate = DateTime.Parse(startDateAsSrting);
            DateTime endDate = DateTime.Parse(endDateAsString);
            TimeSpan diffrence=startDate- endDate;
            return Math.Abs(diffrence.Days);
       }
    }
}
