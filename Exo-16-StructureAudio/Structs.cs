using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_16_StructureAudio
{
    public struct PisteAudio
    {
        public string artiste;
        public string titre;
        public string categorie;
        public int tempsSeconde;
    }

    public struct Album
    {
        public List<PisteAudio> pistes;
        public string titre;
        public DateOnly dateSortie;
    }
}
