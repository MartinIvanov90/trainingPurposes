using BankJob.Enums;
using System;

namespace BankJob.Interfaces
{
    public interface IAccount
    {
        string Customer { get; set; }
        decimal Balance { get; set; }
        double InterestRate { get; set; }
        double CalculateInterest();

    }
}
