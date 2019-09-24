using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UnrecognizedSetting : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour.Status status;
    private bool isDetected = false;
    private TrackableBehaviour mTrackableBehaviour;
    private GameObject unrecognizedCanvas; // 이미지 타겟 미인식 시 나타나는 Canvas

    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        unrecognizedCanvas = GameObject.Find("Unrecognized Canvas(screen space - overlay)");

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        status = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            isDetected = true;
        }
        else
        {
            isDetected = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("status : " + status + " / isDetected : " + isDetected);

        if (isDetected == true)
        {
            unrecognizedCanvas.SetActive(false);
        }
        else
        {
            unrecognizedCanvas.SetActive(true);
        }
    }
}