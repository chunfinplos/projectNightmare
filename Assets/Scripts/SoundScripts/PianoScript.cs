using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScript : MonoBehaviour {

    public GameObject player;
    public AudioSource source;
    public AudioClip [] clips = new AudioClip[5];
    public AudioClip failClip;
    public AudioClip finalClip;

    private bool playing = false;
    private bool[] results = new bool[5];
    private string[] esperados = new string[5];
    private bool destino;

    private float contador;
    private Fade fade;


    private void Start()
    {
        contador = 0;
        fade = GetComponent<Fade>();

        esperados[0] = "rey";
        esperados[1] = "caballo";
        esperados[2] = "torre";
        esperados[3] = "reina";
        esperados[4] = "rey";
    }

    private void Update()
    {
        if(destino && RoomManager.MusicaCompleto == false)
        {
            contador += Time.deltaTime;
            if(contador>= 5)
            {
                //source.clip = finalClip; //CAMBIAR POR CANCION ORIGINAL DEL JUEGO
                //source.Play();

                RoomManager.MusicaCompleto = true;
                player.transform.position = new Vector3(-0.14f, 0.75f, 0.38f);
            }
        }
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
