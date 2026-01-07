using System.Net.Http.Json;
using frontend.Models;

namespace frontend.Services;

public class ExpenseService
{
    private readonly HttpClient _http;

    public ExpenseService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Expense>> GetExpensesAsync()
    {
        return await _http.GetFromJsonAsync<List<Expense>>("api/expenses") ?? new List<Expense>();
    }

    public async Task<Expense?> GetExpenseAsync(int id)
    {
        return await _http.GetFromJsonAsync<Expense>($"api/expenses/{id}");
    }

    public async Task CreateExpenseAsync(Expense expense)
    {
        await _http.PostAsJsonAsync("api/expenses", expense);
    }

    public async Task UpdateExpenseAsync(int id, Expense expense)
    {
        await _http.PutAsJsonAsync($"api/expenses/{id}", expense);
    }

    public async Task DeleteExpenseAsync(int id)
    {
        await _http.DeleteAsync($"api/expenses/{id}");
    }
}