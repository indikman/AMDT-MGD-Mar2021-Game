using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchTest : MonoBehaviour
{
    public TextMeshProUGUI startPoint;
    public TextMeshProUGUI endPoint;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startPoint.SetText(Input.GetTouch(0).position.x + " , " + Input.GetTouch(0).position.y);
        }

        if (Input.touchCount > 0)
        {
            endPoint.SetText(Input.GetTouch(0).position.x + " , " + Input.GetTouch(0).position.y);
        }

    }
}
