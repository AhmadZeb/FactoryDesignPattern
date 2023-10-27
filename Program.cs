using System.Buffers.Text;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //the Factory Design Pattern states that A factory is an object used for
           //creating other objects.In technical terms, we can say that a factory
           //is a class with a method.That method will create and return different
           //objects based on the received input parameter.

            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}