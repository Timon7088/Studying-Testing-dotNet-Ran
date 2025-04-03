using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.users
{
    public class User
    {
        private string username;
        private List<TypesOfUsres> roles = new List<TypesOfUsres>();

        public List<TypesOfUsres> Roles { get => roles; set => roles = value; }
        public string Username { get => username; set => username = value; }
        public bool CanOpenTable()
        {
            return roles != null && roles.Any(role => role == TypesOfUsres.ADMIN || role == TypesOfUsres.MANAGER);
        }
    }
}
