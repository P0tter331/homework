using OrderManagement;

var builder = WebApplication.CreateBuilder(args);

// ��ӷ���������
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddControllers();

var app = builder.Build();

// ����HTTP����ܵ���
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  // ȷ����Ӵ��������ÿ�����·��

app.Run();
