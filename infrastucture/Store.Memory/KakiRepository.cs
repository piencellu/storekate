namespace Store.Memory
{
    public class KakiRepository : IKakiRepository
    {
        private readonly Kaki[] kakis = new[]
        {
            new Kaki(1, "Kakashka Chizzy"),
            new Kaki(2, "Kakashka Musi"),
            new Kaki(2, "Kakashka Musi svezhaya"),
        };

        public Kaki[] GetAllByTitle(string titlePart)
        {
            return kakis.Where(kaki => kaki.Title.Contains(titlePart)).ToArray();
        }
    }
}
