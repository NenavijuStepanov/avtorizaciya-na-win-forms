using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.Http.Json;
using projectX.Models;

namespace projectX
{
    public static class DB
    {

        private static readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7045/") 
        };

        async static public Task<bool> login(string username, string password)
        {
            var newUser = new LoginDto
            {
                Username = username,
                Password = password
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/login", newUser);

                return response.IsSuccessStatusCode; 
            }
            catch
            {
                return false;
            }


        }
        async static public Task<bool> registration(string username, string password)
        {
            var checkUser = new LoginDto
            {
                Username = username,
                Password = password
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/registration", checkUser);

                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }



        }









    }
}

