using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInfo : MonoBehaviour
{
    [SerializeField]
    private GameObject InfoBar_group;
    [SerializeField]
    private Button Info_btn;

    [SerializeField]
    private Animator InfoBar_animator;

    private const int INFO_BAR_START_POSITION = 367;

    private void Awake()
    {
        /* Due in Unity, can't not move UI game object with both Animator and script 
         * This is the normal behaviour of Animator. It will always override all the actions that you make from script.
        */
        Vector3 position = InfoBar_group.GetComponent<RectTransform>().anchoredPosition;
        position.x = INFO_BAR_START_POSITION;
        InfoBar_group.GetComponent<RectTransform>().anchoredPosition = position;

        Info_btn.onClick.AddListener(OnShowSettings);
    }

    private void OnShowSettings()
    {
        Vector3 position = InfoBar_group.GetComponent<RectTransform>().anchoredPosition;
        if (position.x > 0)
        {
            InfoBar_animator.Play("InfoBarShow_anim");
        }
        else
        {
            InfoBar_animator.Play("InfoBarHide_anim");
        }
    }
        
}
