using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LibraryApplicationSystem.Localization
{
    public static class LibraryApplicationSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LibraryApplicationSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LibraryApplicationSystemLocalizationConfigurer).GetAssembly(),
                        "LibraryApplicationSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
