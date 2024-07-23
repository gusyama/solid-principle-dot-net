namespace InterfaceSegregationPrinciple.Incorrect
{
    public class Leader : ILead
    {
        public void CreateTask()
        {
            // ... create task
        }

        public void ReviewTask()
        {
            // ... review task
        }

        public void WorkOnTask()
        {
            // .. work on task
        }
    }
}
