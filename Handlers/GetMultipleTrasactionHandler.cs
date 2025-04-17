using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TransactionDataApiSettlement.ArbiterModels;
using TransactionDataApiSettlement.Interfaces.Repository;
using TransactionDataApiSettlement.Models;
using TransactionDataApiSettlement.Queries;

namespace TransactionDataApiSettlement.Handlers
{
    public class GetMultipleTrasactionHandler : IRequestHandler<GetMultipleTrasaction, IEnumerable<ShclogNonPpt>>
    {

        private readonly IDataRepository<ShclogNonPpt, string> _iRepo;
        public GetMultipleTrasactionHandler(IDataRepository<ShclogNonPpt, string> REpo)
        {
            _iRepo = REpo;

        }
        public async Task<IEnumerable<ShclogNonPpt>> Handle(GetMultipleTrasaction request, CancellationToken cancellationToken)
        {
          

            var result= _iRepo.GetAll().OrderByDescending(u=>u.LocalDate).Take(10000).Where(y => y.LocalDate >= Convert.ToDateTime(request.start_date) && y.LocalDate <= Convert.ToDateTime(request.end_date)).ToList();
        
            return result;



        }
    }


}
