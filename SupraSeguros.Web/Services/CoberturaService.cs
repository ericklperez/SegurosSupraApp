using SupraSeguros.Web.Models.Api;
using SupraSeguros.Web.Services;
using SupraSeguros.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class CoberturaService : IServiceAsync<Cobertura>
{
    private readonly HttpClient _client;

    public CoberturaService(HttpClient client)
    {
        _client = client;
    }

    public async Task<Cobertura> GetByIdAsync(Guid id)
    {
        var response = await _client.GetAsync($"policy/api/coberturas/{id}");
        return await response.ReadContentAs<Cobertura>();
    }

    public async Task<IReadOnlyList<Cobertura>> ListAllAsync()
    {
        var response = await _client.GetAsync("policy/api/coberturas/list");
        return await response.ReadContentAs<IReadOnlyList<Cobertura>>();
    }

    public async Task<Cobertura> AddAsync(Cobertura entity)
    {
        var response = await _client.PostAsJson("policy/api/coberturas", entity);
        return await response.ReadContentAs<Cobertura>();
    }

    public async Task UpdateAsync(Cobertura entity)
    {
        await _client.PutAsJson($"policy/api/coberturas/{entity.CoberturaId}", entity);
    }

    public async Task DeleteAsync(Cobertura entity)
    {
        await _client.DeleteAsync($"policy/api/coberturas/{entity.CoberturaId}");
    }

    public async Task<IReadOnlyList<Cobertura>> GetPagedReponseAsync(int page, int size)
    {
        var response = await _client.GetAsync($"policy/api/coberturas/paged?page={page}&size={size}");
        return await response.ReadContentAs<IReadOnlyList<Cobertura>>();
    }
}
