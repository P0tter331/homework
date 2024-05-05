using OrderManagement;

var builder = WebApplication.CreateBuilder(args);

// 添加服务到容器。
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddControllers();

var app = builder.Build();

// 配置HTTP请求管道。
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  // 确保添加此行以启用控制器路由

app.Run();
