using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClick : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    public GameObject ramp;

    private Renderer renderer;

    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    private Color newColor;

    private void OnMouseDown()
    {
        GameObject b = Instantiate(ball) as GameObject;
        b.SetActive(true);
        b.transform.position = ramp.transform.position + new Vector3(Random.Range(-5, 5), Random.Range(10, 15), Random.Range(-5, 5));

        renderer = b.GetComponent<Renderer>();
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);

        renderer.material.SetColor("_Color", newColor);
    }
}
