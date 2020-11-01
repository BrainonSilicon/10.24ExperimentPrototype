using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class ExperimentGenerator : MonoBehaviour
{
    public void Generate(Session session)
    {
        int numTrials = 10;
        session.CreateBlock(numTrials);
    }
  
}
