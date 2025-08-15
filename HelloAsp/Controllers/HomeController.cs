using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller 
        // controller 에서의 핵심 요소는 Action을 정의하는 것 
    {
        // 한개의 Action을 정의
        public string Index() // 
        {
            string? userId = Request.Query["userId"]; // Query string에서 userId 값을 가져옴
            string? age = Request.Query["age"]; 

            return "응답입니다." + userId + age; 
        }
    }
}







// routing system  (사용자의 요청 경로를 처리하는 시스템) 에서 요청경로와 Action 을 매핑(연결) 하는 과정 필요
// Program.cs 에서 routing system 을 설정함








// query string 
// www/ABC.com/Home/Index?id=1234&password=aaa
// ? 기호 이후에 오는 문자열을 Query string 이라고 함
//  객체, 배열 모두 전달 가능하다.