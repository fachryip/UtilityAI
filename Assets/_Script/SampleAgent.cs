using UnityEngine;
using System.Collections;

public class SampleAgent : MonoBehaviour {

	public float MovementSpeed;
	[Header("Property")]
	public UAI_PropertyBoundedFloat Hunger;
	public UAI_PropertyBoundedFloat Bladder;
	public UAI_PropertyBoundedFloat Boredom;
	[Header("Waypoints")]
	public WayPoint ComputerWayPoint;
	public WayPoint EatingWayPoint;
	public WayPoint ToiletWayPoint;

	private Vector3 _destination;
	private bool _atDestination = false;
	private UAI_Agent _UAIagent;
	private NavMeshAgent _navAgent;

	void Start(){
		_UAIagent = GetComponent<UAI_Agent> ();
		_navAgent = GetComponent<NavMeshAgent> ();

		_UAIagent.SetVoidActionDelegate ("Eating", Eating);
		_UAIagent.SetVoidActionDelegate ("Urinate", Urinate);
		_UAIagent.SetVoidActionDelegate ("Playing", Playing);
	}

	void Update(){
		_UAIagent.UpdateAI ();
	}

	void Eating(){
		ResetPositions ();

		if (_atDestination) {
			Hunger.value -= EatingWayPoint.IncreaseValue * UtilityTime.time;
			Bladder.value += EatingWayPoint.IncreaseValue * UtilityTime.time;
		} else {
			MoveToTarget ();
		}
	}

	void Urinate(){
		ResetPositions ();

		if (_atDestination) {
			Bladder.value -= ToiletWayPoint.IncreaseValue * UtilityTime.time;
		} else {
			MoveToTarget ();
		}
	}

	void Playing(){
		ResetPositions ();

		if (_atDestination) {
			Boredom.value -= ComputerWayPoint.IncreaseValue * UtilityTime.time;
		} else {
			MoveToTarget ();
		}
	}

	void ResetPositions(){
		if (_UAIagent.newAction) {
			_atDestination = false;
			_UAIagent.newAction = false;
		}
	}

	void MoveToTarget(){
		float step = MovementSpeed * UtilityTime.time;

		DetermineTarget ();
		transform.position = Vector3.MoveTowards (transform.position, _destination, step);
		if (transform.position == _destination) {
			_UAIagent.StartTimer ();
			_atDestination = true;
		}
	}

	void DetermineTarget(){
		if (_UAIagent.GetTopAction ().handle == Eating) {
			_destination = EatingWayPoint.transform.position;
		} else if (_UAIagent.GetTopAction ().handle == Urinate) {
			_destination = ToiletWayPoint.transform.position;
		} else if (_UAIagent.GetTopAction ().handle == Playing) {
			_destination = ComputerWayPoint.transform.position;
		}
	}
}
