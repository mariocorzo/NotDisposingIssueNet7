﻿using System.Diagnostics;

namespace NotDisposingIssueNet7.Components
{
    public partial class ComponentOne : IDisposable
    {

        public void Dispose()
        {
			Console.WriteLine("Disposing Component One");
        }
    }
}
