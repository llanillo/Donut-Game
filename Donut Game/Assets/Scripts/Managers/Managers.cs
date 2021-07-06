using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public PlayerManager PlayerManager { get; private set; }
    public ObjectPooler ObjectPools { get; private set; }
    public CanvasManager CanvasManager { get; private set; }

    private List<IGameManager> startSequence;

    private void Awake()
    {
        PlayerManager = GetComponent<PlayerManager>();
        ObjectPools = GetComponent<ObjectPooler>();
        CanvasManager = GetComponent<CanvasManager>();

        startSequence = new List<IGameManager>();

        startSequence.Add(PlayerManager);
        startSequence.Add(ObjectPools);
        startSequence.Add(CanvasManager);

        StartCoroutine(StartupManagers());
    }

    private IEnumerator StartupManagers()
    {
        foreach (IGameManager manager in startSequence)
        {
            manager.Startup();
        }

        yield return null;

        int numModules = startSequence.Count;
        int numReady = 0;

        while (numReady < numModules)
        {
            int lastReady = numReady;
            numReady = 0;

            foreach(IGameManager manager in startSequence)
            {
                if (manager.status == ManagerStatus.Started)
                    numReady++;
            }

            if (numReady > lastReady)
                Debug.Log("Progress: " + numReady + "/" + numModules);

            yield return null;
        }

        Debug.Log("All managers started up");
    }
}
