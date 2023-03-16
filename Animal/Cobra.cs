namespace Animal;

public class Cobra : ReinoAnimal, IAnimal
{
    public Cobra(String _especie,
        int _expectativaDeVida,
        String _habitat,
        String _classe)
    {
        this._especie = _especie;
        this._expectativaDeVida = _expectativaDeVida;
        this._habitat = _habitat;
        this._classe = _classe;
    }
    public void Locomover()
    {
        Console.WriteLine("Cobras rastejam");
    }

    public void EmitirSom()
    {
        Console.WriteLine("SH-SHHH");
    }
}