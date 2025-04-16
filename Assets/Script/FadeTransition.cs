using System.Collections;
using UnityEngine;

public class FadeTransition : MonoBehaviour
{
    public CanvasGroup canvsGrp;
    private float fadeDuration; //Private so dev cant set value in unity

    //Setter for Fade Duration
    public void SetFadeDuration(float duration) {  this.fadeDuration = duration; }

    //Getter for Fade Duration
    public float GetFadeDuration() { return fadeDuration; }

    public void FadeInn() {
        StartCoroutine(CanvasGrpFade(canvsGrp, canvsGrp.alpha, 0, fadeDuration));
    }

    public void FadeOut() {
        StartCoroutine(CanvasGrpFade(canvsGrp, canvsGrp.alpha, 1, fadeDuration));
    }

    private IEnumerator CanvasGrpFade(CanvasGroup cg, float start, float end, float duration) {

        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration) {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsedTime / duration);
            yield return null;
        }
        cg.alpha = end;
    }
}

