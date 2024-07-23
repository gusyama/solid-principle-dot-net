# Interface Segregation Principle

## Bad Design

In the example, the Manager is associated with the activities of creating, reviewing, and executing tasks similar to any leader.

The issue is that managers typically aren't responsible for performing tasks common to leaders. Their domain of operation is different.

Therefore, the manager ends up having to reject the task execution function.