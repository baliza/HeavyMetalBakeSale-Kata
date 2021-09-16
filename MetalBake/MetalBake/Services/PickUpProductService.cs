using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PickUpProductService : IPickUpProductServiceable
    {
        private readonly IStockProductServiceable _iStockService;
        private readonly IPaymentServiceable _paymentService;
        private readonly ICoinsServiceable _coinsService;
        private readonly ICalculatorServiceable _calculatorService;

        public static Dictionary<char, Product> _currentProducts = Setup();
        private static Dictionary<char, Product> Setup()
        {
            Dictionary<char, Product> currentProducts = new Dictionary<char, Product>();
            currentProducts.Add('B', new Product(0, "Brownie", 0.65m));
            currentProducts.Add('M', new Product(1, "Muffin", 1.00m));
            currentProducts.Add('C', new Product(2, "Cake Pop", 1.35m));
            currentProducts.Add('W', new Product(3, "Water", 1.50m));
            return currentProducts;
        }
        
        public PickUpProductService(IStockProductServiceable iStockService, IPaymentServiceable paymentService,
                                    ICoinsServiceable coinsService, ICalculatorServiceable calculatorService)
        {
            _iStockService = iStockService;
            _paymentService = paymentService;
            _coinsService = coinsService;
            _calculatorService = calculatorService;
        }

        public List<Product> GetCurrentProducts()
        {
            List<Product> products = new List<Product>(_currentProducts.Count);
            foreach (var i in _currentProducts)
            {
                products.Add(i.Value);
            }

            return products;
        }

        public void PickProduct(Product product, decimal totalCoins)
        {
            if (!_iStockService.IsInStock(product, 1))
            {
                Console.WriteLine($"Product {product._name} isnt in stock");
                return;
            }

            if (!_paymentService.CoinsAreEnough(product._price, totalCoins)) {
                Console.WriteLine($"Total Coins ({totalCoins.ToString()}) are less than {product._price.ToString()}$");
                return;
            }

            if (_paymentService.NeedMoneyBack(product._price, totalCoins))
            {
                _coinsService.AddCoins(totalCoins-(totalCoins - product._price));
                Console.WriteLine($"You get back {(totalCoins - product._price)}$");
            }
            else {
                _coinsService.AddCoins(totalCoins);
            }
            _iStockService.RemoveUnit(product);
            Console.WriteLine($"Enjoy your {product._name}!");
        }

        public void PickProducts(Dictionary<Product, int> products, decimal totalCoins)
        {
            foreach (var i in products)
            {
                if (!_iStockService.IsInStock(i.Key, i.Value))
                {
                    Console.WriteLine($"Product {i.Key._name} isnt in stock");
                    return;
                }
            }

            decimal totalOfDictionary = _calculatorService.CalculateTotalOfDictionary(products);

            if (!_paymentService.CoinsAreEnough(totalOfDictionary, totalCoins))
            {
                Console.WriteLine($"Total Coins ({totalCoins.ToString()}) are less than {totalCoins.ToString()}$");
                return;
            }

            if (_paymentService.NeedMoneyBack(totalOfDictionary, totalCoins))
            {
                decimal diff = _calculatorService.CalculateDifference(products, totalCoins);
                _coinsService.AddCoins(totalCoins - diff);
                Console.WriteLine($"You get back {diff}$ coins");
            } else {
                _coinsService.AddCoins(totalCoins);
            }

            foreach (var i in products)
            {
                _iStockService.RemoveUnitMultiple(i.Key, i.Value);
            }
            Console.WriteLine($"Enjoy your products!");
        }
    }
}
