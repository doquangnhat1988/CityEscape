using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    [SerializeField]
    private GameObject SettingsBar_group;
    [SerializeField]
    private Button Settings_btn;

    [SerializeField]
    private Animator SettingsBar_animator;

    private const int SETTINGS_BAR_START_POSITION = 392;

    private void Awake()
    {
        Vector3 position = SettingsBar_group.GetComponent<RectTransform>().anchoredPosition;
        position.x = SETTINGS_BAR_START_POSITION;
        SettingsBar_group.GetComponent<RectTransform>().anchoredPosition = position;

        Settings_btn.onClick.AddListener(OnShowSettings);
    }

    private void OnShowSettings()
    {
        
        Vector3 position = SettingsBar_group.GetComponent<RectTransform>().anchoredPosition;
        if (position.x > 0)
        {
            SettingsBar_animator.Play("SettingsBarShow_anim");
        }
        else
        {
            SettingsBar_animator.Play("SettingsBarHide_anim");
        }
    }

}
