using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;
    
    public int RollSpeed;
    public float speedZ;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
          moveDirection.z = speedZ;
        

        transform.Rotate(0, Input.GetAxis("Horizontal") * RollSpeed, 0);
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
    }
}
