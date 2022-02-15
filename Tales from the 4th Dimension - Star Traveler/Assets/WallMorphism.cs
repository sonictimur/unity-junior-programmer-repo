using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class WallMorphism : MonoBehaviour
{
    public float wallSpeed;

    public GameObject endWall;
    public GameObject glassWall;

    public WallState wallState = WallState.Left;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MorphStart());
        StartCoroutine(MorphGlassWall());
    }

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(Vector3.back * Time.deltaTime * wallSpeed);
    }

    IEnumerator MorphStart()
    {
        yield return new WaitForSeconds(1f);

        transform.DOScaleY(30, 1f);
    }

    IEnumerator MorphGlassWall()
    {
        yield return new WaitForSeconds(2f);

        if (wallState == WallState.Right)
        {
            endWall.transform.DOMoveX(17.5f, 1f);
            glassWall.transform.DOMoveX(11.0f, 1f);

            glassWall.transform.DOScaleX(13.5f, 1f);

        } else if (wallState == WallState.Left)
        {
            endWall.transform.DOMoveX(-17.5f, 1f);
            glassWall.transform.DOMoveX(-5.5f, 1f);

            glassWall.transform.DOScaleX(-18f, 1f);

        } else if (wallState == WallState.MiddleCombo)
        {
            //endWall.transform.DOMoveX(-17.5f, 1f);
            //glassWall.transform.DOMoveX(-11.0f, 1f);

            //glassWall.transform.DOScaleX(-13.5f, 1f);
        }

    }
    
    public enum WallState
    {
        Left,
        Right,
        MiddleCombo
    }
}
