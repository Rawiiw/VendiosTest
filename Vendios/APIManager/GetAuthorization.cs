using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vendios.APIManager
{
    internal class GetAuthorization
    {
        private const string AuthorizationUrl = "https://ferma-test.ofd.ru/api/Authorization/CreateAuthToken";

        //выполнение авторизации асинхронно
        public async Task<string> PerformAuthorizationAsync(string login, string password)
        {
            //создание нового экземпляра для выполнения запросов
            var client = new HttpClient();

            //создание содержимого запроса
            var content = new StringContent($"{{ \"Login\": \"{login}\", \"Password\": \"{password}\" }}", Encoding.UTF8, "application/json");

            try
            {
                //отправка пост-запроса на сервер авторизации
                var response = await client.PostAsync(AuthorizationUrl, content);

                //убеждаемся что ответ успешный (статус код 200)
                response.EnsureSuccessStatusCode();

                //чтение ответа от сервера
                string result = await response.Content.ReadAsStringAsync();

                //вывод результата в консоль
                Console.WriteLine($"Результат: {result}");

                //возвращаем результат авторизации
                return result;
            }
            catch (Exception ex)
            {
                //выводим сообщение об ошибке в консоль
                Console.WriteLine($"Ошибка: {ex.Message}");

                //возбуждение исключения
                throw;
            }
        }
    }
}
