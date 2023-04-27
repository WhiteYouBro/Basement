using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamps : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private Light light2;

    [SerializeField] private int randomtimemax;
    [SerializeField] private int randomtimemin;

    private int randomtime;

    private float time;

    private bool isenable;
    private void Start()
    {
        isenable = true;
        randomtime = Random.Range(randomtimemin, randomtimemax);
    }
    private void Update()
    {
        time += Time.deltaTime;
        if(time > randomtime && isenable == true)
        {
            light.enabled = false;
            light2.enabled = false;
            isenable = false;
            time = 0;
        }
        else if(time > randomtimemin)
        {
            light.enabled = true;
            light2.enabled = true;
            isenable = true;
            time = 0;
        }
        
    }
}
