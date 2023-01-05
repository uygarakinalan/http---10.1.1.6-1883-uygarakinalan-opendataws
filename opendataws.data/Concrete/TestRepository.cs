using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opendataws.data.Abstract;
using opendataws.entity;
using opendataws.entity.Context;

namespace opendataws.data.Concrete
{
    public class TestRepository : GenericRepository<Test,TestContext>, ITestRepository
    {

    }
}