using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_1 : MonoBehaviour
{
    //控制int范围
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

        //Resources.Load只能读取Resources文件夹下的资源
        //Config必须放在Resources文件下
        ConfigClass sc = Resources.Load<ConfigClass>("Config");
        Debug.Log(sc.ids);
    }
   
}
