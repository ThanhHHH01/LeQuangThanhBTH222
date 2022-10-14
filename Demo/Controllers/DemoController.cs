using Miccrosoft.AspNetCore.MVC;
namespace LeQuangThanhBTH.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return view;
        }
    ///nhan duoc du lieu tu view gui len
    [HttpPost]
    public IActionResult Index(string heSoA, string heSoB)
    {
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        string thongBao = gpt.GiaiPhuongTrinhBacNhat(a,b);

        ViewBag.mess = thongBao;
        return View();
    }


    
    }
}