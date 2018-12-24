using UnityEngine;
using System.Collections;

public class MeatGenerator : MonoBehaviour {

    public GameObject MeatPrefab;

    void Start () {
	
	}
	
	void Update () {
	
	}

    Vector3 GetInstantiatePosition()
    {
        return transform.position + new Vector3(0, 0, -1);
    }
    void Drop()
    {
        GameObject meat = (GameObject)Instantiate(MeatPrefab);
        meat.transform.position = GetInstantiatePosition();
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Coin") 
            Drop();

    }
}
