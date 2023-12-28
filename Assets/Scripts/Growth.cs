using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 newScale = transform.localScale + Vector3.one * _speed * Time.deltaTime;

        transform.localScale = newScale;
    }
}
