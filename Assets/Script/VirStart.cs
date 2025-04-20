using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class VirStart : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource startBtnAudio;
    public FadeTransition fade;
    public GameObject Title;
    public GameObject Menu;

    public void onClickBtnStart() {
        startBtnAudio.Play();

        Title.SetActive(true);
        Menu.SetActive(false);

        fade.SetFadeDuration(2.0f);
        fade.FadeOut();
        StartCoroutine(FadeDelay());
    }

    IEnumerator FadeDelay() {
        yield return new WaitForSeconds(3f);
        fade.FadeInn();

        yield return new WaitForSeconds(fade.GetFadeDuration());
        Title.SetActive(false);
    }

}
