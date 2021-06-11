using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Rigidbody body;

    public float cameraSmoothSpeed = 10f;

    private Vector3 offset;
    private Vector3 movingDirection;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = Vector3.Lerp(transform.position, target.position  + offset, Time.deltaTime * cameraSmoothSpeed);
        

    }
}
