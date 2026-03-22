class Etudiant
{
    private string nom;
    private string prenom;
    private Projet[] tabProjet;
    private int nbProjets;

    public Init(string p_nom, string prenom)
    {
        nom = p_nom;
        prenom = p_prenom;
        tabProjet = new Projet[20];
        nbProjets = 0;
    }

    public string GetPrénom()
    {
        return prenom;
    }

    public string GetNom()
    {
        return nom;
    }

    public int GetNbProjets()
    {
        return nbProjets;
    }

    public void AjouterProjet(Projet p_leProjet)
    {
        if (!nbProjets = 20)
        {
            tabProjet[nbProjets + 1];
            nbProjets++;
        }
        else
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("| ! | le tableau des projets est plein | ! |");
            Console.WriteLine("--------------------------------------------");
        }
    }

    public double GetMoyenne()
    {
        double result = 0;
        foreach(Projet projet in tabProjet)
        {
            result = result + projet.GetNote();
        }
        return result;
    }

    public Projet MeilleurProjet()
    {
        Projet result = tabProjet[0];
        foreach(Projet projet in tabProjet)
        {
            if (projet.GetNote > result.GetNote)
            {
                result = projet;
            }
        }
        return result;
    }
}