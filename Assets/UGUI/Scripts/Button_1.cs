using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Button_1 : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(delegate ()
        {
            Debug.Log("click");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
