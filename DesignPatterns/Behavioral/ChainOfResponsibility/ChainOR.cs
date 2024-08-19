using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    //Abstract Handler
    public abstract class Handler
    {
        public Handler NextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void DispatchNote(long requestedAmount);

    }
    //Concrete Handlers

    public class FiveThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {

            //ATM 5000 Notes check how many
            long numberofNotes = requestedAmount / 5000;
            if (numberofNotes > 0)
            {   
                    Console.WriteLine($"{numberofNotes} x  five Thousand notes are dispatched");

                long pendingAmount = requestedAmount % 5000;

                if (pendingAmount > 0)
                { 
                NextHandler.DispatchNote(pendingAmount);
                }
                
            }

        }
    }

    public class OneThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {

            //ATM 5000 Notes check how many
            long numberofNotes = requestedAmount / 1000;
            if (numberofNotes > 0)
            {

                    Console.WriteLine($"{numberofNotes} x one Thousand notes are dispatched");
              

                long pendingAmount = requestedAmount % 1000;

                if (pendingAmount > 0)
                {
                    NextHandler.DispatchNote(pendingAmount);
                }

            }

        }
    }

    public class fiveHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {

            //ATM 5000 Notes check how many
            long numberofNotes = requestedAmount / 500;
            if (numberofNotes > 0)
            {

                
                    Console.WriteLine($"{numberofNotes} x five Hundred notes are dispatched");
                    
                

                long pendingAmount = requestedAmount % 500;

                if (pendingAmount > 0)
                {
                    NextHandler.DispatchNote(pendingAmount);
                }

            }

        }
    }

    public class OneHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {

            //ATM 5000 Notes check how many
            long numberofNotes = requestedAmount / 100;
            if (numberofNotes > 0)
            {

               
                    Console.WriteLine($"{numberofNotes} x One Hundred notes are dispatched");
                    
               

                long pendingAmount = requestedAmount % 100;

                if (pendingAmount > 0)
                {
                    NextHandler.DispatchNote(pendingAmount);
                }

            }

        }
    }


    //ATM
    public class ATM
    {
        private FiveThousandHandler fiveThousandHandler = new FiveThousandHandler();
        private OneThousandHandler oneThousandHandler = new OneThousandHandler();
        private fiveHundredHandler fiveHundredHandler = new fiveHundredHandler();
        private OneHundredHandler oneHundredHandler = new OneHundredHandler();        
        



        public ATM()
        {
            fiveThousandHandler.SetNextHandler(oneThousandHandler);
            oneThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(oneHundredHandler);
        }


        public void Withdraw(long requestedAmount) {
            if (requestedAmount % 100 == 0)
            {
                fiveThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }

        }

    }


}
