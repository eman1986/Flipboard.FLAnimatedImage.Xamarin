using System;
using ObjCRuntime;

namespace Flipboard.FLAnimatedImage.Xamarin
{
    [Native]
    public enum FLLogLevel : ulong
    {
        None = 0,
        Error,
        Warn,
        Info,
        Debug,
        Verbose
    }
}