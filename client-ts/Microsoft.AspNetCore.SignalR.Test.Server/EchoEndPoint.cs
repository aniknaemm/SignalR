// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Internal;
using Microsoft.AspNetCore.Sockets;

namespace Microsoft.AspNetCore.SignalR.Test.Server
{
    public class EchoEndPoint : EndPoint
    {
        public async override Task OnConnectedAsync(ConnectionContext connection)
        {
            await connection.Transport.Writer.WriteAsync(await connection.Transport.Reader.ReadAsync());
        }
    }
}
