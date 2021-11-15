using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{

    public float[] currentPosition; 

    public GameObject Player;
    public Animator PlayerAnimation;

    public GameObject[] A;
    public GameObject[] B;
    public GameObject[] C;

    


    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position = B[1].transform.position;
        currentPosition = new float[]{1,1};

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical")) {
            if(Input.GetAxis("Vertical") > 0)
            {
                MovePlayer("Up");
            }
            else
            {
                MovePlayer("Down");
            }
        }else if (Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                MovePlayer("Right");
            }
            else
            {
                MovePlayer("Left");
            }
        }

    }



    void MovePlayer(string direction)
    {
        switch (direction)
        {
            case "Up":
                if(currentPosition[0] > 0)
                {
                    currentPosition[0] = currentPosition[0]-1;
                    MoveSprite();
                }
                break;

            case "Down":
                if (currentPosition[0] < 2)
                {
                    currentPosition[0] = currentPosition[0] + 1;
                    MoveSprite();
                }
                break;

            case "Left":
                if (currentPosition[1] > 0)
                {
                    currentPosition[1] = currentPosition[1] - 1;
                    MoveSprite();
                }
                break;

            case "Right":
                if (currentPosition[1] < 2)
                {
                    currentPosition[1] = currentPosition[1] + 1;
                    MoveSprite();
                }
                break;


        }
        
    }



    void MoveSprite()
    {
        PlayerAnimation.Play("Move", 0, 0.25f);
        int positionX = (int) currentPosition[1];
        if(currentPosition[0] == 0)
        {
            Player.transform.position = A[positionX].transform.position;
        }
        else if (currentPosition[0] == 1)
        {
            Player.transform.position = B[positionX].transform.position;
        }
        else if (currentPosition[0] == 2)
        {
            Player.transform.position = C[positionX].transform.position;
        }

    }
}
