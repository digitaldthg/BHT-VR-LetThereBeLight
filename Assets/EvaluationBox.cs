using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EvaluationBox : MonoBehaviour
{
    [Space(5)]
    public UnityEvent OnSuccess;

    private bool greenCollision = false;
    private bool redCollision = false;
    private bool blueCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButtonGreen") {
            greenCollision = true;
            if (redCollision && !blueCollision) {
                OnSuccess.Invoke();
            }
        }

        if (other.tag == "ButtonRed")
        {
            redCollision = true;
            if (greenCollision && !blueCollision)
            {
                OnSuccess.Invoke();
            }
        }

        if (other.tag == "Button")
        {
            blueCollision = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ButtonGreen")
        {
            greenCollision = false;
        }

        if (other.tag == "ButtonRed")
        {
            redCollision = false;
        }

        if (other.tag == "Button")
        {
            blueCollision = false;
            if (redCollision && greenCollision) {
                OnSuccess.Invoke();
           }
        }
    }
}
