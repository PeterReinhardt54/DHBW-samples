using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Observer
{
    /// <summary>
    /// The 'Observer' interface IInvestor
    /// </summary>
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
