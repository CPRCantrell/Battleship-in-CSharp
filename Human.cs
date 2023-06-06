class Human : Player
{
    override protected void InitializeName()
    {
        while(true){
            try
            {
                Console.Write("Enter your name: ");
                this.name = Console.ReadLine().Split(" ").Where(character => character != "").ToArray()[0];
                break;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine($"Invalid Entry!");
            }
        }
    }
}