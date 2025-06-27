using System.Net.Http;
using System.Net.Http.Json;
using Fuelled.ClientTracker.Models;

namespace Fuelled.ClientTracker.Services;

public class ClientService
{
    private readonly HttpClient _httpClient;

    public ClientService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Client>> GetClientsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Client>>("api/clients") ?? new List<Client>();
    }

    public async Task AddClientAsync(Client client)
    {
        await _httpClient.PostAsJsonAsync("api/clients", client);
    }

    //Fetches client data based on id
    public async Task<Client?> GetClientByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Client>($"api/clients/{id}");
    }

    //Updated specific client data
    public async Task UpdateClientAsync(Client client)
    {
        await _httpClient.PutAsJsonAsync($"api/clients/{client.Id}", client);
    }

    // Deletes a client by id
    public async Task DeleteClientAsync(int clientId)
    {
        await _httpClient.DeleteAsync($"api/clients/{clientId}");
    }
}