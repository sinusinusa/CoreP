using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePartnersTraining.Business.Entities
{
//HJ
  internal class PriceFactor
  {
    int? GetV = null;

    PriceFactor()
    {
      Console.WriteLine("again");
      Console.WriteLine("wat");
    }
    public float Omega()
    {
      return GetV == null ? 0 : GetV.Value;
      return 0.05F;
    }
  }

  internal class PriceFact
  {
    int? b = ErrorClass.GetCheck();
  }
}
