﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

//监听Project视图窗口，可以拓展出资源管理
public class ProjectExpand : UnityEditor.AssetModificationProcessor
{
    //[InitializeOnLoadMethod]
    //static void InitializeOnLoadMethod()
    //{
    //    //全局监听Project视图下的资源是否发生变化（添加、删除、移动）
    //    EditorApplication.projectChanged += OnProjectChanged;
    //}

    //static void OnProjectChanged()
    //{
    //    Debug.Log("OnProjectChanged");
    //}

    ////监听双击鼠标左键打开资源事件
    //public static bool IsOpenForEdit(string assetPath, out string message)
    //{
    //    message = null;
    //    //Debug.LogFormat("assetPath : {0} ", assetPath);
    //    //true表示该资源可以打开，false表示不允许在unity中打开该资源
    //    return false;
    //}

    ////监听资源即将被创建事件
    //public static void OnWillCreateAsset(string path)
    //{
    //    Debug.LogFormat("OnWillCreateAsset ===>>> path : {0}", path);
    //}
    ////监听资源即将被保存事件
    //public static string[] OnWillSaveAssets(string[] paths)
    //{
    //    if (paths != null)
    //    {
    //        Debug.LogFormat("OnWillSaveAssets ===>>> path : {0}", string.Join(",", paths));
    //    }
    //    return paths;
    //}
    ////监听资源即将被移动事件
    //public static AssetMoveResult OnWillMoveAsset(string oldPath, string newPath)
    //{
    //    Debug.LogFormat("OnWillMoveAsset ===>>> from : {0} to : {1}", oldPath, newPath);
    //    //AssetMoveResult.DidMove表示该资源可以移动
    //    return AssetMoveResult.DidMove;
    //}
    ////监听资源即将被删除事件
    //public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option)
    //{
    //    Debug.LogFormat("OnWillDeleteAsset ===>>> delete : {0}", assetPath);
    //    //AssetDeleteResult.DidNotDelete表示该资源不可以被删除
    //    return AssetDeleteResult.DidDelete;
    //}
}
