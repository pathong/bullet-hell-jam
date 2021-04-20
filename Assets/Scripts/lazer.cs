using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineREnderer;
    Transform m_transform;
    // Start is called before the first frame update
    private void Awake()
    {
        m_transform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
    }
    void ShootLaser()
    {
        if(Physics2D.Raycast(m_transform.position, transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(laserFirePoint.position, transform.right);
            Draw2Dray(laserFirePoint.position, _hit.point);
        }
    }
    void Draw2Dray(Vector2 startPos, Vector2 endPos)
    {
        m_lineREnderer.SetPosition(0, startPos);
        m_lineREnderer.SetPosition(1, endPos);
    }
    // Update is called once per frame
}
