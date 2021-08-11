using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteManager : MonoBehaviour
{
    public bool RouteOne = false, RouteTwo = false, RouteThree = false;

    [SerializeField] private GameObject Route1;
    [SerializeField] private GameObject Route2;
    [SerializeField] private GameObject Route3;

    void Start()
    {
        RouteReset();
    }

    public void RouteReset()
    {
        Route1.SetActive(false);
        Route2.SetActive(false);
        Route3.SetActive(false);
    }

    public void RegenerateButton()
    {
        RouteReset();
        Route1.SetActive(false);
        Route2.SetActive(false);
        Route3.SetActive(false);

        int RouteSwitch = UnityEngine.Random.Range(1, 4);
        if (RouteSwitch == 1)
        {
            Route1.SetActive(true);
        }
        else if (RouteSwitch == 2)
        {
            Route2.SetActive(true);
        }
        else
        {
            Route3.SetActive(true);
        }
    }
}