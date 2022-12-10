using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestSuite
{
    GameObject playerPrefab = Resources.Load<GameObject>("Player");
    // A Test behaves as an ordinary method
    [Test]
    public void TestPlayerDamage()
    {
        Vector3 playerPos = Vector3.zero;
        Quaternion playerDir = Quaternion.identity; // the default direction the player is facing is enough
        GameObject player = GameObject.Instantiate(playerPrefab, playerPos, playerDir);
        Assert.That(player.GetComponent<Player>().health, Is.EqualTo(100f));
        player.GetComponent<Player>().applyDamage(20f);
        Assert.That(player.GetComponent<Player>().health, Is.EqualTo(80f));
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestSuiteWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
