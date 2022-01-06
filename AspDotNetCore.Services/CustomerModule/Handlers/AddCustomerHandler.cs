using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess;
using AspDotNetCore.DataAccess.Models;
using AspDotNetCore.Services.CustomerModule.Commands;
using AspDotNetCore.Services.DTOModel.ViewModel;
using AutoMapper;
using MediatR;

namespace AspDotNetCore.Services.CustomerModule.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, CustomerViewModel>
    {
        private readonly AspDotNetCoreDBContext _db;
        private readonly IMapper _mapper;
        public AddCustomerHandler(AspDotNetCoreDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CustomerViewModel> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<CustomerViewModel, Customer>(request.Customer);
            await _db.AddAsync(model);
            await _db.SaveChangesAsync();
            var customerModel = _mapper.Map<Customer,CustomerViewModel> (model);
            return customerModel;
        }
    }
}
