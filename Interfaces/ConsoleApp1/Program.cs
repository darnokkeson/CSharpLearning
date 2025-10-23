namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door leftDoor = new Door();

            leftDoor.Interact();
        }

        interface IInteractable
        {
            void Interact();
        }

        class Door : IInteractable
        {
            public void Interact()
            {
                Console.WriteLine("Door open.");
            }
        }
    }
}