namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;

        public Customer(string firstName, string midleName, string lastName, long id, string permanentAddress, string mobilePhone, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = midleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = new List<Payment>();
            this.CustomerType = customerType;
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can not be null or empty!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty!");
                }

                this.lastName = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("ID can not be negative number!");
                }

                this.id = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Permanent address can not be null or empty!");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Mobile phone can not be null or empty!");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can not be null or empty!");
                }

                this.email = value;
            }
        }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (this.MiddleName != customer.MiddleName)
            {
                return false;
            }

            if (this.LastName != customer.LastName)
            {
                return false;
            }

            if (this.Id != customer.Id)
            {
                return false;
            }

            return true;
        }

        public static bool operator == (Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }
      
        public override int GetHashCode()
        {
            return
                this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.Id.GetHashCode() ^
                this.PermanentAddress.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payments.GetHashCode() ^
                this.CustomerType.GetHashCode();
        }

        public object Clone()
        {
            List<Payment> newCustomerPayments = new List<Payment>();
            for (int i = 0; i < this.Payments.Count; i++)
            {
                newCustomerPayments.Add(this.Payments[i]);
            }

            var newCustomer = new Customer(this.FirstName, this.MiddleName, this.LastName, this.Id, this.PermanentAddress, this.MobilePhone, this.Email, newCustomerPayments, this.CustomerType);

            return newCustomer;
        }

        public int CompareTo(Customer otherCustomer)
        {
            string customerFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string otherCustomerFullName = otherCustomer.FirstName + " " + otherCustomer.MiddleName + " " + otherCustomer.LastName;

            if (customerFullName.CompareTo(otherCustomerFullName) == 0)
            {
                return this.Id.CompareTo(otherCustomer.id);
            }

            return customerFullName.CompareTo(otherCustomerFullName);
        }

        public override string ToString()
        {
            string fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;

            StringBuilder customerResult = new StringBuilder();
            customerResult.AppendLine("Name: " + fullName);
            customerResult.AppendLine("Permanent address: " + this.PermanentAddress);
            customerResult.AppendLine("Mobile phone: " + this.MobilePhone);
            customerResult.AppendLine("Email: " + this.Email);
            customerResult.Append("Payments: ");
            foreach (var payment in this.Payments)
            {
                customerResult.AppendFormat("{0} ", payment);
            }
            customerResult.AppendLine("\nCustomer type: " + this.CustomerType);
            
            return customerResult.ToString();
        }
    }
}