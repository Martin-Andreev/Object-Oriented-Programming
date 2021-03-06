﻿using System;

namespace _02.Laptop_Shop
{
    class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public Battery(string batteryModel) : this(batteryModel, 0) { }

        public string BatteryModel
        {
            get { return this.batteryModel;  }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The value of battery type cannot be empty!");
                }
                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Battery life cannot be negative number!");
                }
                this.batteryLife = value;
            }
        }

    }
}
