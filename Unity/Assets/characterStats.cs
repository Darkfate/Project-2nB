using System.Collections;
using GameCore.Actors.Interfaces;
using GameCore.Data;
using UnityEditor;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Status = new AutomatedStatCore(Class.startingStats, Class.growthRate);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Status.AddExp(100);

            Level = Status.Level;
            Strength = Status.Stats.Strength;
            Intelligence = Status.Stats.Intelligence;
            Speed = Status.Stats.Speed;
            Exp = Status.Exp;
            NextLevel = Status.NextLevel;
        }
    }

    public AutomatedStatCore Status = new AutomatedStatCore(new StatSet(), new StatGrowthRate());

    public int Level;
    public int Strength;
    public int Intelligence;
    public int Speed;
    public int Exp;
    public int NextLevel;
    public IClass Class = new Warrior();
}