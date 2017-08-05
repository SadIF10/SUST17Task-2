using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayIt : MonoBehaviour {

	public AudioSource source;
	public Text text;

	// Use this for initialization
	void Start () {
		StartCoroutine (DownloadAudio());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator DownloadAudio() {
		Debug.Log("WWW Ok!: "+text.text);
		string url = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q="+text.text+"&tl=Bn-gb";

		char[] array = url.ToCharArray ();
		for (int i = 0; i < array.Length; i++) {
			if (array [i] == ' ') {
				array [i] = '+';
			}
		}

		url = new string (array);

		Debug.Log (url);
		WWW www = new WWW (url);

		yield return www;

		source.clip = www.GetAudioClip (false, false, AudioType.MPEG);
		source.Play ();
	}

}
