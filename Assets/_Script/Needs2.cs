using UnityEngine;
using System.Collections;

public class Needs2 : MonoBehaviour {

	public UAI_PropertyBoundedFloat Value;

	private UISlider _slider;

	void Awake(){
		_slider = GetComponent<UISlider> ();
	}

	void Update(){
		_slider.value = Value.value;
	}
}
