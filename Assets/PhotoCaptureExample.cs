using UnityEngine;
using System.Collections;

public class PhotoCaptureExample : MonoBehaviour {
	WebCamTexture back;
	public Renderer render;

	// Use this for initialization
	void Start() {
		back = new WebCamTexture ();

		render.material.mainTexture = back;
		back.Play ();
	}


}