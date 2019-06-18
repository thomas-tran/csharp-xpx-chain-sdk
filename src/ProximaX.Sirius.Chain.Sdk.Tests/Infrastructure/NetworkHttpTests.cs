﻿using System.Reactive.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using ProximaX.Sirius.Chain.Sdk.Infrastructure;
using ProximaX.Sirius.Chain.Sdk.Model.Blockchain;
using Xunit;

namespace ProximaX.Sirius.Chain.Sdk.Tests.Infrastructure
{

    public class NetworkHttpTests : BaseTest
    {
        private readonly NetworkHttp _networkHttp;

        public NetworkHttpTests() : base()
        {
            _networkHttp = new NetworkHttp(BaseUrl);
        }

        [Fact]
        public async Task Should_Return_NetworkType()
        {

            // Arrange
            var networkType = await _networkHttp.GetNetworkType();

            // Actual
            var actual = NetworkTypeExtension.GetRawValue("MIJINTEST");

            // Test
            networkType.Should().BeEquivalentTo(actual);

        }
    }
}