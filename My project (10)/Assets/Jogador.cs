using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Jogador : MonoBehaviour

{

    private const float velocidade = 5f;

    [SerializeField] private bool jogador1;

    [SerializeField] private Color corDoJogador;

    private Vector2 direcao;

    private void Update()

    {

        if (jogador1)

        {

            if (Input.GetKeyUp(KeyCode.A))

            {

                direcao.x = -1;

            }

            else if (Input.GetKeyUp(KeyCode.D))

            {

                direcao.x = 1;

            }

            if (Input.GetKeyUp(KeyCode.W))

            {

                direcao.y = 1;

            }

            else if (Input.GetKeyUp(KeyCode.S))

            {

                direcao.y = -1;

            }

        }

        else

        {

            if (Input.GetKeyUp(KeyCode.LeftArrow))

            {

                direcao.x = -1;

            }

            else if (Input.GetKeyUp(KeyCode.RightArrow))

            {

                direcao.x = 1;

            }

            if (Input.GetKeyUp(KeyCode.UpArrow))

            {

                direcao.y = 1;

            }

            else if (Input.GetKeyUp(KeyCode.DownArrow))

            {

                direcao.y = -1;

            }

        }

        transform.Translate(direcao * velocidade * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))

        {

            direcao.x = 0;

        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))

        {

            direcao.y = 0;

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))

        {

            direcao.x = 0;

        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))

        {

            direcao.y = 0;

        }

    }

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Block"))

        {

            Bloco bloco = other.GetComponent<Bloco>();

            if (bloco != null && !bloco.PegarConquistado())

            {

                bloco.AlterarConquista(jogador1, corDoJogador);

            }

        }

    }

}

