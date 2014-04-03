using System;

namespace ClassLibrary1
{
    public class Demo : IDemo
    {
        public IOrderRepository OrderRepository { get; set; }

        public void Initialise(int id)
        {

            Console.WriteLine("Found {0} for EmployeeId == 5", OrderRepository.GetUser(id));
        }
    }
}