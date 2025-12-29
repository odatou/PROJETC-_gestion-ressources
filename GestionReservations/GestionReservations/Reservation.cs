using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservations
{
    public class Reservation : Organisation
    {
        public int Id { get; set; }

        public required Ressource Ressource { get; set; }

        public string ClientNom { get; set; } = "";
        public string ClientEmail { get; set; } = "";

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public string Statut { get; set; } = "Confirmée";
        public string Motif { get; set; } = "";

        public override void AfficherRecapitulatif()
        {
            Console.WriteLine("=== RÉSERVATION ===");
            Console.WriteLine($"Organisation : {Nom}");
            Console.WriteLine($"Client       : {ClientNom}");
            Console.WriteLine($"Email        : {ClientEmail}");
            Console.WriteLine($"Ressource    : {Ressource.Nom}");
            Console.WriteLine($"Du           : {DateDebut:dd/MM/yyyy}");
            Console.WriteLine($"Au           : {DateFin:dd/MM/yyyy}");
            Console.WriteLine($"Statut       : {Statut}");
        }
    }
}
