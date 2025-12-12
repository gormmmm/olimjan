using System;
using System.Collections.Generic;

namespace ClassTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CLASS TASKS ===");

            // Run ONE task at a time by commenting / uncommenting

             Task1_BankAccount();
            // Task2_ShoppingCart();
            // Task3_Library();
            // Task4_EmployeePayroll();
            // Task5_HotelRoom();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // -------------------------------------------------
        // TASK 1: BANK ACCOUNT
        // -------------------------------------------------
        static void Task1_BankAccount()
        {
            // =================================================
            // TASK 1: BANK ACCOUNT
            // =================================================
            // TODO:
            // class BankAccount
            // - Owner (string, read-only)
            // - Balance (decimal, read-only)
            // - Constructor(owner, initialBalance)
            // - Deposit(decimal amount)
            //   * reject non-positive
            // - Withdraw(decimal amount)
            //   * reject non-positive
            //   * reject if insufficient funds
            // - PrintInfo()
            
            Console.WriteLine("\n=== BANK ACCOUNT ===");

            var aliceBankAccount = new BankAccount("Alice");

            Console.WriteLine(aliceBankAccount.Owner);
            Console.WriteLine(aliceBankAccount.Balance);
            Console.WriteLine(aliceBankAccount.PrintInfo());
            
            aliceBankAccount.Deposit(100);
            aliceBankAccount.Deposit(150);
            aliceBankAccount.Deposit(-150);
            aliceBankAccount.Deposit(50);
            Console.WriteLine(aliceBankAccount.PrintInfo());
            
            aliceBankAccount.Withdraw(100);
            aliceBankAccount.Withdraw(200);
            aliceBankAccount.Withdraw(-200);
            aliceBankAccount.Withdraw(200);
            Console.WriteLine(aliceBankAccount.PrintInfo());
            

            // TODO 1:
            // Create a BankAccount for "Alice"

            // TODO 2:
            // Print account info

            // TODO 3:
            // Ask user for deposit amount and call Deposit

            // TODO 4:
            // Ask user for withdraw amount and call Withdraw

            // TODO 5:
            // Print final account info
        }

        // -------------------------------------------------
        // TASK 2: SHOPPING CART
        // -------------------------------------------------
        static void Task2_ShoppingCart()
        {
            // =================================================
            // TASK 2: SHOPPING CART
            // =================================================
            // TODO:
            // class Cart
            // - private List<CartItem>
            // - AddItem(CartItem item)
            // - GetSubtotal()
            // - GetVat(decimal rate)
            // - GetTotal(decimal rate)
            // - PrintReceipt(decimal rate)

            // class CartItem
            // - Name
            // - UnitPrice
            // - Quantity
            // - GetLineTotal()
            // - validate quantity > 0, unit price >= 0
            
            Console.WriteLine("\n=== SHOPPING CART ===");

            // TODO 1:
            // Create Cart

            // TODO 2:
            // Add at least 3 CartItem objects (hardcoded)

            // TODO 3:
            // Print receipt:
            // - item lines
            // - subtotal
            // - VAT (23%)
            // - total
        }

        // -------------------------------------------------
        // TASK 3: LIBRARY
        // -------------------------------------------------
        static void Task3_Library()
        {
            // =================================================
            // TASK 3: LIBRARY
            // =================================================
            // TODO:
            // class Book
            // - Title
            // - Author
            // - IsBorrowed (private set)
            // - Borrow()
            // - Return()

            // class Library
            // - private List<Book>
            // - AddBook(Book book)
            // - PrintAll()
            // - Borrow(string title)
            
            Console.WriteLine("\n=== LIBRARY ===");

            // TODO 1:
            // Create Library

            // TODO 2:
            // Add a few books

            // TODO 3:
            // Print all books

            // TODO 4:
            // Ask user for title to borrow

            // TODO 5:
            // Borrow book

            // TODO 6:
            // Print books again
        }

        // -------------------------------------------------
        // TASK 4: EMPLOYEE PAYROLL
        // -------------------------------------------------
        static void Task4_EmployeePayroll()
        {
            // =================================================
            // TASK 4: EMPLOYEE
            // =================================================
            // TODO:
            // class Employee
            // - Name
            // - HourlyRate
            // - CalculateMonthlyPay(int hoursWorked)
            // - PrintPayslip(int hoursWorked)
            // - validate hours >= 0, rate >= 0
            
            Console.WriteLine("\n=== EMPLOYEE PAYROLL ===");

            // TODO 1:
            // Create Employee with name and hourly rate

            // TODO 2:
            // Ask user for hours worked

            // TODO 3:
            // Calculate monthly salary

            // TODO 4:
            // Print payslip

            // EXTRA:
            // Hours above 160 are paid 1.5x
        }

        // -------------------------------------------------
        // TASK 5: HOTEL ROOM
        // -------------------------------------------------
        static void Task5_HotelRoom()
        {
            // =================================================
            // TASK 5: HOTEL ROOM
            // =================================================
            // TODO:
            // class Room
            // - RoomNumber
            // - PricePerNight
            // - IsBooked
            // - CurrentGuest
            // - Nights
            // - Book(string guest, int nights)
            //   * prevent double booking
            //   * validate input
            // - GetTotalPrice()
            // - Checkout()
            // - PrintStatus()
            
            Console.WriteLine("\n=== HOTEL ROOM ===");

            // TODO 1:
            // Create Room (room number, price per night)

            // TODO 2:
            // Print initial room status

            // TODO 3:
            // Ask user for guest name and number of nights

            // TODO 4:
            // Book room

            // TODO 5:
            // Print booking summary (total price)

            // TODO 6:
            // Checkout

            // TODO 7:
            // Print final room status
        }
    }
}
