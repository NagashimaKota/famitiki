using UnityEngine;
using System.Collections;

public class MeatDestroyer : MonoBehaviour {

    int meatCount=0;

    void MeatCountPuls()
    {
        meatCount++;
    }
    public int MeatCount()
    {
        return meatCount;
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Famikiti")
            Destroy(this.gameObject);
    }*/
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Famikiti")
            Destroy(this.gameObject);
    }
}
