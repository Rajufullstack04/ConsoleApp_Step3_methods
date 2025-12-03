using System;

namespace ExceptionHandling
{
    /*
     * 
    An Exception is an unexpected issue that occurs in a program, preventing it from executing as intended. 
    It can happen due to coding mistakes, system failures, or invalid user inputs, requiring correction to proceed.

    Types of Exceptions: Exceptions in C# can be of various types, such as System.Exception, 
    System.ArgumentException, System.NullReferenceException, System.DivideByZeroException, etc. 
    Each exception type represents a specific kind of error that may occur during program execution.

    Try-Catch Blocks: Exception handling in C# is typically done using try-catch blocks. 
    The try block contains the code that may throw an exception, and the catch block handles the exception if one occurs.

      Syntax :
        try
        {
            // Code that may throw an exception
        }
        catch (Exception ex)
        {
            // Handle the exception
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // Code that always executes (cleanup, closing connections, etc.)
        }

     */

    // Class representing a Bank Account
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
    }

    class Program
    {
        static void WithdrawMoney(BankAccount account, double amount)
        {
            try
            {
                // Check if account object is null
                if (account == null)
                {
                    throw new NullReferenceException("Account object is missing!");
                }

                // Check if withdrawal amount is valid
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be greater than zero!");
                }

                // Check if balance is sufficient
                if (amount > account.Balance)
                {
                    throw new InvalidOperationException("Insufficient balance for withdrawal!");
                }

                // Perform withdrawal
                account.Balance -= amount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {account.Balance}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General catch block for any other unexpected exceptions
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // This block always executes
                Console.WriteLine("Transaction attempt completed.");
            }
        }

        static void Main()
        {
            // Example 1: Valid withdrawal
            BankAccount account1 = new BankAccount { AccountHolder = "Raju", Balance = 5000 };
            WithdrawMoney(account1, 2000);

            // Example 2: Invalid withdrawal amount
            BankAccount account2 = new BankAccount { AccountHolder = "Raju", Balance = 3000 };
            WithdrawMoney(account2, -500);

            // Example 3: Insufficient balance
            BankAccount account3 = new BankAccount { AccountHolder = "Raju", Balance = 1000 };
            WithdrawMoney(account3, 2000);

            // Example 4: Null account object
            BankAccount account4 = null;
            WithdrawMoney(account4, 1000);
        }
    }
}