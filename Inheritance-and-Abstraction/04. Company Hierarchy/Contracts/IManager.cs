namespace Company_Hierarchy.Contracts
{
    using Company_Hierarchy.Models;
    using System;
    using System.Collections.Generic;

    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
