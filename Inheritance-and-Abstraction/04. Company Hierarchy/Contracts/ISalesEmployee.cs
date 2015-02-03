namespace Company_Hierarchy.Contracts
{
    using System;
    using System.Collections.Generic;
    using Company_Hierarchy.Models;

    interface ISalesEmployee
    {
        List<ISale> Sales { get; set; }
    }
}
