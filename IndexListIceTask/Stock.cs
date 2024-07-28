using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexListIceTask
{
    public class Stock
    {
        private double price;
        private string itemID, name, supplier, category;

        public Stock(double price, string itemID, string name, string supplier, string category)
        {
            this.price = price;
            this.itemID = itemID;
            this.name = name;
            this.supplier = supplier;
            this.category = category;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.itemID;
                }
                else if (index == 1)
                {
                    return this.name;
                }
                else if (index == 2)
                {
                    return this.supplier;
                }
                else if (index == 3)
                {
                    return this.category;
                }
                else if (index == 4)
                {
                    return this.price;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    this.itemID = (string)value;
                }
                else if (index == 1)
                {
                    this.name = (string)value;
                }
                else if (index == 2)
                {
                    this.supplier = (string)value;
                }
                else if (index == 3)
                {
                    this.category = (string)value;
                }
                else if (index == 4)
                {
                    this.price = (double)value;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("itemid"))
                {
                    return this.itemID;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    return this.name;
                }
                else if (attrName.ToLower().Equals("supplier"))
                {
                    return this.supplier;
                }
                else if (attrName.ToLower().Equals("category"))
                {
                    return this.category;
                }
                else if (attrName.ToLower().Equals("price"))
                {
                    return this.price;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (attrName.ToLower().Equals("itemid"))
                {
                    this.itemID = (string)value;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    this.name = (string)value;
                }
                else if (attrName.ToLower().Equals("supplier"))
                {
                    this.supplier = (string)value;
                }
                else if (attrName.ToLower().Equals("category"))
                {
                    this.category = (string)value;
                }
                else if (attrName.ToLower().Equals("price"))
                {
                    this.price = (double)value;
                }
            }
        }
    }
}
