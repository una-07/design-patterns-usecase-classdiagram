namespace LibrarySystem.Models
{
    public class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;

        public void ChangeAvailability(bool status)
        {
            IsAvailable = status;
        }
    }
}
