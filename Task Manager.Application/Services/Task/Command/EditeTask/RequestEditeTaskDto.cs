namespace Task_Manager.Application.Services.Task.Command.EditeTask
{
    public class RequestEditeTaskDto
    {
        public long id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}