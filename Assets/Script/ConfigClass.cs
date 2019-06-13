using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//类似于一个表结构的类，可以在create菜单上创建这个表
[CreateAssetMenu]
public class ConfigClass : ScriptableObject
{
    //只有一个公开int字段
    public int ids;
}
