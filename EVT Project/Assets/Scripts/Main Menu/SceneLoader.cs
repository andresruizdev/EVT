using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class SceneLoader : MonoBehaviour {

    public GameObject loadingScreen,loadingImage;
    public Slider slider;

    public void LoadLevel(int sceneIndex)
    {//Inicializa la corrutina para la carga de escena
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    // Corrutina para cargar la escena con pantalla de carga
    IEnumerator LoadAsynchronously (int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        loadingScreen.SetActive(true);
        loadingImage.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
}
