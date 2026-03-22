using System;

class Program
{
    static void Main(string[] args)
    {
        Etudiant etu= new Etudiant();
        etu.Init("Martinez", "Jean");

        Projet projet = new Projet();
        projet.Init("Gestion des étudiants", 17.5);

        etu.AjouterProjet(projet);
    }
}