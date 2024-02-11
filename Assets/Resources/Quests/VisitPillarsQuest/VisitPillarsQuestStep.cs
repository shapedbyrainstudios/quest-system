using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class VisitPillarsQuestStep : QuestStep
{
    [Header("Config")]
    [SerializeField] private string pillarNumberString = "first";

    private void Start()
    {
        string status = "Visit the " + pillarNumberString + " pillar.";
        ChangeState("", status);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            string status = "The " + pillarNumberString + " pillar has been visited.";
            ChangeState("", status);
            FinishQuestStep();
        }
    }

    protected override void SetQuestStepState(string state)
    {
        // no state is needed for this quest step
    }
}
