﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Vuforia;

public class TextToSpeech : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public AudioSource _audio;
    public Text guide;

    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        _audio = GameObject.Find("Audio Source").GetComponent<AudioSource>();
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            StartCoroutine(DownloadTheAudio());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DownloadTheAudio()
    {
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + guide.text + "&tl=ko-kr";
                        //+ "도움이 필요하신 고객님께는 주문하신 음식을 자리로 가져다 드리고 있습니다."
                        //+ "해당 서비스가 필요하시면 파란색 네모 안을, 필요하지 않으시면 빨간색 네모 안을 눌러주세요."
                        //+ "&tl=ko-kr";
        //string url = "https://google-translate-proxy.herokuapp.com/api/tts?query=" + guide.text + "&language=ko&speed=0.38";
        
        //WWW www = new WWW(url);
        //yield return www;

        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
        {
            www.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            yield return www.SendWebRequest();
            _audio.clip = DownloadHandlerAudioClip.GetContent(www);
        }

        //_audio.clip = www.GetAudioClip(true, false, AudioType.MPEG);
        _audio.Play();
    }
}