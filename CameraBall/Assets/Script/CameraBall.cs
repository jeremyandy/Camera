using UnityEngine;
using System.Collections;

public class CameraBall : MonoBehaviour {
	float randomSpeedX;
	float randomSpeedZ;
	float timerDelay;
	float speedDuration;
	float timer=0;
	float randomTimer;
	
	void Start(){
		init();	
	}
	
	
	void Update () {
		if(timer>randomTimer){
			timer=0;
			init ();	
		}
		timer+=Time.deltaTime;
		transform.Translate(randomSpeedX* Time.deltaTime,0,randomSpeedZ* Time.deltaTime);
	}
	
	void init(){
		randomSpeedX= (float)Random.Range(-5.0f,5.0f);	
		randomSpeedZ= (float)Random.Range(-5.0f,5.0f);
		randomTimer= Random.Range(3,5);
		print ("init again");
	}
}
