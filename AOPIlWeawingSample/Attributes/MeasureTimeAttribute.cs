using System;
using System.Diagnostics;
using MethodBoundaryAspect.Fody.Attributes;

namespace AOPIlWeawingSample.Attributes
{
    public class MeasureTimeAttribute: OnMethodBoundaryAspect
    {
        private Stopwatch _watch;

        public override void OnEntry(MethodExecutionArgs args)
        {
            _watch = Stopwatch.StartNew();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            _watch.Stop();
            var time = _watch.Elapsed;
            Console.WriteLine($"Time of execution: {time.ToString()}");
        }
    }
}