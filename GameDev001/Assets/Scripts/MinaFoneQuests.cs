using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MinaFoneQuests : MonoBehaviour
{
    public static bool isTriggered;
    bool quest;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && quest && isTriggered)
        {
            isTriggered = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && quest)
        {
            isTriggered = quest;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quest = true;
            print("MinaFoneTriggerEnter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quest = false;
            isTriggered = false;
            print("MinaFoneTriggerExit");
        }
    }
}
