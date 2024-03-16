using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    public float noteSpeed = 2f;

    [SerializeField] private float bottomBound = -10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * noteSpeed);

        if (transform.position.z < bottomBound)
        {
            ScoreCounter.Instance.ResetScore();
            Destroy(gameObject);
        }
    }
}
