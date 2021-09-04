using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc2Btn : MonoBehaviour
{
    public Button repro;
    public GameObject npc2;

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
    }

    public void dupli()
    {
        npc2.active = true;
        ContadorColeta.contadorCubosAzuis -= 20;
        ContadorColeta.contadorCubosRosas -= 20;
        repro.interactable = false;
    }
}
