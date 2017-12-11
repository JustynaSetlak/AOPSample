using Castle.Core.Logging;
using Castle.DynamicProxy;

namespace AOPSample
{
    public class MyInterceptorAspect : IInterceptor
    {
        private readonly ILogger _logger;

        public MyInterceptorAspect(ILogger logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            invocation.Proceed();
            watch.Stop();

            var timeOfExecution = watch.Elapsed;
            _logger.Info($"Time of execution: {timeOfExecution.ToString()}");
        }
    }
}