using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GetURL : MonoBehaviour {

	public string a = "not yet";
	public AudioSource source;
	public Text text;

	void Start () {
		string url = "113.11.120.208/do_ocr?src=-kqgSMkQRhA_uUCkVPCf.jpg";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
			a = www.text;



			char[] array = a.ToCharArray ();
			for (int i = 0; i < array.Length; i++) {
				
				if (array [i] == '"') {
					array [i] = 'o';
				}
				if (array [i] == 92) {
					array [i] = 'o';
				}
				if (array [i] == '{') {
					array [i] = 'o';
				}
				if (array [i] == '_') {
					array [i] = 'o';
				}
				if (array [i] == ':') {
					array [i] = 'o';
				}
				if (array [i] == ';') {
					array [i] = 'o';
				}
				if (array [i] == ',') {
					array [i] = 'o';
				}
				if (array [i] == '}') {
					array [i] = 'o';
				}
			}

			a = new string (array);

			for (char i = 'a'; i <= 'z'; i++) {
				a = a.Replace (i.ToString(), string.Empty);
			}
			for (char i = '0'; i <= '9'; i++) {
				a = a.Replace (i.ToString(), string.Empty);
			}
			for (char i = 'A'; i <= 'Z'; i++) {
				a = a.Replace (i.ToString(), string.Empty);
			}

			a = a.Substring (0, 20);
			text.text = a;

			string url2 = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=500&client=tw-ob&q="+a+"&tl=Bn-gb";

			Debug.Log (url2);
			WWW www2 = new WWW (url2);

			yield return www2;


			source.clip = www2.GetAudioClip (false, false, AudioType.MPEG);
			source.Play ();
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}