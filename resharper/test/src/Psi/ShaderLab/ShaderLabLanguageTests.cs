﻿using JetBrains.ReSharper.Plugins.Unity.Psi.ShaderLab;
using JetBrains.ReSharper.Psi;
using JetBrains.TestFramework;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Psi.ShaderLab
{
    [TestFixture]
    public class ShaderLabLanguageTests : BaseTest
    {
        [Test]
        public void LanguageIsRegistered()
        {
            Assert.NotNull(ShaderLabLanguage.Instance);
            Assert.NotNull(Languages.Instance.GetLanguageByName(ShaderLabLanguage.Name));
        }
    }
}