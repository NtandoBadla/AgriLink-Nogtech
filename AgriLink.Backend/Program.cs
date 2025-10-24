// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.EntityFrameworkCore;
// using System.Text;
// using AgriLink.Backend.Data;
// using AgriLink.Backend.Hubs;

// var builder = WebApplication.CreateBuilder(args);

// // Database
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// // Controllers
// builder.Services.AddControllers();

// // JWT Auth
// var jwtKey = builder.Configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT Key not configured");
// var key = Encoding.UTF8.GetBytes(jwtKey);

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateIssuerSigningKey = true,
//             ValidIssuer = builder.Configuration["Jwt:Issuer"],
//             ValidAudience = builder.Configuration["Jwt:Audience"],
//             IssuerSigningKey = new SymmetricSecurityKey(key),
//             ClockSkew = TimeSpan.Zero
//         };
//     });

// // SignalR
// builder.Services.AddSignalR();

// var app = builder.Build();

// // Middlewares
// app.UseHttpsRedirection();
// app.UseAuthentication();
// app.UseAuthorization();
// app.MapControllers();
// app.MapHub<ChatHub>("/chathub");

// app.Run();
