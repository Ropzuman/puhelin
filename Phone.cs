using System;

namespace puhelin
{
    public class Phone
    {
        public string Model { private set; get; }
        public bool CallOnGoing { private set; get; } = false;

        public string Number { private set; get; }

        public Phone(string _model)
        {
            Model = _model;
        }

        public void Call(string _number)
        {
            if (CallOnGoing == true)
            {
                Console.WriteLine($"Call already on going with {Number}");
                return;
            }

            Number = _number;
            CallOnGoing = true;
            Console.WriteLine($"Calling number {Number}");
        }

        public void EndCall()
        {
            if (CallOnGoing)
            {
                CallOnGoing = false;
                Console.WriteLine("Hanging Up");
            }
            else
            {
                Console.WriteLine("No call to hang up");
            }
        }

    }
}
