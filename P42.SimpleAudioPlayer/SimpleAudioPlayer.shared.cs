using System;

namespace P42.SimpleAudioPlayer
{
    /// <summary>
    /// Cross platform SimpleAudioPlayer implemenations
    /// </summary>
#if __ANDROID__
    [Android.Runtime.Preserve(AllMembers = true)]
#endif
    public class CrossSimpleAudioPlayer
    {
      static readonly Lazy<ISimpleAudioPlayer> Implementation 
         = new Lazy<ISimpleAudioPlayer>(() => CreateSimpleAudioPlayer(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

      /// <summary>
      /// Current settings to use
      /// </summary>
      public static ISimpleAudioPlayer Current
      {
         get
         {
            var ret = Implementation.Value;
            if (ret == null)
            {
               throw NotImplementedInReferenceAssembly();
            }
            return ret;
         }
      }

		///<Summary>
		/// Create a new SimpleAudioPlayer object
		///</Summary>
	   public static ISimpleAudioPlayer CreateSimpleAudioPlayer()
         => new SimpleAudioPlayerImplementation();

      internal static Exception NotImplementedInReferenceAssembly()
         => new NotImplementedException("This functionality is not implemented in the .NET standard version of this assembly. Reference the NuGet package from your platform-specific (head) application project in order to reference the platform-specific implementation.");
      
   }
}