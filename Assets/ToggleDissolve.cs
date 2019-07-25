using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDissolve : MonoBehaviour
{
    public Material dissolveMat;
    float dissolveValue;
    public float maxHealth;
    bool isToggled;

    // Start is called before the first frame update
    void Start()
    {
        dissolveValue = 0f;
        maxHealth = 100f;
        dissolveMat.SetFloat("Vector1_2326039C", dissolveValue);
        isToggled = false;
    }

    void dissolveToggleOn()
    {
        if(dissolveMat.GetFloat("Vector1_2326039C") < 1)
        {
            dissolveValue = dissolveValue + 0.01f;
            dissolveMat.SetFloat("Vector1_2326039C", dissolveValue);
        }
    }

    void dissolveToggleOff()
    {
        if (dissolveMat.GetFloat("Vector1_2326039C") > 0)
        {
            dissolveValue = dissolveValue - 0.01f;
            dissolveMat.SetFloat("Vector1_2326039C", dissolveValue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isToggled == false)
            {
                isToggled = true;
            }
            else
            {
                isToggled = false;
            }
        }
        if(isToggled == false)
        {
            dissolveToggleOff();
        } else
        {
            dissolveToggleOn();
        }
    }
}