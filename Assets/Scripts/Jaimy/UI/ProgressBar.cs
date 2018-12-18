using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FillBar { BAR_1, BAR_2, BAR_3 }

public class ProgressBar : MonoBehaviour {

    private FillBar fillBar;
    private Image image;

    public float addedAmount;

    private float maxAmount;

    private bool canFill;

    private GameObject progressPoint1;
    private GameObject progressPoint2;

    void Start()
    {
        fillBar = FillBar.BAR_1;

        image = GetComponent<Image>();
        image.type = Image.Type.Filled;
        image.fillMethod = Image.FillMethod.Horizontal;
        image.fillAmount = 0.833f;
        maxAmount = image.fillAmount;
    }

    void FixedUpdate()
    {
        if (image.fillAmount < maxAmount)
        {
            if (image.fillAmount + addedAmount > maxAmount)
            {
                UpdateDisplay(maxAmount);
            } else
            {
                UpdateDisplay(image.fillAmount + addedAmount);
            }
        } else if (image.fillAmount == maxAmount && !canFill)
        {
            canFill = true;
        }
    }

    public void UpdateDisplay(float percentage)
    {
        image.fillAmount = percentage;
    }


    public void FillNext()
    {
        if (!canFill) return;

        Debug.Log("Test");

        switch (fillBar)
        {
            case FillBar.BAR_1:
                fillBar = FillBar.BAR_2;

                maxAmount = 0.915f;

                canFill = false;

                break;

            case FillBar.BAR_2:
                fillBar = FillBar.BAR_3;

                maxAmount = 1;

                canFill = false;
                break;
        }
    } 
}