using MPTI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPTI.Services
{
    public class LoginService : IloginRepository
    {
        Task<UserInfo> IloginRepository.Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
