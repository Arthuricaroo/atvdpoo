using System.Security.AccessControl;

class Cachorro : Animal
{ 

    public Cachorro(string nome) : base(nome)
    {
        Console.WriteLine($"Cachorro: {nome}");
    }

    

    public virtual void latir(){Console.WriteLine("Latindo...");
    }
}