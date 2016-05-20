using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

    public void FadeMe()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade ()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0f)
        {
            canvasGroup.alpha -= Time.deltaTime / 0.6f;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
}
