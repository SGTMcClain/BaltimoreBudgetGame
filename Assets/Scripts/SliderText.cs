using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderText : MonoBehaviour {

	public GameObject GUITextObject;
	Text txt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	public void SetText (Text newText){
		txt = newText;
	}
}
