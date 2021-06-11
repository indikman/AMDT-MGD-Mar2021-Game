using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 500.0f;
    public float jumpSpeed = 10f;

    public GameObject pickupParticle;
    public GameManager manager;

    public GameTouch touch;


    private float horizontalMovement;
    private float verticalMovement;

    private Rigidbody ballBody;

    private Vector3 movementForce;

    private Vector3 startPoint;


    void Start()
    {
        ballBody = GetComponent<Rigidbody>();
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalMovement = Input.GetAxis("Horizontal");
        //verticalMovement = Input.GetAxis("Vertical");

        //Debug.Log(horizontalMovement + "     " + verticalMovement);
        //Debug.DrawRay(transform.position, Vector3.up * -1 * 0.6f, Color.red);


        horizontalMovement = touch.getHorizontal;
        verticalMovement = touch.getVertical;


        

        if (Input.GetButtonDown("Jump"))
        {

            Jump();
            
        }


    }

    public void Jump()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.up * -1, out hit, 0.6f))
        {
            Debug.Log(hit.transform.gameObject.name);
            ballBody.AddForce(new Vector3(0, 1, 0) * jumpSpeed);
        }
    }


    private void FixedUpdate()
    {

        movementForce = new Vector3(horizontalMovement, 0.0f, verticalMovement);


        ballBody.AddForce(movementForce * speed);

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickup")
        {
            Instantiate(pickupParticle, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            manager.AddScore(1);
            
        }
        else if (other.gameObject.tag == "gameover")
        {
            transform.position = startPoint;
            ballBody.velocity = Vector3.zero;
        }
        else if (other.gameObject.tag == "gamewin")
        {
            manager.GameWin();
        }
    }


}
