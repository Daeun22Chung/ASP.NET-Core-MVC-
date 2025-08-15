// 사용자의 사이트에 요청하는 url(요청경로)와 controller이 매핑되도록 설정해줌

var builder = WebApplication.CreateBuilder(args); // 기본 윕 애플리케이션 생성은 WebApplicationBuilder 클래스를 사용하여 생성함  

builder.Services.AddControllers(); // 컨트롤러를 사용하기 위해 서비스에 추가함. 

var app = builder.Build(); // 요청처리, 경로설정, 서비스 추가 등에 사용

//app.MapGet("/", () => "Hello World!");
//app.MapControllers(); // 컨트롤러를 사용하기 위해 경로 설정함.
app.MapControllerRoute( //MapControllerRoute 메서드는 사용자의 요청을 받는 새로운 endpoint 
    name: "default", 
    pattern: "{controller=Home}/{action=Index}/{id?}" 
    );

app.Run(); //시작






