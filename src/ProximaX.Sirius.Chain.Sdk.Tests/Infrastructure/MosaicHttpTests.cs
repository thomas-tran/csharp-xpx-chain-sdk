﻿
using ProximaX.Sirius.Chain.Sdk.Infrastructure;
using ProximaX.Sirius.Chain.Sdk.Model.Mosaics;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl.Http.Testing;
using ProximaX.Sirius.Chain.Sdk.Model.Blockchain;
using ProximaX.Sirius.Chain.Sdk.Tests.Utils;
using Xunit;

namespace ProximaX.Sirius.Chain.Sdk.Tests.Infrastructure
{

    public class MosaicHttpTests : BaseTest
    {
        private readonly MosaicHttp _mosaicHttp;

        public MosaicHttpTests()
        {

            _mosaicHttp = new MosaicHttp(BaseUrl)
            { NetworkType = NetworkType.MIJIN_TEST };

        }

        [Fact]
        public void Should_Initialize_MosaicHttp_Constructor()
        {
            var mosaicHttpCtor = new MosaicHttp(BaseUrl);
            mosaicHttpCtor.Should().BeOfType<MosaicHttp>();
        }


        [Fact]
        public async Task Should_Get_Mosaic_Info()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson =
                    TestHelper.LoadJsonFileToObject(@"Testdata\\Mosaic\\GetMosaicInfoFromHex.json");

                httpTest.RespondWithJson(fakeJson);

                const string mosaicHex = "5D4BF0BA9EEB54FCB5CD4E7F";
                var mosaicId = new MosaicId(mosaicHex);
                var mosaicInfo = await _mosaicHttp.GetMosaic(mosaicId);
                mosaicInfo.Should().NotBeNull();
                mosaicInfo.Divisibility.Should().Be(0);
                mosaicInfo.Duration.Should().Be(1000);
                mosaicInfo.IsLevyMutable.Should().BeFalse();
                mosaicInfo.IsSupplyMutable.Should().BeTrue();
                mosaicInfo.IsTransferable.Should().BeTrue();
                mosaicInfo.Supply.Should().Be(1000000);
            }
        }

        [Fact]
        public async Task Get_Mosaic_By_List_Should_Return_MosaicInfo_List()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson =
                    TestHelper.LoadJsonFileToArray(@"Testdata\\Mosaic\\GetMosaicListInfo.json");

                httpTest.RespondWithJson(fakeJson);

                var list = new List<string>
                {
                     "0DC67FBE1CAD29E3",
                     "218CCEBA64D13BC8"
                };
                var mosaicInfoList = await _mosaicHttp.GetMosaicListAsync(list);
                mosaicInfoList.Should().HaveCountGreaterThan(0);
            }
        }

        [Fact]
        public async Task Get_Mosaic_Names()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson =
                    TestHelper.LoadJsonFileToArray(@"Testdata\\Mosaic\\GetMosaicNames.json");

                httpTest.RespondWithJson(fakeJson);

                var list = new List<string>
                {
                    "0DC67FBE1CAD29E3"
               
                };
                var mosaicNames = await _mosaicHttp.GetMosaicNames(list);
                mosaicNames.Should().HaveCountGreaterThan(0);
                mosaicNames[0].Names[0].Should().BeEquivalentTo("cat.currency");
            }


        }
    }
}
