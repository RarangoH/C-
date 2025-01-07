
char[] validInputs = { 'S', 'A', 'R', 'E' };
string input = "";
int contador = 0;
List<string> inputs = new List<string>();






void pregunta()
{
    loop();
    void loop()
    {
        do
        {
            Console.WriteLine("Hello");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            input = Console.ReadLine();


        } while (!validation(input.ToUpper()));
    }

    bool validation(string userInput)
    {
        for (int i = 0; i < validInputs.Length; i++)
        {
            if (validInputs[i] == Char.Parse(userInput))
            {
                Console.WriteLine("Opcion Valida");
                ciclos();
                return true;
            }

        }
        Console.WriteLine("Opcion No Valida");
        return false;
    }
    void ciclos()
    {
        if (Char.Parse(input.ToUpper()) == 'S')
        {
            seeTodos();

        }
        else if (Char.Parse(input.ToUpper()) == 'A')
        {
            addTodos();
        }
        else if (Char.Parse(input.ToUpper()) == 'R')
        {
            removeTodos();
        }
        else if (Char.Parse(input.ToUpper()) == 'E')
        {
            Console.WriteLine("Exit");
        }
        else
        {
            Console.WriteLine("Opcion NO Valida");
        }
    }


    void seeTodos()
    {
        foreach (string input in inputs)
        {
            Console.WriteLine($"{input}");
            
        }
        pregunta();
    }

    void addTodos()
    {
        string inp = Console.ReadLine();
        inputs.Add(inp);
        pregunta();
    }

    void removeTodos()
    {
        string remove = Console.ReadLine();
        foreach (string word in inputs)
        {
            if (word == remove)
            {
                inputs.Remove(remove);
                pregunta();
                break;
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
        pregunta();

    }







}


pregunta();
Console.WriteLine("FinCiclos");
Console.ReadKey();



