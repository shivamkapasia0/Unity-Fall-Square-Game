using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{
    public Vector2 speedMinMax;
    float speed ;

    private float visibleHeightThersold;
    // Start is called before the first frame update
    void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, DifficultyLevel.GetDifficultyPercent());
        visibleHeightThersold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down *speed * Time.deltaTime);
        if (transform.position.y < visibleHeightThersold)
        {
            Destroy(gameObject);
        }
    }
}