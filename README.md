# Reproduction of Azure Functions .NET6 Isolated Startup Error

- [Main issue tracking worker startup errors](https://github.com/Azure/azure-functions-host/issues/8025#issuecomment-1054864600)
- [Comment](https://github.com/Azure/azure-functions-dotnet-worker/issues/747#issuecomment-1042465092) that details this specific scenario that results in a startup error not getting surfaced.

Logs from AppInsights:

```
2022-03-01T19:03:29Z   [Verbose]   Request successfully matched the route with name 'Function1' and template 'api/Function1'
2022-03-01T19:03:29Z   [Information]   Executing 'Functions.Function1' (Reason='This function was programmatically called via the host APIs.', Id=fb4d020e-d47a-4853-a894-158ddd2f62c5)
2022-03-01T19:03:29Z   [Verbose]   FunctionDispatcher state: WorkerProcessRestarting
2022-03-01T19:03:54Z   [Information]   Host lock lease acquired by instance ID '0000000000000000000000002D185285'.
2022-03-01T19:04:17Z   [Error]   Final functionDispatcher state: WorkerProcessRestarting. Initialization timed out and host is shutting down
2022-03-01T19:04:17Z   [Verbose]   Sending invocation id:fb4d020e-d47a-4853-a894-158ddd2f62c5
2022-03-01T19:04:17Z   [Error]   Executed 'Functions.Function1' (Failed, Id=fb4d020e-d47a-4853-a894-158ddd2f62c5, Duration=48023ms)
2022-03-01T19:04:17Z   [Verbose]   Hosting stopping
2022-03-01T19:04:17Z   [Verbose]   Stopping file watchers.
2022-03-01T19:04:17Z   [Verbose]   Waiting for RpcFunctionInvocationDispatcher to shutdown
2022-03-01T19:04:17Z   [Verbose]   Draining invocations from language worker channel completed. Shutting down 'RpcFunctionInvocationDispatcher'
2022-03-01T19:04:17Z   [Information]   Stopping JobHost
2022-03-01T19:04:17Z   [Information]   Job host stopped
2022-03-01T19:04:17Z   [Verbose]   Hosting stopped
2022-03-01T19:04:17Z   [Verbose]   Disposing ScriptHost.
2022-03-01T19:04:17Z   [Verbose]   Disposing FunctionDispatcher
```
