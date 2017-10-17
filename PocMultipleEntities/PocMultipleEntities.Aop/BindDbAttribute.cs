using System;
using PocMultipleEntities.Business.Interface;
using PostSharp.Aspects;

namespace PocMultipleEntities.Aop
{
    public class BindDbAttribute : OnMethodBoundaryAspect
    {
        private IOperationFacotory _operationFacotory = null;
        public override void OnEntry(MethodExecutionArgs args)
        {
        }
    }
}
