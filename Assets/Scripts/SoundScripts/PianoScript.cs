using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScript : MonoBehaviour {


    private bool playing = false;

    /*public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;*/


    public AudioSource source;
    public AudioClip [] clips = new AudioClip[5];
    public AudioClip failClip;
    public AudioClip finalClip;

    private bool[] results = new bool[5];
    private string[] esperados = new string[5];

    private bool destino;

    private void Start()
    {
        esperados[0] = "rey";
        esperados[1] = "caballo";
        esperados[2] = "torre";
        esperados[3] = "reina";
        esperados[4] = "rey";
    }

    public void Play()
    {
        source = gameObject.GetComponent<AudioSource>();

        if (playing == false)
        {
            playing = true;
            BindingItem[] item = GetComponentsInChildren<BindingItem>();

            for(int i = 0; i < 5; i++)
            {
                if(item[i].myItem!=null)
                {
                    if (item[i].myItem.name == esperados[i])
                        results[i] = true;
                    else
                        results[i] = false;
                }
                else
                {
                    results[i] = false;
                }

            }

            

            destino = true;
            for(int i = 0; i < 5; i++)
            {
                if (results[i] == false)
                    destino = false;
            }

            playing = false;

            if (destino == true)
            {
                Debug.Log("CONGRATULATIONS");
				Fade fade = GetComponent<Fade> ();
				fade.StartFade ();

                source.clip = finalClip;
                source.Play();
            }
            else
            {
                Debug.Log("FAIL");
                StartCoroutine(PlaySong());
            }

        }
    }

    IEnumerator PlaySong()
    {
        int index = 0;

        while(true)
        {
            if(!source.isPlaying)
            {
                if (results[index])
                    source.clip = clips[index];
                else
                    source.clip = failClip; 
                index++;
                source.Play();
            }

            yield return null;
        }
    }
}
