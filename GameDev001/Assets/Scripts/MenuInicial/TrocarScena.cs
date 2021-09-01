using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarScena : MonoBehaviour
{
    public string nomeDaCena;

    public void TrocarCena()
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
