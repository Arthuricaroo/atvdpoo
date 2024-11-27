class Gato : Animal
{

        public Gato(string nome) : base(nome)
    {
        Console.WriteLine($"Gato: {nome}");
    }



    public override void Emitirsom(){
        base.Emitirsom();
        Console.WriteLine("Miau");
    }
}