using AutoFixture;
using AssetIndexUpdateApi.V1.Controllers;
using AssetIndexUpdateApi.V1.UseCase;
using AssetIndexUpdateApi.V1.UseCase.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetIndexUpdateApi.Tests.V1.Controllers
{
    [TestFixture]
    public class AssetIndexUpdateApiControllerTests : LogCallAspectFixture
    {
        private AssetIndexUpdateApiController _classUnderTest;
        private Mock<IGetByIdUseCase> _mockGetByIdUseCase;
        private Mock<IGetAllUseCase> _mockGetByAllUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetByIdUseCase = new Mock<IGetByIdUseCase>();
            _mockGetByAllUseCase = new Mock<IGetAllUseCase>();
            _classUnderTest = new AssetIndexUpdateApiController(_mockGetByAllUseCase.Object, _mockGetByIdUseCase.Object);
        }


        //Add Tests Here
    }
}
