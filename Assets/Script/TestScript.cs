using UnityEngine;

public class TestScript : MonoBehaviour
{

    public FadeTransition fade;
    void Start()
    {
        fade.SetFadeDuration(5.0f);
        fade.FadeInn();
    }

}
