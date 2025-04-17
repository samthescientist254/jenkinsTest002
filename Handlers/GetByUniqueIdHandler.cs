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
    public class GetByUniqueIdHandler : IRequestHandler<GetByUniqueId, IEnumerable<ShclogNonPpt>>
    {

        private readonly IDataRepository<ShclogNonPpt, string> _iRepo;
        public GetByUniqueIdHandler(IDataRepository<ShclogNonPpt, string> REpo)
        {
            _iRepo = REpo;

        }
        public async Task<IEnumerable<ShclogNonPpt>> Handle(GetByUniqueId request, CancellationToken cancellationToken)
        {


            var result = _iRepo.GetAll().OrderByDescending(u => u.LocalDate).Take(10000).Where(y => y.Id == Convert.ToInt32(request.uniqueid) ||  y.SmsId <= Convert.ToInt64(request.uniqueid)).ToList();

            return result;



        }
    }
}
