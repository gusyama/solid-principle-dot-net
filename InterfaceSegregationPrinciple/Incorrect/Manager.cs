using System;

namespace InterfaceSegregationPrinciple.Incorrect
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            // .. create task
        }

        public void ReviewTask()
        {
            // ... review task
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException("Manager can't work on Task");
        }
    }
}
