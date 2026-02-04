using UnityEngine;

public class DarkOnLightOff : MonoBehaviour
{
    private SpriteRenderer sr;
    private Color originalColor;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            originalColor = sr.color;
        }
    }

    public void SetDark(bool dark)
    {
        if (sr == null) return;

        if (dark)
        {
            sr.color = new Color(
                originalColor.r * 0.25f,
                originalColor.g * 0.25f,
                originalColor.b * 0.25f,
                originalColor.a
            );
        }
        else
        {
            sr.color = originalColor;
        }
    }
}
