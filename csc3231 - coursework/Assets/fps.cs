using UnityEngine;
using System.Collections;

public class Fps : MonoBehaviour
{
    private float count;

    void Update(){
        OnGUI();
    }

    private IEnumerator Start()
    {
        Application.targetFrameRate=60;
        GUI.depth = 2;
        GUI.color = Color.black;
        while (true)
        {
            count = 1f / Time.unscaledDeltaTime;
            yield return new WaitForSeconds(0.1f);
            
        }

    }
    

    private void OnGUI()
    {
        GUI.Label(new Rect(5, 40, 100, 25), "FPS: " + Mathf.Round(count));
        
        GUI.Label(new Rect(5, 55, 100, 25), "Memory: " + System.GC.GetTotalMemory(false)/(1024*1024) + "MB");
    }
}