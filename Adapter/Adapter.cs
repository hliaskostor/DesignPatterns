using System;

public class MediaPlayer
{
    public virtual void Play(string audioType, string filename)
    {
       
    }
}

public interface AdvancedMediaPlayer
{
    void PlayVlc(string filename);
    void PlayMp4(string filename);
}

public class VLCPlayer : AdvancedMediaPlayer
{
    public void PlayVlc(string filename)
    {
        Console.WriteLine("Playing VLC file: " + filename);
    }

    public void PlayMp4(string filename)
    {
    
    }
}

public class MP4Player : AdvancedMediaPlayer
{
    public void PlayVlc(string filename)
    {
    
    }

    public void PlayMp4(string filename)
    {
        Console.WriteLine("Playing MP4 file: " + filename);
    }
}

public class MediaAdapter : MediaPlayer
{
    private AdvancedMediaPlayer advancedPlayer;
  
    private string filename;

    public MediaAdapter(string audioType, string filename)
    {
        if (audioType == "vlc")
        {
            advancedPlayer = new VLCPlayer();
        }
        else if (audioType == "mp4")
        {
            advancedPlayer = new MP4Player();
        }
        this.filename = filename;
    }

    public override void Play(string audioType, string filename)
    {
        if (audioType == "vlc")
        {
            advancedPlayer.PlayVlc(this.filename);
        }
        else if (audioType == "mp4")
        {
            advancedPlayer.PlayMp4(this.filename);
        }
    }
}

public class AudioPlayer : MediaPlayer
{
    public override void Play(string audioType, string filename)
    {
        if (audioType == "mp3")
        {
            Console.WriteLine("Playing MP3 file: " + filename);
        }
        else if (audioType == "vlc" || audioType == "mp4")
        {
            MediaAdapter mediaAdapter = new MediaAdapter(audioType, filename);
            mediaAdapter.Play(audioType, filename);
        }
        else
        {
            Console.WriteLine("Invalid media type: " + audioType);
        }
    }
}


class Adapter
{
    static void Main(string[] args)
    {
        AudioPlayer audioPlayer = new AudioPlayer();
        audioPlayer.Play("mp3", "song.mp3");
        audioPlayer.Play("vlc", "movie.vlc");
        audioPlayer.Play("mp4", "video.mp4");
        audioPlayer.Play("avi", "video.avi");
    }
}
