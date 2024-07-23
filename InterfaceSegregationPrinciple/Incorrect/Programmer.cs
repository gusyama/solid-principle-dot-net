using System;

namespace InterfaceSegregationPrinciple.Incorrect
{
    public class Programmer : ILead
    {
        public void CreateTask()
        {
            throw new NotImplementedException("Programmer can't create Task");
        }

        public void ReviewTask()
        {
            throw new NotImplementedException("Programmer can't review Task");
        }

        public void WorkOnTask()
        {
            // .. work on task
        }
    }
}