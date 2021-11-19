using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using LusidFeatures;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Instruments
{
    [TestFixture]
    public class FutureExamples: DemoInstrumentBase
    {
        internal override void CreateAndUpsertMarketDataToLusid(string scope, ModelSelection.ModelEnum model, LusidInstrument instrument)
        {
        }

        internal override void GetAndValidatePortfolioCashFlows(LusidInstrument instrument, string scope, string portfolioCode, string recipeCode, string instrumentID)
        {
            var cashflows = _transactionPortfoliosApi.GetPortfolioCashFlows(
                scope: scope,
                code: portfolioCode,
                effectiveAt: TestDataUtilities.EffectiveAt,
                windowStart: new DateTimeOrCutLabel(new DateTimeOffset(2000, 01, 01, 01, 0, 0, 0, TimeSpan.Zero)),
                windowEnd: new DateTimeOrCutLabel(new DateTimeOffset(2050, 01, 01, 01, 0, 0, 0, TimeSpan.Zero)),
                asAt:null,
                filter:null,
                recipeIdScope: scope,
                recipeIdCode: recipeCode).Values;
            
            Assert.That(cashflows.Count, Is.EqualTo(2));
            
            _instrumentsApi.DeleteInstrument("ClientInternal", instrumentID);
            _portfoliosApi.DeletePortfolio(scope, portfolioCode);
        }

        [LusidFeature("F22-3")]
        [Test]
        public void FuturesCreationAndUpsertionExample()
        {
            // CREATE a future instrument (that can then be upserted into LUSID)
            var future = InstrumentExamples.CreateExampleFuture();

            // ASSERT that it was created
            Assert.That(future, Is.Not.Null);
            
            // CAN NOW UPSERT TO LUSID
            var uniqueId = future.InstrumentType+Guid.NewGuid().ToString(); 
            var instrumentsIds = new List<(LusidInstrument, string)>{(future, uniqueId)};
            var definitions = TestDataUtilities.BuildInstrumentUpsertRequest(instrumentsIds);
            
            UpsertInstrumentsResponse upsertResponse = _instrumentsApi.UpsertInstruments(definitions);
            ValidateUpsertInstrumentResponse(upsertResponse);

            // CAN NOW QUERY FROM LUSID
            GetInstrumentsResponse getResponse = _instrumentsApi.GetInstruments("ClientInternal", new List<string> { uniqueId });
            ValidateInstrumentResponse(getResponse ,uniqueId);
            
            // CHECK contents
            var retrieved = getResponse.Values.First().Value.InstrumentDefinition;
            Assert.That(retrieved.InstrumentType == LusidInstrument.InstrumentTypeEnum.Future);
            var roundTripFuture = retrieved as Future;
            Assert.That(roundTripFuture, Is.Not.Null);
            Assert.That(roundTripFuture.StartDate, Is.EqualTo(future.StartDate));
            Assert.That(roundTripFuture.RefSpotPrice, Is.EqualTo(future.RefSpotPrice));
            Assert.That(roundTripFuture.MaturityDate, Is.EqualTo(future.MaturityDate));
            Assert.That(roundTripFuture.Contracts, Is.EqualTo(future.Contracts));
            Assert.That(roundTripFuture.ContractDetails.Description, Is.EqualTo(future.ContractDetails.Description));
            Assert.That(roundTripFuture.ContractDetails.ContractMonth, Is.EqualTo(future.ContractDetails.ContractMonth));
            Assert.That(roundTripFuture.Underlying.InstrumentType, Is.EqualTo(future.Underlying.InstrumentType));
            Assert.That(roundTripFuture.Underlying.InstrumentType, Is.EqualTo(LusidInstrument.InstrumentTypeEnum.ExoticInstrument));
        }
    }
}