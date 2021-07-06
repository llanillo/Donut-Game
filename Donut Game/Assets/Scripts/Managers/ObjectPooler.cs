using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour, IGameManager
{            
    [System.Serializable]
    public class Pool
    {
        public PoolTag tag;
        public GameObject objectToPool;
        public int size;
    }

    [SerializeField] private List<Pool> pools;
    private Dictionary<PoolTag, Queue<GameObject>> poolDictionary;

    public ManagerStatus status { get; }

    public void Startup()
    {
        Debug.Log("Object pooler starting...");

        CreatePools();
    }

    private void CreatePools()
    {
        poolDictionary = new Dictionary<PoolTag, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.objectToPool);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    } 

    public GameObject GetPooledObject(PoolTag tag)
    {        
        GameObject objToSpawn = poolDictionary[tag].Dequeue();
    
        objToSpawn.SetActive(false);

        poolDictionary[tag].Enqueue(objToSpawn);

        return objToSpawn;
    }
}
