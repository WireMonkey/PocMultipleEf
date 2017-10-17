using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PocMultipleEntities.Aop;
using PocMultipleEntities.Business.Interface;
using PocMultipleEntities.Data;
using PocMultipleEntities.Poco;

namespace PocMultipleEntities.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestInit()
        {
            _enviromentSettingOperations = _operationFacotory.GetEnviromentSettingOperations(Databases.ABC);
            _inventoryDetailsOperations = _operationFacotory.GetInventoryDetailsOperations(Databases.ABC);
        }

        [TestMethod]
        public void Test1()
        {
            //make sure entites go to the right db
            using (var context = _entities.GetDbContext(Databases.ABC))
            {
                Assert.AreEqual("ABC", context.Database.Connection.Database);
            }

            using (var context = _entities.GetDbContext(Databases.Standard))
            {
                Assert.AreEqual("TheStandard", context.Database.Connection.Database);
            }
        }

        [TestMethod]
        public void Test2()
        {
            //make sure correct value is pulled in from db
            using (var context = _entities.GetDbContext(Databases.ABC))
            {
                var item = ((IEnumerable<dynamic>) context.EnvironmentSettings).Where(x => x.Code == "Error.Emails")
                    .Select(x =>
                    {
                        dynamic newItem = new EnviromentalSettingsViewModel();
                        newItem.Code = x.Code;
                        newItem.Description = x.Description;
                        newItem.Value = x.Value;
                        return newItem;
                    }).FirstOrDefault();

                Assert.IsTrue(item.Value == "ABC.tech@veritas-solutions.com");
            }
        }

        [TestMethod]
        public void Test3()
        {
            //make sure different entities can have different properties
            using (var context = _entities.GetDbContext(Databases.ABC))
            {
                var item = ((IEnumerable<dynamic>) context.InventoryDetails).Where(x => x.MultimediaURL != null).Select(
                    x =>
                    {
                        dynamic newItem = new InventoryDetailsViewModel();
                        newItem.LongDescription = x.LongDescription;
                        newItem.Alias = x.Alias;
                        newItem.Version = x.Version;
                        newItem.RevisionDate = x.RevisionDate;
                        newItem.RevisionReason = x.RevisionReason;
                        newItem.Predecessor = x.Predecessor;
                        newItem.InventoryTypeID = x.InventoryTypeID;
                        newItem.DocumentType = x.DocumentType;
                        newItem.FormOwner = x.FormOwner;
                        newItem.FormCostCenter = x.FormCostCenter;
                        newItem.ProductCategory = x.ProductCategory;
                        newItem.ProductNumber = x.ProductNumber;
                        newItem.Program = x.Program;
                        newItem.Viewability = x.Viewability;
                        newItem.CanBackorder = x.CanBackorder;
                        newItem.IsFulfillment = x.IsFulfillment;
                        newItem.IsMarketing = x.IsMarketing;
                        newItem.IsUserKitContainer = x.IsUserKitContainer;
                        newItem.IsBulkOrder = x.IsBulkOrder;
                        newItem.SpecialMessage = x.SpecialMessage;
                        newItem.SpecialMessageActivationDate = x.SpecialMessageActivationDate;
                        newItem.SpecialMessageDeactivationDate = x.SpecialMessageDeactivationDate;
                        newItem.InventoryPricingTypeID = x.InventoryPricingTypeID;
                        newItem.IsPrintCostApproved = x.IsPrintCostApproved;
                        newItem.NoCostItem = x.NoCostItem;
                        newItem.PricingType = x.PricingType;
                        newItem.PrintCost = x.PrintCost;
                        newItem.FulfillmentCost = x.FulfillmentCost;
                        newItem.ChargebackCost = x.ChargebackCost;
                        newItem.OrderQtyMin = x.OrderQtyMin;
                        newItem.OrderQtyMax = x.OrderQtyMax;
                        newItem.OrderQtyMax = x.OrderQtyMax;
                        newItem.ReplaceDate = x.ReplaceDate;
                        newItem.ReplacePart = x.ReplacePart;
                        newItem.ReplaceReason = x.ReplaceReason;
                        newItem.EffectiveDate = x.EffectiveDate;
                        newItem.ObsoleteDate = x.ObsoleteDate;
                        newItem.IsObsoleted = x.IsObsoleted;
                        newItem.IsReplaced = x.IsReplaced;
                        newItem.IncludeState = x.IncludeState;
                        newItem.ExcludeState = x.ExcludeState;
                        newItem.Popularity = x.Popularity;
                        newItem.PageflexJobName = x.PageflexJobName;
                        newItem.CalculatedMaxOrderQty = x.CalculatedMaxOrderQty;
                        newItem.BusinessOwnerRoleID = x.BusinessOwnerRoleID;
                        newItem.OrderQtyMaxFrequency = x.OrderQtyMaxFrequency;
                        newItem.CreateDate = x.CreateDate;
                        newItem.CreateUser = x.CreateUser;
                        newItem.ModDate = x.ModDate;
                        newItem.ModUser = x.ModUser;
                        newItem.IsAppBuilder = x.IsAppBuilder;
                        newItem.AppBuilderSort = x.AppBuilderSort;
                        newItem.CanRemoveDuplicates = x.CanRemoveDuplicates;
                        newItem.MultimediaURL = x.MultimediaURL;
                        return newItem;
                    }).FirstOrDefault();

                Assert.IsTrue(item.MultimediaURL == "Testing");
            }
            using (var context = _entities.GetDbContext(Databases.Standard))
            {
                var item = ((IEnumerable<dynamic>) context.InventoryDetails).Where(x => x.ServiceProductIds != null)
                    .Select(x =>
                    {
                        dynamic newItem = new InventoryDetailsViewModel();
                        newItem.LongDescription = x.LongDescription;
                        newItem.Alias = x.Alias;
                        newItem.Version = x.Version;
                        newItem.RevisionDate = x.RevisionDate;
                        newItem.RevisionReason = x.RevisionReason;
                        newItem.Predecessor = x.Predecessor;
                        newItem.InventoryTypeID = x.InventoryTypeID;
                        newItem.DocumentType = x.DocumentType;
                        newItem.FormOwner = x.FormOwner;
                        newItem.FormCostCenter = x.FormCostCenter;
                        newItem.ProductCategory = x.ProductCategory;
                        newItem.ProductNumber = x.ProductNumber;
                        newItem.Channel = x.Channel;
                        newItem.Viewability = x.Viewability;
                        newItem.CanBackorder = x.CanBackorder;
                        newItem.IsFulfillment = x.IsFulfillment;
                        newItem.IsMarketing = x.IsMarketing;
                        newItem.IsUserKitContainer = x.IsUserKitContainer;
                        newItem.IsBulkOrder = x.IsBulkOrder;
                        newItem.SpecialMessage = x.SpecialMessage;
                        newItem.SpecialMessageActivationDate = x.SpecialMessageActivationDate;
                        newItem.SpecialMessageDeactivationDate = x.SpecialMessageDeactivationDate;
                        newItem.InventoryPricingTypeID = x.InventoryPricingTypeID;
                        newItem.IsPrintCostApproved = x.IsPrintCostApproved;
                        newItem.NoCostItem = x.NoCostItem;
                        newItem.PricingType = x.PricingType;
                        newItem.PrintCost = x.PrintCost;
                        newItem.FulfillmentCost = x.FulfillmentCost;
                        newItem.ChargebackCost = x.ChargebackCost;
                        newItem.OrderQtyMin = x.OrderQtyMin;
                        newItem.OrderQtyMax = x.OrderQtyMax;
                        newItem.OrderQtyMax = x.OrderQtyMax;
                        newItem.ReplaceDate = x.ReplaceDate;
                        newItem.ReplacePart = x.ReplacePart;
                        newItem.ReplaceReason = x.ReplaceReason;
                        newItem.EffectiveDate = x.EffectiveDate;
                        newItem.ObsoleteDate = x.ObsoleteDate;
                        newItem.IsObsoleted = x.IsObsoleted;
                        newItem.IsReplaced = x.IsReplaced;
                        newItem.IncludeState = x.IncludeState;
                        newItem.ExcludeState = x.ExcludeState;
                        newItem.Popularity = x.Popularity;
                        newItem.PageflexJobName = x.PageflexJobName;
                        newItem.CalculatedMaxOrderQty = x.CalculatedMaxOrderQty;
                        newItem.BusinessOwnerRoleID = x.BusinessOwnerRoleID;
                        newItem.OrderQtyMaxFrequency = x.OrderQtyMaxFrequency;
                        newItem.CreateDate = x.CreateDate;
                        newItem.CreateUser = x.CreateUser;
                        newItem.ModDate = x.ModDate;
                        newItem.ModUser = x.ModUser;
                        newItem.IsAppBuilder = x.IsAppBuilder;
                        newItem.AppBuilderSort = x.AppBuilderSort;
                        newItem.CanRemoveDuplicates = x.CanRemoveDuplicates;
                        newItem.PersonalizeFillableFields = x.PersonalizeFillableFields;
                        newItem.ServiceProductIds = x.ServiceProductIds;
                        return newItem;
                    }).FirstOrDefault();

                Assert.IsTrue(item.ServiceProductIds == "Testing");
            }
        }

        [TestMethod]
        public void Test4()
        {
            //Make sure enviroment settings operations can pull from different db's

            var settingAbc = _enviromentSettingOperations.GetEnviromentSetting("Error.Emails");

            _enviromentSettingOperations.SetDb(Databases.Standard);
            var settingStd = _enviromentSettingOperations.GetEnviromentSetting("Error.Emails");

            Assert.AreNotEqual(settingStd, settingAbc);
        }

        [TestMethod]
        public void Test5()
        {
            //Make sure factory can set client specific class vs generic class

            _inventoryDetailsOperations.SetDb(Databases.Standard);
            var items = _inventoryDetailsOperations.GetDetailsViewModels();

            //Change binding to standard's operations
            _operationFacotory.GetInventoryDetailsOperations(Databases.Standard);

            var items2 = _inventoryDetailsOperations.GetDetailsViewModels();

            Assert.AreNotEqual(items, items2);
        }

        #region Created via aop dependency injection

        [Dependency] private readonly IEntities _entities = null;

        [Dependency] private readonly IOperationFacotory _operationFacotory = null;

        #endregion

        #region Created via factory method

        private IEnviromentSettingOperations _enviromentSettingOperations;
        private IInventoryDetailsOperations _inventoryDetailsOperations;

        #endregion
    }
}