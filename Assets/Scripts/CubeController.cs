using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    
    
    //�L���[�u�̈ړ����x
    private float speed = -12f;
    //���ňʒu
    private float deadLine = -10f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        bool destroyBlock = transform.position.x < this.deadLine;
        if (destroyBlock) Destroy(this.gameObject);

        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        bool blockSound = collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Block");
        if (blockSound) {
            GetComponent<AudioSource>().Play();
        }
    }
}
