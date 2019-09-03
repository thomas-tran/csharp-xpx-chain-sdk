﻿using System.Reactive.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl.Http.Testing;
using ProximaX.Sirius.Chain.Sdk.Infrastructure;
using ProximaX.Sirius.Chain.Sdk.Model.Blockchain;
using ProximaX.Sirius.Chain.Sdk.Model.Transactions;
using ProximaX.Sirius.Chain.Sdk.Model.Transactions.Messages;
using ProximaX.Sirius.Chain.Sdk.Tests.Utils;
using Xunit;

namespace ProximaX.Sirius.Chain.Sdk.Tests.Infrastructure
{
    public class TransactionHttpTests : BaseTest
    {
        private readonly TransactionHttp _transactionHttp;

        public TransactionHttpTests()
        {
            _transactionHttp = new TransactionHttp(BaseUrl) { NetworkType = NetworkType.MIJIN_TEST };
        }

        [Fact]
        public async Task Should_Return_Transfer_Transaction_Details()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\TransferTransactionWithPlainMessage.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "D88C48782537108AE069225CF07F81122E068A60E5825B1C6E57373B0FC2437A";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);

                var agTx = (TransferTransaction)transaction;

                transaction.Should().BeOfType<TransferTransaction>();
            }
        }

        [Fact]
        public async Task Get_Transaction_By_Hash_Should_Return_Aggregate_Transaction_Plain_Message()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\AggreateTransactionWithPlainMessage.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "0E91936DFEF1DC659B1EA4F32F1CD8EE4AFADF804B812E3966245FD0888CDD74";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);
                var agTx = (AggregateTransaction)transaction;

                transaction.Should().BeOfType<AggregateTransaction>();
            }
        }


        [Fact]
        public async Task Get_Transaction_By_Hash_Should_Return_Aggregate_Transaction()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\CreateMosaicAggregateTransaction.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "72CA2DA47931D995887592E3E9A93719DED92A12452655F1E88811CD2602ADCE";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);
                var agTx = (AggregateTransaction) transaction;
           
                transaction.Should().BeOfType<AggregateTransaction>();
            }
        }

        [Fact]
        public async Task Get_Transaction_By_Hash_Should_Return_MosaicSupplyChange_Transaction()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\DecreaseMosaicSupplyTransaction.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "549E6C78D2708CC6BA14DEB6D7F313A4E130A4655C2DCCD723EED4B6ECAA81AF";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);
                
                transaction.Should().BeOfType<MosaicSupplyChangeTransaction>();
            }
        }

        [Fact]
        public async Task Get_Transaction_By_Hash_Should_Return_AliasTransaction_Link_Namespace_To_Mosaic()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\LinkNamespaceToMosaic.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "EE038F41EDE24587C98E234675026DECA6625F77DA818F9FEA3BE56BCEB073E6";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);

                transaction.Should().BeOfType<AliasTransaction>();
                transaction.TransactionType.Should().BeEquivalentTo(TransactionType.MOSAIC_ALIAS);
                ((AliasTransaction)transaction).MosaicId.Should().NotBeNull();
            }
        }


        [Fact]
        public async Task Get_Transaction_By_Hash_Should_Return_AliasTransaction_Link_Namespace_To_Address()
        {
            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\\LinkNamespaceToAddress.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "79463E18A0F91B9D191E058037B0AF3A3B9003F9BA1B94B6A4A8CFE6AADE7C27";

                var transaction = await _transactionHttp.GetTransaction(transactionHash);

                transaction.Should().BeOfType<AliasTransaction>();
                transaction.TransactionType.Should().BeEquivalentTo(TransactionType.ADDRESS_ALIAS);
                ((AliasTransaction) transaction).Address.Should().NotBeNull();
            }
        }

        [Fact]
        public async Task Get_Transfer_Transaction_With_Secure_Message()
        {
            var transactionHttp = new TransactionHttp(BaseUrl) { NetworkType = NetworkType.TEST_NET };

            using (var httpTest = new HttpTest())
            {
                var fakeJson = TestHelper.LoadJsonFileToObject(@"Testdata\\Transactions\TransferTransactionWithSecureMessage.json");

                httpTest.RespondWithJson(fakeJson);

                const string transactionHash = "68B465D832DD2FE6976414FE3D7F645DFA438051760C5C20DF42B75D3560D2AC";
                const string receiverPrivateKey = "DBD900D56FF058729079B97A0E447FA4DED723D74C8081632C08F6CE49CAC9C0";
                const string senderPublicKey = "95de2ffdcc397bb9688da28a18a70fdd23f4ce2ef4240a4a7b6baf5dfa07e5dc";
                var transaction = await transactionHttp.GetTransaction(transactionHash);

                transaction.Should().BeOfType<TransferTransaction>();
                var transferTransaction = ((TransferTransaction)transaction);
                var messageType = MessageTypeExtension.GetRawValue(transferTransaction.Message.GetMessageType());
                messageType.Should().BeEquivalentTo(MessageType.SECURED_MESSAGE);

                var securedMessage = (SecureMessage)transferTransaction.Message;
                var payload = securedMessage.DecryptPayload(receiverPrivateKey, senderPublicKey);
                payload.Should().BeEquivalentTo("Hi Thomas");
                
            }
        }
    }
}
