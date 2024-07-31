using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    public class KakiServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithKakinum_CallsGetAllByKakinum()
        {
            var kakiRepositoryStub = new Mock<IKakiRepository>();
            kakiRepositoryStub.Setup(x => x.GetAllByKakinum(It.IsAny<string>()))
                              .Returns(new[] { new Kaki(1, "", "", "", "", 0m) });
            kakiRepositoryStub.Setup(x => x.GetAllByTitleOrAuthorkak(It.IsAny<string>()))
                             .Returns(new[] { new Kaki(2, "", "", "", "", 0m) });

            var kakiService = new KakiService(kakiRepositoryStub.Object);
            var validKakinum = "KAKINUMBER 123-45";

            var actual = kakiService.GetAllByQuery(validKakinum);

            Assert.Collection(actual, kaki => Assert.Equal(1, kaki.Id));

        }
        [Fact]
        public void GetAllByQuery_WithAuthorkak_CallsGetAllByTitleOrAuthorkak()
        {
            var kakiRepositoryStub = new Mock<IKakiRepository>();
            kakiRepositoryStub.Setup(x => x.GetAllByKakinum(It.IsAny<string>()))
                              .Returns(new[] { new Kaki(1, "", "", "", "", 0m) });
            kakiRepositoryStub.Setup(x => x.GetAllByTitleOrAuthorkak(It.IsAny<string>()))
                             .Returns(new[] { new Kaki(2, "", "", "", "", 0m) });

            var kakiService = new KakiService(kakiRepositoryStub.Object);
            var invalidKakinum = "123-45";

            var actual = kakiService.GetAllByQuery(invalidKakinum);

            Assert.Collection(actual, kaki => Assert.Equal(2, kaki.Id));
        }
    }
}
