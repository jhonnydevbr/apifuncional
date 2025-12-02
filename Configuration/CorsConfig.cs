using System;

namespace apifuncional.Configuration;

public static class CorsConfig
{
    public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
    {
        options.AddPolicy("Development", builder =>
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
        options.AddPolicy("Production", builder =>
                    builder
                        .WithOrigins("https://localhost:7200")
                        .WithMethods("POST", "GET", "DELETE", "PUT")
                        .AllowAnyHeader());
    });

        return builder;
    }
}
