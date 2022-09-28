using DiamondShapes;

namespace DiamondShapeTests
{
    [TestClass]
    public class DiamondShapesTests
    {
        IPrintShapes _printShapes;
        public DiamondShapesTests()
        {
            _printShapes = new PrintShapes();
        }

        [TestMethod]
        public void Valid_Character_Entered()
        {
            // Arrange
            char alphabet = 'c';

            // Act
            bool isChar = _printShapes.IsValidInput(alphabet);

            // Assert
            Assert.IsTrue(isChar);
        }

        [TestMethod]
        public void InValid_Character_Entered()
        {
            // Arrange
            char alphabet = '2';

            // Act
            bool isChar = _printShapes.IsValidInput(alphabet);

            // Assert
            Assert.IsFalse(isChar);
        }

        [TestMethod]
        public void ValidationMessage_InValid_Character_Entered()
        {
            // Arrange
            char alphabet = '2';

            // Act
            string validationMsg = _printShapes.ShowValidationMessage(alphabet);

            // Assert
            Assert.AreEqual("Please enter only alphabet:", validationMsg);
        }

        [TestMethod]
        public void ValidationMessage_Valid_Character_Entered()
        {
            // Arrange
            char alphabet = 'b';

            // Act
            string validationMsg = _printShapes.ShowValidationMessage(alphabet);

            // Assert
            Assert.AreNotEqual("Please enter only alphabet:", validationMsg);
        }

        [TestMethod]
        public void Validate_Diamond_Pattern()
        {
            // Arrange
            char alphabet = 'c';
            string strDiamond = "  A\r\n B B\r\nC   C\r\n B B\r\n  A\r\n";

            // Act
            string strGenerated = _printShapes.PrintDiamond(alphabet);

            // Assert
            Assert.AreEqual(strDiamond, strGenerated, "Diamond generated correctly");
        }

        [TestMethod]
        public void Validate_Diamond_Pattern_Check()
        {
            // Arrange
            char alphabet = 'e';
            string strDiamond = "    A\r\n   B B\r\n  C   C\r\n D     D\r\nE       E\r\n D     D\r\n  C   C\r\n   B B\r\n    A\r\n";

            // Act
            string strGenerated = _printShapes.PrintDiamond(alphabet);

            // Assert
            Assert.AreEqual(strDiamond, strGenerated, "Diamond generated correctly");
        }

        [TestMethod]
        public void Validate_Diamond_Shape_Check()
        {
            // Arrange
            char alphabet = 'd';
            const string diamond = "   A\r\n" +
                                   "  B B\r\n" +
                                   " C   C\r\n" +
                                   "D     D\r\n" +
                                   " C   C\r\n" +
                                   "  B B\r\n" +
                                   "   A\r\n";

            // Act
            string strGenerated = _printShapes.PrintDiamond(alphabet);

            // Assert
            Assert.AreEqual(diamond, strGenerated);
        }

        [TestMethod]
        public void Validate_Diamond_count_Check()
        {
            // Arrange
            char alphabet = 'd';
            int expectedCount = ((((int)char.ToUpper(alphabet) - (int)'A') + 1) * 2) - 1;

            // Act
            int diamondLineCount = _printShapes.PrintDiamond(alphabet).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Count();

            // Assert
            Assert.AreEqual(expectedCount, diamondLineCount);

        }

        [TestMethod]
        public void Validate_Diamond_FirstLetter()
        {
            // Arrange
            const char alphabet = 'd';
            const string diamond = "A";

            // Act
            string[] splitString = _printShapes.PrintDiamond(alphabet).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


            // Assert
            Assert.AreEqual(diamond, splitString[0].TrimStart());
        }

        [TestMethod]
        public void Validate_Diamond_MiddleLetter()
        {
            // Arrange
            const char alphabet = 'd';
            const string diamond = "D     D";
            int MiddleLineCount = (int)char.ToUpper(alphabet) - (int)'A';

            // Act
            string[] splitString = _printShapes.PrintDiamond(alphabet).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


            // Assert
            Assert.AreEqual(diamond, splitString[MiddleLineCount]);
        }

        [TestMethod]
        public void Validate_Malformed_Diamond()
        {
            // Arrange
            const char alphabet = 'd';
            const string diamond = "DD";
            int MiddleLineCount = (int)char.ToUpper(alphabet) - (int)'A';

            // Act
            string[] splitString = _printShapes.PrintDiamond(alphabet).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


            // Assert
            Assert.AreNotEqual(diamond, splitString[MiddleLineCount]);
        }
    }
}