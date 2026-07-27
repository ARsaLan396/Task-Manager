namespace Task_Manager.Application.Services.Task.Command.AddNewTask
{
    public class RequestAddnewTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}