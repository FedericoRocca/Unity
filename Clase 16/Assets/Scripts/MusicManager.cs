using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {

	public Button PlayStopMusicButton;
	
	public AudioClip MusicClip;

	public AudioSource MusicSource;

	public Slider VolumeAndPitch;

	// Use this for initialization
	void Start () {
		VolumeAndPitch.value = 0.5f;
		VolumeAndPitch.onValueChanged.AddListener(SetVolumeAndPitch);
		MusicSource.volume = VolumeAndPitch.value;
		PlayStopMusicButton.onClick.AddListener(ToggleMusicPlay);
		MusicSource.clip = MusicClip;
		MusicSource.loop = true;
		MusicSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ToggleMusicPlay()
	{
		if( MusicSource.isPlaying )
		{
			MusicSource.Stop();
		}
		else
		{
			MusicSource.Play();
		}
	}

	void SetVolumeAndPitch(float NewValue)
	{
		MusicSource.volume = NewValue;
		MusicSource.pitch = NewValue;
	}
}
