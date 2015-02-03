namespace Company_Hierarchy.Contracts
{
    using System;
    using System.Collections.Generic;
    using Company_Hierarchy.Models;

    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
