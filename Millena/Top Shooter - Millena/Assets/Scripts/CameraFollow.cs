using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float followSpeed;
    public Transform targetPos;
    Vector3 playerPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(targetPos.position.x, targetPos.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, playerPos, followSpeed*Time.deltaTime);
    }
}
