using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opendataws.business.Abstract;
using opendataws.data.Abstract;
using opendataws.data.Concrete;
using opendataws.entity;

namespace opendataws.business.Concrete
{
    public class UsersManager : IUsersService
    {
        private IUsersRepository _usersRepository;
        public UsersManager()
        {
            _usersRepository = new UsersRepository();

        }
        public Users Create(Users test)
        {
            return _usersRepository.Create(test);
        }

        public void Delete(int id)
        {
            _usersRepository.Delete(id);
        }

        public List<Users> GetAll()
        {
            return _usersRepository.GetAll();
        }

        public Users GetById(int id)
        {
            return _usersRepository.GetById(id);
        }

        public Users Update(Users test)
        {
            return _usersRepository.Update(test);
        }


    }
}