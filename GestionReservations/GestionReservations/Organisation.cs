using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservations
{ 
    public abstract class Organisation
    {
        public string Nom { get; set; } = String.Empty;
        public  string Adresse { get; set; }= String.Empty;
        public  string Email { get; set; }= String.Empty;

        public abstract void AfficherRecapitulatif();
    }} 