using System;
using System.Collections.Generic;
using System.Linq;
using TransactionDataApiSettlement.Interfaces.Repository;
using TransactionDataApiSettlement.Models;

namespace TransactionDataApiSettlement.Implementation
{
    public class ShcLogManager : IDataRepository<ShclogNonPpt, string>
    {
        private readonly PesaPointUATContext modelContext;

        public ShcLogManager(PesaPointUATContext context)
        {
            modelContext = context;

        }
        public object Add(ShclogNonPpt b)
        {
            throw new NotImplementedException();
        }

        public long Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ShclogNonPpt Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShclogNonPpt> GetAll()
        {
            IList<ShclogNonPpt> students = modelContext.ShclogNonPpt.ToList<ShclogNonPpt>();

            return students;
        }

        public long Update(string id, ShclogNonPpt b)
        {
            throw new NotImplementedException();
        }
    }
}

