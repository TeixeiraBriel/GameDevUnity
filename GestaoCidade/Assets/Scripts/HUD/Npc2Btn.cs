using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Npc2Btn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button repro;
    public GameObject npc2;
    public GameObject helpText;

    private void Start()
    {
        repro.interactable = false;
    }

    private void Update()
    {
        if (ContadorColeta.contadorCubosAzuis == 20 && ContadorColeta.contadorCubosRosas == 20)
        {
            repro.interactable = true;
        }
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
            helpText.SetActive(true);
        }
        else
        {
            helpText.SetActive(false);
        }
    }

    public void dupli()
    {
        npc2.SetActive(true);
        ContadorColeta.contadorCubosAzuis -= 20;
        ContadorColeta.contadorCubosRosas -= 20;
        repro.interactable = false;
    }

    private bool mouse_over = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
    }
}

