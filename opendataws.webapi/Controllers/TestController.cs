using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opendataws.business.Abstract;
using opendataws.business.Concrete;
using opendataws.entity;
using opendataws.entity.Context;
using opendataws.entity.Entities;
using opendataws.entity.Entities.Views;

namespace opendataws.webapi.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : ControllerBase
    {

        private ITestService _testService;

        public TestController()
        {
            _testService = new TestManager();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public string getTest()
        {
            return "asdasd";
        }

        [HttpGet]
        public List<Test> getAll()
        {
            return _testService.GetAll();
        }

        [HttpGet("{id}")]
        public Test getTestId(int id)
        {
            return _testService.GetById(id);
        }

        [HttpPost]
        public Test addTest([FromBody] Test test)
        {
            //Test _test = new Test();
            //_test.Name = "asddsa";
            //_test.TypeId = 1;
            return _testService.Create(test);

        }

        [HttpPut]
        public Test updateTest()
        {
            Test _test = new Test();
            _test.Id = 12;
            _test.Name = "uygar";
            _test.TypeId = 2;
            return _testService.Update(_test);

        }

        [HttpPost]
        public void deleteTest([FromBody] int id)
        {
            _testService.Delete(id);
        }

        [HttpGet]
        public List<TypeView> listeGetirMaster()
        {
            using (var context = new TestContext())
            {
                return context.TypeView.ToList();
            }

        }

    }
}