using Abc.MvcWebUI2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI2.Models
{
    public class Cart
    {
        //alışveriş sepetinin tamamı ve listeden olusuyor.
        //her bir satırın toplanacağı bir liste oluştuyruz.
        private List<CartLine> _cardlines= new List<CartLine>();
        //Oluştrduğumuz CartLine'ı dışarıya gönderiyoruz
        public List<CartLine> Cardlines
        {
            get {  return _cardlines; }
        }
        //bütün ekleme silme işlemlerini bu cartline üzerinde yapacağız

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardlines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line==null)
            {
                _cardlines.Add(new CartLine {  Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardlines.RemoveAll(i=>i.Product.Id==product.Id);
        }

        public double Total()
        {
            return _cardlines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardlines.Clear();
        }
    }

    public class CartLine
    {
        //alışveriş sepetinin her bir satırı. ürünün adetini belirtiyor
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}