using TryAbp.Debugging;

namespace TryAbp
{
    public class TryAbpConsts
    {
        public const string LocalizationSourceName = "TryAbp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8babb784de5b4f109c98e09ac21a3b0e";
    }
}
