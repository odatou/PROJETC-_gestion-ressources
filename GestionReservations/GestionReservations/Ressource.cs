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
    Console.WriteLine("=====================================");
    Console.WriteLine("        RÉCAPITULATIF DE RÉSERVATION");
    Console.WriteLine("=====================================\n");

    Console.WriteLine("RESSOURCE");
   
    Console.WriteLine($"Type : {Type}");
    Console.WriteLine($"Nom         : {Nom}");
    Console.WriteLine($"Contact     : {Email}");

    }}
}
