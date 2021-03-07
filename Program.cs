using Microsoft.Azure.Amqp.Framing;
using System;


namespace bankacckawser
{
  
  class Progran
  {
     
       public class Account
       {
            private const int open = 1;
            private const int account = 2;
            private const int savings = 3;
            private const int checking = 4;
            private const int quit = 5;
            private const int deposit = 6;
            private const int withdraw = 7;
            private const int transfer = 8;
            private const int change = 9;
            private const int show = 10;
            private const int Quit = 11;

            
       }
      
      static void Main(string[] args)
      {
            Account bank = new Account();
            int balance = 10000;
            int tk = 5000;
            int Num = 18368371;
            int dep, wit;
            int ch;
            int name;
            int trans;
            int num;
            int DateOfBirth = 23;
            int Address = 3422;
            int ID = 20433754;


            Console.WriteLine("OPEN YOUR ACCOUNT\n");
            Console.WriteLine("Enter Date of Birth:");
            DateOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address:");
            Address = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");


         while (true)
         {
            Console.WriteLine("1.open \n\n");
            Console.WriteLine("2.account\n\n");


            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case open:
                    Console.WriteLine("\n\n OPEN AN ACCOUNT\n\n");

                    Console.WriteLine("3. savings\n");
                    Console.WriteLine("4.checking \n");
                    Console.WriteLine("s.quit\n\n\n");


                    while (true)
                    {
                        ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case savings:

                                Console.WriteLine("\n\n OPEN SAVING ACCOUNT ");
                                Console.WriteLine("\n\n Transaction ID:");
                                ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n Date of Birth:\n ");
                                DateofBirth = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n Address:\n ");
                                Address = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n Your saving Money is : {e}", tk);
                                break;

                            case checking:
                                
                                Console.WriteLine("\n\n OPEN CHAKING ACCOUNT");
                                Console.WriteLine("\n\n Your Balance is : {O}", balance);
                                break;


                            case checking:
                                Console.WriteLine("\n\n OPEN A CHAKING ACCOUNT" );
                                Console.WriteLine("\n\n Your Balance is : {O}", balance);
                        break;

                            case quit:
                                Console.WriteLine("\n Exit The Application");
                                return;
                        }
                    }


                    case account:
                          Console.WriteLine("\n\n PERFORM TRANSACTIoNS ON AN ACCOUNT ");


                    while (true)
                    {
                        Console.WriteLine("6. deposit\n");
                        Console.WriteLine("7. withdraw\n");
                        Console.WriteLine("8. transfer\n");
                        Console.WriteLine("9. chnage\n");
                        Console.WriteLine("10. show\n’");
                        Console.WriteLine("11. Quit\n\n\n");
                        ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                                case deposit:
                                Console.WriteLine(" Make a Deposit\n");
                                Console.WriteLine("\n Enter the amount to be deposited");

                                dep = int.Parse(Console.ReadLine());
                                balance = balance + dep;
                                Console.WriteLine("\n Current Balance is {O}\n\n", balance);
                                break;

                            case withdraw:
                                Console.WriteLine("Make a Withdrawal\n");
                                Console.WriteLine("Account to be withdrawed");
                                wit = int.Parse(Console.ReadLine());
                                if (wit % 100 != 0)
                                {
                                    Console.WriteLine("\n\nEnter the amount in Multip1e of 100");
                                }
                                   

                                    else if (wit > (balance = 200))
                                    {
                                        Console.WriteLine("\n Insufficient Fund");
                                    }

                                  else
                                  {
                                        balance = balance = wit;
                                        Console.WriteLine("\n Take Your Money");
                                        Console.WriteLine("\n Current Balance is {0}\n\n", balance);


                                  }

                                    break;

                            case transfer:
                                Console.WriteLine("make A TRANsFER\n\n");
                                Console.WriteLine("Give Transaction ID Where You Want to Transfer\n");
                                ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Give Transfer Anmnount\n");
                                trans = int.Parse(Console.ReadLine());
                                balance = balance - trans;
                                Console.WriteLine("\n successfully Transfered\n");
                                Console.WriteLine("\n Current Balance is {0}\n\n", balance);
                                break;
                            case change:
                                Console.WriteLine("CHANGE OWNER NAME\n");
                                Console.WriteLine("Input New Name");
                                name = int.Parse(Console.ReadLine());
                                break;
                            case show:
                                Console.WriteLine("SHOW THE NUMBER TRANSACTIONS\n");
                                Console.WriteLine("New Transactions Number : {O}", Num);
                                num = int.Parse(Console.ReadLine());
                                break;
                            case Quit:
                                Console.WriteLine("\n THANK YOU FoR VISITING OUR SITE\n\n");
                                return;



                        }
                    }
            }
         }
      }
  }
}
