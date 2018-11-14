using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathOfExile.Models
{
    public class CharacterModel
    {
        public int Classes_Id { get; set; }

        public string Classes_Name { get; set; }

        public int Starting_Str { get; set; }

        public int Starting_Dex { get; set; }

        public int Starting_Int { get; set; }

        public string Classes_Image { get; set; }

        public int Ascendancy_Id { get; set; }

        public string Ascendancy_Name { get; set; }

        public string Ascendancy_Image { get; set; }
    }
}
