using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    [SerializeField] GameObject AreaPrefab;
   

    Bloco[,]blocos;

    int contador;

    public int linhas = 5;
    public int colunas = 5;
    public float espacamento = 1.0f;
    private Bloco[,] grade;
    private Jogador jogador1;
    private Jogador jogador2;
    private int contadorConquistados = 0;
    void Start()
    {
        CriarGrade();
        PosicionarJogadores();
    }
    void CriarGrade()
    {
        grade = new Bloco[linhas, colunas];
        for (int linha = 0; linha < linhas; linha++)
        {
            for (int coluna = 0; coluna < colunas; coluna++)
            {
                Vector3 posicao = new Vector3(coluna * espacamento, 0, linha * espacamento);
                GameObject blocoObj = Instantiate(Resources.Load("Bloco"), posicao, Quaternion.identity) as GameObject;
                grade[linha, coluna] = blocoObj.GetComponent<Bloco>();
            }
        }
    }
    void PosicionarJogadores()
    {
        Vector3 posicaoJogador1 = new Vector3(0, 0, 0);
        Vector3 posicaoJogador2 = new Vector3((colunas - 1) * espacamento, 0, (linhas - 1) * espacamento);
        jogador1 = Instantiate(Resources.Load("Jogador"), posicaoJogador1, Quaternion.identity) as Jogador;
        jogador2 = Instantiate(Resources.Load("Jogador"), posicaoJogador2, Quaternion.identity) as Jogador;
        Camera.main.transform.position = new Vector3(colunas * espacamento / 2, 10, linhas * espacamento / 2);
        Camera.main.orthographicSize = Mathf.Max(linhas, colunas) * espacamento / 2;
    }
    public void ConquistarTerritorio(Bloco blocoConquistado, Jogador jogador)
    {
        if (!blocoConquistado.Conquistado)
        {
            blocoConquistado.Conquistado = true;
            contadorConquistados++;
            if (contadorConquistados == linhas * colunas)
            {
                FimDeJogo();
            }
        }
    }
    private void FimDeJogo()
    {
        int contadorJogador1 = 0;
        int contadorJogador2 = 0;
        foreach (Bloco bloco in grade)
        {
            if (bloco.Jogador == jogador1)
            {
                contadorJogador1++;
            }
            else if (bloco.Jogador == jogador2)
            {
                contadorJogador2++;
            }
        }
        string vencedor;
        if (contadorJogador1 > contadorJogador2)
        {
            vencedor = "Jogador 1 venceu!";
        }
        else if (contadorJogador2 > contadorJogador1)
        {
            vencedor = "Jogador 2 venceu!";
        }
        else
        {
            vencedor = "Empate!";
        }
        Debug.Log(vencedor);
    }
}
}
