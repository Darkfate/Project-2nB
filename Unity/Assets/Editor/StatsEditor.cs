using System.Collections;
using GameCore.Actors.Interfaces;
using GameCore.Data;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(characterStats))]
public class StatsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        characterStats statCore = target as characterStats;

        #region StrGrowth

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Str Growth");

        statCore.Status.StatGrowthRate.StrGrowthRate =
            EditorGUILayout.IntField(statCore.Status.StatGrowthRate.StrGrowthRate);

        EditorGUILayout.EndHorizontal();

        #endregion StrGrowth

        #region IntGrowth

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Int Growth");

        statCore.Status.StatGrowthRate.IntGrowthRate =
            EditorGUILayout.IntField(statCore.Status.StatGrowthRate.IntGrowthRate);

        EditorGUILayout.EndHorizontal();

        #endregion IntGrowth

        #region SpdGrowth

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Spd Growth");

        statCore.Status.StatGrowthRate.SpdGrowthRate =
            EditorGUILayout.IntField(statCore.Status.StatGrowthRate.SpdGrowthRate);

        EditorGUILayout.EndHorizontal();

        #endregion SpdGrowth
    }

    public IClass[] ListOfClass = ClassList.All;
}