using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    private bool conquistado;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono;

    public bool Conquistado { get; internal set; }
    public Jogador Jogador { get; internal set; }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InicializarBloco(Color.white);
    }

    private void InicializarBloco(Color cor)
    {
        spriteRenderer.color = cor;
        conquistado = false;
        jogadorDono = 0;
    }

    private void AtualizarCor(Color novaCor)
    {
        spriteRenderer.color = novaCor;
    }


    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        AtualizarCor(corDoJogador);

        jogadorDono = jogador1 ? 1 : 2;
        GameManager.Instance.ConquistarTerritorio(this);
    }
    public bool PegarConquistado()
    {
        return conquistado;
    }

    public int PegarJogadorDono()
    {
        return jogadorDono;
    }
}