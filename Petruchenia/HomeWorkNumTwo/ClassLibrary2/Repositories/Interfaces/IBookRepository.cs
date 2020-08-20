namespace ClassLibrary2.Repositories
{
    public interface IBookRepository : IBaseRepository
    {
        BookData Show5MostPopular();
        BookData ShowAllBooks();
        BookData ShowAllOrders();
        BookData ShowAllOrdersFromToday();
    }
}