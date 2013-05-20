using UnityEngine;
using System.Collections;

public class ButtonMovement : MonoBehaviour {
	
	GameObject player;
	bool isDown;
	int speedX;
	int speedZ;
	float timerDelay;
	float timer;
	
	void Start(){
		
		player= GameObject.Find("Player");
		timerDelay= .05f;
		timer= 0f;
		
		switch(gameObject.name){
			case "ButtonLeft":
				speedX=-10;
				speedZ=0;
			break;
			
			case "ButtonRight":
				speedX=10;
				speedZ=0;
			break;
			
			case "ButtonUp":
				speedX=0;
				speedZ=10;
			break;
			
			case "ButtonDown":
				speedX=0;
				speedZ=-10;
			break;
		}
	}
	
	void OnPress(bool isDown1){
		if(isDown1){
			isDown= true;
		}
		else {
			isDown= false;
		}
		
	}
	
	void FixedUpdate(){
		if(isDown)
			player.transform.Translate(speedX*Time.deltaTime,0,speedZ*Time.deltaTime);
	}
	

}
