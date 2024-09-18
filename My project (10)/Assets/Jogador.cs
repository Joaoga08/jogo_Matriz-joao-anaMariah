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

    }


}

