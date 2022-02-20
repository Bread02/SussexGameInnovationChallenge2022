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
    }


    public static void PlaySound(Sound sound)
    {
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
