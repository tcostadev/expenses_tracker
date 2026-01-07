namespace backend.Models;

public enum ExpenseCategory
{
    Food,
    Supermarket,
    CarFuel,
    Health,
    Technology,
    House,
    Tools
}

public class Expense
{
    public int Id { get; set; }
    public ExpenseCategory Category { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
}