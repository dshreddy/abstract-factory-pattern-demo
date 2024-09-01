/******************************************************************************
* Filename    = Bike.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'Product1' class
*****************************************************************************/
namespace Products
{
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a Bike");
        }
    }
}
