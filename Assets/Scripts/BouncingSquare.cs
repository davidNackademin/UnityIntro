using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class BouncingSquare : MonoBehaviour {

    [Range(0f, 1f)]
    public float speed = 0.1f;
    public List<Color> colors = new List<Color>();

    private float direction = 1;

    SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        //Debug.Log("Vector3: " + Vector3.zero);
        //transform.position = Vector3.zero;
        spriteRenderer = GetComponent<SpriteRenderer>();


        spriteRenderer.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.x += speed * direction;
        transform.position = position;


        if (position.x > 8.0f || position.x < -8.0f) {
            ChangeDirection();
        }

	}

    void OnMouseDown()
    {
        ChangeColor();
    }


    void ChangeDirection() {
        direction *= -1;
    }

    void ChangeColor() {
        if (spriteRenderer == null)
            return;

        Color lastColor = spriteRenderer.color;

        Color color;
        do
        {
            color = colors[Random.Range(0, colors.Count)];
        } while (lastColor == color);

        spriteRenderer.color = color;
    }
}
