using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : BallBase
{
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        //Accedemos a la posicion del mouse
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        //Calculamos dirección
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direccion calculada
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
