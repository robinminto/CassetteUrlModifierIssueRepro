using Cassette;
using Cassette.TinyIoC;

namespace CassetteRepro
{
    public class CassetteSettings : IConfiguration<TinyIoCContainer>
    {
        public void Configure(TinyIoCContainer configurable)
        {
            configurable.Register<IUrlModifier, AppNameUrlModifier>();
        }
    }
}