using MediatR;
using SchoolManagment.Core.Bases;
using SchoolManagment.Data.Helper;

namespace SchoolManagment.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthModel>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
