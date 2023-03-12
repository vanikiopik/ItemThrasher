using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public int numItems = 10;

    public void Awake()
    {
        // Получаем границы BoxCollider2D
        Vector2 colliderSize = GetComponent<BoxCollider2D>().size;
        Vector2 colliderPosition = GetComponent<BoxCollider2D>().transform.position;
        Vector2 minPosition = colliderPosition - colliderSize / 2;
        Vector2 maxPosition = colliderPosition + colliderSize / 2;

        // Создаем предметы в случайных местах
        for (int i = 0; i < numItems; i++)
        {
            // Выбираем случайный префаб из массива
            GameObject itemPrefab = itemPrefabs[Random.Range(0, itemPrefabs.Length)];

            // Создаем предмет в случайном месте
            Vector2 spawnPosition = new Vector2(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y)
            );
            Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
