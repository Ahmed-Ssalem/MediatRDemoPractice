using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{

    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {    
        private readonly IDataAccess _dataAccess;

        public GetPersonListHandler(IDataAccess data)
        {
            _dataAccess = data;
        }

        

        public async Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_dataAccess.GetPeople());
        }
    }
}
