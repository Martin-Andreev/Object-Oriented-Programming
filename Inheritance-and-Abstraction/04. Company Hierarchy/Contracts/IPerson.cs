namespace Company_Hierarchy.Contracts
{
    using System;

    interface IPerson
    {
        uint Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
