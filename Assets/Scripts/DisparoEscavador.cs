using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEscavador : MonoBehaviour {

    public float velocidade = 10f;
    public Rigidbody2D meuRB;

    // Start is called before the first frame update
    void Start() {
        meuRB.velocity = Vector2.down * velocidade;
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // collision.GetComponent<TileBlock>().Destruindo();
        if(collision.CompareTag("Estrutura")) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
