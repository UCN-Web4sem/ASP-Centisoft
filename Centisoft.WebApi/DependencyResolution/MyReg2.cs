using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centisoft.WebApi.DependencyResolution
{
    using Centisoft.Core.BLL;
    using Centisoft.Core.Contracts;
    using Centisoft.Core.DAL;
    using Centisoft.Core.Models;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    public class MyReg2 : Registry
    {
        public MyReg2()
        {
            For<IDeveloperFacade>().Use<DeveloperFacade>();
            For<IUoW>().Use<UoWData>();
            For<IGenericInterface<Developer>>().Use<GenericRepo<Developer>>();

        }
    }
}