﻿using System;

namespace PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get 
            { 
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                     throw new ArgumentNullException("Details cannot be empty!");
                }
                this.details = value;
            }
        }

        public decimal Price 
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative number!");
                }
                this.price = value;
            } 
        }
    }
}
