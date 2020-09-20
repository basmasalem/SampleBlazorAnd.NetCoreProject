using AutoMapper;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EditEmployeeModel>();
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}
