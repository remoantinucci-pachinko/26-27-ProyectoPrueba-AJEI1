using UnityEngine; //Libreria general de unity
using UnityEngine.InputSystem; //Libreria para recoger inputs del usario

public class Mover2D : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0);

        //wKey
        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }

        //aKey
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        //sKey
        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }

        //dKey
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }

        transform.position = transform.position + direction * speed * Time.deltaTime;

        //transform.position -> Acceder a la posicion del objeto

        //1st step: read user input
        //2nd step: generate a direction
        //3rd step: apply the movement
    }
}
