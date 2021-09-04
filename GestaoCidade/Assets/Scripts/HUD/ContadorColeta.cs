using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorColeta : MonoBehaviour
{
    public TextMeshProUGUI txtColetaBolaRosa;
    public TextMeshProUGUI txtColetaBolaAzul;

    public static int contadorCubosRosas;
    public static int contadorCubosAzuis;
    // Start is called before the first frame update
    void Start()
    {
        txtColetaBolaRosa.text = $"Cubos Rosas: {contadorCubosRosas}";
        txtColetaBolaAzul.text = $"Cubos Azuis: {contadorCubosAzuis}";
    }

    // Update is called once per frame
    void Update()
    {
        txtColetaBolaRosa.text = $"Cubos Rosas: {contadorCubosRosas}";
        txtColetaBolaAzul.text = $"Cubos Azuis: {contadorCubosAzuis}";
    }
}
