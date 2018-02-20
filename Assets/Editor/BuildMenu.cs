﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using monaka;

/*
 * ビルドメニュー
 */
public class BuildMenu : EditorWindow
{
    // Androidのビルド_
    [MenuItem("Build/Android")]
    private static void BuildAndroid()
    {
        AutoBuildClass.BuildAndroid();
    }

    // Androidのビルド_
    [MenuItem("Build/iOS")]
    private static void BuildiOS()
    {
        AutoBuildClass.BuildiOS();
    }
}
