class Animal
{
    public Animal(string nome){
        Console.WriteLine($"Animal: {nome}");
    }
public void comer(){Console.WriteLine("Comendo...");}

public virtual void Emitirsom(){
    Console.WriteLine("Som de animal");
}
}
