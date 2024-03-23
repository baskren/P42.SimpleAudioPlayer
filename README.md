### IMPORTANT
This library is a slight modernization of the `Plugin.SimpleAudioPlayer` by Adrian Stevens: https://github.com/adrianstevens/Xamarin-Plugins

### SimpleAudioPlayer
SimpleAudioPlayer plays local files and audio data as a stream. This allows you to store audio data in a .NET 7+ Class Library and play it on all supported platforms.

### Setup
* Soon will be Available on NuGet: 

**Platform Support**

|Platform|Version|
| ------------------- | :------------------: |
|net7.0-iOS|iOS 7+|
|net7.0-Android|API 10+|
|WinUI 3| |
|net7.0-Mac|All|
|net7.0-MacCatalyst|All|
|net7.0-tvOS|All|

### API Usage

Call **P42.SimpleAudioPlayer.Current** from any project or PCL to gain access to APIs

#### Properties

**Duration**: length of audio in seconds

**CurrentPosition**: current playpack position in seconds

**Volume**: volume of audio between 0 and 1

**Balance**: balance between left and right as as double, -1 is left only, 0 is both, +1 is right only

**IsPlaying**: is the audio currently playing

**CanSeek**: can the playback position be updated

#### Methods

**Load(Stream audioStream)**: load a compatible (wav, mp3, etc) audio from a stream

**Load(string fileName)**: load a compatible audio file stored in the executing platform project

**Play()**: play the currently loaded audio 

**Stop()**: stop playback and reset current position to start (0)

**Pause()**: pause playback (use Play() to resume)

**Seek(double position)**: seek to a specific location in the audio (in seconds)


### Example
Coded in a Uno.Platform or MAUI cross-platform project
with **mysound.wav** stored in the project as an **Embedded Resource**
```
ISimpleAudioPlayer player = P42.SimpleAudioPlayer.SimpleAudioPlayer.Current;
player.Load(GetStreamFromFile("mysound.wav"));
player.Play();
```

```
Stream GetStreamFromFile(string filename)
{
    var assembly = typeof(App).GetTypeInfo().Assembly;
    var stream = assembly.GetManifestResourceStream("YourApp." + filename);
    return stream;
}
```

Or to load multiple instances
```
var player1 = P42.SimpleAudioPlayer.SimpleAudioPlayer.CreateSimpleAudioPlayer();
var player2 = P42.SimpleAudioPlayer.SimpleAudioPlayer.CreateSimpleAudioPlayer();
...
```

### Background Audio on iOS 
Add the following to the FinishedLaunching method of the AppDelegate class. Seems to be working fine now. Remember to Enable background audio within info.plist!

    private void EnableBackgroundAudio()
    {
        var currentSession = AVAudioSession.SharedInstance();
        currentSession.SetCategory(AVAudioSessionCategory.Playback,
        AVAudioSessionCategoryOptions.MixWithOthers);
        currentSession.SetActive(true);
    }


For more examples see the **Samples** folder or check out
https://github.com/adrianstevens/Xamarin-Forms/tree/master/DrumPad2


#### Contributions
Contributions are welcome! If you find a bug or want a feature added please report it - and don't forget to include your device make, model and OS version.

If you want to contribute code please file an issue, create a branch, and file a pull request.

#### License 
MIT License - see LICENSE.txt

