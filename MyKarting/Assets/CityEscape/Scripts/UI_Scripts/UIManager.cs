using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public GameObject loadingInterface;
    [SerializeField]
    public Image loadingProgressBar;

    [SerializeField]
    public GameObject InfoGroup;
    [SerializeField]
    public GameObject SettingsGroup;

    [SerializeField]
    private Button Play_btn;
    [SerializeField]
    public GameObject Exit_btn;


    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    // Start is called before the first frame update
    void Start()
    {
        Play_btn.onClick.AddListener(PlayGame);

        loadingInterface.SetActive(false);
    }

    private void PlayGame()
    {
        HideMenu();
        ShowLoadingBar();

        scenesToLoad.Add(SceneManager.LoadSceneAsync("CityEscape/Scenes/GamePlayLighting"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("CityEscape/Scenes/GamePlayCharacter", LoadSceneMode.Additive));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("CityEscape/Scenes/GamePlayEnv_1", LoadSceneMode.Additive));

        StartCoroutine(LoadingScreen());
    }

    private IEnumerator LoadingScreen()
    {
        float totalProgress = 0;
        for (int scene = 0; scene < scenesToLoad.Count; ++scene)
        {
            Debug.Log($"{scene} {scenesToLoad.Count}");
            while (!scenesToLoad[scene].isDone)
            {
                totalProgress += scenesToLoad[scene].progress;
                loadingProgressBar.fillAmount = totalProgress / scenesToLoad.Count;
                Debug.Log($"{totalProgress} {scenesToLoad[scene].progress}");
                yield return null;
            }
        }
    }

    private void ShowLoadingBar()
    {
        loadingInterface.SetActive(true);
        loadingProgressBar.fillAmount = 0;
    }

    private void HideMenu()
    {
        InfoGroup.SetActive(false);
        SettingsGroup.SetActive(false);
        Exit_btn.SetActive(false);
        Play_btn.gameObject.SetActive(false);
    }


}
