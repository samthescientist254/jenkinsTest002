using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TransactionDataApiSettlement.Models;

namespace TransactionDataApiSettlement.Queries
{
    public class GetMultipleTrasaction : IRequest<IEnumerable<ShclogNonPpt>>
    {
        [BindRequired]
        public string start_date { get; set; }
        [BindRequired]
        public string end_date { get; set; }
        public string account { get; set; }
        public string pan { get; set; }
        public string stan { get; set; }
        public string rrn { get; set; }
        public string terminal { get; set; }

        public GetMultipleTrasaction(string startdate,string enddate, string account_,string pan_,string stan_,string rrn_,string terminal_)
        {
            start_date = startdate;
            end_date = enddate;
            account = account_;
            pan = pan_;
            stan = stan_;
            rrn = rrn_;
            terminal = terminal_;

        }
    
}
}
