using System;
using PostSharp.Aspects;

namespace PocMultipleEntities.Aop
{
    [Serializable]
    public class DependencyAttribute : LocationInterceptionAspect
    {
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            args.Value = args.GetCurrentValue();
            if (args.Value == null)
            {
                args.Value = Dependencies.Get(args.Location.LocationType);
                args.ProceedSetValue();
            }
        }
    }
}