using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpDemoTwo.Localization
{
    public static class AbpDemoTwoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpDemoTwoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpDemoTwoLocalizationConfigurer).GetAssembly(),
                        "AbpDemoTwo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
