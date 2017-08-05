using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class postMessage : MonoBehaviour 
{
	    public Text displayText;
		public Image up;
	    // Use this for initialization
	    void Start ()
	    {
		string url = "113.11.120.208/upload";

		        WWWForm formDate = new WWWForm ();
		        formDate.AddField ("Key", "sample");
				formDate.AddField ("Values", "up");

		        WWW www = new WWW (url, formDate);

		        StartCoroutine (request (www));
		    }
	    
	    // Update is called once per frame
	    IEnumerator request (WWW www) 
	    {
		        yield return www;

		        displayText.text = www.text;
		    }
}