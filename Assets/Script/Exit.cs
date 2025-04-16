using UnityEngine;
using UnityEngine.XR.Management;

public class NewMonoBehaviourScript : MonoBehaviour {

    public GameObject MenuIn;
    public GameObject MenuExit;

    void Start() {

    }

    void Update() {

    }

    public void OnClickExitBtn() {
        MenuIn.SetActive(false);
        MenuExit.SetActive(true);
    }

    public void OnClickNoBtn() {
        MenuExit.SetActive(false);
        MenuIn.SetActive(true);
    }

    

}