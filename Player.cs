class Player
{
    private string name;
    private bool winner;

    public bool Winner(){
        return this.winner;
    }

    public string Name(){
        return this.name;
    }

    public void SetName(string newName){
        this.name = newName;
    }

    public void PlayTurn()
    {
        Console.WriteLine(this.name + " is taking their turn.");
    }
}