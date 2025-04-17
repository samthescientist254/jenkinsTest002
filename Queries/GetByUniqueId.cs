using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionDataApiSettlement.Models;

namespace TransactionDataApiSettlement.Queries
{
    public class GetByUniqueId: IRequest<IEnumerable<ShclogNonPpt>>
    {

        public string uniqueid { get; set; }

        public GetByUniqueId(string uniquef)
        {
            uniqueid = uniquef;


        }
    }
}
