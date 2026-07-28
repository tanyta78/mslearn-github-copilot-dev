using Library.ApplicationCore.Enums;
using Xunit;

namespace UnitTests.ApplicationCore.Enums;

public class EnumHelperTests
{
    [Fact]
    public void GetDescription_ReturnsDescriptionForLoanExtensionStatus()
    {
        var description = EnumHelper.GetDescription(LoanExtensionStatus.Success);

        Assert.Equal("Book loan extension was successful.", description);
    }

    [Fact]
    public void GetDescription_ReturnsDescriptionForLoanReturnStatus()
    {
        var description = EnumHelper.GetDescription(LoanReturnStatus.Success);

        Assert.Equal("Book was successfully returned.", description);
    }

    [Fact]
    public void GetDescription_ReturnsDescriptionForMembershipRenewalStatus()
    {
        var description = EnumHelper.GetDescription(MembershipRenewalStatus.Success);

        Assert.Equal("Membership renewal was successful.", description);
    }
}
