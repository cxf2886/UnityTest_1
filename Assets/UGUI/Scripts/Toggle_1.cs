using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_1 : MonoBehaviour
{
    public Toggle []toogles;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var toogle in toogles) {
            toogle.onValueChanged.AddListener(delegate (bool selected)
            {
                Debug.LogFormat("toogle = {0} selected = {1}", toogle.name, selected);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
