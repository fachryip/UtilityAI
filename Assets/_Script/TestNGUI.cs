using UnityEngine;
using System.Collections;

public class TestNGUI : MonoBehaviour {

	public UIButton GreenButton;
	public UIButton RedButton;
	public UIButton BlueButton;

	void Start(){
		EventDelegate.Set (GreenButton.onClick, MakeGreen);
		EventDelegate.Set (RedButton.onClick, MakeRed);
		EventDelegate.Set (BlueButton.onClick, MakeBlue);
	}

	public void MakeGreen(){
		GetComponent<UIWidget> ().color = Color.green;
	}

	public void MakeRed(){
		GetComponent<UIWidget> ().color = Color.red;
	}

	public void MakeBlue(){
		GetComponent<UIWidget> ().color = Color.blue;
	}



}
