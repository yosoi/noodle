namespace Noodle
{
  using UnityEngine;

  public class PoolTester : MonoBehaviour
  {
    public Pool Pool;

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        Pool.RetrieveObject(transform);
      }
    }
  }
}
