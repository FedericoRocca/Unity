using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour {

	public Button PlaySoundButton;

	public AudioClip SoundClip;

	public AudioSource AudioSourcePlaySound;

	// Use this for initialization
	void Start () {
		PlaySoundButton.onClick.AddListener(PlayTheSound);
	}
	
	// Update is called once per frame
	void PlayTheSound () 
	{
		AudioSourcePlaySound.clip = SoundClip;
		AudioSourcePlaySound.Play();
	}
}
