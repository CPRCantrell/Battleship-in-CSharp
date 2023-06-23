abstract class Player
{
    protected string name;
    protected bool winner = false;

    public bool Winner(){
        return this.winner;
    }

    public string Name(){
        return this.name;
    }

    public void SetName(string newName){
        this.name = newName;
    }

    public void Initialize()
    {
        this.InitializeName();
    }
    protected abstract void InitializeName();

    public void PlayTurn()
    {
        Console.WriteLine(this.name + " is taking their turn.");
    }
}