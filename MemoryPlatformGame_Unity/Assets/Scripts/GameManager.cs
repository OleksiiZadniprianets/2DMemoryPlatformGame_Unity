using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public float lightTime = 2f;
    public float darkTime = 10f;

    public DarkOnLightOff[] spikes;
    public DarkOnLightOff[] teleports;

    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(LightDarkLoop());
    }

    IEnumerator LightDarkLoop()
    {
        while (true)
        {
            // світло
            SetDark(false);
            yield return new WaitForSecondsRealtime(lightTime);

            // темрява
            SetDark(true);
            yield return new WaitForSecondsRealtime(darkTime);
        }
    }

    void SetDark(bool dark)
    {
        foreach (var s in spikes)
            if (s != null) s.SetDark(dark);

        foreach (var t in teleports)
            if (t != null) t.SetDark(dark);
    }
}
