using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level2Evaluation : MonoBehaviour
{

    public UnityEvent OnSuccess;

    public Transform griffLinksUnten;
    public float griffLinksUntenMinY;
    public float griffLinksUntenMaxY;

    public Transform griffRechtsUnten;
    public float griffRechtsUntenMinY;
    public float griffRechtsUntenMaxY;

    public Transform griffLinksSeite;
    public float griffLinksSeiteMinY;
    public float griffLinksSeiteMaxY;

    public Transform griffRechtsSeite;
    public float griffRechtsSeiteMinY;
    public float griffRechtsSeiteMaxY;

    private bool griffLinksUntenState = false;
    private bool griffLinksSeiteState = false;
    private bool griffRechtsUntenState = false;
    private bool griffRechtsSeiteState = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        griffLinksUntenState = Check(griffLinksUnten, griffLinksUntenMinY, griffLinksUntenMaxY, 1);
        griffRechtsUntenState = Check(griffRechtsUnten, griffRechtsUntenMinY, griffRechtsUntenMaxY, 1);

        griffLinksSeiteState = Check(griffLinksSeite, griffLinksSeiteMinY, griffLinksSeiteMaxY, 0);
        griffRechtsSeiteState = Check(griffRechtsSeite, griffRechtsSeiteMinY, griffRechtsSeiteMaxY, 0);

        if (griffLinksUntenState && griffLinksSeiteState && griffRechtsUntenState && griffRechtsSeiteState) {
            OnSuccess.Invoke();
        }
    }


    bool Check(Transform griff, float min, float max, int direction) {

        if (griff.localPosition[direction]> min && griff.localPosition[direction] < max)
        {
            return true;
        }
        else {
            return false;
        }
    }
}
