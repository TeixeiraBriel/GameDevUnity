using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AcaoAtualController : MonoBehaviour
{
    public TextMeshProUGUI txtAcaoAtual;
    public static string acaoRealizar;
    // Start is called before the first frame update
    void Start()
    {
        acaoRealizar = "Atoa";
    }

    // Update is called once per frame
    void Update()
    {
        txtAcaoAtual.text = $"{acaoRealizar}";
    }
}
