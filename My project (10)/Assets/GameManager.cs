using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
        grade = grade[linhas, colunas];


    }
    public void ChecarGrade()

    {

        int posicao = 0;
        for (int i = 0; i < grade.Length; i++)
        {
            for(int j = 0; j <grade.Length; j++ )
            {
                posicao = colunas = linhas;
            }
        }

        Instantiate(blocoPrefab, new Vector3(posicao, posicao), Quaternion.identity);

        grade[1,1] = posicao;
      blocoPrefab  = Instantiate(AreaPrefab, new Vector3(posicao, posicao), Quaternion.identity);


    }
    #endregion
    public GameObject jogador1;
    public GameObject jogador2;
    [SerializeField] GameObject AreaPrefab;
    int linhas;
    int colunas;
    float espacamento;

   public GameObject blocoPrefab;
    GameObject bloco;

    Bloco[,] grade;

   
    int contador;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
