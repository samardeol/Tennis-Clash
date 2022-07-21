using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class space_continue : MonoBehaviour
{
	Text score2;
    // Start is called before the first frame update
    void Start()
    {
        score2=GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        score2.text="Press Space to Continue";
        }
        if(Input.GetKeyDown(KeyCode.Space)){
        score2.text="";
        }
    }
}
