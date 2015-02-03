namespace Company_Hierarchy.Contracts
{
    using System;
    using Company_Hierarchy.Enumerations;

    interface IProject
    {
        string ProductName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }
    }
}
