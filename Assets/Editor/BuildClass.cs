using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace monaka
{
    /*
     * コンソールビルド用
     */
    public class BuildClass
    {

        public static void BuildAndroid()
        {
            // ビルド対象のシーンリスト
            // TODO:インスペクタ等に出す。
            string[] sceneList =
            {
            "./Assets/main.unity"
        };

            // ビルド実行_
            string errorMessage = BuildPipeline.BuildPlayer(
                sceneList,                          //!< ビルド対象シーンリスト_
                "./Build/Android/monaka.apk",       //!< 出力先_
                BuildTarget.Android,                //!< ビルド対象プラットフォーム_
                BuildOptions.Development            //!< ビルドオプション_
                );

            // 結果出力_
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Debug.LogError("Error:" + errorMessage);
            }
            else
            {
                Debug.Log("Success");
            }

        }

        public static void BuildiOS()
        {
            // ビルド対象のシーンリスト
            // TODO:インスペクタ等に出す。
            string[] sceneList =
            {
            "./Assets/main.unity"
        };

            // ビルド実行_
            string errorMessage = BuildPipeline.BuildPlayer(
                sceneList,                          //!< ビルド対象シーンリスト_
                "./Build/bin/iOS",               //!< 出力先_
                BuildTarget.iOS,                    //!< ビルド対象プラットフォーム_
                BuildOptions.Development            //!< ビルドオプション_
                );

            // 結果出力_
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Debug.LogError("Error:" + errorMessage);
            }
            else
            {
                Debug.Log("Success");
            }

        }
    }
}
