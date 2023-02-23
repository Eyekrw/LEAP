using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flag : MonoBehaviour
{
    public int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returntoS()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void onclick()
    {
        t++;
        if (t > 3)
        {
            SceneManager.LoadScene("save2");
        }
    }
}
