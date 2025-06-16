using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_karamov
{
    class Shop 
    {

        private Dictionary<Product, int> products;

        private decimal profit = 0; //Прибыль

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Profit
        {
            get { return profit; }
            set { profit = value; }
        }

        public Dictionary<Product, int> Products
        {
            get { return products; }
            set { products = value; }
        }

        public Shop()
        {
            products = new Dictionary<Product, int>(); //При создании магазина инициализируется словарь с продуктами
        }
        public void AddProduct(Product product, int count) //Добавление уже созданного продукта
        {
            products.Add(product, count);
        }
        public void CreateProduct(string name, decimal price, int count) //Создание и добавление продукта
        {
            products.Add(new Product(name, price), count);
        }

        public string WriteAllProducts() //Вывод всех продуктов
        {
            string info = "Список продуктов:\n";
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    info += product.Key.GetInfo() + "; Количество: " + product.Value + "\n";
                }
            }
            return info;
        }
        public Product FindByName(string name) //Поиск продукта по ключу
        {
            foreach (var product in products.Keys)
            {
                if (product.name == name)
                {
                    return product;
                }
            }
            return null;
        }
        public string Sell(Product product) //Продажа продукта
        {
            string info = "Товар продан";
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    info = "Нет в наличии!";
                }
                else
                {
                    products[product]--;
                    ShopProfit(product.price);
                }
            }
            else
            {
                info = "Товар не найден";
            }
            return info;
        }
        public string Sell(string ProductName) //Перегрузка метода продажи продукта
        {
            Product ToSell = FindByName(ProductName);
            string info = "Продано";
            if (ToSell != null)
            {
                info = this.Sell(ToSell);
            }
            else
            {
                info = "Товар не найден";
            }
            return info;
        }

        public void ShopProfit(decimal money) //Прибавка к прибыли
        {
            this.profit += money;
        }

        public string ShopProfit() //Перегрузка метода, которая выводит прибыль
        {
            return $"Прибыль магазина {name} = {profit}";
        }
    }
}
