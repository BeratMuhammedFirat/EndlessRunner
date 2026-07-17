    using System.Collections.Generic;
    using UnityEngine;

    public class CityTile : MonoBehaviour
    {
        [Header("Obstacle Settings")]
        public Transform[] spawnPoints;
        public GameObject[] obstaclePrefabs;
        public int obstacleCount = 7;

        [Header("Coin Settings")]
        public Transform[] coinSpawnPoints;
        public GameObject coinPrefab;
        public int coinCount = 10;

        private List<GameObject> spawnedObstacles = new List<GameObject>();
        private List<GameObject> spawnedCoins = new List<GameObject>();

        private void Start()
        {
            SpawnObstacles();
            SpawnCoins();
        }

        // ---------------- ENGELLER ----------------

        public void SpawnObstacles()
        {
            ClearObstacles();

            List<int> usedPoints = new List<int>();

            while (usedPoints.Count < obstacleCount)
            {
                int randomPoint = Random.Range(0, spawnPoints.Length);

                if (!usedPoints.Contains(randomPoint))
                {
                    usedPoints.Add(randomPoint);

                    int randomObstacle = Random.Range(0, obstaclePrefabs.Length);

                    Vector3 position = spawnPoints[randomPoint].position;
                    Quaternion rotation = Quaternion.Euler(0, 90, 0);

                    if (randomObstacle == 1)
                    {
                        rotation = Quaternion.Euler(180, 90, 0);
                        position.y += 2.4f;
                    }

                    GameObject obstacle = Instantiate(
                        obstaclePrefabs[randomObstacle],
                        position,
                        rotation,
                        transform
                    );

                    spawnedObstacles.Add(obstacle);
                }
            }
        }

        public void ClearObstacles()
        {
            foreach (GameObject obstacle in spawnedObstacles)
            {
                Destroy(obstacle);
            }

            spawnedObstacles.Clear();
        }

        // ---------------- COINLER ----------------

        public void SpawnCoins()
        {
            ClearCoins();

            List<int> usedPoints = new List<int>();

            while (usedPoints.Count < coinCount)
            {
                int randomPoint = Random.Range(0, coinSpawnPoints.Length);

                if (!usedPoints.Contains(randomPoint))
                {
                    usedPoints.Add(randomPoint);

                    Vector3 position = coinSpawnPoints[randomPoint].position;
                    position.y += 1f;

                    GameObject coin = Instantiate(
                        coinPrefab,
                        position,
                        Quaternion.identity,
                        transform
                    );

                    spawnedCoins.Add(coin);
                }
            }
        }

        public void ClearCoins()
        {
            foreach (GameObject coin in spawnedCoins)
            {
                Destroy(coin);
            }

            spawnedCoins.Clear();
        }
    }