using Data.URI;
using NUnit.Framework;

using System;

namespace TestDataURI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAJsAAACBCAIAAABYTl8mAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKFSURBVHhe7dnrbYMwFEDhzMVAnodpWIZhUvLC1w+aVqJSfHrOrxauqZQPpxJcrsZKUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaX2G6DpPl0fTvDyPxaP3pjSvzzNt9ezB6Louc5qmODtt113W4yuP1qeJXlIWXdLz2N4hVOm51U6uS6qHio6uPVpjiR587C1oPdiZaAt/euDGEM3fkz3SffWU9m1YzJW3xv1b9nlmW3zbu49VjF06hmia94H2Y9/Htv/BvbFifx7tw21oco+e11vRJU/UpAF07U2Fa7d3A7BRRA9GwuEbV0f0v4GOI9r8ei8vvB/riOZVETQfDcU7ZdwGEu2QVqCKbo0k2ug0A4oOJlrxtOc7ov1L596dH66xRCNpSq+f8+briIYlxS59peif9GPR6PMqOPVEiyWtqaJ/0s9F4+ijiNQVrZaUD+bj015Fz+sXojVpsev6oludrd2m6Hn9RrQkLRUORbfW+ft3L4qeWZToiFY8m83rRIWQr5PCw/hQ+3r09hYgzfHZ/eB9hqidl6K0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FairK6Xr8AcXi6YHwSvjIAAAAASUVORK5CYII=")]
        public void BuildOK_StrDataUri_ReturnEqual(string strDataUri)
        {
            DataURI dataUri = new(strDataUri);

            Assert.AreEqual(dataUri.SectionDescription, "IMAGE");
            Assert.AreEqual(dataUri.TypeDescription, "PNG");
            Assert.AreEqual(dataUri.ToString(), strDataUri);
        }

        [Test]
        [TestCase("image", "png", "iVBORw0KGgoAAAANSUhEUgAAAJsAAACBCAIAAABYTl8mAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKFSURBVHhe7dnrbYMwFEDhzMVAnodpWIZhUvLC1w+aVqJSfHrOrxauqZQPpxJcrsZKUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaX2G6DpPl0fTvDyPxaP3pjSvzzNt9ezB6Louc5qmODtt113W4yuP1qeJXlIWXdLz2N4hVOm51U6uS6qHio6uPVpjiR587C1oPdiZaAt/euDGEM3fkz3SffWU9m1YzJW3xv1b9nlmW3zbu49VjF06hmia94H2Y9/Htv/BvbFifx7tw21oco+e11vRJU/UpAF07U2Fa7d3A7BRRA9GwuEbV0f0v4GOI9r8ei8vvB/riOZVETQfDcU7ZdwGEu2QVqCKbo0k2ug0A4oOJlrxtOc7ov1L596dH66xRCNpSq+f8+briIYlxS59peif9GPR6PMqOPVEiyWtqaJ/0s9F4+ijiNQVrZaUD+bj015Fz+sXojVpsev6oludrd2m6Hn9RrQkLRUORbfW+ft3L4qeWZToiFY8m83rRIWQr5PCw/hQ+3r09hYgzfHZ/eB9hqidl6K0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FairK6Xr8AcXi6YHwSvjIAAAAASUVORK5CYII=")]
        public void BuildOK_SectionTypeBase64_ReturnEqual(string section, string type, string base64)
        {
            DataURI dataUri = new(section, type, base64);
            Assert.AreEqual(dataUri.SectionDescription, "IMAGE");
            Assert.AreEqual(dataUri.TypeDescription, "PNG");
            Assert.AreEqual(Convert.ToBase64String(dataUri.Data), base64);
        }

        [Test]
        [TestCase("data:image/invalid;base64,iVBORw0KGgoAAAANSUhEUgAAAJsAAACBCAIAAABYTl8mAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKFSURBVHhe7dnrbYMwFEDhzMVAnodpWIZhUvLC1w+aVqJSfHrOrxauqZQPpxJcrsZKUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaX2G6DpPl0fTvDyPxaP3pjSvzzNt9ezB6Louc5qmODtt113W4yuP1qeJXlIWXdLz2N4hVOm51U6uS6qHio6uPVpjiR587C1oPdiZaAt/euDGEM3fkz3SffWU9m1YzJW3xv1b9nlmW3zbu49VjF06hmia94H2Y9/Htv/BvbFifx7tw21oco+e11vRJU/UpAF07U2Fa7d3A7BRRA9GwuEbV0f0v4GOI9r8ei8vvB/riOZVETQfDcU7ZdwGEu2QVqCKbo0k2ug0A4oOJlrxtOc7ov1L596dH66xRCNpSq+f8+briIYlxS59peif9GPR6PMqOPVEiyWtqaJ/0s9F4+ijiNQVrZaUD+bj015Fz+sXojVpsev6oludrd2m6Hn9RrQkLRUORbfW+ft3L4qeWZToiFY8m83rRIWQr5PCw/hQ+3r09hYgzfHZ/eB9hqidl6K0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FairK6Xr8AcXi6YHwSvjIAAAAASUVORK5CYII=")]
        public void BuildThrow_InvalidType_ReturnTrue(string strDataUri)
        {
            try
            {
                DataURI dataUri = new(strDataUri);
                throw new Exception("Error");
            }
            catch(Exception e)
            {
                Assert.IsTrue(e.Message.Contains("does not exist in section"));
            }
        }

        [Test]
        [TestCase("data:invalid/png;base64,iVBORw0KGgoAAAANSUhEUgAAAJsAAACBCAIAAABYTl8mAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKFSURBVHhe7dnrbYMwFEDhzMVAnodpWIZhUvLC1w+aVqJSfHrOrxauqZQPpxJcrsZKUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaX2G6DpPl0fTvDyPxaP3pjSvzzNt9ezB6Louc5qmODtt113W4yuP1qeJXlIWXdLz2N4hVOm51U6uS6qHio6uPVpjiR587C1oPdiZaAt/euDGEM3fkz3SffWU9m1YzJW3xv1b9nlmW3zbu49VjF06hmia94H2Y9/Htv/BvbFifx7tw21oco+e11vRJU/UpAF07U2Fa7d3A7BRRA9GwuEbV0f0v4GOI9r8ei8vvB/riOZVETQfDcU7ZdwGEu2QVqCKbo0k2ug0A4oOJlrxtOc7ov1L596dH66xRCNpSq+f8+briIYlxS59peif9GPR6PMqOPVEiyWtqaJ/0s9F4+ijiNQVrZaUD+bj015Fz+sXojVpsev6oludrd2m6Hn9RrQkLRUORbfW+ft3L4qeWZToiFY8m83rRIWQr5PCw/hQ+3r09hYgzfHZ/eB9hqidl6K0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FaitJSlJaitBSlpSgtRWkpSktRWorSUpSWorQUpaUoLUVpKUpLUVqK0lKUlqK0FKWlKC1FaSlKS1FairK6Xr8AcXi6YHwSvjIAAAAASUVORK5CYII=")]
        public void BuildThrow_InvalidSection_ReturnTrue(string strDataUri)
        {
            try
            {
                DataURI dataUri = new(strDataUri);
                throw new Exception("Error");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains($"Section 'invalid' is invalid."));
            }
        }

    }
}