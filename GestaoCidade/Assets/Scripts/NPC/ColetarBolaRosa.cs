using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarBolaRosa : MonoBehaviour
{
    public int CargaAtual;
    public int LimitCarga;
    public float Velocidade;
    Transform fonte;
    public Transform fonteBolaAzul;
    public Transform fonteBolaRosa;
    public Transform cabana;

    private bool cargaMaximaAtingida;

    // Start is called before the first frame update
    void Start()
    {
        fonte = null;

        if (Velocidade <= 0)
        {
            Velocidade = 5;
        }

        if (CargaAtual == LimitCarga)
        {
            cargaMaximaAtingida = true;
        }
        else
        {
            cargaMaximaAtingida = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CargaAtual == LimitCarga)//Vai pra cabana
        {
            seguir(cabana);
        }
        else//Vai coletar
        {
            seguir(fonte);
        }

        if (Input.GetKeyUp(KeyCode.Q) && fonte != fonteBolaAzul)
        {
            fonte = fonteBolaAzul;
            CargaAtual = 0;
            AcaoAtualController.acaoRealizar = "Coletando Bola Azul";
        }
        if (Input.GetKeyUp(KeyCode.W) && fonte != fonteBolaRosa)
        {
            fonte = fonteBolaRosa;
            CargaAtual = 0;
            AcaoAtualController.acaoRealizar = "Coletando Bola Rosa";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == fonte && CargaAtual != LimitCarga)
        {
            CargaAtual = LimitCarga;
            print("carga maxima atiginda!");
        }
        else if (other.transform == cabana && CargaAtual == LimitCarga)
        {
            CargaAtual = 0;
            print("carga maxima Zerada!");

            if (fonte == fonteBolaRosa)
            {
                ContadorColeta.contadorCubosRosas += LimitCarga;
            }
            else if (fonte == fonteBolaAzul)
            {
                ContadorColeta.contadorCubosAzuis += LimitCarga;
            }
        }
    }

    void seguir(Transform alvo)
    {
        if (fonte != null)
        {
            seguirJogador(controleDaDistancia(alvo), alvo);
        }
    }

    bool controleDaDistancia(Transform alvo)
    {
        float distanciaAoPlayer = Vector3.Distance(transform.position, alvo.position);
        if (distanciaAoPlayer < 100 && distanciaAoPlayer > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void seguirJogador(bool seguir, Transform alvo)
    {
        if (seguir)
        {
            Vector3 Direcao = (alvo.position - transform.position).normalized;
            transform.position += Direcao * Time.deltaTime * Velocidade;
            Quaternion olharPara = Quaternion.LookRotation(Direcao);
            transform.rotation = olharPara;
        }
        else
        {
            return;
        }
    }
}
