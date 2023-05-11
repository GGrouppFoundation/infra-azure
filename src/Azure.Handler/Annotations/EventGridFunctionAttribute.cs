using System;

namespace GarageGroup.Infra;

[AttributeUsage(AttributeTargets.Method)]
public sealed class EventGridFunctionAttribute : HandlerFunctionAttribute
{
    public EventGridFunctionAttribute(string name) : base(name)
    {
    }
}