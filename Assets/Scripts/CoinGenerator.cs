using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {

    public GameObject CoinPrefab;
    public float shotSpeed;
    public float shotTorque;

	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) Shot();
    }
    Vector3 GetInstantiatePosition()
    {
        return transform.position + new Vector3(0, -0.5f, 1);
    }
    void Shot()
    {
        GameObject coin = (GameObject)Instantiate(CoinPrefab, GetInstantiatePosition(), Quaternion.identity);
        Rigidbody candyRigidbody = coin.GetComponent<Rigidbody>();
        candyRigidbody.AddForce(transform.forward * shotSpeed);
        candyRigidbody.AddForce(new Vector3(0, shotTorque, 0));
    }

}
