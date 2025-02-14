using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;      // Move a raquete para cima
    public KeyCode moveDown = KeyCode.S;    // Move a raquete para baixo
    public float speed = 10.0f;             // Define a velocidade da bola
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        if (mousePos.y > 0) 
        {                  
            mousePos.y = 0;                     // Corrige a posicao da raquete caso ele ultrapasse o limite superior
        }
        else if (mousePos.y < -5) 
        {
            mousePos.y = -5;                    // Corrige a posicao da raquete caso ele ultrapasse o limite superior
        }

        if (mousePos.x > 4.5f) 
        {
            mousePos.x = 4.5f;
        } 
        else if (mousePos.x < -4.5f) 
        {
            mousePos.x = -4.5f;
        }
        pos.x = mousePos.x;
        pos.y = mousePos.y;
        transform.position = pos;
    }
}
