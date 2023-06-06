class OptionMenu
{
    private string[] MenuOptions = {"menu", "options", "option", "help", "m", "o"};
    private string[] QuitOptions = {"quit", "leave", "q"};
    private string[] RestartOptions = {"restart", "r"};

    public string filterInput(string input)
    {
        foreach(string option in MenuOptions)
            if(input.ToLower() == option)
                this.Menu();

        foreach(string option in QuitOptions)
            if(input.ToLower() == option)
                this.Quit();

        foreach(string option in RestartOptions)
            if(input.ToLower() == option)
                this.Restart();

        return "string";
    }

    private void Menu()
    {
        Console.WriteLine("Menu");
    }

    private void Quit()
    {
        Console.WriteLine("Quit");
    }

    private void Restart()
    {
        Console.WriteLine("Restart");
    }
}