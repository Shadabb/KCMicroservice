using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kraken
{
    [Dependency(ReplaceServices = true)]
    public class KrakenBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Kraken";
    }
}
