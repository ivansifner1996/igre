using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperiRuke : MonoBehaviour
{
    public GameObject OperiPanel = null;
    private bool operiRuke;
    public GameObject oru�je = null;
    void Start()
    {
        operiRuke = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            operiRuke = true;
            OperiPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (operiRuke)
        {
            operiRuke = false;
            OperiPanel.SetActive(false);
            Debug.Log("ajde exit");
        }
        Debug.Log("ajde exit");
    }

    void Update()
    {
        if (operiRuke)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                OperiPanel.SetActive(false);
                oru�je.SetActive(true);
            }
        }
    }
}
