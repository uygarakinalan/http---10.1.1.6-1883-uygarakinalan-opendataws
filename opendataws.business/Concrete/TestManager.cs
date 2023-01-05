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
    public class TestManager : ITestService
    {
        private ITestRepository _testRepository;

        public TestManager()
        {
            _testRepository = new TestRepository();
        }
        public Test Create(Test test)
        {
          return  _testRepository.Create(test);
        }
        public void Delete(int id)
        {
            _testRepository.Delete(id);
        }

        public List<Test> GetAll()
        {
            return _testRepository.GetAll();
        }

        public Test GetById(int id)
        {
            return _testRepository.GetById(id);
        }

        public Test Update(Test test)
        {
            
           return _testRepository.Update(test);
        }

        
    }
}