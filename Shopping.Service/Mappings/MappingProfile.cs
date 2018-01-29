using AutoMapper;
using Shopping.Data;
using Shopping.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCateCreateModel, ProductCate>();
            


        }
    }
}
