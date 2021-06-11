using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTouch : MonoBehaviour
{
    public Image joyStick;


    private Vector2 startPos;
    private Vector2 endPos;

    private float Horizontal;
    private float Vertical;

    public float getHorizontal;
    public float getVertical;

    bool isJoyAvailable = false;


    // Start is called before the first frame update
    void Start()
    {
        startPos = Vector2.zero;
        endPos = Vector2.zero;
        joyStick.enabled = false;
        isJoyAvailable = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

           
            if (touch.phase == TouchPhase.Began)
            {
                if(touch.position.x < Screen.width / 2)
                {
                    startPos = touch.position;
                    joyStick.enabled = true;
                    isJoyAvailable = true;
                }
            }

            if (isJoyAvailable && touch.phase == TouchPhase.Ended)
            {
                startPos = Vector2.zero;
                endPos = Vector2.zero;
                joyStick.enabled = false;
                isJoyAvailable = false;
            }

            if (isJoyAvailable)
            {
                endPos = touch.position;
                joyStick.transform.position = endPos;

                Horizontal = endPos.x - startPos.x;
                Vertical = endPos.y - startPos.y;

                getHorizontal = Mathf.Clamp(Horizontal, -60, 60)/60f;
                getVertical = Mathf.Clamp(Vertical, -60, 60)/60f;

                Debug.Log(Horizontal + " , " + Vertical);
            }
            
        }
        else
        {
            getVertical = 0;
            getHorizontal = 0;
        }
        
        
    }
}
