using System;
using System.Collections.Generic;
using GestionReservations;

var ressources = new List<Ressource>();
var reservations = new List<Reservation>();

Console.Write("Combien de ressources voulez-vous ajouter ? ");
int nbRessources = int.Parse(Console.ReadLine()!);

for (int i = 0; i < nbRessources; i++)
{
    var res = new Ressource();
    Console.WriteLine($"\nRessource {i + 1}");
    Console.Write("Nom : ");
    res.Nom = Console.ReadLine()!;
    Console.Write("Adresse : ");
    res.Adresse = Console.ReadLine()!;
    Console.Write("Email : ");
    res.Email = Console.ReadLine()!;
    Console.Write("Type (Salle/Chambre/Equipement) : ");
    string t = Console.ReadLine()!;
    res.Type = t.ToLower() switch
    {
        "salle" => TypeRessource.Salle,
        "chambre" => TypeRessource.Chambre,
        "equipement" => TypeRessource.Equipement,
        _ => TypeRessource.Salle
    };
    ressources.Add(res);
}

Console.Write("\nCombien de réservations voulez-vous ajouter ? ");
int nbResa = int.Parse(Console.ReadLine()!);

for (int i = 0; i < nbResa; i++)
{
    var r = new Reservation();
    Console.WriteLine($"\nRéservation {i + 1}");
    Console.Write("Nom de l'organisation : ");
    r.Nom = Console.ReadLine()!;
    Console.Write("Adresse : ");
    r.Adresse = Console.ReadLine()!;
    Console.Write("Email : ");
    r.Email = Console.ReadLine()!;
    Console.Write("Nom du client : ");
    r.ClientNom = Console.ReadLine()!;
    Console.Write("Email du client : ");
    r.ClientEmail = Console.ReadLine()!;

    Console.WriteLine("Choisir une ressource :");
    for (int j = 0; j < ressources.Count; j++)
        Console.WriteLine($"{j + 1}. {ressources[j].Nom} ({ressources[j].Type})");
    int choix = int.Parse(Console.ReadLine()!);
    r.Ressource = ressources[choix - 1];

    Console.Write("Date début (yyyy-mm-dd) : ");
    r.DateDebut = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Date fin (yyyy-mm-dd) : ");
    r.DateFin = DateTime.Parse(Console.ReadLine()!);

    r.Statut = "Confirmée";
    reservations.Add(r);
}

Console.WriteLine("\n--- RESSOURCES ---");
foreach (var res in ressources)
{
    res.AfficherRecapitulatif();
    Console.WriteLine();
}

Console.WriteLine("\n--- RÉSERVATIONS ---");
foreach (var r in reservations)
{
    r.AfficherRecapitulatif();
    Console.WriteLine();
}

Console.WriteLine("Appuyez sur une touche pour quitter...");
Console.ReadKey();
