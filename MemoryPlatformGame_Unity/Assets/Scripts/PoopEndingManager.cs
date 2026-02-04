using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PoopEndingManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ReturnToMain());
    }

    IEnumerator ReturnToMain()
    {
        yield return new WaitForSecondsRealtime(10f);
        SceneManager.LoadScene("SampleScene");
    }
}
