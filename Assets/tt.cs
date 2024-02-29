using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tt : MonoBehaviour
{
    public Text ScriptTxt;
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScriptTxt.text = counter.ToString();

    }
}
