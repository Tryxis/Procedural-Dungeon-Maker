using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRooms : MonoBehaviour {

	public int openingDirection;
	private RoomTemplates templates;
	private int randomInt;
	public bool isGenerated = false;

	public float waitTime = 4f;

	void Start(){
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
		Invoke("Generate", 0.1f);
	}


	void Generate(){
		if(isGenerated == false){
			if(openingDirection == 1){
				// Need to spawn a room with a BOTTOM door.
				randomInt = Random.Range(0, templates.bottomRooms.Length);
				Instantiate(templates.bottomRooms[randomInt], transform.position, templates.bottomRooms[randomInt].transform.rotation);
			} else if(openingDirection == 2){
				// Need to spawn a room with a TOP door.
				randomInt = Random.Range(0, templates.topRooms.Length);
				Instantiate(templates.topRooms[randomInt], transform.position, templates.topRooms[randomInt].transform.rotation);
			} else if(openingDirection == 3){
				// Need to spawn a room with a LEFT door.
				randomInt = Random.Range(0, templates.leftRooms.Length);
				Instantiate(templates.leftRooms[randomInt], transform.position, templates.leftRooms[randomInt].transform.rotation);
			} else if(openingDirection == 4){
				// Need to spawn a room with a RIGHT door.
				randomInt = Random.Range(0, templates.rightRooms.Length);
				Instantiate(templates.rightRooms[randomInt], transform.position, templates.rightRooms[randomInt].transform.rotation);
			}
			isGenerated = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other){                                //Destroys overlapping tiles
		if(other.CompareTag("Spawn Point")){
			if(other.GetComponent<SpawnRooms>().isGenerated == false && isGenerated == false)
            {
				Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
				Destroy(gameObject);
			} 
			isGenerated = true;
		}
	}
}
