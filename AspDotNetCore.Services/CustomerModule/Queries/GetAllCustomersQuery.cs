using System;
using System.Collections.Generic;
using System.Text;
using AspDotNetCore.Services.DTOModel.ViewModel;
using MediatR;

namespace AspDotNetCore.Services.CustomerModule.Queries
{
    public class GetAllCustomersQuery : IRequest<List<CustomerViewModel>>
    {
    }
}
