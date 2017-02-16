using UnityEngine;
using System.Collections;

public class Needs : MonoBehaviour {

	public enum Status
	{
		Idle,
		Busy
	}

	public float StartValue;
	public float IdleAcceleration;
	public GameObject DecreaseAnimation;
	public GameObject IncreaseAnimation;
	public bool IsNegativeValue;

	private UISlider _slider;
	private Status _myStatus = Status.Idle;

	void Awake(){
		_slider = GetComponent<UISlider> ();
	}

	void Start(){
		_slider.value = StartValue;
		DecreaseAnimation.SetActive (false);
		IncreaseAnimation.SetActive (false);
	}

	void Update(){		
		if (_myStatus != Status.Busy) {
			_slider.value += IdleAcceleration * Time.deltaTime;
			ChangeIncreaseAnimation (true);
		} else {
			ChangeIncreaseAnimation (false);
		}
	}

	void ChangeIncreaseAnimation(bool status){
		IncreaseAnimation.SetActive (status);
		DecreaseAnimation.SetActive (!status);
	}
}
