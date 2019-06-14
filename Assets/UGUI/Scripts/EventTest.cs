using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyEvent : UnityEvent<int, string> { }

public class EventTest : MonoBehaviour
{
    public UnityAction<int, string> action1;
    public UnityAction<int, string> action2;
    public MyEvent myEvent = new MyEvent();

    public void RunMyEvent1(int a, string b)
    {
        Debug.Log(string.Format("RunMyEvent1, {0}, {1}", a, b));
    }
    public void RunMyEvent2(int a, string b)
    {
        Debug.Log(string.Format("RunMyEvent2, {0}, {1}", a, b));
    }

    private void Start()
    {
        
    }
}
