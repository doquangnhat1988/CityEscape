using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayTooltip : MonoBehaviour
{

    [SerializeField]
    private GameObject PlayTooltip_img;
    [SerializeField]
    private GameObject Play_txt;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2.0f);

        StartCoroutine(ShowPlayTooltip(4.0f));
    }

    private IEnumerator ShowPlayTooltip(float showTime)
    {
        PlayTooltip_img.active = true;
        Play_txt.active = true;

        yield return new WaitForSeconds(showTime);

        StartCoroutine(HidePlayTooltip(4.0f));
    }

    private IEnumerator HidePlayTooltip(float hideTime)
    {
        PlayTooltip_img.active = false;
        Play_txt.active = false;

        yield return new WaitForSeconds(hideTime);

        StartCoroutine(ShowPlayTooltip(4.0f));
    }
}
