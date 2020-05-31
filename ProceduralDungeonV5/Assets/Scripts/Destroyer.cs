using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
   
    void OnTriggerEnter2D(Collider2D other){            //Destroys any tiles on top of the spawn room
        if (other.tag == "Rooms")
        {
            Destroy(other.gameObject);
        }
	}
}
