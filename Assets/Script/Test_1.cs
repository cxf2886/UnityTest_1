using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_1 : MonoBehaviour
{
    [Range(1, 100) ]
    public int id;

    public new string name;

    private int id2;

    private void Awake()
    {
        Debug.Log("Test_1 Awake");
    }
  
    void Start()
    {
        Debug.Log("Test_1 Start");
        id2 = 123;
        Test_4 sc = Resources.Load<Test_4>("num_test_4");
        Debug.Log(sc.ids);
    }
   
}
