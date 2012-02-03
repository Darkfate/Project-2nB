using System.Collections;
using GameCore.Actors.Interfaces;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Stats = new AutomatedStatCore(new StatSet(), new StatGrowthRate());
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stats.AddExp(100);

            Level = Stats.Level;
            Strength = Stats.Stats.Strength;
            Intelligence = Stats.Stats.Intelligence;
            Speed = Stats.Stats.Speed;
            Exp = Stats.Exp;
            NextLevel = Stats.NextLevel;
        }
    }

    private AutomatedStatCore Stats { get; set; }

    public int Level;
    public int Strength;
    public int Intelligence;
    public int Speed;
    public int Exp;
    public int NextLevel;
}