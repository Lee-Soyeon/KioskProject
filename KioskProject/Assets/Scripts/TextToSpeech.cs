using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

        _audio = gameObject.GetComponent<AudioSource>();
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
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + guide.text + "&tl=ko";
                        //+ "도움이 필요하신 고객님께는 주문하신 음식을 자리로 가져다 드리고 있습니다."
                        //+ "해당 서비스가 필요하시면 파란색 네모 안을, 필요하지 않으시면 빨간색 네모 안을 눌러주세요."
                        //+ "&tl=ko";

        WWW www = new WWW(url);
        yield return www;

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
    }
}
