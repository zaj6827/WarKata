using System;
using Xunit;

namespace warKata
{
    public class WarKata
    {
        int player1Card, player2Card;
        int player1CardVal, player2CardVal;
        string player1CardSuit, player2CardSuit;

        [Fact]

        // This test block would be used to assert that the first players card and the second players card are not the same value, meaning there is a clear winner.
        public void ValueComparisonForNonMatchingCards()
        {
            Assert.NotEqual(player1CardVal, player2CardVal);
        }

        [Fact]

        //This test block would test to see if Player 1 and Player 2's cards have identical values, so we can compare suits to determine a winner.

        public void ValueComparisonForMatchingCards()
        {
            Assert.Equal(player1CardVal, player2CardVal);
        }

        [Fact]

        //This would be to compare suits if there was a matching value

        public void SuitComparisonToDetermineWinner()
        {
            Assert.NotEqual(player1CardSuit, player2CardSuit);
        }
    }
}
