using WebSocketSharp;
using UnityEngine;
using System;


public class Sound : MonoBehaviour
{
    WebSocket ws;

    public AudioSource Music;
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;



    public string message;
    public int audioIndex;


    AudioClip soundClip(int audio)
    {
        return audioClipArray[audio];
    }

    void Start()
    {
        Music = GetComponent<AudioSource>();

        message = "0";

        ws = new WebSocket("ws://localhost:9500");

        ws.OnMessage += (sender, e) =>
        {

            message = e.Data;
        };

        ws.Connect();
    }


    void Update()
    {
        if (ws == null)
        {
            return;
        }

        if (message != "")
        {
            audioIndex = Int32.Parse(message);
        }

        switch (message)
        {
            case "0":
                Music.Stop();
                break;
            case "1":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();
                }
                break;
            case "2":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();

                }


                break;
            case "3":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();
                }
                break;
            case "4":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();
                }
                break;
            case "5":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();
                }
                break;
            case "6":
                Music.clip = soundClip(audioIndex);
                if (!Music.isPlaying)
                {
                    Music.Play();
                }
                break;
            case "7":
                Music.Stop();
                break;


        }

    }


}

