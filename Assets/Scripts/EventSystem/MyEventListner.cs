using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MyEventListner : MonoBehaviour
    {
   [SerializeField]  UnityEvent[] responses;
   [SerializeField]  MyEventSO emptyPaper;

    private void OnEnable()
    {
        emptyPaper.RegisterEvent(this);
    }
    private void OnDisable()
    {

        emptyPaper.UnRegisterEvent(this);

    }
    public void OnEventRaise()
    {
        foreach(var response in responses)
        response.Invoke();
       

    }
}
