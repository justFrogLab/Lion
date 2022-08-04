using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class StartScence : MonoBehaviour
{
    [SerializeField]
    Text logoTxt;

    private void Start()
    {
        Debug.Log(logoTxt.color);
        StartCoroutine(startLogoTxt());
    }

    IEnumerator startLogoTxt()
    {
        float f = 1.0f;
        logoTxt.color = new Color(logoTxt.color.r, logoTxt.color.g, logoTxt.color.b, 1);

        while (logoTxt.color.a > 0.0f)
        {
            logoTxt.color = new Color(logoTxt.color.r, logoTxt.color.g, logoTxt.color.b, logoTxt.color.a - (Time.deltaTime / 4.0f));
            yield return null;
        }
    }
}
