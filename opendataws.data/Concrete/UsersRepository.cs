using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opendataws.data.Abstract;
using opendataws.data.Context;
using opendataws.entity;

namespace opendataws.data.Concrete
{
    public class UsersRepository : GenericRepository<Users, UsersContext>, IUsersRepository
    {

    }
}