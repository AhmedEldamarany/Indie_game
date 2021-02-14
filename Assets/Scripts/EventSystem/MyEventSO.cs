using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName="SO/My EventSO")]
public class MyEventSO : ScriptableObject
{
    List<MyEventListner> EventListners = new List<MyEventListner>();


      public void RegisterEvent(MyEventListner listner)
    {
        if (!EventListners.Contains(listner))
        {
            EventListners.Add(listner);
        }
    }
    public void UnRegisterEvent(MyEventListner listner)
    {
        if (EventListners.Contains(listner))
        {

            EventListners.Remove(listner);
        }
    }

    public void Raise()
    {
        for (int i = EventListners.Count - 1; i >= 0; i--)
        {

            EventListners[i].OnEventRaise();
        }

    }
 
}
