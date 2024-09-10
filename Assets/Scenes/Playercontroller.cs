using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f; // Velocidad del movimiento
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtiene el componente Rigidbody del jugador
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Obtiene la entrada horizontal del teclado
        float vertical = Input.GetAxis("Vertical"); // Obtiene la entrada vertical del teclado

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical); // Crea un vector de movimiento
        rb.AddForce(movement * moveSpeed); // Aplica una fuerza al Rigidbody para mover el jugador
    }
}
