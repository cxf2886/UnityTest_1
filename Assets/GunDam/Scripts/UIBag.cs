using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBag : MonoBehaviour
{
    public GameObject title;
    private Transform tf;

    void Start()
    {
        tf = title.transform;
        title.SetActive(false);

        //如果object关了，返回null
        Debug.Log(GameObject.Find("img_namebg"));
        //这个不会受到开关影响
        Debug.Log(tf.Find("img_namebg"));

        Transform tt = transform.Find("Bag").GetComponent<Transform>();
        Vector3 p = new Vector3(200 , 0, 0);
        //tt.SetPositionAndRotation(p, new Quaternion());
        //tt.position = p;
        tt.localPosition = p;
        //tt.InverseTransformPoint(p);
        Debug.Log("123123");
    }

}
