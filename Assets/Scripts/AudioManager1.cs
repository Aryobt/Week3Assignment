using UnityEngine;

public class AudioManager1 : Singleton<AudioManager1>
{
    public void PlaySoundEffect(AudioSource source, AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
