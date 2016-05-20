using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

    public void FadeMe()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade ()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1f)
        {
            canvasGroup.alpha += Time.deltaTime / 0.6f;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
    }
}
