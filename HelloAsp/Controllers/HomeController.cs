using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller 
        // controller 에서의 핵심 요소는 Action을 정의하는 것 
    {
        public string Index() // 한개의 Action을 정의
        {
            return "응답입니다."; 
        }
    }
}



// routing system  (사용자의 요청 경로를 처리하는 시스템) 에서 요청경로와 Action 을 매핑(연결) 하는 과정 필요
// Program.cs 에서 routing system 을 설정함