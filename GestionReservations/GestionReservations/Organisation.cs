using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservations
{ 

public abstract class Organisation{

    public string Nom{ get ; set;}

    public string Adresse{get; set;}

    public string Email{get; set;} 

    public abstract void AfficherRecapitulatif();

}}