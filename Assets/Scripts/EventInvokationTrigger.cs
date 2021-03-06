using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventInvokationTrigger : MonoBehaviour {

    public bool EventInvokationTriggerActive = true;

    [Header("Leave empty detect all collisions")]
    public string ColliderTag;
    
    [Space(5)]
    public UnityEvent OnTriggerEnterEvent;
    [Space(5)]
    public UnityEvent OnTriggerStayEvent;
    [Space(5)]
    public UnityEvent OnTriggerExitEvent;

    void Start () {
        if (ColliderTag == null)
        {
            ColliderTag = "other";
        }
    }
	
	private void OnTriggerEnter(Collider Collider)

    {
        if (Collider.tag == ColliderTag)
        {
            OnTriggerEnterEvent.Invoke();
        }
            
    }
        
    private void OnTriggerStay(Collider Collider)
    {
        if (Collider.tag == ColliderTag)
        {
            OnTriggerStayEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider Collider)
    {
        if (Collider.tag == ColliderTag)
        {
            OnTriggerExitEvent.Invoke();
        }
    }

}
