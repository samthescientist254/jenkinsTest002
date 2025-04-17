using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionDataApiSettlement.Models;

namespace TransactionDataApiSettlement.Queries
{
  

    public class GetAllShcLogQuery : IRequest<IEnumerable<ShclogNonPpt>>
    {
    }
}
