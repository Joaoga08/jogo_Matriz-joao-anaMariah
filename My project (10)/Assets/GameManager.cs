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
    public GameObject jogador1;
    public GameObject jogador2;
    [SerializeField] GameObject AreaPrefab;
    int linhas;
    int colunas;
    float espacamento;

    Bloco[,]blocos;

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
