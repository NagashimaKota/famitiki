using UnityEngine;
using System.Collections;

public class CoinDestoryer : MonoBehaviour {

	void Start () {
	
	}
	void Update () {

	}
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Ground"||collision.gameObject.tag=="NPC")
            Destroy(this.gameObject);
    }
}
