using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Users.Queries
{
    public record LoginQueryResponse(bool Status);
    public record LoginQuery(string Login, string Password) : IRequest<LoginQueryResponse>;

    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginQueryResponse>
    {
        public async Task<LoginQueryResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            return new LoginQueryResponse(true);
        }
    }
}
