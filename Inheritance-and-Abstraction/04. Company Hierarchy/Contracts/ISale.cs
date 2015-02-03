namespace Company_Hierarchy.Contracts
{
    using System;

    class ISale
    {
        string ProductName { get; set; }

        DateTime date { get; set; }

        decimal price { get; set; }
    }
}
