using System;

namespace GestionReservations
{
    public enum TypeRessource
    {
        Salle,
        Chambre,
        Equipement
    }

    public class Ressource : Organisation
    {
        public TypeRessource Type { get; set; }
        public bool EstDisponible { get; set; } = true;

        public override void AfficherRecapitulatif()
        {
            Console.WriteLine("RESSOURCE ");
            Console.WriteLine($"Nom          : {Nom}");
            Console.WriteLine($"Type         : {Type}");
            Console.WriteLine($"Adresse      : {Adresse}");
            Console.WriteLine($"Email        : {Email}");
            Console.WriteLine($"Disponible   : {(EstDisponible ? "Oui" : "Non")}");
        }
    }
}
