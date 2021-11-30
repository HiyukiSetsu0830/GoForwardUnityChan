using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //�X�N���[�����x
    private float scrollSpeed = -1;
    //�w�i�I���ʒu
    private float deadLine = -16;
    //�w�i�J�n�ʒu
    private float startLine = 15.8f;

    // Update is called once per frame
    void Update()
    {
        //�w�i���ړ�����
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����A��ʉE�[�Ɉړ�����
        bool backgroundRightMove = transform.position.x < this.deadLine;
        if (backgroundRightMove) transform.position = new Vector2(this.startLine, 0);
    }
}
