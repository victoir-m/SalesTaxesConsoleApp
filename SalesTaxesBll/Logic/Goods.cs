using AutoMapper;
using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;
using SalesTaxesDal.Repositories.ItemsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Logic
{
    public class Goods : IGoods
    {
        private readonly IItemsRepo _itemsRepo;
        private readonly IMapper _mapper;

        public Goods(IItemsRepo itemsRepo, IMapper mapper)
        {
            _itemsRepo = itemsRepo;
            _mapper = mapper;
        }

        public ItemsDto GetGood(int Id)
        {
            var res = _itemsRepo.GetItem(Id);

            var item = res != null ? _mapper.Map<ItemsDto>(res) : new ItemsDto { ItemName = "Item does not exist"};

            return item;
        }

        public List<ItemsDto> GetGoodsList()
        {
            var res = _itemsRepo.GetItems();

            var items = _mapper.Map<List<ItemsDto>>(res);

            return items;
        }
    }
}
