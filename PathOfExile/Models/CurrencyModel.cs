using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathOfExile.Models
{
    public class CurrencyModel
    {
        public int Currency_Id { get; set; }

        public string Currency_Name { get; set; }

        public int Stack_Size { get; set; }

        public string Description_Text { get; set; }

        public string Currency_Image { get; set; }

        public string Trade_Description { get; set; }
    }
}
