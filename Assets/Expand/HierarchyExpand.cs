using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class HierarchyExpand 
{
    //第三个参数是排序
    [MenuItem("Assets/My Tools/Tools 1", false, 2)]
    static void MyTools1(){
        if (Selection.activeObject != null)
        {
            Debug.Log(Selection.activeObject.name);
        }
    }

    [MenuItem("Assets/My Tools/Tools 2", false, 1)]
    static void MyTools2()
    {
        if (Selection.activeObject != null)
        {
            Debug.Log(Selection.activeObject.name);
        }
    }

    [MenuItem("Assets/Create/My Create/Cube", false, 2)]
    static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube); //创建立方体

    }
    [MenuItem("Assets/Create/My Create/Sphere", false, 1)]
    static void CreateSphere()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);//创建球体
    }

    //重写image菜单，将raycastTarget默认关闭
    [MenuItem("GameObject/UI/Image")]
    static void CreatImage()
    {
        if (Selection.activeTransform)
        {
            if (Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                Image image = new GameObject("image").AddComponent<Image>();
                image.raycastTarget = false;
                image.transform.SetParent(Selection.activeTransform, false);
                //设置选中状态
                Selection.activeTransform = image.transform;
            }
        }
    }
}
