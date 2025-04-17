using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TransactionDataApiSettlement.Interfaces.Repository;
using TransactionDataApiSettlement.Models;
using TransactionDataApiSettlement.Queries;

namespace TransactionDataApiSettlement.Handlers
{

    public class GetAllShcLogQueryHandler : IRequestHandler<GetAllShcLogQuery, IEnumerable<ShclogNonPpt>>
    {
        private readonly IDataRepository<ShclogNonPpt, string> _iRepo;

        public GetAllShcLogQueryHandler(IDataRepository<ShclogNonPpt, string> REpo)
        {
            _iRepo = REpo;
        }
        public async Task<IEnumerable<ShclogNonPpt>> Handle(GetAllShcLogQuery request, CancellationToken cancellationToken)
        {
            return _iRepo.GetAll();
        }
    }
}
