namespace Store.Memory
{
    public class KakiRepository : IKakiRepository
    {
        private readonly Kaki[] kakis = new[]
        {
            new Kaki(1, "KAKINUMBER 134-24", "Chizzy", "Kakashka Chizzy", "Свежие каки Чизы, которые собираются каждое утро с трепетом и любовью! Все для Вас!", 12m),
            new Kaki(2, "KAKINUMBER 123-23", "Muskula", "Kakashka Musi", "Свежие каки Мусеньки, которые собираются каждое утро с трепетом и любовью! Все для Вас!", 12m),
            new Kaki(3, "KAKINUMBER 125-44","Muskula", "Kakashka Musi svezhaya", "Свежие каки Мусеньки, которые собираются каждое утро с трепетом и любовью! Все для Вас!", 12m),
        };

        public Kaki[] GetAllByKakinum(string kakinum)
        {
            return kakis.Where(kaki => kaki.Kakinum == kakinum)
                        .ToArray();  
        }
        
        public Kaki[] GetAllByTitleOrAuthorkak(string query)
        {
            return kakis.Where(kaki => kaki.Authorkak.Contains(query)
                                   || kaki.Title.Contains(query))
                       .ToArray();
        }

        public Kaki GetById(int id)
        {
            return kakis.Single(kaki => kaki.Id == id);
        }
    }
}
