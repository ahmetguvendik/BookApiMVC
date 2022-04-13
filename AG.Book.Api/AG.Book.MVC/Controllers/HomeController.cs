using AG.Book.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AG.Book.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public HomeController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5001/api/book");
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Başarılı olduğu durumlar için;
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //json okumak için. Json formatta gelir
                var result = JsonConvert.DeserializeObject<List<BookResponseModel>>(jsonData); //json datayı çevirmek için.
                return View(result);
            }
            return View(new BookResponseModel());
        }

        public IActionResult Create()
        {
            return View(new CreateBookModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookModel model)
        {
            var client = _clientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(model); //json formata çevirmek için
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var message = await client.PostAsync("http://localhost:5001/api/book", content);
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public async Task<IActionResult> Remove(int id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5001/api/book/{id}");
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            return Json("");

        }

        public async Task<IActionResult> Update(int id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5001/api/book/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UpdateBookModel>(jsonData);
                return View(data);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBookModel model)
        {
            var client = _clientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(model); //json formata çevirmek için
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:5001/api/book/{model.Id}", content);
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
