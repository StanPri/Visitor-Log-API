using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;

namespace VL.Tests.Helpers
{
    //public class VisitorLogComparer : IComparer, IComparer<VisitorLog>
    //{
    //    public int Compare(object expected, object actual)
    //    {
    //        var lhs = expected as VisitorLog;
    //        var rhs = actual as VisitorLog;
    //        if (lhs == null || rhs == null) throw new InvalidOperationException();
    //        return Compare(lhs, rhs);
    //    }

    //    public int Compare(VisitorLog expected, VisitorLog actual)
    //    {
    //        int temp;
    //        return (temp = expected.VisitID.CompareTo(actual.VisitID)) != 0 ? temp : expected.Company.CompareTo(actual.Company);
    //        //return (temp = expected.VisitID.CompareTo(actual.VisitID)) != 0 ? temp : expected.ProductName.CompareTo(actual.ProductName);
    //    }
    //}
}
