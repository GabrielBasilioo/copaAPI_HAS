using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHAS.Models;

namespace copaAPI_HAS.Models
{
    public class Jogo
    {
        public int Id {get; set;}
        public DateTime DataHora {get; set;}
        public int EstadioId {get; set;} //Fk
        public Estadio EstadioIdNavegacao { get; set; }

        //N:N
        public List <JogoSelecao> JogoSelecoes {get;set;} =
        new List<JogoSelecao> ();
        
    }
}