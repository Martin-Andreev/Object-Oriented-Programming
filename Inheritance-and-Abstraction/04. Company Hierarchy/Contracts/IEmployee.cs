namespace Company_Hierarchy.Contracts
{
    using System;
    using Company_Hierarchy.Enumerations;

    interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}
