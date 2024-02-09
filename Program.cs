namespace carPoo;

class Carro
{
    private string marca = "Fiat";
    private string modelo = "UNO Mille";
    private string anoFabricacao = "2015";
    private string cor = "Branco";
    private string tipo = "o melhor carro do mundo!";

    public void CarDescription(){
        Console.WriteLine($"{marca} {modelo} {cor}, é {tipo}");
    }

    public void Ligar(){
        Console.WriteLine($"O {modelo} está ligado!");
    }
    public void Desligar(){
        Console.WriteLine($"O {modelo} está desligado!");
    }
    
}

