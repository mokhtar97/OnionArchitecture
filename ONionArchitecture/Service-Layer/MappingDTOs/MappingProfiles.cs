using AutoMapper;
using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.MappingDTOs
{
    class MappingProfiles:Profile
    {
        public MappingProfiles()
        {

            CreateMap<Product, ProductDTO>().ReverseMap();
              

        }
    }
}
