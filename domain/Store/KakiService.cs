using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class KakiService
    {
        private readonly IKakiRepository kakiRepository;

        public KakiService(IKakiRepository kakiRepository)
        {
            this.kakiRepository = kakiRepository;
        }

        public Kaki[] GetAllByQuery(string query)
        {
            if (Kaki.IsKakinum(query))
                return kakiRepository.GetAllByKakinum(query);

                return kakiRepository.GetAllByTitleOrAuthorkak(query);
        }

    }
}
