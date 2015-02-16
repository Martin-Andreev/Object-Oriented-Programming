﻿using System;

namespace StudentClass
{
    public delegate void ChangedPropertyEventHandler(object sender, PropertyChangedEventArgs eventArgs);

    public class Student
    {
        private string name;
        private int age;
        public event ChangedPropertyEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.PropertyChanged += this.GetMessage;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null or empty!");
                }

                if (this.Name != value)
                {
                    var eventName = new PropertyChangedEventArgs { ChangedProperty = "Name", OldName = this.Name, NewName = value };
                    this.name = value;
                    this.OnChanged(this, eventName);
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can not be negative number");
                }
                if (this.age != value)
                {
                    var eventAge = new PropertyChangedEventArgs { ChangedProperty = "Age", NewAge = value, OldAge = this.Age };
                    this.age = value;
                    this.OnChanged(this, eventAge);
                }
                else
                {
                    this.age = value;
                }
            }
        }

        protected virtual void OnChanged(object sender, PropertyChangedEventArgs eventArgs)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender, eventArgs);
            }
        }

        private void GetMessage(object sender, PropertyChangedEventArgs eventArgs)
        {
            switch (eventArgs.ChangedProperty)
            {
                case "Name":
                    Console.WriteLine("Property changed: {0} (from {1} to {2})", eventArgs.ChangedProperty, eventArgs.OldName, eventArgs.NewName);
                    break;

                case "Age":
                    Console.WriteLine("Property changed: {0} (from {1} to {2})", eventArgs.ChangedProperty, eventArgs.OldAge, eventArgs.NewAge);
                    break;
            }
        }
    }
}