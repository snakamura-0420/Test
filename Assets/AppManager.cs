using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AppManager : MonoBehaviour {

    [SerializeField]
    private Button button = null;

    // Use this for initialization
    void Start () {
        // ボタンクリック処理を追加_
		if( button != null )
        {
            button.onClick.AddListener(buttonClick);
        }
        else
        {
            Debug.LogError("button not found");
        }
	}
	
    /*
	// Update is called once per frame
	void Update () {
		
	}
    */

    void buttonClick()
    {
        Debug.LogError("OnClick");
    }
}
