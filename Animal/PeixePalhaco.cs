namespace Animal;

public class PeixePalhaco: ReinoAnimal, IAnimal
{
    public PeixePalhaco(String _especie,
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
        Console.WriteLine("Peixes nadam!");
    }

    public void EmitirSom()
    {
        Console.WriteLine("blub-blub");
    }
}