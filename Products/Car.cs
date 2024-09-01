/******************************************************************************
* Filename    = Car.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'Product2' class
*****************************************************************************/
namespace Products
{
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
}
