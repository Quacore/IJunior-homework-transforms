using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 newScale = transform.localScale + new Vector3(1f, 1f, 1f) * _speed * Time.deltaTime;

        transform.localScale = newScale;
    }
}
