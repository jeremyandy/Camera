using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	GameObject cameraBall;
	Transform myTransform;
	
	void Start () {
		cameraBall= GameObject.Find ("CameraBall");
		myTransform= transform;
		myTransform.position= new Vector3(cameraBall.transform.position.x, myTransform.position.y, cameraBall.transform.position.x);
	}
	
	void Update () {
		myTransform.position= new Vector3(cameraBall.transform.position.x, myTransform.position.y, cameraBall.transform.position.z);
	}
}
