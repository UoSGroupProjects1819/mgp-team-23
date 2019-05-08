using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    public Image image;
    private float ratCount;
    public float barFillAmount;

    void Start()
    {
        image.type = Image.Type.Filled;
        image.fillAmount = 0;
    }

    void Update()
    {
        barFillAmount = GameObject.Find("RatCounter").GetComponent<RatCounter>().ratList.Length;
        image.fillAmount = barFillAmount / 100 * 5;
        if (image.fillAmount >= 1.0f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
