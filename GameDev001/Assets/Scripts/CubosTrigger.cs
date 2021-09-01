using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && QuestController.statusQuest == 1)
        {
            gameObject.SetActive(false);
            QuestController.contadorAtual += 1;
        }
    }
}
