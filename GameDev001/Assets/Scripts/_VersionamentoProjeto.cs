using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _VersionamentoProjeto : MonoBehaviour
{
    /* HELP Versionamento
     * x. Master - Quando há uma mudança muito grande no projeto
     * x. Minor - Sempre que adicionar uma funcionalidade novo (Como missão, char, cidade, vila, vilão, mapa...)
     * x. build - Sempre que realizar qualquer mudança.
     * xxxx data - Referente a data que editou, por exemplo, setembro de 2021 ficaria, (21 -> do ano + 09 -> referente ao mes) logo 2109         
     */

    private string versao = "v1.0.1.2109";

    #region Codigo
    public TextMeshProUGUI txtVersao;

    private void Start()
    {
        txtVersao.text = versao;
    }
    #endregion
}
