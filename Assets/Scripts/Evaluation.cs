using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluation : MonoBehaviour
{
    public List<TriggerState> TriggerZones;


    // Start is called before the first frame update
    public void EvaluateTriggerZones()
    {
        int counter = 0;
        foreach(TriggerState zone in TriggerZones)
        {
            zone.SelfEvaluation();
            if (zone.isTriggered) counter++;
        }

        Debug.Log("Auswertung: "+counter+"/"+TriggerZones.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
