using NullConditionalDemo;
using System;
using Microsoft.Pex.Framework;

namespace NullConditionalDemo
{
    /// <summary>A factory for NullConditionalDemo.NullDemo instances</summary>
    public static partial class NullDemoFactory
    {
        /// <summary>A factory for NullConditionalDemo.NullDemo instances</summary>
        [PexFactoryMethod(typeof(NullDemo))]
        public static NullDemo Create()
        {
            NullDemo nullDemo = new NullDemo();
            return nullDemo;
        }
    }
}
