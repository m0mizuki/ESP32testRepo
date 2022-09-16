using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESP32Manager : MonoBehaviour
{

    public SerialHandler serialHandler;

    // Start is called before the first frame update
    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDataReceived(string message)
    {
        var data = message.Split(
            new string[]{"\n"}, System.StringSplitOptions.None);
        if (data.Length != 1) return;
        Debug.Log(data[0]);
    }
}
