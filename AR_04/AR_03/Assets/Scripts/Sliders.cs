using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public GameObject obj;
    public Slider scale;
    public Slider rotation;
    public GameObject checkeredPlane;
    bool isOn = true;

    // Update is called once per frame
    void Update()
    {
        obj.transform.localScale = new Vector3(scale.value, scale.value, scale.value);
        obj.transform.rotation = Quaternion.Euler(0, rotation.value, 0);
    }
    public void button()
    {
        if (isOn)
        {
            checkeredPlane.SetActive(false);
        }
        else
        {
            checkeredPlane.SetActive(true);
        }
    }
}
