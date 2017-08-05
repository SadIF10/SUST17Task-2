using UnityEngine;
using System.Collections;
using System.IO;

public class takeScreenShot : MonoBehaviour {
    Texture2D screenCap;
	Texture2D border;
    bool shot = false;

	private string Screenshot_name;
	private int counter = 0;
	    // Use this for initialization
	    void Start () {
		        screenCap = new Texture2D(300, 200, TextureFormat.RGB24, false); // 1
		        border = new Texture2D(2, 2, TextureFormat.ARGB32, false); // 2
		        border.Apply();
		    }

	    // Update is called once per frame
	    void Update () {
		      
		}

	public void shoot() {
		StartCoroutine ("Capture");
	}
		

	public void Capture(){
		Screenshot_name = "Screenshot" + counter + System.DateTime.Now.ToString ("_yyyy-MM-dd") + ".png";
		Application.CaptureScreenshot (Screenshot_name);

		string Origin_path = System.IO.Path.Combine (Application.persistentDataPath, Screenshot_name);

		string path = "/Pictures/" + Screenshot_name;

		if (System.IO.File.Exists(Origin_path)) {
			System.IO.File.Move (Origin_path, path);
		}




	}
} 