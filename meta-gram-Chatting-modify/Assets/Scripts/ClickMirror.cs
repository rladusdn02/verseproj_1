using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickMirror : MonoBehaviour
{
    private void OnMouseDown() {
        Debug.Log("Mirror Clicked");
        //FindObjectOfType<SceneEffect_Simple>().FadeToScene("Mirror");
        SceneManager.LoadScene("Mirror");
    }
}