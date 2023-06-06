class Ai : Player
{
    private string[] AiNames = new string[] {"M3gan", "Bastion", "iRobot"};

    override protected void InitializeName()
    {
        Random random = new Random();
        this.name = AiNames[random.Next(0, this.AiNames.Length)];
    }
}