using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerState : MonoBehaviour
{

    public bool isTriggered;
    [Space(5)]
    public UnityEvent EvaluationEvent_True;
    [Space(5)]
    public UnityEvent EvaluationEvent_False;

    public void SetTriggerState(bool State)
    {
        isTriggered = State;
    }




    public void SelfEvaluation()
    {
        if(isTriggered)
        {
            EvaluationEvent_True.Invoke();
        }
        else
        {
            EvaluationEvent_False.Invoke();
        }              
        
    }

}
