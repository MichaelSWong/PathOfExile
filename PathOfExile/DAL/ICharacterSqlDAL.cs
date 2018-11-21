using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathOfExile.Models;

namespace PathOfExile.DAL
{
    public interface ICharacterSqlDAL
    {
        List<CharacterModel> GetAllCharacters();


    }
}
