using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTestScene : MonoBehaviour
{
    public FadeTransition Fade;
    public AudioSource audioSrc;
    public AudioSource musicBack;

    public void Scene2Load() {
        audioSrc.Play();
        Fade.SetFadeDuration(3.0f);
        StartCoroutine(LoadScene2Fade());
    }

    private IEnumerator LoadScene2Fade() {
        Fade.FadeOut();
        yield return new WaitForSeconds(Fade.GetFadeDuration());
        SceneManager.LoadScene("TestScene");
    }

    private void Awake() {
        DontDestroyOnLoad(musicBack);
    }



}
