using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnItemZombie : MonoBehaviour
{
    //TODO : 소환할 프리팹과 좌표를 먼저 받는다.
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private List<SpawnMonster> monsterPrefabs;
    [SerializeField] private List<SpawnItem> monsterItems;
    [SerializeField] private Transform zombieSpawner;
    private Random.State originalState;
    [SerializeField] private int seed;


    //TODO : 랜덤맵 / QA
    //TODO : List에서 랜덤한 위치로 몬스터를 스폰한다.
    private void Awake()
    {
        originalState = Random.state;
        
        Random.InitState(seed);
        //TODO : 소환할 프리팹들의 수를 입력한다.
        for (int k = 0; k < monsterPrefabs.Count - 1; k++)
        {
            for (int i = 0; i < monsterPrefabs[k].count; i++)
            {
                int spawnPoint = Random.Range(0, spawnPoints.Count);
                var monster = Instantiate(monsterPrefabs[k].monsterPrefab, spawnPoints[spawnPoint].position, Quaternion.identity);
                float randomY = Random.Range(0f, 360f);
                monster.transform.rotation = Quaternion.Euler(0, randomY, 0);

                monster.gameObject.SetActive(true);
                spawnPoints.RemoveAt(spawnPoint);
            }
        }
         //TODO : 소환할 프리팹들 중 아이템을 가진 프리팹의 수를 입력한다.
        for(int i=0; i< monsterItems.Count; i++)
        {
            for (int j = 0; j < monsterItems[i].count; j++)
            {
                int spawnPoint = Random.Range(0, spawnPoints.Count);
                var monster = Instantiate(monsterPrefabs[monsterPrefabs.Count-1].monsterPrefab, spawnPoints[spawnPoint].position, Quaternion.identity, zombieSpawner);
                var item = monsterItems[i].itemdata;
                monster.GetComponent<ZombieObject>().ItemData = item;
                float randomY = Random.Range(0f, 360f);
                monster.transform.rotation = Quaternion.Euler(0, randomY, 0);

                monster.gameObject.SetActive(true);
                spawnPoints.RemoveAt(spawnPoint);
            }
        }
        
        Random.state = originalState;
    }
    //TODO : 같은 위치에는 소환할 수 없으므로, 이미 소환된 자표는 배제한다.

}

[System.Serializable]
public class SpawnMonster
{
    public GameObject monsterPrefab;
    public int count;
}

[System.Serializable]
public class SpawnItem
{
    public ItemData itemdata;
    public int count;
}
