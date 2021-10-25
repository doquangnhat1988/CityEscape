using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPlay : MonoBehaviour
{
    [SerializeField]
    private Button Play_btn;

    // Start is called before the first frame update
    void Start()
    {
        Play_btn.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("CityEscape/Scenes/GamePlayLighting");
        SceneManager.LoadScene("CityEscape/Scenes/GamePlayCharacter", LoadSceneMode.Additive);
        SceneManager.LoadScene("CityEscape/Scenes/GamePlayEnv_1", LoadSceneMode.Additive);
    }

}
