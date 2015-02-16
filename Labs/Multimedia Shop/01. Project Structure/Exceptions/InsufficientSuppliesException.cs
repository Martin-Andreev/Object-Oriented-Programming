namespace MultimediaShop.Exceptions
{
    using System;

    class InsufficientSuppliesException : SystemException
    {
        public override string Message
        {
            get
            {
                return "Insufficient quantity of products of this type";
            }
        }
    }
}
