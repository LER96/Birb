using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public LineRenderer[] lineRenderer;
    public Transform[] stripPosition;
    public Transform center;
    public Transform idlePosition;
    public GameObject birdPrefabs;

    public int count;
    Rigidbody2D bird;
    Collider2D birdCollider;

    public Vector3 currentPosition;
 
    bool isMouseDown;
    public float maxLength;
    public float bottomBoundry;
    public float birdOffset;
    public float force;

    private void Start()
    {
        count = 3;
        lineRenderer[0].positionCount = 2;
        lineRenderer[1].positionCount = 2;
        lineRenderer[0].SetPosition(0, stripPosition[0].position);
        lineRenderer[1].SetPosition(0, stripPosition[1].position);

        CreateBirds();
    }

    private void Update()
    {
        if (isMouseDown)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = center.position + Vector3.ClampMagnitude(currentPosition - center.position, maxLength);
            currentPosition = ClampBoundry(currentPosition);
            SetStrips(currentPosition);

            if (birdCollider)
            {
                birdCollider.enabled = true;
            }
        }
        else
        {
            ResetStrips();
        }
    }

    void CreateBirds()
    {
        bird = Instantiate(birdPrefabs).GetComponent<Rigidbody2D>();
        birdCollider = bird.GetComponent<Collider2D>();
        birdCollider.enabled = false;

        bird.isKinematic = true;

        ResetStrips();
    }

    void ResetStrips()
    {
        currentPosition = idlePosition.position;
        SetStrips(currentPosition);
    }

    void SetStrips(Vector3 position)
    {
        lineRenderer[0].SetPosition(1, position);
        lineRenderer[1].SetPosition(1, position);
        if (bird)
        {
            Vector3 direction = position - center.position;
            bird.transform.position = position + direction.normalized * birdOffset;
            bird.transform.right = -direction.normalized;
        }
    }

    void Shoot()
    {
        bird.isKinematic = false;

        Vector3 birdForce = (currentPosition - center.position) * force * -1;
        bird.velocity = birdForce;

        bird = null;
        birdCollider = null;
        Invoke("CreateBirds", 2);
        count--;
    }

    private void OnMouseDown()
    {
        isMouseDown = true;
    }

    private void OnMouseUp()
    {
        isMouseDown = false;
        Shoot();
    }

    Vector3 ClampBoundry(Vector3 vector)
    {
        vector.y = Mathf.Clamp(vector.y, bottomBoundry, 1000);
        return vector;
    }
}
