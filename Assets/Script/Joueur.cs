using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float Xaxis = 0;
    public float Yaxis = 0;
    public Vector3 motiondirection = Vector2.zero;
    public Vector3 motionVector = Vector2.zero;
    public float speed = 10;



    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //DEFINITION DE L'AXE Z(forward)
        if (Input.GetKey(KeyCode.UpArrow)) { Yaxis = 1f; }
        else if (Input.GetKey(KeyCode.DownArrow)) { Yaxis = -1f; }
        else { Yaxis = 0f; }

        //DEFINITION DE L'AXE (lateral)
        if (Input.GetKey(KeyCode.LeftArrow)) { Xaxis = -1f; }
        else if (Input.GetKey(KeyCode.RightArrow)) { Xaxis = 1f; }
        else { Xaxis = 0f; }




        //CONSTRUCTION DU VECTEUR DE DIRECTION
        motiondirection = new Vector3(Xaxis, Yaxis);

        //CONSTRUCTION DU VECTOR DE MOUVEMENT
        motionVector = motiondirection * speed * Time.deltaTime;


        controller.Move(motionVector);
    }
}
