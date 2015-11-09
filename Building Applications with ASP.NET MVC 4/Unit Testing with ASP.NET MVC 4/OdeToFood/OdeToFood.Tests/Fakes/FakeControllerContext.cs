using OdeToFood.Tests.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Tests.Fakes
{
    class FakeControllerContext : ControllerContext
    {
        HttpContextBase _context = new FakeHttpContext();

        public override System.Web.HttpContextBase HttpContext
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
            }
        }
    }
}
