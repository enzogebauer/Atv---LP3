namespace AnimalSemRef;

public class Cobra
{
    public string especie;
    public string habitat;
    public string classe;
    public int expectativaDeVida;

    public Cobra(string especie, string habitat, string classe, int expectativaDeVida)
    {
        this.especie = especie;
        this.habitat = habitat;
        this.classe = classe;
        this.expectativaDeVida = expectativaDeVida;
    }


    public void EmitirSom()
    {
        Console.WriteLine("SH-SHHH");
    }

    public void Locomover()
    {
        Console.WriteLine("Cobras rastejam");
    }

}