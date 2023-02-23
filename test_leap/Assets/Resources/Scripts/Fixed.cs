using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }
    public void SetResolution()
    {
        int setWidth = 720;
        int setHeight = 1280;

        int deviceWidth = Screen.width;
        int deviceHeight = Screen.height;

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true);

        if ((float)setHeight / setWidth < (float)deviceHeight / deviceWidth)
        {
            
            float newHeight = ((float)setHeight / setWidth) / ((float)deviceHeight / deviceWidth);
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight);

        }
        else
        {
            float newWidth = ((float)deviceHeight / deviceWidth) / ((float)setHeight / setWidth);
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);
        }
    }
}
