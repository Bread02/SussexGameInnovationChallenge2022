using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    //Code Monkey's SoundManager Tutorial

    public enum Sound
    {
        MenuSelect,
        MenuClick,
        MainMenu1,
        MainMenu2,
        PlayerMove
    }

    private static Dictionary<Sound, float> soundTimerDictionary;

    public static void Initialize()
    {
        soundTimerDictionary = new Dictionary<Sound, float>();
        soundTimerDictionary[Sound.PlayerMove] = 0f;

    }

    private static bool CanPlaySound(Sound sound)
    {
        switch (sound)
        {
            default:
                return true;
            case Sound.PlayerMove:
                if (soundTimerDictionary.ContainsKey(sound))
                {
                    float lastTimePlayed = soundTimerDictionary[sound];
                    float playerMoveTimeMax = 0.05f;
                    if (lastTimePlayed + playerMoveTimeMax < Time.time)
                    {
                        soundTimerDictionary[sound] = Time.time;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
                //break;

        }
    }

    public static void PlaySound(Sound sound)
    {
        //in other scripts, use SoundManager.Playsound(SoundManager.Sound.{the sound enum});
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.soundAduioClipArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound" + sound + "Not Found");
        return null;
    }


}
