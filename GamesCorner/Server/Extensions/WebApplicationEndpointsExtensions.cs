﻿using GamesCorner.Server.Requests;

namespace GamesCorner.Server.Extensions;
using MediatR;

public static class WebApplicationEndpointsExtensions
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MediateGet<OidcConfigurationRequest>("_configuration/{clientId}");
        return app;
    }
}