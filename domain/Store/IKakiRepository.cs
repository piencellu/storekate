using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IKakiRepository
    {
        Kaki[] GetAllByKakinum(string kakinum);

        Kaki[] GetAllByTitleOrAuthorkak(string titleOrAuthorkak);

        Kaki GetById(int id);
    }
}
