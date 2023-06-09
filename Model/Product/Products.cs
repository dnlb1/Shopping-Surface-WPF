﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Product
{
    public class Products : IComparable
    {
        public int ArticleNumber { get; set; }
        public string ProductName { get; set; }
        public Products(int ArticleNumber, string ProductName)
        {
            this.ArticleNumber = ArticleNumber;
            this.ProductName = ProductName;
        }
        public int CompareTo(object obj)
        {
            //Ez valósítja majd meg, hogy névszerint lehessen a listába beszúrni elemeket
            if (obj is Products)
            {
                Products other = obj as Products;
                return this.ProductName.CompareTo(other.ProductName);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == (obj as Products).GetHashCode();
        }
        public override int GetHashCode()
        {
            return ArticleNumber.GetHashCode() + ProductName.GetHashCode();
        }
    }
}
