using System;
using System.IO;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace P42.SimpleAudioPlayer
{
  /// <summary>
  /// Implementation for Feature
  /// </summary>
  public class SimpleAudioPlayerImplementation : ISimpleAudioPlayer
  {
        public const string NotImplmentedMessage = "This functionality is not implemented in the .NET standard version of this assembly. Reference the NuGet package from your platform-specific (head) application project in order to reference the platform-specific implementation.";
        public event EventHandler PlaybackEnded;
        

        ///<Summary>
        /// Length of audio in seconds
        ///</Summary>
        public double Duration => throw new NotImplementedException(NotImplmentedMessage);

        ///<Summary>
        /// Current position of audio in seconds
        ///</Summary>
        public double CurrentPosition => throw new NotImplementedException(NotImplmentedMessage);

        ///<Summary>
        /// Playback volume (0 to 1)
        ///</Summary>
        public double Volume
        {
            get => throw new NotImplementedException(NotImplmentedMessage);
            set => throw new NotImplementedException(NotImplmentedMessage);
        }

        ///<Summary>
        /// Balance left/right: -1 is 100% left : 0% right, 1 is 100% right : 0% left, 0 is equal volume left/right
        ///</Summary>
        public double Balance
        {
            get => throw new NotImplementedException(NotImplmentedMessage);
            set => throw new NotImplementedException(NotImplmentedMessage);
        }

        ///<Summary>
        /// Indicates if the currently loaded audio file is playing
        ///</Summary>
        public bool IsPlaying => throw new NotImplementedException(NotImplmentedMessage);

        ///<Summary>
        /// Continously repeats the currently playing sound
        ///</Summary>
        public bool Loop
        {
            get => throw new NotImplementedException(NotImplmentedMessage);
            set => throw new NotImplementedException(NotImplmentedMessage);
        }
        bool _loop;

        ///<Summary>
        /// Indicates if the position of the loaded audio file can be updated
        ///</Summary>
        public bool CanSeek => throw new NotImplementedException(NotImplmentedMessage);

        ///<Summary>
        /// Load wave or mp3 audio file from a stream
        ///</Summary>
        public bool Load(Stream audioStream)
            => throw new NotImplementedException(NotImplmentedMessage);            
        
        ///<Summary>
        /// Load wave or mp3 audio file from assets folder in the UWP project
        ///</Summary>
        public bool Load(string fileName)
            => throw new NotImplementedException(NotImplmentedMessage);            

        void DeletePlayer()
            => throw new NotImplementedException(NotImplmentedMessage);            

        private void OnPlaybackEnded(MediaPlayer sender, object args)
            => throw new NotImplementedException(NotImplmentedMessage);            

        ///<Summary>
        /// Begin playback or resume if paused
        ///</Summary>
        public void Play()
            => throw new NotImplementedException(NotImplmentedMessage);            

        ///<Summary>
        /// Pause playback if playing (does not resume)
        ///</Summary>
        public void Pause()
            => throw new NotImplementedException(NotImplmentedMessage);            

        ///<Summary>
        /// Stop playack and set the current position to the beginning
        ///</Summary>
        public void Stop()
            => throw new NotImplementedException(NotImplmentedMessage);            

        ///<Summary>
        /// Seek a position in seconds in the currently loaded sound file 
        ///</Summary>
        public void Seek (double position)
            => throw new NotImplementedException(NotImplmentedMessage);            

        void SetVolume(double volume, double balance)
            => throw new NotImplementedException(NotImplmentedMessage);            

        MediaPlayer GetPlayer ()
            => throw new NotImplementedException(NotImplmentedMessage);            

        bool isDisposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
                return;

            isDisposed = true;
        }

        ~SimpleAudioPlayerImplementation()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}