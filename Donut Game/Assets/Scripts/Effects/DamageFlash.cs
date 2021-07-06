using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerHealth))]
public class DamageFlash : MonoBehaviour
{
    [SerializeField] private MeshRenderer mesh;

    private PlayerHealth health;
    private Color originColor;

    private float flashTime;

    private void Awake() => AsignVariables();

    public void StartFlash() => StartCoroutine(Flash());

    private IEnumerator Flash()
    {
        Debug.Log("Flsah happening");
        health.canBeAttacked = false;

        for (int i = 0; i < 3; i++)
        {
            int counter = 0;
            mesh.material.color = Color.white;
            yield return new WaitForSecondsRealtime(flashTime);
            mesh.material.color = originColor;
            yield return new WaitForSecondsRealtime(flashTime);
            Debug.Log(counter);
            counter++;
        }

        Debug.Log("Flsah ended");
        health.canBeAttacked = true;
    }

    private void AsignVariables()
    {
        health = GetComponent<PlayerHealth>();

        originColor = mesh.material.color;        

        flashTime = health.immunityTime / 2;
    }
}
