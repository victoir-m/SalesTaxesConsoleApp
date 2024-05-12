using System.Text.Json;
using System;
using System.IO;
using Newtonsoft.Json;
using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;
using SalesTaxesBll.Logic;
using AutoMapper;
using SalesTaxesDal.Repositories.ItemsRepository;
using SalesTaxesDal.Models;

class Program
{
    static void Main(string[] args)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ItemsModel, ItemsDto>().ReverseMap();
        });

        IMapper mapper = config.CreateMapper();
        IItemsRepo itemsrepo = new ItemsRepo();
        IGoods goods = new Goods(itemsrepo, mapper);
        IReceipt receipt = new Receipt();
        ISales _sale = new Sales(receipt, goods);

        SalesProcess(_sale, goods);
        Console.WriteLine();
        Console.WriteLine();
    }

    static void GetGoods(IGoods goods)
    {

        List<ItemsDto> items = goods.GetGoodsList();

        Console.WriteLine("Item Id\tItem Name\t\t\tPrice\t\tImported Item\tTaxable Item");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Id}\t{item.ItemName,-20}\t{item.Price,13}\t{(item.IsImported ? "Imported" : ""),15}\t{(item.IsTaxable? "Yes" : ""),15}");
        }

    }

    static void SalesProcess(ISales sales, IGoods goods)
    {
        do
        {
            Console.WriteLine();
            Console.WriteLine();

            GetGoods(goods);

            Console.WriteLine();
            Console.WriteLine();

            var basketItems = new List<BasketDto>();

            while (true)
            {
                Console.WriteLine("Please enter the Item Id as indicated above (or type 0 to checkout and -1 to stop the application) :");
                int Id;
                InputValidation(out Id);

                if (Id == 0)
                    break;

                Console.WriteLine("Enter quantity:");
                int quantity;
                InputValidation(out quantity);

                basketItems.Add(new BasketDto { Id = Id, Quantity = quantity });
            }

            string receipt = sales.Sale(basketItems);

            Console.WriteLine(receipt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Would you like to continue shopping? (yes/no)");
        } while (Console.ReadLine().ToLower() == "yes");
    }

    static void InputValidation(out int validInput)
    {
        bool isValidIntergerInput = false;
        validInput = 0;// assign default vaule incase of invalid inputs
        while (!isValidIntergerInput)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out validInput))
            {
                if (validInput == -1)
                {
                    Console.WriteLine("Application stopped.");
                    Environment.Exit(0);//stops the application if the user enters 0
                }
                isValidIntergerInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input, only numeric characters are accpeted, Please enter a valid numeric character.");
            }
        }
    }


 }

