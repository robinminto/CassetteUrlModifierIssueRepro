using Cassette;

namespace CassetteRepro
{
    public class AppNameUrlModifier : IUrlModifier
    {
        public string Modify(string url)
        {
            return "/MyApp/" + url.TrimStart('/');
        }
    }
}