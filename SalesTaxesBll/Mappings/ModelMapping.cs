using AutoMapper;
using SalesTaxesBll.Dtos;
using SalesTaxesDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Mappings
{
    public class ModelMapping : Profile
    {
        public ModelMapping()
        {

            CreateMap<ItemsModel, ItemsDto>().ReverseMap();

        }
    }
}
