using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day/New Day", fileName = "New Day")]
public class NewDay : ScriptableObject
{
    [Tooltip("���������� ����� ���")]
    [SerializeField] private int _dayNumber;
    public int DayNumber    
        => _dayNumber;

    [Tooltip("���� ����� � ������� ����")]
    [SerializeField] private AtackZone[] _atackZone;

    public AtackZone GetAtackZone(int index)
    {
        return _atackZone[index];
    }

}
