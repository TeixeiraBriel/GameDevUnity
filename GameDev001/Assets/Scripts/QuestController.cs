using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour
{
    public Canvas Quest;
    public Canvas QuestAtualPanel;
    public TextMeshProUGUI blocoQuest;
    public TextMeshProUGUI txtButtonQuest;
    public TextMeshProUGUI txtQuestAtual;
    public Button btnQuest;
    public string textoMissao;
    public string textoFazendo;
    public string textoCompleto;

    public int contadorMax;
    public static int contadorAtual;
    public static int statusQuest;

    private bool trigger;
    private bool sair;
    // Start is called before the first frame update
    void Start()
    {
        blocoQuest.text = textoMissao;
        statusQuest = 0;
    }

    // Update is called once per frame
    void Update()
    {
        trigger = MinaFoneQuests.isTriggered;

        if (!sair)
        {
            if (trigger)
            {
                Quest.enabled = true;
            }
            else
            {
                Quest.enabled = false;
            }
        }


        switch (statusQuest)
        {
            case 0:
                blocoQuest.text = textoMissao;
                txtButtonQuest.text = "Aceitar";
                break;
            case 1:
                blocoQuest.text = textoFazendo + $" ({contadorAtual}/{contadorMax})";
                txtQuestAtual.text = blocoQuest.text;
                QuestAtualPanel.enabled = true;

                txtButtonQuest.text = "Completar";
                if (contadorAtual == contadorMax)
                {
                    btnQuest.interactable = true;
                }
                else
                {
                    btnQuest.interactable = false;
                }
                break;
            case 2:
                blocoQuest.text = textoCompleto;
                txtButtonQuest.text = "Sair";
                break;
        }
    }

    public void aceitarQuest()
    {
        if (trigger && statusQuest == 0)
        {
            statusQuest = 1;
        }
        else if (trigger && statusQuest == 1)
        {
            statusQuest = 2;
        }
        else if(trigger && statusQuest == 2)
        {
            Quest.enabled = false;;
            QuestAtualPanel.enabled = false;
            sair = true;
        }
    }
}
