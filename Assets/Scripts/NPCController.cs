using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour
{

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;

    //ランダムで決める範囲
    public int RollRange;
    public float speedZ;
    private float Roll;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        moveDirection.z = speedZ;

        Roll = Random.Range(-60, 60);

        transform.Rotate(0, RollRange, 0);
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
    }
}
