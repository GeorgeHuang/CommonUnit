using UnityEngine;
using System.Collections;

public class FPSDisplayScript : MonoBehaviour
{
    float timeA;
    public int fps;
    public int lastFPS;
    public GUIStyle textStyle;
    // Use this for initialization
    void Start()
    {
        timeA = Time.timeSinceLevelLoad;
        textStyle.fontSize = 60;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.timeSinceLevelLoad+" "+timeA);
        if (Time.timeSinceLevelLoad - timeA <= 1)
        {
            fps++;
        }
        else
        {
            lastFPS = fps + 1;
            timeA = Time.timeSinceLevelLoad;
            fps = 0;
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 300, 300), "" + lastFPS, textStyle);
    }
}
