using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace XiaoLin.VNADS.Localization
{
    public static class VNADSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VNADSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VNADSLocalizationConfigurer).GetAssembly(),
                        "XiaoLin.VNADS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
