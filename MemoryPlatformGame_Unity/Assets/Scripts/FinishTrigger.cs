using UnityEngine;
using System.Collections;

public class FinishTrigger : MonoBehaviour
{
    public GameObject victoryText;
    public Transform startPoint;

    private bool waitingForRestart = false;
    private Transform playerTransform;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !waitingForRestart)
        {
            playerTransform = other.transform;
            StartCoroutine(VictorySequence());
        }
    }

    void Update()
    {
        if (waitingForRestart && Input.GetKeyDown(KeyCode.L))
        {
            RestartLevel();
        }
    }

    IEnumerator VictorySequence()
    {
        waitingForRestart = true;

        victoryText.SetActive(true);

        Time.timeScale = 0f;

        float timer = 0f;
        while (timer < 10f && waitingForRestart)
        {
            timer += Time.unscaledDeltaTime;
            yield return null;
        }

        RestartLevel();
    }

    void RestartLevel()
    {
        Time.timeScale = 1f;

        victoryText.SetActive(false);

        if (playerTransform != null)
        {
            playerTransform.position = startPoint.position;
        }

        waitingForRestart = false;
    }
}
