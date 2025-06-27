using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace QBimeh.AdminApi.Extentions
{
    public static class ExtentionService
    {
        //public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration) 
        //{
        //    var jwtSettings = configuration.GetSection("JwtSettings"); 
        //    var secretKey = Environment.GetEnvironmentVariable("SECRET");
        //    services.AddAuthentication(opt => 
        //    { 
        //        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; 
        //    }).AddJwtBearer(options => 
        //    { 
        //        options.TokenValidationParameters = new TokenValidationParameters 
        //        { 
        //            ValidateIssuer = true, 
        //            ValidateAudience = true, 
        //            ValidateLifetime = true, 
        //            ValidateIssuerSigningKey = true, 
        //            ValidIssuer = jwtSettings["validIssuer"],
        //            ValidAudience = jwtSettings["validAudience"], 
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        //        }; 
        //    }); 
        //}

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"]; // یا از Environment بخون اگر تعریف شده

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }



    }
}
