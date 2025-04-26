using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    public enum sonsFX { Bubbles, Die, Damage, PulsePause };
    public enum bgm { Found, Story, GameOver, Menu, Pause };

    [SerializeField]
    float FXVolume = 0.5f, bgmVolume = 0.2f;

    static AudioClip[] sounds;
    static AudioClip[] bgmLvl;


    static AudioSource asFX, asBGM;

    private void Awake()
    {
        //crea els components AudioSource
        asFX = gameObject.AddComponent<AudioSource>();
        asFX.volume = FXVolume;

        asBGM = gameObject.AddComponent<AudioSource>();
        asBGM.volume = bgmVolume;
        asBGM.loop = true;

        sounds = new AudioClip[4]; //nº de clips que quieras cargar
        sounds[(int)sonsFX.Bubbles] = Resources.Load<AudioClip>("FX/Bubbles");
        sounds[(int)sonsFX.Die] = Resources.Load<AudioClip>("FX/Die");
        sounds[(int)sonsFX.Damage] = Resources.Load<AudioClip>("FX/Damage");
        sounds[(int)sonsFX.PulsePause] = Resources.Load<AudioClip>("FX/PulsePause");



        bgmLvl = new AudioClip[5]; //nº de clips que quieras cargar
        bgmLvl[(int)bgm.Found] = Resources.Load<AudioClip>("BGM/Found");
        bgmLvl[(int)bgm.Menu] = Resources.Load<AudioClip>("BGM/Story");
        bgmLvl[(int)bgm.Menu] = Resources.Load<AudioClip>("BGM/GameOver");
        bgmLvl[(int)bgm.Menu] = Resources.Load<AudioClip>("BGM/Menu");
        bgmLvl[(int)bgm.Menu] = Resources.Load<AudioClip>("BGM/Pause");

    }

    public static void Reproduir(sonsFX soAReproduir)
    {
        asFX.PlayOneShot(sounds[(int)soAReproduir]);
    }

    public static void Reproduir(bgm soAReproduir)
    {
        asBGM.clip = bgmLvl[(int)soAReproduir];
        asBGM.Play();
    }
}

