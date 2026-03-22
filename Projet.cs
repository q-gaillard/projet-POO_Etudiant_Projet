class Projet
{

    private string libelle;
    private double note;

    public Init(string p_libelle, double p_note)
    {
        libelle = p_libelle;
    }

    public string GetLibelle()
    {
        return libelle;
    }

    public double GetNote()
    {
        return note;
    }

}