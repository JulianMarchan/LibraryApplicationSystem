using LibraryApplicationSystem.Debugging;

namespace LibraryApplicationSystem
{
    public class LibraryApplicationSystemConsts
    {
        public const string LocalizationSourceName = "LibraryApplicationSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6f98fb0eb0b34090a537bd9c968c9862";
    }
}
